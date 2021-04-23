namespace Braille
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_SaveBitmap = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_braille_translate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rchtxtbx_btext = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rchtxtbx_braille = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_changeFontLeft = new System.Windows.Forms.Button();
            this.btn_changeFontRight = new System.Windows.Forms.Button();
            this.btn_change_font = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbobx_style = new System.Windows.Forms.ComboBox();
            this.cmbobx_fontsize = new System.Windows.Forms.ComboBox();
            this.cmbobx_fontname = new System.Windows.Forms.ComboBox();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1186, 536);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 460);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1180, 460);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1172, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Convert to Braille";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1166, 425);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.btn_SaveBitmap);
            this.panel3.Controls.Add(this.btn_clear);
            this.panel3.Controls.Add(this.btn_braille_translate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1160, 44);
            this.panel3.TabIndex = 1;
            // 
            // btn_SaveBitmap
            // 
            this.btn_SaveBitmap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveBitmap.Location = new System.Drawing.Point(893, 9);
            this.btn_SaveBitmap.Name = "btn_SaveBitmap";
            this.btn_SaveBitmap.Size = new System.Drawing.Size(98, 26);
            this.btn_SaveBitmap.TabIndex = 5;
            this.btn_SaveBitmap.Text = "Save";
            this.btn_SaveBitmap.UseVisualStyleBackColor = true;
            this.btn_SaveBitmap.Click += new System.EventHandler(this.btn_SaveBitmap_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(3, 9);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(98, 26);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_braille_translate
            // 
            this.btn_braille_translate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_braille_translate.Location = new System.Drawing.Point(1055, 9);
            this.btn_braille_translate.Name = "btn_braille_translate";
            this.btn_braille_translate.Size = new System.Drawing.Size(98, 26);
            this.btn_braille_translate.TabIndex = 3;
            this.btn_braille_translate.Text = "Translate";
            this.btn_braille_translate.UseVisualStyleBackColor = true;
            this.btn_braille_translate.Click += new System.EventHandler(this.btn_braille_translate_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rchtxtbx_btext);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 369);
            this.panel2.TabIndex = 2;
            // 
            // rchtxtbx_btext
            // 
            this.rchtxtbx_btext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxtbx_btext.Location = new System.Drawing.Point(0, 0);
            this.rchtxtbx_btext.Name = "rchtxtbx_btext";
            this.rchtxtbx_btext.Size = new System.Drawing.Size(577, 369);
            this.rchtxtbx_btext.TabIndex = 1;
            this.rchtxtbx_btext.Text = "";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rchtxtbx_braille);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(586, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(577, 369);
            this.panel5.TabIndex = 3;
            // 
            // rchtxtbx_braille
            // 
            this.rchtxtbx_braille.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxtbx_braille.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtbx_braille.Location = new System.Drawing.Point(0, 0);
            this.rchtxtbx_braille.Name = "rchtxtbx_braille";
            this.rchtxtbx_braille.Size = new System.Drawing.Size(577, 369);
            this.rchtxtbx_braille.TabIndex = 1;
            this.rchtxtbx_braille.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1172, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.btn_help);
            this.panel4.Controls.Add(this.btn_close);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 469);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1180, 64);
            this.panel4.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_changeFontLeft);
            this.groupBox1.Controls.Add(this.btn_changeFontRight);
            this.groupBox1.Controls.Add(this.btn_change_font);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbobx_style);
            this.groupBox1.Controls.Add(this.cmbobx_fontsize);
            this.groupBox1.Controls.Add(this.cmbobx_fontname);
            this.groupBox1.Location = new System.Drawing.Point(135, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 70);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            // 
            // btn_changeFontLeft
            // 
            this.btn_changeFontLeft.Location = new System.Drawing.Point(11, 25);
            this.btn_changeFontLeft.Name = "btn_changeFontLeft";
            this.btn_changeFontLeft.Size = new System.Drawing.Size(107, 37);
            this.btn_changeFontLeft.TabIndex = 76;
            this.btn_changeFontLeft.Text = "Change Left";
            this.btn_changeFontLeft.UseVisualStyleBackColor = true;
            this.btn_changeFontLeft.Click += new System.EventHandler(this.btn_changeFontLeft_Click);
            // 
            // btn_changeFontRight
            // 
            this.btn_changeFontRight.Location = new System.Drawing.Point(803, 24);
            this.btn_changeFontRight.Name = "btn_changeFontRight";
            this.btn_changeFontRight.Size = new System.Drawing.Size(107, 37);
            this.btn_changeFontRight.TabIndex = 75;
            this.btn_changeFontRight.Text = "Change Right";
            this.btn_changeFontRight.UseVisualStyleBackColor = true;
            this.btn_changeFontRight.Click += new System.EventHandler(this.btn_changeFontRight_Click);
            // 
            // btn_change_font
            // 
            this.btn_change_font.Location = new System.Drawing.Point(690, 24);
            this.btn_change_font.Name = "btn_change_font";
            this.btn_change_font.Size = new System.Drawing.Size(107, 37);
            this.btn_change_font.TabIndex = 74;
            this.btn_change_font.Text = "Change All";
            this.btn_change_font.UseVisualStyleBackColor = true;
            this.btn_change_font.Click += new System.EventHandler(this.btn_change_font_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(596, 18);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 73;
            this.label11.Text = "Font Style";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(480, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 72;
            this.label10.Text = "Font Size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 71;
            this.label9.Text = "Font Family";
            // 
            // cmbobx_style
            // 
            this.cmbobx_style.FormattingEnabled = true;
            this.cmbobx_style.Items.AddRange(new object[] {
            "Italic",
            "Bold",
            "Regular",
            "Strikeout",
            "Underline"});
            this.cmbobx_style.Location = new System.Drawing.Point(575, 38);
            this.cmbobx_style.Margin = new System.Windows.Forms.Padding(4);
            this.cmbobx_style.Name = "cmbobx_style";
            this.cmbobx_style.Size = new System.Drawing.Size(108, 24);
            this.cmbobx_style.TabIndex = 70;
            // 
            // cmbobx_fontsize
            // 
            this.cmbobx_fontsize.FormattingEnabled = true;
            this.cmbobx_fontsize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.cmbobx_fontsize.Location = new System.Drawing.Point(462, 38);
            this.cmbobx_fontsize.Margin = new System.Windows.Forms.Padding(4);
            this.cmbobx_fontsize.Name = "cmbobx_fontsize";
            this.cmbobx_fontsize.Size = new System.Drawing.Size(105, 24);
            this.cmbobx_fontsize.TabIndex = 69;
            // 
            // cmbobx_fontname
            // 
            this.cmbobx_fontname.FormattingEnabled = true;
            this.cmbobx_fontname.Location = new System.Drawing.Point(125, 37);
            this.cmbobx_fontname.Margin = new System.Windows.Forms.Padding(4);
            this.cmbobx_fontname.Name = "cmbobx_fontname";
            this.cmbobx_fontname.Size = new System.Drawing.Size(329, 24);
            this.cmbobx_fontname.TabIndex = 68;
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(3, 16);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(107, 37);
            this.btn_help.TabIndex = 1;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Location = new System.Drawing.Point(1070, 16);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(107, 37);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 536);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1204, 583);
            this.Name = "Form1";
            this.Text = "Braille Translator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_braille_translate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rchtxtbx_btext;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox rchtxtbx_braille;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_change_font;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbobx_style;
        private System.Windows.Forms.ComboBox cmbobx_fontsize;
        private System.Windows.Forms.ComboBox cmbobx_fontname;
        private System.Windows.Forms.Button btn_changeFontRight;
        private System.Windows.Forms.Button btn_changeFontLeft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SaveBitmap;
    }
}

