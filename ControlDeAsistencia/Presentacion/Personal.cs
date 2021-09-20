using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControlDeAsistencia.Logica;
using ControlDeAsistencia.Datos;

namespace ControlDeAsistencia.Presentacion
{
    public partial class Personal : UserControl
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelCargos.Visible = false;
            panelPaginado.Visible = false;
            PanelRegistro.Visible = true;
            PanelRegistro.Dock = DockStyle.Fill;
            btnGuardarPersonal.Visible = false;
            btnGuadarCambiosPersonal.Visible = false;
            Limpiar();
            BuscarCargo();

        }
        private void Limpiar() {
            txtNombres.Clear();
            txtIdentificacion.Clear();
            txtCargo.Clear();
            txtSueldoPorHora.Clear();
        }

        private void btnGuardarPersonal_Click(object sender, EventArgs e)
        {

        }
        private void Insertar_Personal() {
            Lpersonal parametros = new Lpersonal();
            Dpersonal funcion = new Dpersonal();
            parametros.Nombres = txtNombres.Text;
            parametros.Identificacion = txtIdentificacion.Text;
            parametros.Pais = comboBoxPais.Text;
            
        }
        private void InsertarCargo() {
            Lcargos parametros = new Lcargos();
            Dcargos funcion = new Dcargos();
            parametros.Cargo = txtCargoG.Text;
            parametros.SueldoPorHora =Convert.ToDouble(txtSueldoHoraG.Text);
            if (funcion.insertar_Cargo(parametros) == true){
                BuscarCargo();
            }
        }
        private void BuscarCargo() {
            DataTable dt = new DataTable();
            Dcargos funcion = new Dcargos();
            funcion.buscarCargos(ref dt, txtCargo.Text);
            datalistadoCargo.DataSource = dt;
            Bases.DisenioDtv(ref datalistadoCargo);

        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {
            BuscarCargo();
        }
    }
}
