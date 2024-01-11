namespace Lr1__BIS_.Forms
{
    partial class KeyRSACipherF
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCopy2 = new System.Windows.Forms.Button();
            this.buttonCopy1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.privateKeyBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.publicKeyBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonCopy2);
            this.panel1.Controls.Add(this.buttonCopy1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.privateKeyBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.publicKeyBox);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 218);
            this.panel1.TabIndex = 58;
            // 
            // buttonCopy2
            // 
            this.buttonCopy2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.buttonCopy2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCopy2.Location = new System.Drawing.Point(386, 181);
            this.buttonCopy2.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCopy2.Name = "buttonCopy2";
            this.buttonCopy2.Size = new System.Drawing.Size(121, 29);
            this.buttonCopy2.TabIndex = 60;
            this.buttonCopy2.Text = "копіювати";
            this.buttonCopy2.UseVisualStyleBackColor = false;
            this.buttonCopy2.Click += new System.EventHandler(this.buttonCopy2_Click);
            // 
            // buttonCopy1
            // 
            this.buttonCopy1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.buttonCopy1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCopy1.Location = new System.Drawing.Point(386, 89);
            this.buttonCopy1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCopy1.Name = "buttonCopy1";
            this.buttonCopy1.Size = new System.Drawing.Size(121, 29);
            this.buttonCopy1.TabIndex = 59;
            this.buttonCopy1.Text = "копіювати";
            this.buttonCopy1.UseVisualStyleBackColor = false;
            this.buttonCopy1.Click += new System.EventHandler(this.buttonCopy1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Відкритий ключ:";
            // 
            // privateKeyBox
            // 
            this.privateKeyBox.BackColor = System.Drawing.SystemColors.Window;
            this.privateKeyBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privateKeyBox.Location = new System.Drawing.Point(12, 134);
            this.privateKeyBox.Multiline = true;
            this.privateKeyBox.Name = "privateKeyBox";
            this.privateKeyBox.ReadOnly = true;
            this.privateKeyBox.Size = new System.Drawing.Size(495, 48);
            this.privateKeyBox.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "Закритий ключ:";
            // 
            // publicKeyBox
            // 
            this.publicKeyBox.BackColor = System.Drawing.SystemColors.Window;
            this.publicKeyBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publicKeyBox.Location = new System.Drawing.Point(12, 41);
            this.publicKeyBox.Multiline = true;
            this.publicKeyBox.Name = "publicKeyBox";
            this.publicKeyBox.ReadOnly = true;
            this.publicKeyBox.Size = new System.Drawing.Size(495, 49);
            this.publicKeyBox.TabIndex = 47;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(23, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 43);
            this.button1.TabIndex = 46;
            this.button1.Text = "Згенерувати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KeyRSACipherF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 289);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "KeyRSACipherF";
            this.Text = "KeyRSACipherF";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox privateKeyBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox publicKeyBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCopy2;
        private System.Windows.Forms.Button buttonCopy1;
    }
}