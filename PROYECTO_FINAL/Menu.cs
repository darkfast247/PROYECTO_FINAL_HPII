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
    public partial class Menu : MaterialSkin.Controls.MaterialForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_videos_Click(object sender, EventArgs e)
        {
            videos vid = new videos();
            vid.Show();
            this.Hide();
        }

        private void btn_subir_vid_Click(object sender, EventArgs e)
        {
            SubirVideos sub_vid = new SubirVideos();
            sub_vid.Show();
            this.Hide();
        }

        private void btn_subir_ejer_Click(object sender, EventArgs e)
        {
            SubirEjercicios sub_ejer = new SubirEjercicios();
            sub_ejer.Show();
            this.Hide();
        }

        private void btn_ejer_Click(object sender, EventArgs e)
        {
            ejercicios ejer = new ejercicios();
            ejer.Show();
            this.Hide();
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            Modificar mod = new Modificar();
            mod.Show();
            this.Hide();

        }
    }
}
