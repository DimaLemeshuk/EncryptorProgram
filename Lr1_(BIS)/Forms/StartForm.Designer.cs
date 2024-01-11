namespace Lr1__BIS_
{
    partial class StartForm
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
            this.GoWorkButton = new System.Windows.Forms.Button();
            this.GoDevelopersButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoWorkButton
            // 
            this.GoWorkButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GoWorkButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.GoWorkButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoWorkButton.Location = new System.Drawing.Point(150, 78);
            this.GoWorkButton.Name = "GoWorkButton";
            this.GoWorkButton.Size = new System.Drawing.Size(346, 60);
            this.GoWorkButton.TabIndex = 0;
            this.GoWorkButton.Text = "Шифрування/Розшифрування";
            this.GoWorkButton.UseVisualStyleBackColor = false;
            this.GoWorkButton.Click += new System.EventHandler(this.GoWorkButton_Click);
            // 
            // GoDevelopersButton
            // 
            this.GoDevelopersButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GoDevelopersButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.GoDevelopersButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoDevelopersButton.Location = new System.Drawing.Point(159, 166);
            this.GoDevelopersButton.Name = "GoDevelopersButton";
            this.GoDevelopersButton.Size = new System.Drawing.Size(326, 51);
            this.GoDevelopersButton.TabIndex = 1;
            this.GoDevelopersButton.Text = "Розробники";
            this.GoDevelopersButton.UseVisualStyleBackColor = false;
            this.GoDevelopersButton.Click += new System.EventHandler(this.GoDevelopersButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExitButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(159, 245);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(326, 51);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Вихід";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 400);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.GoDevelopersButton);
            this.Controls.Add(this.GoWorkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GoWorkButton;
        private System.Windows.Forms.Button GoDevelopersButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

