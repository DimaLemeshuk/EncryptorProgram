namespace Lr1__BIS_.Forms
{
    partial class BookCipherF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookCipherF));
            this.CryptionMethod = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.menu1 = new System.Windows.Forms.MenuStrip();
            this.GoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Algorithm = new System.Windows.Forms.ToolStripMenuItem();
            this.CaesarCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.TrithemiusCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.GaammaCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.BookCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenKey = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveKey = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Decryption = new System.Windows.Forms.Button();
            this.Encryption = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.DESCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // CryptionMethod
            // 
            this.CryptionMethod.AutoSize = true;
            this.CryptionMethod.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CryptionMethod.Location = new System.Drawing.Point(1030, 9);
            this.CryptionMethod.Name = "CryptionMethod";
            this.CryptionMethod.Size = new System.Drawing.Size(211, 31);
            this.CryptionMethod.TabIndex = 91;
            this.CryptionMethod.Text = "Книжковий шифр";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(756, 70);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(496, 403);
            this.textBox3.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(-208, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 92;
            this.label2.Text = "Введіть сід:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(412, 316);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 22);
            this.ErrorLabel.TabIndex = 89;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.SystemColors.Menu;
            this.menu1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GoMenu,
            this.MenuItemFile,
            this.Algorithm,
            this.KeyToolStripMenuItem,
            this.About});
            this.menu1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(1264, 30);
            this.menu1.TabIndex = 90;
            this.menu1.Text = "menuStrip1";
            // 
            // GoMenu
            // 
            this.GoMenu.BackColor = System.Drawing.SystemColors.Control;
            this.GoMenu.Image = ((System.Drawing.Image)(resources.GetObject("GoMenu.Image")));
            this.GoMenu.Name = "GoMenu";
            this.GoMenu.Size = new System.Drawing.Size(34, 26);
            this.GoMenu.Click += new System.EventHandler(this.GoMenu_Click);
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile,
            this.SaveFile});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(70, 26);
            this.MenuItemFile.Text = "Файл";
            // 
            // OpenFile
            // 
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(205, 26);
            this.OpenFile.Text = "Завантажити";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click_1);
            // 
            // SaveFile
            // 
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(205, 26);
            this.SaveFile.Text = "Зберегти";
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click_1);
            // 
            // Algorithm
            // 
            this.Algorithm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CaesarCipher,
            this.TrithemiusCipher,
            this.GaammaCipher,
            this.BookCipher,
            this.DESCipher});
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Size = new System.Drawing.Size(120, 26);
            this.Algorithm.Text = "Алгоритми";
            // 
            // CaesarCipher
            // 
            this.CaesarCipher.Name = "CaesarCipher";
            this.CaesarCipher.Size = new System.Drawing.Size(249, 26);
            this.CaesarCipher.Text = "Шифр Цезаря";
            this.CaesarCipher.Click += new System.EventHandler(this.CaesarCipher_Click);
            // 
            // TrithemiusCipher
            // 
            this.TrithemiusCipher.Name = "TrithemiusCipher";
            this.TrithemiusCipher.Size = new System.Drawing.Size(249, 26);
            this.TrithemiusCipher.Text = "Шифр Тритеміуса";
            this.TrithemiusCipher.Click += new System.EventHandler(this.TrithemiusCipher_Click);
            // 
            // GaammaCipher
            // 
            this.GaammaCipher.Name = "GaammaCipher";
            this.GaammaCipher.Size = new System.Drawing.Size(249, 26);
            this.GaammaCipher.Text = "Шифр гамування";
            this.GaammaCipher.Click += new System.EventHandler(this.GaammaCipher_Click);
            // 
            // BookCipher
            // 
            this.BookCipher.Checked = true;
            this.BookCipher.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BookCipher.Name = "BookCipher";
            this.BookCipher.Size = new System.Drawing.Size(249, 26);
            this.BookCipher.Text = "Книжковий шифр";
            // 
            // KeyToolStripMenuItem
            // 
            this.KeyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenKey,
            this.SaveKey});
            this.KeyToolStripMenuItem.Name = "KeyToolStripMenuItem";
            this.KeyToolStripMenuItem.Size = new System.Drawing.Size(71, 26);
            this.KeyToolStripMenuItem.Text = "Ключ";
            // 
            // OpenKey
            // 
            this.OpenKey.Name = "OpenKey";
            this.OpenKey.Size = new System.Drawing.Size(205, 26);
            this.OpenKey.Text = "Завантажити";
            this.OpenKey.Click += new System.EventHandler(this.OpenKey_Click);
            // 
            // SaveKey
            // 
            this.SaveKey.Name = "SaveKey";
            this.SaveKey.Size = new System.Drawing.Size(205, 26);
            this.SaveKey.Text = "Зберегти";
            this.SaveKey.Click += new System.EventHandler(this.SaveKey_Click);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(143, 26);
            this.About.Text = "Про програму";
            this.About.Click += new System.EventHandler(this.About_Click_1);
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox1.Location = new System.Drawing.Point(12, 70);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox1.Size = new System.Drawing.Size(723, 229);
            this.TextBox1.TabIndex = 86;
            // 
            // TextBox2
            // 
            this.TextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBox2.Location = new System.Drawing.Point(12, 330);
            this.TextBox2.Multiline = true;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ReadOnly = true;
            this.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox2.Size = new System.Drawing.Size(723, 218);
            this.TextBox2.TabIndex = 87;
            // 
            // Decryption
            // 
            this.Decryption.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Decryption.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decryption.Location = new System.Drawing.Point(1013, 505);
            this.Decryption.Name = "Decryption";
            this.Decryption.Size = new System.Drawing.Size(239, 44);
            this.Decryption.TabIndex = 95;
            this.Decryption.Text = "Розшифрувати";
            this.Decryption.UseVisualStyleBackColor = false;
            this.Decryption.Click += new System.EventHandler(this.Encryption_Click);
            // 
            // Encryption
            // 
            this.Encryption.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Encryption.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encryption.Location = new System.Drawing.Point(756, 505);
            this.Encryption.Name = "Encryption";
            this.Encryption.Size = new System.Drawing.Size(251, 43);
            this.Encryption.TabIndex = 94;
            this.Encryption.Text = "Зашифрувати";
            this.Encryption.UseVisualStyleBackColor = false;
            this.Encryption.Click += new System.EventHandler(this.Decryption_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 23);
            this.label1.TabIndex = 96;
            this.label1.Text = "Вхідне повідомлення:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(752, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 97;
            this.label3.Text = "Ключ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(577, 23);
            this.label4.TabIndex = 98;
            this.label4.Text = "Повідомлення після проведеня шифрування/розшифрування:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(752, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 22);
            this.label5.TabIndex = 99;
            this.label5.Text = "Довжина ряду таблиці шифрування:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1102, 479);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 100;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // DESCipher
            // 
            this.DESCipher.Name = "DESCipher";
            this.DESCipher.Size = new System.Drawing.Size(249, 26);
            this.DESCipher.Text = "Шифр DES";
            this.DESCipher.Click += new System.EventHandler(this.DESCipher_Click);
            // 
            // BookCipherF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 587);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Decryption);
            this.Controls.Add(this.Encryption);
            this.Controls.Add(this.CryptionMethod);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.TextBox2);
            this.Name = "BookCipherF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookCipherF";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookCipherF_FormClosed);
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CryptionMethod;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.MenuStrip menu1;
        private System.Windows.Forms.ToolStripMenuItem GoMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem SaveFile;
        private System.Windows.Forms.ToolStripMenuItem Algorithm;
        private System.Windows.Forms.ToolStripMenuItem CaesarCipher;
        private System.Windows.Forms.ToolStripMenuItem TrithemiusCipher;
        private System.Windows.Forms.ToolStripMenuItem GaammaCipher;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.Button Decryption;
        private System.Windows.Forms.Button Encryption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem BookCipher;
        private System.Windows.Forms.ToolStripMenuItem KeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenKey;
        private System.Windows.Forms.ToolStripMenuItem SaveKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ToolStripMenuItem DESCipher;
    }
}