namespace Lr1__BIS_.Forms
{
    partial class RSACipherF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSACipherF));
            this.label1 = new System.Windows.Forms.Label();
            this.CryptionMethod = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.Decryption = new System.Windows.Forms.Button();
            this.Encryption = new System.Windows.Forms.Button();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.menu1 = new System.Windows.Forms.MenuStrip();
            this.GoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Algorithm = new System.Windows.Forms.ToolStripMenuItem();
            this.CaesarCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.TrithemiusCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.GammaCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.BookCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.DESCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.KnapsackCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.шифрRSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.menu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(729, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Увага !!! Для шифрування потрібно ввести відкритий ключ, а для розшифрування - за" +
    "критий";
            // 
            // CryptionMethod
            // 
            this.CryptionMethod.AutoSize = true;
            this.CryptionMethod.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CryptionMethod.Location = new System.Drawing.Point(1277, 9);
            this.CryptionMethod.Name = "CryptionMethod";
            this.CryptionMethod.Size = new System.Drawing.Size(117, 28);
            this.CryptionMethod.TabIndex = 63;
            this.CryptionMethod.Text = "Шифр RSA";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(19, 392);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 22);
            this.ErrorLabel.TabIndex = 61;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Decryption
            // 
            this.Decryption.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Decryption.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decryption.Location = new System.Drawing.Point(977, 419);
            this.Decryption.Name = "Decryption";
            this.Decryption.Size = new System.Drawing.Size(227, 46);
            this.Decryption.TabIndex = 60;
            this.Decryption.Text = "Розшифрувати";
            this.Decryption.UseVisualStyleBackColor = false;
            this.Decryption.Click += new System.EventHandler(this.Decryption_Click);
            // 
            // Encryption
            // 
            this.Encryption.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Encryption.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encryption.Location = new System.Drawing.Point(732, 420);
            this.Encryption.Name = "Encryption";
            this.Encryption.Size = new System.Drawing.Size(227, 45);
            this.Encryption.TabIndex = 59;
            this.Encryption.Text = "Зашифрувати";
            this.Encryption.UseVisualStyleBackColor = false;
            this.Encryption.Click += new System.EventHandler(this.Encryption_Click);
            // 
            // KeyBox
            // 
            this.KeyBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyBox.Location = new System.Drawing.Point(12, 420);
            this.KeyBox.Multiline = true;
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KeyBox.Size = new System.Drawing.Size(678, 85);
            this.KeyBox.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(18, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 26);
            this.label9.TabIndex = 57;
            this.label9.Text = "Ключ:";
            // 
            // TextBox2
            // 
            this.TextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox2.Location = new System.Drawing.Point(732, 47);
            this.TextBox2.Multiline = true;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ReadOnly = true;
            this.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox2.Size = new System.Drawing.Size(678, 337);
            this.TextBox2.TabIndex = 56;
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
            this.keyToolStripMenuItem,
            this.About});
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(1423, 30);
            this.menu1.TabIndex = 62;
            this.menu1.Text = "menuStrip1";
            // 
            // GoMenu
            // 
            this.GoMenu.BackColor = System.Drawing.SystemColors.Control;
            this.GoMenu.Image = ((System.Drawing.Image)(resources.GetObject("GoMenu.Image")));
            this.GoMenu.Name = "GoMenu";
            this.GoMenu.Size = new System.Drawing.Size(34, 26);
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
            this.OpenFile.Size = new System.Drawing.Size(224, 26);
            this.OpenFile.Text = "Завантажити";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(224, 26);
            this.SaveFile.Text = "Зберегти";
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // Algorithm
            // 
            this.Algorithm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CaesarCipher,
            this.TrithemiusCipher,
            this.GammaCipher,
            this.BookCipher,
            this.DESCipher,
            this.KnapsackCipher,
            this.шифрRSAToolStripMenuItem});
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
            // GammaCipher
            // 
            this.GammaCipher.Name = "GammaCipher";
            this.GammaCipher.Size = new System.Drawing.Size(249, 26);
            this.GammaCipher.Text = "Шифр гамування";
            this.GammaCipher.Click += new System.EventHandler(this.GammaCipher_Click);
            // 
            // BookCipher
            // 
            this.BookCipher.Name = "BookCipher";
            this.BookCipher.Size = new System.Drawing.Size(249, 26);
            this.BookCipher.Text = "Книжковий шифр";
            this.BookCipher.Click += new System.EventHandler(this.BookCipher_Click);
            // 
            // DESCipher
            // 
            this.DESCipher.Name = "DESCipher";
            this.DESCipher.Size = new System.Drawing.Size(249, 26);
            this.DESCipher.Text = "Шифр DES";
            this.DESCipher.Click += new System.EventHandler(this.DESCipher_Click);
            // 
            // KnapsackCipher
            // 
            this.KnapsackCipher.Name = "KnapsackCipher";
            this.KnapsackCipher.Size = new System.Drawing.Size(249, 26);
            this.KnapsackCipher.Text = "Рюкзачний шифр";
            this.KnapsackCipher.Click += new System.EventHandler(this.KnapsackCipher_Click);
            // 
            // шифрRSAToolStripMenuItem
            // 
            this.шифрRSAToolStripMenuItem.Checked = true;
            this.шифрRSAToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.шифрRSAToolStripMenuItem.Name = "шифрRSAToolStripMenuItem";
            this.шифрRSAToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.шифрRSAToolStripMenuItem.Text = "Шифр RSA";
            // 
            // keyToolStripMenuItem
            // 
            this.keyToolStripMenuItem.Name = "keyToolStripMenuItem";
            this.keyToolStripMenuItem.Size = new System.Drawing.Size(71, 26);
            this.keyToolStripMenuItem.Text = "Ключ";
            this.keyToolStripMenuItem.Click += new System.EventHandler(this.keyToolStripMenuItem_Click);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(143, 26);
            this.About.Text = "Про програму";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox1.Location = new System.Drawing.Point(12, 47);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox1.Size = new System.Drawing.Size(678, 337);
            this.TextBox1.TabIndex = 55;
            // 
            // RSACipherF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CryptionMethod);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.Decryption);
            this.Controls.Add(this.Encryption);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.TextBox1);
            this.Name = "RSACipherF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSACipherF";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.En_De_cryption_FormClosed);
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CryptionMethod;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button Decryption;
        private System.Windows.Forms.Button Encryption;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.MenuStrip menu1;
        private System.Windows.Forms.ToolStripMenuItem GoMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem SaveFile;
        private System.Windows.Forms.ToolStripMenuItem Algorithm;
        private System.Windows.Forms.ToolStripMenuItem CaesarCipher;
        private System.Windows.Forms.ToolStripMenuItem TrithemiusCipher;
        private System.Windows.Forms.ToolStripMenuItem GammaCipher;
        private System.Windows.Forms.ToolStripMenuItem BookCipher;
        private System.Windows.Forms.ToolStripMenuItem DESCipher;
        private System.Windows.Forms.ToolStripMenuItem KnapsackCipher;
        private System.Windows.Forms.ToolStripMenuItem keyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.ToolStripMenuItem шифрRSAToolStripMenuItem;
    }
}