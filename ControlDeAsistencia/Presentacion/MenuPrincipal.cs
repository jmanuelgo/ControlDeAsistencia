using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlDeAsistencia.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            PanelDeBienvenida.Dock = DockStyle.Fill;
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            panelPadre.Controls.Clear();
            Personal Control = new Personal();
            panelPadre.Controls.Clear();
            Control.Dock = DockStyle.Fill;
            panelPadre.Controls.Add(Control);

        }
    }
}
