using App.Models;
using App.Neo4JConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class EmployeeFrame : Form
    {
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
            N4jConnector connector = new N4jConnector();
            var emp = new Employee { Id = "E07", Name = "huy outfit", DoB = "2001-08-15", Email = "mail@mail.com", PhoneNumber = "03699999999", Address = "Trại giam chứ đâu", CitizenId = "XXXXXXXXXXXXX", EmployeeRole = "Giám đốc", Username = "huy", Password = "123"};
            var result = await connector.CreateEmployee(emp);
            if (result != null)
            {
                MessageBox.Show("Thêm thành công!");
            } else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }
    }
}
