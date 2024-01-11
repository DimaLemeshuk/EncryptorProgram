namespace Lr1__BIS_.Forms
{
    partial class TrithemiusCipherF2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrithemiusCipherF2));
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.motto = new System.Windows.Forms.ToolStripMenuItem();
            this.equation2 = new System.Windows.Forms.ToolStripMenuItem();
            this.equation1 = new System.Windows.Forms.ToolStripMenuItem();
            this.виглядToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.Decryption = new System.Windows.Forms.Button();
            this.Encryption = new System.Windows.Forms.Button();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.menu1 = new System.Windows.Forms.MenuStrip();
            this.GoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Algorithm = new System.Windows.Forms.ToolStripMenuItem();
            this.CaesarCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.GammaCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.BookCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.DESCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.CryptionMethod = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.рюкзачнийШифрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 22);
            this.label2.TabIndex = 67;
            this.label2.Text = "Введіть гасло для шифрування";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox1.Location = new System.Drawing.Point(10, 53);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox1.Size = new System.Drawing.Size(605, 261);
            this.TextBox1.TabIndex = 59;
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(143, 26);
            this.About.Text = "Про програму";
            this.About.Click += new System.EventHandler(this.About_Click_1);
            // 
            // motto
            // 
            this.motto.Checked = true;
            this.motto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.motto.Name = "motto";
            this.motto.Size = new System.Drawing.Size(259, 26);
            this.motto.Text = "гасло";
            // 
            // equation2
            // 
            this.equation2.Name = "equation2";
            this.equation2.Size = new System.Drawing.Size(259, 26);
            this.equation2.Text = "нелінійне рівняння";
            this.equation2.Click += new System.EventHandler(this.equation2_Click);
            // 
            // equation1
            // 
            this.equation1.Name = "equation1";
            this.equation1.Size = new System.Drawing.Size(259, 26);
            this.equation1.Text = "лінійне рівняння";
            this.equation1.Click += new System.EventHandler(this.equation1_Click);
            // 
            // виглядToolStripMenuItem
            // 
            this.виглядToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equation1,
            this.equation2,
            this.motto});
            this.виглядToolStripMenuItem.Name = "виглядToolStripMenuItem";
            this.виглядToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.виглядToolStripMenuItem.Text = "Вигляд";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(615, 143);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 22);
            this.ErrorLabel.TabIndex = 63;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Decryption
            // 
            this.Decryption.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Decryption.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decryption.Location = new System.Drawing.Point(892, 357);
            this.Decryption.Name = "Decryption";
            this.Decryption.Size = new System.Drawing.Size(238, 44);
            this.Decryption.TabIndex = 62;
            this.Decryption.Text = "Розшифрувати";
            this.Decryption.UseVisualStyleBackColor = false;
            this.Decryption.Click += new System.EventHandler(this.Decryption_Click);
            // 
            // Encryption
            // 
            this.Encryption.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Encryption.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encryption.Location = new System.Drawing.Point(648, 359);
            this.Encryption.Name = "Encryption";
            this.Encryption.Size = new System.Drawing.Size(238, 43);
            this.Encryption.TabIndex = 61;
            this.Encryption.Text = "Зашифрувати";
            this.Encryption.UseVisualStyleBackColor = false;
            this.Encryption.Click += new System.EventHandler(this.Encryption_Click);
            // 
            // TextBox2
            // 
            this.TextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBox2.Location = new System.Drawing.Point(648, 53);
            this.TextBox2.Multiline = true;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ReadOnly = true;
            this.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox2.Size = new System.Drawing.Size(600, 261);
            this.TextBox2.TabIndex = 60;
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
            this.виглядToolStripMenuItem,
            this.About});
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(1264, 30);
            this.menu1.TabIndex = 64;
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
            this.toolStripMenuItem1,
            this.GammaCipher,
            this.BookCipher,
            this.DESCipher,
            this.рюкзачнийШифрToolStripMenuItem});
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(249, 26);
            this.toolStripMenuItem1.Text = "Шифр Тритеміуса";
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
            // CryptionMethod
            // 
            this.CryptionMethod.AutoSize = true;
            this.CryptionMethod.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CryptionMethod.Location = new System.Drawing.Point(1050, 8);
            this.CryptionMethod.Name = "CryptionMethod";
            this.CryptionMethod.Size = new System.Drawing.Size(185, 28);
            this.CryptionMethod.TabIndex = 65;
            this.CryptionMethod.Text = "Шифр Тритеміуса";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(10, 359);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(603, 42);
            this.textBox3.TabIndex = 75;
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.browse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.browse.Location = new System.Drawing.Point(568, 359);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(45, 42);
            this.browse.TabIndex = 76;
            this.browse.Text = "🔍︎";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // рюкзачнийШифрToolStripMenuItem
            // 
            this.рюкзачнийШифрToolStripMenuItem.Name = "рюкзачнийШифрToolStripMenuItem";
            this.рюкзачнийШифрToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.рюкзачнийШифрToolStripMenuItem.Text = "Рюкзачний шифр";
            this.рюкзачнийШифрToolStripMenuItem.Click += new System.EventHandler(this.рюкзачнийШифрToolStripMenuItem_Click);
            // 
            // TrithemiusCipherF2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 462);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.CryptionMethod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.Decryption);
            this.Controls.Add(this.Encryption);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.menu1);
            this.Name = "TrithemiusCipherF2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrithemiusCipherF_FormClosed);
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem motto;
        private System.Windows.Forms.ToolStripMenuItem equation2;
        private System.Windows.Forms.ToolStripMenuItem equation1;
        private System.Windows.Forms.ToolStripMenuItem виглядToolStripMenuItem;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button Decryption;
        private System.Windows.Forms.Button Encryption;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.MenuStrip menu1;
        private System.Windows.Forms.ToolStripMenuItem GoMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem SaveFile;
        private System.Windows.Forms.ToolStripMenuItem Algorithm;
        private System.Windows.Forms.ToolStripMenuItem CaesarCipher;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label CryptionMethod;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.ToolStripMenuItem GammaCipher;
        private System.Windows.Forms.ToolStripMenuItem BookCipher;
        private System.Windows.Forms.ToolStripMenuItem DESCipher;
        private System.Windows.Forms.ToolStripMenuItem рюкзачнийШифрToolStripMenuItem;
    }
}