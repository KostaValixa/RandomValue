using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomValues
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rdn = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            int tableSize = Convert.ToInt32(sizeBox.Text);

            int minValue = tableSize*10;
            int maxValue = 0;

            tableView.ColumnCount = tableSize;
            tableView.RowCount = tableSize;

            for (int i=0; i < tableView.Columns.Count; i++)
            {
                for (int g=0; g<tableView.Rows.Count; g++)
                {
                    int value = rdn.Next(0,tableSize*10);
                    tableView[i, g].Value = value.ToString();
                    if (value > maxValue){ maxValue = value; };
                    if (value < minValue){ minValue = value; };
                };
            };
            difMinMax.Text = Convert.ToString(maxValue - minValue);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sizeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sizeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
