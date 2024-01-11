namespace Lr1__BIS_.Classes
{
    partial class KnapsackCipherF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KnapsackCipherF));
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.DESCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.BookCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.GammaCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.TrithemiusCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.CaesarCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.Algorithm = new System.Windows.Forms.ToolStripMenuItem();
            this.рюкзачнийШифрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.CryptionMethod = new System.Windows.Forms.Label();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.GoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.Decryption = new System.Windows.Forms.Button();
            this.Encryption = new System.Windows.Forms.Button();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.menu1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.keyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.moduleBox = new System.Windows.Forms.TextBox();
            this.multiplierBox = new System.Windows.Forms.TextBox();
            this.menu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(143, 26);
            this.About.Text = "Про програму";
            // 
            // DESCipher
            // 
            this.DESCipher.Name = "DESCipher";
            this.DESCipher.Size = new System.Drawing.Size(249, 26);
            this.DESCipher.Text = "Шифр DES";
            this.DESCipher.Click += new System.EventHandler(this.DESCipher_Click);
            // 
            // BookCipher
            // 
            this.BookCipher.Name = "BookCipher";
            this.BookCipher.Size = new System.Drawing.Size(249, 26);
            this.BookCipher.Text = "Книжковий шифр";
            this.BookCipher.Click += new System.EventHandler(this.BookCipher_Click);
            // 
            // GammaCipher
            // 
            this.GammaCipher.Name = "GammaCipher";
            this.GammaCipher.Size = new System.Drawing.Size(249, 26);
            this.GammaCipher.Text = "Шифр гамування";
            this.GammaCipher.Click += new System.EventHandler(this.GammaCipher_Click);
            // 
            // TrithemiusCipher
            // 
            this.TrithemiusCipher.Name = "TrithemiusCipher";
            this.TrithemiusCipher.Size = new System.Drawing.Size(249, 26);
            this.TrithemiusCipher.Text = "Шифр Тритеміуса";
            this.TrithemiusCipher.Click += new System.EventHandler(this.TrithemiusCipher_Click);
            // 
            // CaesarCipher
            // 
            this.CaesarCipher.Name = "CaesarCipher";
            this.CaesarCipher.Size = new System.Drawing.Size(249, 26);
            this.CaesarCipher.Text = "Шифр Цезаря";
            this.CaesarCipher.Click += new System.EventHandler(this.CaesarCipher_Click);
            // 
            // Algorithm
            // 
            this.Algorithm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CaesarCipher,
            this.TrithemiusCipher,
            this.GammaCipher,
            this.BookCipher,
            this.DESCipher,
            this.рюкзачнийШифрToolStripMenuItem});
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Size = new System.Drawing.Size(120, 26);
            this.Algorithm.Text = "Алгоритми";
            // 
            // рюкзачнийШифрToolStripMenuItem
            // 
            this.рюкзачнийШифрToolStripMenuItem.Checked = true;
            this.рюкзачнийШифрToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.рюкзачнийШифрToolStripMenuItem.Name = "рюкзачнийШифрToolStripMenuItem";
            this.рюкзачнийШифрToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.рюкзачнийШифрToolStripMenuItem.Text = "Рюкзачний шифр";
            // 
            // SaveFile
            // 
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(205, 26);
            this.SaveFile.Text = "Зберегти";
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // CryptionMethod
            // 
            this.CryptionMethod.AutoSize = true;
            this.CryptionMethod.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CryptionMethod.Location = new System.Drawing.Point(1211, 9);
            this.CryptionMethod.Name = "CryptionMethod";
            this.CryptionMethod.Size = new System.Drawing.Size(178, 28);
            this.CryptionMethod.TabIndex = 49;
            this.CryptionMethod.Text = "Рюкзачний шифр";
            // 
            // OpenFile
            // 
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(205, 26);
            this.OpenFile.Text = "Завантажити";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // GoMenu
            // 
            this.GoMenu.BackColor = System.Drawing.SystemColors.Control;
            this.GoMenu.Image = ((System.Drawing.Image)(resources.GetObject("GoMenu.Image")));
            this.GoMenu.Name = "GoMenu";
            this.GoMenu.Size = new System.Drawing.Size(34, 26);
            this.GoMenu.Click += new System.EventHandler(this.GoMenu_Click_1);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(19, 395);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 22);
            this.ErrorLabel.TabIndex = 47;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Decryption
            // 
            this.Decryption.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Decryption.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decryption.Location = new System.Drawing.Point(978, 416);
            this.Decryption.Name = "Decryption";
            this.Decryption.Size = new System.Drawing.Size(227, 46);
            this.Decryption.TabIndex = 46;
            this.Decryption.Text = "Розшифрувати";
            this.Decryption.UseVisualStyleBackColor = false;
            this.Decryption.Click += new System.EventHandler(this.Decryption_Click);
            // 
            // Encryption
            // 
            this.Encryption.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Encryption.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encryption.Location = new System.Drawing.Point(732, 417);
            this.Encryption.Name = "Encryption";
            this.Encryption.Size = new System.Drawing.Size(227, 45);
            this.Encryption.TabIndex = 45;
            this.Encryption.Text = "Зашифрувати";
            this.Encryption.UseVisualStyleBackColor = false;
            this.Encryption.Click += new System.EventHandler(this.Encryption_Click);
            // 
            // KeyBox
            // 
            this.KeyBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyBox.Location = new System.Drawing.Point(103, 422);
            this.KeyBox.Multiline = true;
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(587, 34);
            this.KeyBox.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(7, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 26);
            this.label9.TabIndex = 43;
            this.label9.Text = "Ключ:";
            // 
            // TextBox2
            // 
            this.TextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox2.Location = new System.Drawing.Point(732, 50);
            this.TextBox2.Multiline = true;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ReadOnly = true;
            this.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox2.Size = new System.Drawing.Size(678, 337);
            this.TextBox2.TabIndex = 42;
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
            this.menu1.Size = new System.Drawing.Size(1425, 30);
            this.menu1.TabIndex = 48;
            this.menu1.Text = "menuStrip1";
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
            // keyToolStripMenuItem
            // 
            this.keyToolStripMenuItem.Name = "keyToolStripMenuItem";
            this.keyToolStripMenuItem.Size = new System.Drawing.Size(71, 26);
            this.keyToolStripMenuItem.Text = "Ключ";
            this.keyToolStripMenuItem.Click += new System.EventHandler(this.keyToolStripMenuItem_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox1.Location = new System.Drawing.Point(12, 50);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox1.Size = new System.Drawing.Size(678, 337);
            this.TextBox1.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(729, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Увага !!! Для шифрування потрібно ввести відкритий ключ, а для розшифрування - за" +
    "критий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 51;
            this.label2.Text = "Модуль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(349, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 26);
            this.label3.TabIndex = 52;
            this.label3.Text = "Множник:";
            // 
            // moduleBox
            // 
            this.moduleBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moduleBox.Location = new System.Drawing.Point(103, 468);
            this.moduleBox.Multiline = true;
            this.moduleBox.Name = "moduleBox";
            this.moduleBox.Size = new System.Drawing.Size(224, 34);
            this.moduleBox.TabIndex = 53;
            // 
            // multiplierBox
            // 
            this.multiplierBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplierBox.Location = new System.Drawing.Point(466, 468);
            this.multiplierBox.Multiline = true;
            this.multiplierBox.Name = "multiplierBox";
            this.multiplierBox.Size = new System.Drawing.Size(224, 34);
            this.multiplierBox.TabIndex = 54;
            // 
            // KnapsackCipherF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 511);
            this.Controls.Add(this.multiplierBox);
            this.Controls.Add(this.moduleBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
            this.Name = "KnapsackCipherF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KnapsackCipherF";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.En_De_cryption_FormClosed);
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem DESCipher;
        private System.Windows.Forms.ToolStripMenuItem BookCipher;
        private System.Windows.Forms.ToolStripMenuItem GammaCipher;
        private System.Windows.Forms.ToolStripMenuItem TrithemiusCipher;
        private System.Windows.Forms.ToolStripMenuItem CaesarCipher;
        private System.Windows.Forms.ToolStripMenuItem Algorithm;
        private System.Windows.Forms.ToolStripMenuItem SaveFile;
        private System.Windows.Forms.Label CryptionMethod;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem GoMenu;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button Decryption;
        private System.Windows.Forms.Button Encryption;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.MenuStrip menu1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.ToolStripMenuItem рюкзачнийШифрToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem keyToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox moduleBox;
        private System.Windows.Forms.TextBox multiplierBox;
    }
}