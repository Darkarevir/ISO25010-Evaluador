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
        DataTable tblsubc = new DataTable();
        int UwU;

        public Evaluador()
        {
            InitializeComponent();
        }

        private void Evaluador_Load(object sender, EventArgs e)
        {
            showData();
            showDataSub();

        }

        void showData()
        {
            tblCaracteristicas = objConexion.get_caracteristicas().Tables["caracteristicas"];
            cbxCaracteristica.DataSource = tblCaracteristicas;
            cbxCaracteristica.DisplayMember = "caracteristica";
            cbxCaracteristica.ValueMember = "id_c";
        }
        void showDataSub() {
            tblsubc = objConexion.getSubCarta(1).Tables["sub_caracteristicas"];
            cbxSubCaracteristica.DataSource = tblsubc;
            cbxSubCaracteristica.DisplayMember = "sub_caracteristica";
            cbxSubCaracteristica.ValueMember = "id_sc";
        }

        private void CbxSubCaracteristica_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbxCaracteristica_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UwU = Convert.ToInt32( cbxCaracteristica.SelectedValue);
                tblsubc = objConexion.getSubCarta(UwU).Tables["sub_caracteristicas"];
                cbxSubCaracteristica.DataSource = tblsubc;
                cbxSubCaracteristica.DisplayMember = "sub_caracteristica";
                cbxSubCaracteristica.ValueMember = "id_sc";

            }
            catch (Exception)
            {

                
            }
        }
    }
}
