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
    public partial class edit_bus_form : Form
    {
        public edit_bus_form()
        {
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.BusStationConnectionString))
                {
                    connection.Open();
                    main.dataGridView1.CurrentRow.Cells[0].Value = textBox1.Text.ToString();
                    main.dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text.ToString();
                    main.dataGridView1.CurrentRow.Cells[2].Value = textBox3.Text.ToString();
                    int index = main.dataGridView1.CurrentRow.Index + 1;
                    string text = "UPDATE [Bus] SET [Brand] = @brand, [Color] = @color WHERE [№ bus] = @id";
                    SqlCommand sql = new SqlCommand(text, connection);
                    sql.Parameters.Add("@brand", SqlDbType.NVarChar).Value = textBox2.Text;
                    sql.Parameters.Add("@color", SqlDbType.NVarChar).Value = textBox3.Text;
                    sql.Parameters.Add("@id", SqlDbType.Int).Value = index;
                    sql.ExecuteNonQuery();
                    connection.Close();
                    main.busTableAdapter.Update(main.busTable.Bus);
                    main.busTable.Tables[0].AcceptChanges();
                    main.dataGridView1.Refresh();
                }
            }
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void edit_bus_form_Load(object sender, EventArgs e)
        {

        }
    }
}
