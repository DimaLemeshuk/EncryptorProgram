namespace Lr1__BIS_.Forms
{
    partial class KeyKnapsackCipherF
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.seedTextBox = new System.Windows.Forms.TextBox();
            this.lenghtTextBox = new System.Windows.Forms.TextBox();
            this.GetKey = new System.Windows.Forms.Button();
            this.publicKeyTextBox = new System.Windows.Forms.TextBox();
            this.privateKeyTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.multiplierTextBox = new System.Windows.Forms.TextBox();
            this.moduleTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сід:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Довжина ключів:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(-1, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Відкритий ключ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Закритий ключ:";
            // 
            // seedTextBox
            // 
            this.seedTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seedTextBox.Location = new System.Drawing.Point(228, 18);
            this.seedTextBox.Name = "seedTextBox";
            this.seedTextBox.Size = new System.Drawing.Size(250, 30);
            this.seedTextBox.TabIndex = 4;
            // 
            // lenghtTextBox
            // 
            this.lenghtTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lenghtTextBox.Location = new System.Drawing.Point(228, 67);
            this.lenghtTextBox.Name = "lenghtTextBox";
            this.lenghtTextBox.Size = new System.Drawing.Size(250, 30);
            this.lenghtTextBox.TabIndex = 5;
            // 
            // GetKey
            // 
            this.GetKey.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.GetKey.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetKey.Location = new System.Drawing.Point(132, 114);
            this.GetKey.Name = "GetKey";
            this.GetKey.Size = new System.Drawing.Size(227, 43);
            this.GetKey.TabIndex = 46;
            this.GetKey.Text = "Згенерувати";
            this.GetKey.UseVisualStyleBackColor = false;
            this.GetKey.Click += new System.EventHandler(this.GetKey_Click);
            // 
            // publicKeyTextBox
            // 
            this.publicKeyTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.publicKeyTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publicKeyTextBox.Location = new System.Drawing.Point(192, 34);
            this.publicKeyTextBox.Name = "publicKeyTextBox";
            this.publicKeyTextBox.ReadOnly = true;
            this.publicKeyTextBox.Size = new System.Drawing.Size(315, 30);
            this.publicKeyTextBox.TabIndex = 47;
            // 
            // privateKeyTextBox
            // 
            this.privateKeyTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.privateKeyTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privateKeyTextBox.Location = new System.Drawing.Point(192, 86);
            this.privateKeyTextBox.Name = "privateKeyTextBox";
            this.privateKeyTextBox.ReadOnly = true;
            this.privateKeyTextBox.Size = new System.Drawing.Size(315, 30);
            this.privateKeyTextBox.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.moduleTextBox);
            this.panel1.Controls.Add(this.multiplierTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.privateKeyTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.publicKeyTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 207);
            this.panel1.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ErrorLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.GetKey);
            this.panel2.Controls.Add(this.seedTextBox);
            this.panel2.Controls.Add(this.lenghtTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 193);
            this.panel2.TabIndex = 50;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(15, 162);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 22);
            this.ErrorLabel.TabIndex = 48;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(84, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 26);
            this.label5.TabIndex = 49;
            this.label5.Text = "Модуль:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(311, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 26);
            this.label6.TabIndex = 50;
            this.label6.Text = "Множник:";
            // 
            // multiplierTextBox
            // 
            this.multiplierTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.multiplierTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplierTextBox.Location = new System.Drawing.Point(273, 160);
            this.multiplierTextBox.Name = "multiplierTextBox";
            this.multiplierTextBox.ReadOnly = true;
            this.multiplierTextBox.Size = new System.Drawing.Size(205, 30);
            this.multiplierTextBox.TabIndex = 52;
            // 
            // moduleTextBox
            // 
            this.moduleTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.moduleTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moduleTextBox.Location = new System.Drawing.Point(36, 160);
            this.moduleTextBox.Name = "moduleTextBox";
            this.moduleTextBox.ReadOnly = true;
            this.moduleTextBox.Size = new System.Drawing.Size(205, 30);
            this.moduleTextBox.TabIndex = 53;
            // 
            // KeyKnapsackCipherF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 446);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "KeyKnapsackCipherF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox seedTextBox;
        private System.Windows.Forms.TextBox lenghtTextBox;
        private System.Windows.Forms.Button GetKey;
        private System.Windows.Forms.TextBox publicKeyTextBox;
        private System.Windows.Forms.TextBox privateKeyTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox moduleTextBox;
        private System.Windows.Forms.TextBox multiplierTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}