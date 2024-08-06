using App.Models;
using App.Neo4JConnector;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class HomeFrame : Form
    {
        public HomeFrame()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private async void Home_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            init();
            await LoadData();
        }

        private async Task init()
        {
            this.dataGridView1.Columns.Clear();
            this.dataGridView1.Columns.Add("Mã khách hàng", "Mã khách hàng");
            this.dataGridView1.Columns.Add("Tên khách hàng", "Tên khách hàng");
            this.dataGridView1.Columns.Add("Ngày tháng năm sinh", "Ngày tháng năm sinh");
            this.dataGridView1.Columns.Add("Số điện thoại", "Số điện thoại");
            this.dataGridView1.Columns.Add("Email", "Email");
            this.dataGridView1.Columns.Add("Địa chỉ", "Địa chỉ");
            this.dataGridView1.Columns.Add("Căn cước công dân", "Căn cước công dân");
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async Task LoadData()
        {
            N4jConnector connector = new N4jConnector();
            List<Customer> l = await connector.GetListAyncCustomers();
            if (dataGridView1.Columns.Count > 0)
            {
                foreach (var c in l)
                    this.dataGridView1.Rows.Add(c.Id, c.Name, c.DoB, c.Email, c.PhoneNumber, c.Address, c.CitizenId);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tbCusName.Text = row.Cells["Tên khách hàng"].Value.ToString();
                tbCusPhone.Text = row.Cells["Số điện thoại"].Value.ToString();
                tbCusEmail.Text = row.Cells["Email"].Value.ToString();
                tbCusAddress.Text = row.Cells["Địa chỉ"].Value.ToString();
                tbCusCitizenID.Text = row.Cells["Căn cước công dân"].Value.ToString();
                dtpCusDob.Text = row.Cells["Ngày tháng năm sinh"].Value.ToString();
            }
        }
    }
}
