namespace App
{
    partial class EmployeeFrame
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            tbEmpName = new System.Windows.Forms.TextBox();
            tbEmpCitizenID = new System.Windows.Forms.TextBox();
            dtpEmpDob = new System.Windows.Forms.DateTimePicker();
            tbEmpAddress = new System.Windows.Forms.RichTextBox();
            tbEmpPhone = new System.Windows.Forms.TextBox();
            tbEmpEmail = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            tbEmpRole = new System.Windows.Forms.TextBox();
            btnEdit = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            tb_username = new System.Windows.Forms.TextBox();
            lb_username = new System.Windows.Forms.Label();
            tb_password = new System.Windows.Forms.TextBox();
            lb_password = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            tbEmpID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(241, 239, 231);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new System.Drawing.Point(10, 341);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(1027, 309);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.Window;
            label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(23, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(178, 45);
            label2.TabIndex = 2;
            label2.Text = "Employees";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(108, 84);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(40, 15);
            label3.TabIndex = 3;
            label3.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(318, 84);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(58, 15);
            label5.TabIndex = 5;
            label5.Text = "CitizenID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(588, 84);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(31, 15);
            label7.TabIndex = 13;
            label7.Text = "DoB";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(767, 84);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 15);
            label1.TabIndex = 14;
            label1.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(39, 152);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 15);
            label4.TabIndex = 15;
            label4.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(318, 152);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(36, 15);
            label6.TabIndex = 16;
            label6.Text = "Email";
            // 
            // tbEmpName
            // 
            tbEmpName.Location = new System.Drawing.Point(108, 110);
            tbEmpName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbEmpName.Name = "tbEmpName";
            tbEmpName.Size = new System.Drawing.Size(158, 23);
            tbEmpName.TabIndex = 17;
            // 
            // tbEmpCitizenID
            // 
            tbEmpCitizenID.Location = new System.Drawing.Point(318, 110);
            tbEmpCitizenID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbEmpCitizenID.Name = "tbEmpCitizenID";
            tbEmpCitizenID.Size = new System.Drawing.Size(229, 23);
            tbEmpCitizenID.TabIndex = 18;
            // 
            // dtpEmpDob
            // 
            dtpEmpDob.CustomFormat = "yyyy-MM-dd";
            dtpEmpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpEmpDob.Location = new System.Drawing.Point(588, 110);
            dtpEmpDob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dtpEmpDob.Name = "dtpEmpDob";
            dtpEmpDob.Size = new System.Drawing.Size(151, 23);
            dtpEmpDob.TabIndex = 19;
            // 
            // tbEmpAddress
            // 
            tbEmpAddress.Location = new System.Drawing.Point(767, 110);
            tbEmpAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbEmpAddress.Name = "tbEmpAddress";
            tbEmpAddress.Size = new System.Drawing.Size(270, 91);
            tbEmpAddress.TabIndex = 20;
            tbEmpAddress.Text = "";
            // 
            // tbEmpPhone
            // 
            tbEmpPhone.Location = new System.Drawing.Point(39, 180);
            tbEmpPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbEmpPhone.Name = "tbEmpPhone";
            tbEmpPhone.Size = new System.Drawing.Size(229, 23);
            tbEmpPhone.TabIndex = 21;
            // 
            // tbEmpEmail
            // 
            tbEmpEmail.Location = new System.Drawing.Point(318, 180);
            tbEmpEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbEmpEmail.Name = "tbEmpEmail";
            tbEmpEmail.Size = new System.Drawing.Size(229, 23);
            tbEmpEmail.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(588, 152);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(32, 15);
            label8.TabIndex = 23;
            label8.Text = "Role";
            // 
            // tbEmpRole
            // 
            tbEmpRole.Location = new System.Drawing.Point(593, 180);
            tbEmpRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbEmpRole.Name = "tbEmpRole";
            tbEmpRole.Size = new System.Drawing.Size(146, 23);
            tbEmpRole.TabIndex = 24;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = System.Drawing.Color.FromArgb(241, 239, 231);
            btnEdit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEdit.ForeColor = System.Drawing.Color.Black;
            btnEdit.Location = new System.Drawing.Point(209, 291);
            btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(128, 32);
            btnEdit.TabIndex = 25;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.Black;
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Location = new System.Drawing.Point(37, 291);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(128, 32);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.LightCoral;
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.Location = new System.Drawing.Point(378, 291);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(128, 32);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.Gold;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(547, 291);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(128, 32);
            btnSave.TabIndex = 34;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.Maroon;
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(909, 291);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(128, 32);
            btnCancel.TabIndex = 35;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // tb_username
            // 
            tb_username.Location = new System.Drawing.Point(39, 242);
            tb_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb_username.Name = "tb_username";
            tb_username.Size = new System.Drawing.Size(229, 23);
            tb_username.TabIndex = 37;
            tb_username.Visible = false;
            // 
            // lb_username
            // 
            lb_username.AutoSize = true;
            lb_username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_username.Location = new System.Drawing.Point(39, 214);
            lb_username.Name = "lb_username";
            lb_username.Size = new System.Drawing.Size(67, 15);
            lb_username.TabIndex = 36;
            lb_username.Text = "User name";
            lb_username.Visible = false;
            // 
            // tb_password
            // 
            tb_password.Location = new System.Drawing.Point(318, 242);
            tb_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb_password.Name = "tb_password";
            tb_password.Size = new System.Drawing.Size(229, 23);
            tb_password.TabIndex = 39;
            tb_password.Visible = false;
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_password.Location = new System.Drawing.Point(317, 214);
            lb_password.Name = "lb_password";
            lb_password.Size = new System.Drawing.Size(59, 15);
            lb_password.TabIndex = 38;
            lb_password.Text = "Password";
            lb_password.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.Black;
            label9.Location = new System.Drawing.Point(39, 84);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(20, 15);
            label9.TabIndex = 40;
            label9.Text = "ID";
            // 
            // tbEmpID
            // 
            tbEmpID.Location = new System.Drawing.Point(39, 110);
            tbEmpID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbEmpID.Name = "tbEmpID";
            tbEmpID.Size = new System.Drawing.Size(59, 23);
            tbEmpID.TabIndex = 41;
            // 
            // EmployeeFrame
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1048, 659);
            Controls.Add(tbEmpID);
            Controls.Add(label9);
            Controls.Add(tb_password);
            Controls.Add(lb_password);
            Controls.Add(tb_username);
            Controls.Add(lb_username);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(tbEmpRole);
            Controls.Add(label8);
            Controls.Add(tbEmpEmail);
            Controls.Add(tbEmpPhone);
            Controls.Add(tbEmpAddress);
            Controls.Add(dtpEmpDob);
            Controls.Add(tbEmpCitizenID);
            Controls.Add(tbEmpName);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "EmployeeFrame";
            Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmpName;
        private System.Windows.Forms.TextBox tbEmpCitizenID;
        private System.Windows.Forms.DateTimePicker dtpEmpDob;
        private System.Windows.Forms.RichTextBox tbEmpAddress;
        private System.Windows.Forms.TextBox tbEmpPhone;
        private System.Windows.Forms.TextBox tbEmpEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEmpRole;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbEmpID;
    }
}