using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace maket
{
    public partial class route_add_form : Form
    {
        public route_add_form()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.route2.Tables[0].NewRow();
                int rc = main.dataGridView2.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox2.Text;
                nRow[2] = textBox3.Text;
                nRow[3] = textBox4.Text;
                nRow[4] = textBox5.Text;
                nRow[5] = textBox6.Text;
                main.route2.Tables[0].Rows.Add(nRow);
                main.routeTableAdapter.Update(main.route2.Route);
                main.route2.Tables[0].AcceptChanges();
                main.dataGridView2.Refresh();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
