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
    }
}
