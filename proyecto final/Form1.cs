using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(4);
            label1.Text = progressBar1.Value.ToString() + "%";

            if (progressBar1.Value==progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                loguin logi = new loguin();
                logi.ShowDialog();
            }
        }
    }
}
