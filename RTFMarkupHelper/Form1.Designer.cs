namespace RTFMarkupHelper
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtfBox = new System.Windows.Forms.RichTextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.formatBold = new System.Windows.Forms.Button();
            this.formatItalic = new System.Windows.Forms.Button();
            this.formatUnderline = new System.Windows.Forms.Button();
            this.insertSymbolC = new System.Windows.Forms.Button();
            this.insertSymbolR = new System.Windows.Forms.Button();
            this.insertSymbolTM = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFontSize = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // rtfBox
            // 
            this.rtfBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfBox.Location = new System.Drawing.Point(21, 79);
            this.rtfBox.Name = "rtfBox";
            this.rtfBox.Size = new System.Drawing.Size(398, 389);
            this.rtfBox.TabIndex = 0;
            this.rtfBox.Text = "";
            this.rtfBox.TextChanged += new System.EventHandler(this.rtfBox_TextChanged);
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.BackColor = System.Drawing.SystemColors.Control;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Location = new System.Drawing.Point(446, 49);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(311, 376);
            this.textBox.TabIndex = 1;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Paste/Edit Rich Text Here:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "RTF Markup Code";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVersion.Location = new System.Drawing.Point(515, 535);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(242, 13);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "RTF Markup Helper | Build: #DateWillShowHere#";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblVersion.Click += new System.EventHandler(this.lblVersion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(20, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Insert:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(502, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 66);
            this.button1.TabIndex = 8;
            this.button1.Text = "Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(446, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 66);
            this.button2.TabIndex = 9;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(726, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Location = new System.Drawing.Point(320, 474);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Example Text";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.Location = new System.Drawing.Point(215, 474);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Clear Text";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(368, 50);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Super";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // formatBold
            // 
            this.formatBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatBold.Location = new System.Drawing.Point(300, 50);
            this.formatBold.Name = "formatBold";
            this.formatBold.Size = new System.Drawing.Size(22, 23);
            this.formatBold.TabIndex = 14;
            this.formatBold.Text = "B";
            this.formatBold.UseVisualStyleBackColor = true;
            this.formatBold.Click += new System.EventHandler(this.formatBold_Click);
            // 
            // formatItalic
            // 
            this.formatItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatItalic.Location = new System.Drawing.Point(323, 50);
            this.formatItalic.Name = "formatItalic";
            this.formatItalic.Size = new System.Drawing.Size(20, 23);
            this.formatItalic.TabIndex = 15;
            this.formatItalic.Text = "I";
            this.formatItalic.UseVisualStyleBackColor = true;
            this.formatItalic.Click += new System.EventHandler(this.formatItalic_Click);
            // 
            // formatUnderline
            // 
            this.formatUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatUnderline.Location = new System.Drawing.Point(344, 50);
            this.formatUnderline.Name = "formatUnderline";
            this.formatUnderline.Size = new System.Drawing.Size(22, 23);
            this.formatUnderline.TabIndex = 16;
            this.formatUnderline.Text = "U";
            this.formatUnderline.UseVisualStyleBackColor = true;
            this.formatUnderline.Click += new System.EventHandler(this.formatUnderline_Click);
            // 
            // insertSymbolC
            // 
            this.insertSymbolC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertSymbolC.Location = new System.Drawing.Point(66, 474);
            this.insertSymbolC.Name = "insertSymbolC";
            this.insertSymbolC.Size = new System.Drawing.Size(27, 23);
            this.insertSymbolC.TabIndex = 17;
            this.insertSymbolC.Text = "©®™";
            this.insertSymbolC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.insertSymbolC.UseVisualStyleBackColor = true;
            this.insertSymbolC.Click += new System.EventHandler(this.insertSymbolC_Click);
            // 
            // insertSymbolR
            // 
            this.insertSymbolR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertSymbolR.Location = new System.Drawing.Point(126, 474);
            this.insertSymbolR.Name = "insertSymbolR";
            this.insertSymbolR.Size = new System.Drawing.Size(26, 23);
            this.insertSymbolR.TabIndex = 18;
            this.insertSymbolR.Text = "®";
            this.insertSymbolR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.insertSymbolR.UseVisualStyleBackColor = true;
            this.insertSymbolR.Click += new System.EventHandler(this.insertSymbolR_Click);
            // 
            // insertSymbolTM
            // 
            this.insertSymbolTM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertSymbolTM.Location = new System.Drawing.Point(96, 474);
            this.insertSymbolTM.Name = "insertSymbolTM";
            this.insertSymbolTM.Size = new System.Drawing.Size(26, 23);
            this.insertSymbolTM.TabIndex = 19;
            this.insertSymbolTM.Text = "™";
            this.insertSymbolTM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.insertSymbolTM.UseVisualStyleBackColor = true;
            this.insertSymbolTM.Click += new System.EventHandler(this.insertSymbolTM_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(203, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Font Size:";
            // 
            // tbFontSize
            // 
            this.tbFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFontSize.Location = new System.Drawing.Point(259, 50);
            this.tbFontSize.Name = "tbFontSize";
            this.tbFontSize.Size = new System.Drawing.Size(36, 24);
            this.tbFontSize.TabIndex = 22;
            this.tbFontSize.Text = "12";
            this.tbFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFontSize.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(21, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 40);
            this.panel1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tbFontSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.insertSymbolTM);
            this.Controls.Add(this.insertSymbolR);
            this.Controls.Add(this.insertSymbolC);
            this.Controls.Add(this.formatUnderline);
            this.Controls.Add(this.formatItalic);
            this.Controls.Add(this.formatBold);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.rtfBox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RTF Markup Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button formatBold;
        private System.Windows.Forms.Button formatItalic;
        private System.Windows.Forms.Button formatUnderline;
        private System.Windows.Forms.Button insertSymbolC;
        private System.Windows.Forms.Button insertSymbolR;
        private System.Windows.Forms.Button insertSymbolTM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFontSize;
        private System.Windows.Forms.Panel panel1;
    }
}

