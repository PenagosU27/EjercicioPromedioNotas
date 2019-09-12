using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPromedioNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            float n1 = float.Parse(txtn1.Text);
            float n2 = float.Parse(txtn2.Text);
            float n3 = float.Parse(txtn3.Text);
            float n4 = float.Parse(txtn4.Text);
            float n5 = float.Parse(txtn5.Text);
            float promedio = n1 + n2 + n3 + n4 + n5;
            float total = promedio / 5;

            if (total > 3.5)
            {
                MessageBox.Show(" Has superado la materia");
            }
            else
            {
                MessageBox.Show("No superaste la competencia de la materia");
            }
            
        }
    }
}
 