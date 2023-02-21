namespace viznerovasifra
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
            this.PlainText = new System.Windows.Forms.TextBox();
            this.CipherText = new System.Windows.Forms.TextBox();
            this.BtnEncrypt = new System.Windows.Forms.Button();
            this.KeyText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SerbianCyrillic = new System.Windows.Forms.RadioButton();
            this.SerbianLatin = new System.Windows.Forms.RadioButton();
            this.EnglishAlphabet = new System.Windows.Forms.RadioButton();
            this.BtnDecrypt = new System.Windows.Forms.Button();
            this.PlainText2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PlainTextLabel = new System.Windows.Forms.Label();
            this.KeyTextLabel = new System.Windows.Forms.Label();
            this.autocrypt = new System.Windows.Forms.CheckBox();
            this.Latin = new System.Windows.Forms.Button();
            this.Cyrillic = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.About = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Contact = new System.Windows.Forms.ToolStripButton();
            this.github = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlainText
            // 
            this.PlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlainText.Location = new System.Drawing.Point(65, 85);
            this.PlainText.Multiline = true;
            this.PlainText.Name = "PlainText";
            this.PlainText.Size = new System.Drawing.Size(244, 111);
            this.PlainText.TabIndex = 0;
            this.PlainText.TextChanged += new System.EventHandler(this.PlainText_TextChanged);
            // 
            // CipherText
            // 
            this.CipherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CipherText.Location = new System.Drawing.Point(503, 85);
            this.CipherText.Multiline = true;
            this.CipherText.Name = "CipherText";
            this.CipherText.ReadOnly = true;
            this.CipherText.Size = new System.Drawing.Size(244, 111);
            this.CipherText.TabIndex = 1;
            this.CipherText.TextChanged += new System.EventHandler(this.CipherText_TextChanged);
            // 
            // BtnEncrypt
            // 
            this.BtnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEncrypt.Location = new System.Drawing.Point(315, 85);
            this.BtnEncrypt.Name = "BtnEncrypt";
            this.BtnEncrypt.Size = new System.Drawing.Size(182, 111);
            this.BtnEncrypt.TabIndex = 2;
            this.BtnEncrypt.Text = "Шифруј";
            this.BtnEncrypt.UseVisualStyleBackColor = true;
            this.BtnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // KeyText
            // 
            this.KeyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyText.Location = new System.Drawing.Point(65, 233);
            this.KeyText.Name = "KeyText";
            this.KeyText.Size = new System.Drawing.Size(244, 26);
            this.KeyText.TabIndex = 3;
            this.KeyText.TextChanged += new System.EventHandler(this.KeyText_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SerbianCyrillic);
            this.panel1.Controls.Add(this.SerbianLatin);
            this.panel1.Controls.Add(this.EnglishAlphabet);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(315, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 92);
            this.panel1.TabIndex = 4;
            // 
            // SerbianCyrillic
            // 
            this.SerbianCyrillic.AutoSize = true;
            this.SerbianCyrillic.Location = new System.Drawing.Point(3, 63);
            this.SerbianCyrillic.Name = "SerbianCyrillic";
            this.SerbianCyrillic.Size = new System.Drawing.Size(163, 24);
            this.SerbianCyrillic.TabIndex = 2;
            this.SerbianCyrillic.Text = "Српска Ћирилица";
            this.SerbianCyrillic.UseVisualStyleBackColor = true;
            this.SerbianCyrillic.CheckedChanged += new System.EventHandler(this.Alphabet_CheckedChanged);
            // 
            // SerbianLatin
            // 
            this.SerbianLatin.AutoSize = true;
            this.SerbianLatin.Location = new System.Drawing.Point(3, 33);
            this.SerbianLatin.Name = "SerbianLatin";
            this.SerbianLatin.Size = new System.Drawing.Size(160, 24);
            this.SerbianLatin.TabIndex = 1;
            this.SerbianLatin.Text = "Српска Латиница";
            this.SerbianLatin.UseVisualStyleBackColor = true;
            this.SerbianLatin.CheckedChanged += new System.EventHandler(this.Alphabet_CheckedChanged);
            // 
            // EnglishAlphabet
            // 
            this.EnglishAlphabet.AutoSize = true;
            this.EnglishAlphabet.Checked = true;
            this.EnglishAlphabet.Location = new System.Drawing.Point(3, 3);
            this.EnglishAlphabet.Name = "EnglishAlphabet";
            this.EnglishAlphabet.Size = new System.Drawing.Size(174, 24);
            this.EnglishAlphabet.TabIndex = 0;
            this.EnglishAlphabet.TabStop = true;
            this.EnglishAlphabet.Text = "Енглески Алфабет";
            this.EnglishAlphabet.UseVisualStyleBackColor = true;
            this.EnglishAlphabet.CheckedChanged += new System.EventHandler(this.Alphabet_CheckedChanged);
            // 
            // BtnDecrypt
            // 
            this.BtnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDecrypt.Location = new System.Drawing.Point(503, 202);
            this.BtnDecrypt.Name = "BtnDecrypt";
            this.BtnDecrypt.Size = new System.Drawing.Size(244, 60);
            this.BtnDecrypt.TabIndex = 5;
            this.BtnDecrypt.Text = "Дешифруј";
            this.BtnDecrypt.UseVisualStyleBackColor = true;
            this.BtnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // PlainText2
            // 
            this.PlainText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlainText2.Location = new System.Drawing.Point(503, 311);
            this.PlainText2.Multiline = true;
            this.PlainText2.Name = "PlainText2";
            this.PlainText2.ReadOnly = true;
            this.PlainText2.Size = new System.Drawing.Size(244, 111);
            this.PlainText2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(607, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = " | \r\n |\r\nV\r\n";
            // 
            // PlainTextLabel
            // 
            this.PlainTextLabel.AutoSize = true;
            this.PlainTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlainTextLabel.Location = new System.Drawing.Point(64, 66);
            this.PlainTextLabel.Name = "PlainTextLabel";
            this.PlainTextLabel.Size = new System.Drawing.Size(104, 16);
            this.PlainTextLabel.TabIndex = 8;
            this.PlainTextLabel.Text = "Унесите текст:";
            // 
            // KeyTextLabel
            // 
            this.KeyTextLabel.AutoSize = true;
            this.KeyTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyTextLabel.Location = new System.Drawing.Point(64, 214);
            this.KeyTextLabel.Name = "KeyTextLabel";
            this.KeyTextLabel.Size = new System.Drawing.Size(102, 16);
            this.KeyTextLabel.TabIndex = 9;
            this.KeyTextLabel.Text = "Унесите кључ:";
            // 
            // autocrypt
            // 
            this.autocrypt.AutoSize = true;
            this.autocrypt.Location = new System.Drawing.Point(67, 277);
            this.autocrypt.Name = "autocrypt";
            this.autocrypt.Size = new System.Drawing.Size(183, 17);
            this.autocrypt.TabIndex = 10;
            this.autocrypt.Text = "Аутоматски шифруј и дешифруј";
            this.autocrypt.UseVisualStyleBackColor = true;
            this.autocrypt.CheckedChanged += new System.EventHandler(this.autocrypt_CheckedChanged);
            // 
            // Latin
            // 
            this.Latin.Location = new System.Drawing.Point(716, 28);
            this.Latin.Name = "Latin";
            this.Latin.Size = new System.Drawing.Size(75, 23);
            this.Latin.TabIndex = 11;
            this.Latin.Text = "Latinica";
            this.Latin.UseVisualStyleBackColor = true;
            this.Latin.Click += new System.EventHandler(this.Latin_Click);
            // 
            // Cyrillic
            // 
            this.Cyrillic.Location = new System.Drawing.Point(797, 28);
            this.Cyrillic.Name = "Cyrillic";
            this.Cyrillic.Size = new System.Drawing.Size(75, 23);
            this.Cyrillic.TabIndex = 12;
            this.Cyrillic.Text = "Ћирилица";
            this.Cyrillic.UseVisualStyleBackColor = true;
            this.Cyrillic.Click += new System.EventHandler(this.Cyrillic_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About,
            this.toolStripSeparator1,
            this.Contact,
            this.toolStripSeparator2,
            this.github});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(884, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // About
            // 
            this.About.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.About.Image = ((System.Drawing.Image)(resources.GetObject("About.Image")));
            this.About.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(69, 22);
            this.About.Text = "O aplikaciji";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Contact
            // 
            this.Contact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Contact.Image = ((System.Drawing.Image)(resources.GetObject("Contact.Image")));
            this.Contact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(52, 22);
            this.Contact.Text = "Kontakt";
            this.Contact.Click += new System.EventHandler(this.Contact_Click);
            // 
            // github
            // 
            this.github.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.github.Image = ((System.Drawing.Image)(resources.GetObject("github.Image")));
            this.github.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(47, 22);
            this.github.Text = "Github";
            this.github.Click += new System.EventHandler(this.github_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Cyrillic);
            this.Controls.Add(this.Latin);
            this.Controls.Add(this.autocrypt);
            this.Controls.Add(this.KeyTextLabel);
            this.Controls.Add(this.PlainTextLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlainText2);
            this.Controls.Add(this.BtnDecrypt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.KeyText);
            this.Controls.Add(this.BtnEncrypt);
            this.Controls.Add(this.CipherText);
            this.Controls.Add(this.PlainText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlainText;
        private System.Windows.Forms.TextBox CipherText;
        private System.Windows.Forms.Button BtnEncrypt;
        private System.Windows.Forms.TextBox KeyText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton SerbianCyrillic;
        private System.Windows.Forms.RadioButton SerbianLatin;
        private System.Windows.Forms.RadioButton EnglishAlphabet;
        private System.Windows.Forms.Button BtnDecrypt;
        private System.Windows.Forms.TextBox PlainText2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PlainTextLabel;
        private System.Windows.Forms.Label KeyTextLabel;
        private System.Windows.Forms.CheckBox autocrypt;
        private System.Windows.Forms.Button Latin;
        private System.Windows.Forms.Button Cyrillic;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton About;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Contact;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton github;
    }
}

