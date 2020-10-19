using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textIspis.Text = cmbIzbor.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Poruka", "Naslov");
        }

        private void textIspis_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            textIspis.Clear();
            cmbIzbor.SelectedIndex = 0;
        }
    }
}
