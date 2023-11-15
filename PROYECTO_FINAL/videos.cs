using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class videos : MaterialSkin.Controls.MaterialForm
    {

        public videos()
        {
            InitializeComponent();
        }

        private void videos_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            try
            {
                string rutaVideo = "C:\\Users\\santi\\source\\repos\\PROYECTO_FINAL\\PROYECTO_FINAL\\Derivadas.mp4";

                // Carga y reproduce el video
                axWindowsMediaPlayer1.URL = rutaVideo;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar y reproducir el video: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {
            try
            {
                string rutaVideo = "C:\\Users\\santi\\source\\repos\\PROYECTO_FINAL\\PROYECTO_FINAL\\Algebra.mp4";

                // Carga y reproduce el video
                axWindowsMediaPlayer2.URL = rutaVideo;
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar y reproducir el video: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void axWindowsMediaPlayer3_Enter(object sender, EventArgs e)
        {
            try
            {
                string rutaVideo = "C:\\Users\\santi\\source\\repos\\PROYECTO_FINAL\\PROYECTO_FINAL\\Programacion.mp4";

                // Carga y reproduce el video
                axWindowsMediaPlayer3.URL = rutaVideo;
                axWindowsMediaPlayer3.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar y reproducir el video: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
