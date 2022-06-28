using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depreciacionactivos
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            double costo, Residual;
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

       operaciones op = new operaciones();

        private void button1_Click(object sender, EventArgs e)

        {

           
            if (!op.Numeric(txtcosto.Text) && !op.Numeric(Residual.Text))
            {


            }
            else

            {
                int division = op.division(Convert.ToInt32(txtcosto.Text), Convert.ToInt32(Residual.Text));
                texttotal.Text = Convert.ToString(division);
                data.Rows.Add(txtcosto.Text, Residual.Text, texttotal.Text);
            }
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {

            txtcosto.Text = data.CurrentRow.Cells[0].Value.ToString();
            Residual.Text = data.CurrentRow.Cells[1].Value.ToString();
            texttotal.Text = data.CurrentRow.Cells[2].Value.ToString();
            



        }

        private void texttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            txtcosto.Clear();
            Residual.Clear();
            texttotal.Clear();
        }
    }
}
