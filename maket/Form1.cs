using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace maket
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            comboBox1.KeyPress += (sender, e) => e.Handled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string con = Properties.Settings.Default.ADGConnectionString;
            string cmdText = "SELECT * FROM [dbo].[Driver] Where [Experience]  between 10 and 100";
            using (SqlDataAdapter passenger = new SqlDataAdapter(cmdText, con))
            {
                DataTable ps = new DataTable();
                passenger.Fill(ps);
                dataGridView4.DataSource = ps;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bus_add_frm f2 = new bus_add_frm();
            f2.Owner = this;
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            route_add_form f3 = new route_add_form();
            f3.Owner = this;
            f3.Show();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aDGDataSet3.партнёры". При необходимости она может быть перемещена или удалена.
            this.партнёрыTableAdapter.Fill(this.aDGDataSet3.партнёры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aDGDataSet2.сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.aDGDataSet2.сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aDGDataSet1.post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.aDGDataSet1.post);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aDGDataSet.auto". При необходимости она может быть перемещена или удалена.
            this.autoTableAdapter.Fill(this.aDGDataSet.auto);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "route2.Route". При необходимости она может быть перемещена или удалена.
            this.routeTableAdapter.Fill(this.route2.Route);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "passengersTable1.Passengers". При необходимости она может быть перемещена или удалена.
            this.passengersTableAdapter.Fill(this.passengersTable1.Passengers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "passengersTable.Passengers". При необходимости она может быть перемещена или удалена.
            this.driverTableAdapter.Fill(this.driverTable.Driver);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "departureTable.Departure". При необходимости она может быть перемещена или удалена.
            this.departureTableAdapter.Fill(this.departureTable.Departure);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "busTable.Bus". При необходимости она может быть перемещена или удалена.
            this.busTableAdapter.Fill(this.busTable.Bus);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            passenger_add_form f4 = new passenger_add_form();
            f4.Owner = this;
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            driver_add_form f5 = new driver_add_form();
            f5.Owner = this;
            f5.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string filter = @"Convert(brand,'System.String') LIKE '%{0}%'"; // название поля
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox1.Text = "";
            }
            busBindingSource.Filter = string.Format(filter, comboBox1.Text);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            партнёрыBindingSource.Filter = "Age > 18";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
             партнёрыBindingSource.Filter = "Age < 18";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string con = Properties.Settings.Default.ADGConnectionString;
            string cmdText = "SELECT * FROM [dbo].[Driver] Where [Experience]  between 1 and 9";
            using (SqlDataAdapter партнёры = new SqlDataAdapter(cmdText, con))
            {
                DataTable ps = new DataTable();
                партнёры.Fill(ps);
                dataGridView4.DataSource = ps;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                        if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView2.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView4.RowCount; i++)
            {
                for (int j = 0; j < dataGridView4.ColumnCount; j++)
                    if (dataGridView4.Rows[i].Cells[j].Value != null)
                        if (dataGridView4.Rows[i].Cells[j].Value.ToString().Contains(textBox2.Text))
                        {
                            dataGridView4.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
            busTableAdapter.Update(busTable.Bus);
            busTable.Tables[0].AcceptChanges();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.Remove(row);
            }
            busTableAdapter.Update(busTable.Bus);
            busTable.Tables[0].AcceptChanges();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView3.SelectedRows)
            {
                dataGridView3.Rows.Remove(row);
            }
            passengersTableAdapter.Update(passengersTable1.Passengers);
            passengersTable1.Tables[0].AcceptChanges();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView4.SelectedRows)
            {
                dataGridView4.Rows.Remove(row);
            }
            busTableAdapter.Update(busTable.Bus);
            busTable.Tables[0].AcceptChanges();
        }

        public void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1[0, 0].Value != null)
                {
                    edit_bus_form f10 = new edit_bus_form();
                    f10.Owner = this;
                    f10.Show();
                }
            }

            catch { }
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string con = Properties.Settings.Default.BusStationConnectionString;
                if (checkBox1.Checked == true)
                {
                    string cmdText = "SELECT [RouteName], avg(Price) as midl from Route WHERE Price >= 1500 GROUP BY [RouteName]";
                    using (SqlDataAdapter route = new SqlDataAdapter(cmdText, con))
                    {
                        DataTable dt = new DataTable();
                        route.Fill(dt);
                        dataGridView2.DataSource = dt;
                    }
                }
            else
            {
                MessageBox.Show("Флажок " + checkBox1.Text + "  теперь не отмечен");
                string cmdText = "SELECT * from Route";
                using (SqlDataAdapter route = new SqlDataAdapter(cmdText, con))
                {
                    DataTable dt1 = new DataTable();
                    route.Fill(dt1);
                    dataGridView2.DataSource = dt1;
                }
            }
        }
    }    
}
