using App.Models;
using App.Neo4JConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class EmployeeFrame : Form
    {
        int status = 0;
        public EmployeeFrame()
        {
            InitializeComponent();
            this.Load += EmployeeFrame_Load;
        }

        public async void EmployeeFrame_Load(object sender, EventArgs e)
        {
            init();
            await LoadData();
        }

        private async Task init()
        {
            this.dataGridView1.Columns.Clear();
            this.dataGridView1.Columns.Add("Mã nhân viên", "Mã nhân viên");
            this.dataGridView1.Columns.Add("Tên nhân viên", "Tên nhân viên");
            this.dataGridView1.Columns.Add("Ngày tháng năm sinh", "Ngày tháng năm sinh");
            this.dataGridView1.Columns.Add("Số điện thoại", "Số điện thoại");
            this.dataGridView1.Columns.Add("Email", "Email");
            this.dataGridView1.Columns.Add("Địa chỉ", "Địa chỉ");
            this.dataGridView1.Columns.Add("Căn cước công dân", "Căn cước công dân");
            this.dataGridView1.Columns.Add("Chức vụ", "Chức vụ");
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async Task LoadData()
        {
            N4jConnector connector = new N4jConnector();
            dataGridView1.Rows.Clear();
            List<Employee> l = await connector.GetListAyncEmployees();
            if (dataGridView1.Columns.Count > 0)
            {
                foreach (var e in l)
                    this.dataGridView1.Rows.Add(e.Id, e.Name, e.DoB, e.Email, e.PhoneNumber, e.Address, e.CitizenId, e.EmployeeRole);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tbEmpID.Text = row.Cells[0].Value.ToString();
                tbEmpName.Text = row.Cells["Tên nhân viên"].Value.ToString();
                tbEmpPhone.Text = row.Cells["Số điện thoại"].Value.ToString();
                tbEmpEmail.Text = row.Cells["Email"].Value.ToString();
                tbEmpAddress.Text = row.Cells["Địa chỉ"].Value.ToString();
                tbEmpCitizenID.Text = row.Cells["Căn cước công dân"].Value.ToString();
                dtpEmpDob.Text = row.Cells["Ngày tháng năm sinh"].Value.ToString();
                tbEmpRole.Text = row.Cells["Chức vụ"].Value.ToString();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (status == 1)
            {
                N4jConnector connector = new N4jConnector();
                var emp = new Employee { Id = tbEmpID.Text, Name = tbEmpName.Text, DoB = dtpEmpDob.Text, Email = tbEmpEmail.Text, PhoneNumber = tbEmpPhone.Text, Address = tbEmpAddress.Text, CitizenId = (tbEmpCitizenID.Text != "" ? tbEmpCitizenID.Text : "XXXXXXXXXXXXXXXXX"), EmployeeRole = tbEmpRole.Text, Username = tb_username.Text, Password = tb_password.Text };

                Employee result = await connector.CreateEmployee(emp);
                if (result != null)
                {
                    MessageBox.Show("Added Successfully!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Add failure!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                status = 0;
                lb_username.Visible = false;
                lb_password.Visible = false;
                tb_username.Visible = false;
                tb_password.Visible = false;
            }
            else if (status == 2)
            {
                N4jConnector connector = new N4jConnector();
                var emp = new Employee { Id = tbEmpID.Text, Name = tbEmpName.Text, DoB = dtpEmpDob.Text, Email = tbEmpEmail.Text, PhoneNumber = tbEmpPhone.Text, Address = (tbEmpAddress.Text != ""?tbEmpAddress.Text:"Không có"), CitizenId = tbEmpCitizenID.Text, EmployeeRole = tbEmpRole.Text, Username = tb_username.Text, Password = tb_password.Text };
                Employee result = await connector.UpdateEmployee(emp);
                if (result != null)
                {
                    MessageBox.Show("Updated Successfully!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Update failure!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                status = 0;
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            lb_username.Visible = true;
            lb_password.Visible = true;
            tb_username.Visible = true;
            tb_password.Visible = true;
            status = 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lb_username.Visible = false;
            lb_password.Visible = false;
            tb_username.Visible = false;
            tb_password.Visible = false;
            status = 0;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            status = 2;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            N4jConnector connector = new N4jConnector();
            var emp = new Employee { Id = tbEmpID.Text, Name = tbEmpName.Text, DoB = dtpEmpDob.Text, Email = tbEmpEmail.Text, PhoneNumber = tbEmpPhone.Text, Address = tbEmpAddress.Text, CitizenId = tbEmpCitizenID.Text, EmployeeRole = tbEmpRole.Text, Username = tb_username.Text, Password = tb_password.Text };
            await connector.DeleteEmployee(emp);
            MessageBox.Show("Deleted Successfully!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            LoadData();

        }
    }
}
