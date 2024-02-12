using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_gui_mensaje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMostral_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eso no es de Ganster");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Resultado;

            Resultado = MessageBox.Show("Seguro que deseas salir","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
          
            if (Resultado == DialogResult.Yes)

            { Close(); }
        }
    }
}
