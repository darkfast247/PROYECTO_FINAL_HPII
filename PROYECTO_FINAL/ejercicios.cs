using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class ejercicios : MaterialSkin.Controls.MaterialForm
    {
        public ejercicios()
        {
            InitializeComponent();
            
        }

        private void ejercicios_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void axAcroPDF1_Enter_1(object sender, EventArgs e)
        {
            try
            {
                string rutaPDF = "C:\\Users\\santi\\source\\repos\\PROYECTO_FINAL\\PROYECTO_FINAL\\Ejercicios de derivadas.pdf";

                // Carga el archivo PDF en el control AxAcroPDF
                axAcroPDF1.src = rutaPDF;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void axAcroPDF2_Enter(object sender, EventArgs e)
        {
            try
            {
                string rutaPDF = "C:\\Users\\santi\\source\\repos\\PROYECTO_FINAL\\PROYECTO_FINAL\\Algebra lineal.pdf";

                // Carga el archivo PDF en el control AxAcroPDF
                axAcroPDF2.src = rutaPDF;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void axAcroPDF3_Enter(object sender, EventArgs e)
        {
            try
            {
                string rutaPDF = "C:\\Users\\santi\\source\\repos\\PROYECTO_FINAL\\PROYECTO_FINAL\\Ejercicios de programacion.pdf";

                // Carga el archivo PDF en el control AxAcroPDF
                axAcroPDF3.src = rutaPDF;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
