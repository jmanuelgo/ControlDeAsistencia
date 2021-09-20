using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlDeAsistencia.Logica
{
    public class Bases
    {
        public static void DisenioDtv(ref DataGridView Listado) {
            Listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Listado.BackgroundColor = Color.Red;
        }  
    }
}
