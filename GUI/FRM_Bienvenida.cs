using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FRM_Bienvenida : Form
    {
        public FRM_Bienvenida()
        {
            InitializeComponent();
            lblInfoSistema.Text = "Proyecto TIENDA ALAS - Prototipo SAP Negocio";
            lblFecha.Text = string.Format("FECHA: {0}", System.DateTime.Now.ToString("dd/MM/yyyy"));
            lblVersion.Text = "Versión: 1.0";
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            FRM_Principal frm_Principal = new FRM_Principal();
            frm_Principal.ShowDialog();
            this.Close();
        }
    }
}
