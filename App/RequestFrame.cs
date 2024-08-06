using App.Models;
using App.Neo4JConnector;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class RequestFrame : Form
    {
        bool isFirstLoad = true;
        int status = 0;
        public RequestFrame()
        {
            InitializeComponent();
            this.Load += RequestFrame_Load;
        }

        private async void RequestFrame_Load(object sender, EventArgs e)
        {
            await init();
            await LoadData();
            await LoadEmployeeCombobox();
            LoadProcessStatusCombobox();
        }

        private async Task init()
        {
            this.dataGridView1.Columns.Clear();
            this.dataGridView1.Columns.Add("Mã yêu cầu", "Mã yêu cầu");
            this.dataGridView1.Columns.Add("Mã khách hàng", "Mã khách hàng");
            this.dataGridView1.Columns.Add("Tên khách hàng", "Tên khách hàng");
            this.dataGridView1.Columns.Add("Mã nhân viên", "Mã nhân viên");
            this.dataGridView1.Columns.Add("Nhân viên tiếp nhận", "Nhân viên tiếp nhận");
            this.dataGridView1.Columns.Add("Mã dịch vụ", "Mã dịch vụ");
            this.dataGridView1.Columns.Add("Tên dịch vụ", "Tên dịch vụ");
            this.dataGridView1.Columns.Add("Tiêu đề", "Tiêu đề");
            this.dataGridView1.Columns.Add("Chi tiết", "Chi tiết");
            this.dataGridView1.Columns.Add("Ngày nhận", "Ngày nhận");
            this.dataGridView1.Columns.Add("Trạng thái", "Trạng thái");
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async Task LoadData()
        {
            N4jConnector connector = new N4jConnector();
            dataGridView1.Rows.Clear();
            List<Request> l = await connector.GetListAyncRequests();
            if (dataGridView1.Columns.Count > 0)
            {
                foreach (var rq in l)
                    this.dataGridView1.Rows.Add(rq.Id, rq.CusId, rq.CusName, rq.EmpId, rq.EmpName, rq.ServiceId, rq.ServiceName, rq.Title, rq.Detail, rq.DateCreated, rq.ProcessStatus);
            }
        }

        private void LoadProcessStatusCombobox()
        {
            cbProcessStatus.Items.Clear();
            cbProcessStatus.Items.Add("Đang chờ");
            cbProcessStatus.Items.Add("Đang xử lý");
            cbProcessStatus.Items.Add("Đã hoàn thành");
        }
        private async Task LoadEmployeeCombobox()
        {
            N4jConnector connector = new N4jConnector();
            List<Employee> l2 = await connector.GetListAyncEmployees();
            l2.Add(new Employee { Id = null, Name = "All" });
            l2.Reverse();
            List<Employee> l = await connector.GetListAyncEmployees();
            if (cbEmp.Items.Count >= 0)
            {
                cbSort.DataSource = l2;
                cbEmp.DataSource = l;
                cbEmp.DisplayMember = "DisplayValue";
                cbEmp.ValueMember = "Id";
                cbSort.DisplayMember = "DisplayValue";
                cbSort.ValueMember = "Id";
            }
            isFirstLoad = false;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                requestIdTextBox.Text = row.Cells[0].Value?.ToString() ?? "null";

                tbCusID.Text = row.Cells[1].Value.ToString();
                tbCusName.Text = row.Cells[2].Value.ToString();
                tbSerID.Text = row.Cells[5].Value.ToString();
                tbSerName.Text = row.Cells[6].Value.ToString();
                tbTitle.Text = row.Cells[7].Value.ToString();
                tbDetail.Text = row.Cells[8].Value.ToString();
                dtpDateCreated.Text = row.Cells[9].Value.ToString();
                cbEmp.SelectedValue = row.Cells["Mã nhân viên"].Value.ToString();
                cbProcessStatus.Text = row.Cells[10].Value.ToString();


            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (cbEmp.SelectedItem != null)
            {
                if (status == 2)
                {
                    String id = cbEmp.SelectedValue.ToString();
                    N4jConnector connector = new N4jConnector();
                    var emp = new Employee { Id = id };
                    var rq = new Request { Id = requestIdTextBox.Text, Detail = tbDetail.Text, Title = tbTitle.Text, DateCreated = dtpDateCreated.Text, ProcessStatus = cbProcessStatus.Text };
                    await connector.UpdateRequest(rq, emp);
                    MessageBox.Show("Updated Successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                status = 0;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            status = 2;
        }

        private async void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFirstLoad)
            {
                dataGridView1.Rows.Clear();

                N4jConnector connector = new N4jConnector();
                List<Request> l = new List<Request>();
                if (cbSort.SelectedValue != null)
                {
                    String id = cbSort.SelectedValue.ToString();
                    var emp = new Employee { Id = id };
                    l = await connector.GetListAyncRequests(emp);
                }
                else
                {
                    l = await connector.GetListAyncRequests();
                }
                if (dataGridView1.Columns.Count > 0)
                {
                    foreach (var rq in l)
                        this.dataGridView1.Rows.Add(rq.Id, rq.CusId, rq.CusName, rq.EmpId, rq.EmpName, rq.ServiceId, rq.ServiceName, rq.Title, rq.Detail, rq.DateCreated, rq.ProcessStatus);
                }
            }
        }
    }
}
