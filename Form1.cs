using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelciusToFahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCelsius_Click(object sender, EventArgs e)
        {
           

            if(String.IsNullOrEmpty(tbCelsius.Text))
            {
                MessageBox.Show("Foute invoer");
            }
            else
            {
                double Farhenheit = double.Parse(tbCelsius.Text) * 9 / 5 + 32;
                tbFahrenheit.Text = Farhenheit.ToString();
            }
        }

        private void btFahrenheit_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(tbFahrenheit.Text))
            {
                MessageBox.Show("Foute invoer");
            }
            else
            {
                double Celsius = (double.Parse(tbFahrenheit.Text) - 32) * 5 / 9;
                tbCelsius.Text = Celsius.ToString();
            }
        }
    }
}
