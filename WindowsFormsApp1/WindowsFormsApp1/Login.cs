using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        static string usuarioActual;

        private void btm_log_Click(object sender, EventArgs e)
        {
            if(Consulta.obtenerDepartemento(txt_usario.Text, txt_contra.Text)==0)
            {
                MessageBox.Show("Datos Erroneos");
            }
            else
            {
                usuarioActual = txt_usario.Text;
                Principal ventana = new Principal();
                ventana.Show();
                this.Hide();
            }
        }
    }
}