using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mixy
{
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
        }

        private void textBox_categoria_TextChanged(object sender, EventArgs e)
        {
            Options.CATEGORY = textBox_categoria.Text;
        }

        private void textBox_comentarios_TextChanged(object sender, EventArgs e)
        {
            Options.COMMENT = textBox_comentarios.Text;
        }

        private void textBox_asignacion_TextChanged(object sender, EventArgs e)
        {
            Options.VALUE_ASSIGN = textBox_asignacion.Text;
        }

        private void Opciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;
            else if (e.CloseReason == CloseReason.ApplicationExitCall)
                return;
            else
            {
                e.Cancel = true;
                this.Visible = false;
            }
        }

        private void Opciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }
    }
}
