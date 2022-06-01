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
    public partial class bus_add_frm : Form
    {
        public bus_add_frm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.busTable.Tables[0].NewRow();
                nRow[0] = textBox2.Text;
                nRow[1] = textBox3.Text;
                nRow[2] = textBox4.Text;
                main.busTable.Tables[0].Rows.Add(nRow);
                main.busTableAdapter.Update(main.busTable.Bus);
                main.busTable.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
