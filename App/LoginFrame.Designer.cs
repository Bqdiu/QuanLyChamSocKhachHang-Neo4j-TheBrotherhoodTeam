namespace App
{
    partial class LoginFrame
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            passwordTextBox = new System.Windows.Forms.TextBox();
            usernameTextBox = new System.Windows.Forms.TextBox();
            loginButton = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            button2 = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Black;
            label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(98, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(234, 33);
            label1.TabIndex = 2;
            label1.Text = "LOGIN ACCOUNT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label2.Location = new System.Drawing.Point(11, 27);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 23);
            label2.TabIndex = 3;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label3.Location = new System.Drawing.Point(10, 57);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(91, 23);
            label3.TabIndex = 4;
            label3.Text = "Password  :";
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(usernameTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(34, 76);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(364, 114);
            panel1.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new System.Drawing.Point(129, 58);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new System.Drawing.Size(216, 23);
            passwordTextBox.TabIndex = 6;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            usernameTextBox.Location = new System.Drawing.Point(129, 28);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new System.Drawing.Size(217, 23);
            usernameTextBox.TabIndex = 5;
            // 
            // loginButton
            // 
            loginButton.BackColor = System.Drawing.Color.Black;
            loginButton.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            loginButton.ForeColor = System.Drawing.Color.White;
            loginButton.Location = new System.Drawing.Point(199, 203);
            loginButton.Name = "loginButton";
            loginButton.Size = new System.Drawing.Size(102, 34);
            loginButton.TabIndex = 6;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.White;
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(loginButton);
            panel2.Location = new System.Drawing.Point(293, 47);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(424, 272);
            panel2.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.HighlightText;
            button2.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(307, 203);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(91, 34);
            button2.TabIndex = 8;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._174203378;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(39, 73);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(228, 213);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // LoginFrame
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(241, 239, 231);
            ClientSize = new System.Drawing.Size(751, 367);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Name = "LoginFrame";
            Text = "CUSTOMER CARE MANAGEMENT";
            Load += LoginFrame_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}