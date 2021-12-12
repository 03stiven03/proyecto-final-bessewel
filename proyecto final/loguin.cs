using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using capa_entidades;
using capa_negocios;


namespace proyecto_final
{
    public partial class loguin : Form
    {

        E_users objeuser = new E_users();
        N_users objnuser = new N_users();
        MDI frmMDI = new MDI();

        void p_logueo()
        {
            DataTable dt = new DataTable();
            objeuser.usuario = txtusuario.Text;
            objeuser.clave = txtpassword.Text;

            dt = objnuser.N_user(objeuser);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido" + MessageBoxButtons.OK + MessageBoxIcon.Information);
                frmMDI.ShowDialog();
                loguin loguin = new loguin();
                loguin.ShowDialog();

                if (loguin.DialogResult == DialogResult.OK)
                    Application.Run(new MDI());
            }


            else
            {
                MessageBox.Show("usuario o contraseña incorrecto" + MessageBoxButtons.OK + MessageBoxIcon.Information);
            }
        }





        public loguin()
        {
            InitializeComponent();
        }

        private void loguin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loguin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p_logueo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
