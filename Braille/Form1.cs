using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using help_about;
using Translator.braille;

namespace Braille
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily oneFontFamily in FontFamily.Families)
            {
                cmbobx_fontname.Items.Add(oneFontFamily.Name);
            }

            cmbobx_fontname.SelectedIndex = 6;
            cmbobx_fontsize.SelectedIndex = 8;
            cmbobx_style.SelectedIndex = 2;

            SetFont();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            var f1 = new Help_Form();
            f1.ShowDialog();
            GC.Collect();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            BrailleTable.ResetFlags(); //reset back to initial flags

            rchtxtbx_braille.Clear();
            rchtxtbx_btext.Clear();
        }

        private void btn_change_font_Click(object sender, EventArgs e)
        {
            SetFont();
        }

        private void SetFont()
        {
            // get the font name and style
            FontFamily fname = new FontFamily(cmbobx_fontname.Text);
            FontStyle fs = FontStyle.Regular;


            FontStyle fstyle = (FontStyle)Enum.Parse(typeof(FontStyle), cmbobx_style.Text, true);

            rchtxtbx_braille.Font = new Font(cmbobx_fontname.Text,
                float.Parse(cmbobx_fontsize.Text, CultureInfo.InvariantCulture.NumberFormat), fstyle);

            rchtxtbx_btext.Font = new Font(cmbobx_fontname.Text,
                float.Parse(cmbobx_fontsize.Text, CultureInfo.InvariantCulture.NumberFormat), fstyle);
        }

        private void btn_changeFontRight_Click(object sender, EventArgs e)
        {
            // get the font name and style
            FontFamily fname = new FontFamily(cmbobx_fontname.Text);
            FontStyle fs = FontStyle.Regular;


            FontStyle fstyle = (FontStyle)Enum.Parse(typeof(FontStyle), cmbobx_style.Text, true);

            rchtxtbx_braille.Font = new Font(cmbobx_fontname.Text,
                float.Parse(cmbobx_fontsize.Text, CultureInfo.InvariantCulture.NumberFormat), fstyle);
        }

        private void btn_changeFontLeft_Click(object sender, EventArgs e)
        {
            // get the font name and style
            FontFamily fname = new FontFamily(cmbobx_fontname.Text);
            FontStyle fs = FontStyle.Regular;


            FontStyle fstyle = (FontStyle)Enum.Parse(typeof(FontStyle), cmbobx_style.Text, true);

            rchtxtbx_btext.Font = new Font(cmbobx_fontname.Text,
                float.Parse(cmbobx_fontsize.Text, CultureInfo.InvariantCulture.NumberFormat), fstyle);
        }

        private StringBuilder sb = new StringBuilder(); //needed to replace text into richtextbox after preview
        
        private void btn_SaveBitmap_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument1 = new PrintDocument();
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Icon = new Icon("..\\..\\braille.ico");

            sb.Append(rchtxtbx_braille.Text);

            printDocument1.PrintPage += PrintDocument_PrintPage;
            printPreviewDialog1.Document = printDocument1;
            
            printPreviewDialog1.ShowDialog();
            
            printDocument1.Dispose();
            printPreviewDialog1.Dispose();
        }


        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            //comes in here for every page it needs to make

            int charactersOnPage = 0;
            int linesPerPage = 0;
            Font drawFont = new Font(rchtxtbx_braille.Font.ToString(), rchtxtbx_braille.Font.Size);

            // Sets the value of charactersOnPage to the number of characters
            // of stringToPrint that will fit within the bounds of the page.
            e.Graphics.MeasureString(rchtxtbx_braille.Text, drawFont,
                e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charactersOnPage, out linesPerPage);

            // Draws the string within the bounds of the page
            e.Graphics.DrawString(rchtxtbx_braille.Text, drawFont, Brushes.Black,
                e.MarginBounds, StringFormat.GenericTypographic);


            // Remove the portion of the string that has been printed.
             rchtxtbx_braille.Text = rchtxtbx_braille.Text.Substring(charactersOnPage);
           

            // Check to see if more pages are to be printed.
            // replace the text when the window is empty so we have something to print
            // otherwise we print a balnk document.
            
             if (rchtxtbx_braille.Text.Length > 0)
             {
                 e.HasMorePages = true;
             }
             else
             {
                 e.HasMorePages = false;
                 rchtxtbx_braille.Text = sb.ToString();
             }
        }

       
        private void btn_braille_translate_Click(object sender, EventArgs e)
        {
            BrailleTable.ResetFlags(); //reset back to initial flags

            rchtxtbx_braille.Text = "";

            string data = rchtxtbx_btext.Text;


            // As first pass we just parse each char. In future we need to parse this to be able to markup properly.
            foreach (char c in data)
            {
                rchtxtbx_braille.Text += BrailleTable.ToBraille(c);
            }
        }


    }
}
