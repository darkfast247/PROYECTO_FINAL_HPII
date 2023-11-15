using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROYECTO_FINAL
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
       

        public Form1(string correoinstitucional, string contrasena)
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
       
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection SqlCon;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        string conexion = "Data Source=DESKTOP-AI45HF9\\SQLEXPRESS;Initial Catalog=PASCUAL_MENTOR;Integrated Security=True";
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM INICIO WHERE CORREO=@CORREO AND CONTRASEÑA=@CONTRASEÑA", cn);
                cmd.Parameters.AddWithValue("@CORREO", textBox1.Text);
                cmd.Parameters.AddWithValue("@CONTRASEÑA", textBox2.Text);
                cmd.CommandType = CommandType.Text;

                cn.Open();

                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    if (reader.HasRows)
                    {
                        Menu menu = new Menu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y contraseña incorrextos. Intenta de nuevo");
                    }
                }
                else
                {
                    MessageBox.Show("Los campos estan vacios. Intenta de nuevo");
                }


            }
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
