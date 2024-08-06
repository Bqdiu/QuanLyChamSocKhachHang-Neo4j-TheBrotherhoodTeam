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
    public partial class ServiceFrame : Form
    {
        public ServiceFrame()
        {
            InitializeComponent();
            this.Load += ServiceFrame_Load;
        }

        private async void ServiceFrame_Load(object sender, EventArgs e)
        {
            await init();
            await LoadData();
        }

        private async Task init()
        {
            this.dataGridView1.Columns.Clear();
            this.dataGridView1.Columns.Add("Mã dịch vụ", "Mã dịch vụ");
            this.dataGridView1.Columns.Add("Tên dịch vụ", "Tên dịch vụ");
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async Task LoadData()
        {
            N4jConnector connector = new N4jConnector();
            List<Service> l = await connector.GetListAyncServices();
            if (dataGridView1.Columns.Count > 0)
            {
                foreach (var s in l)
                    this.dataGridView1.Rows.Add(s.Id, s.Name);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tbSerID.Text = row.Cells["Mã dịch vụ"].Value.ToString();
                tbSerName.Text = row.Cells["Tên dịch vụ"].Value.ToString();
            }
        }


    }
}
