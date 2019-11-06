using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISO25010_Evaluador
{
    public partial class Evaluador : Form
    {
        mySqlConexion objConexion = new mySqlConexion();
        DataTable tblCaracteristicas = new DataTable();

        public Evaluador()
        {
            InitializeComponent();
        }

        private void Evaluador_Load(object sender, EventArgs e)
        {
            showData();
        }

        void showData()
        {
            tblCaracteristicas = objConexion.get_caracteristicas().Tables["caracteristicas"];
            cbxCaracteristica.DataSource = tblCaracteristicas;
            cbxCaracteristica.DisplayMember = "caracteristica";
            cbxCaracteristica.ValueMember = "id_c";
        }
    }
}
