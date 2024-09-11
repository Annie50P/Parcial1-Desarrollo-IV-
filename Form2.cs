using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_Desarrollo_IV__Ana_Patricia_Aparicio_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btOpcion1_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de Form1
            Form1 form1 = new Form1();

            // Mostrar Form1
            form1.Show();

            // Cerrar el formulario actual (Form2)
            this.Close();
        }

        private void btVolverMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
