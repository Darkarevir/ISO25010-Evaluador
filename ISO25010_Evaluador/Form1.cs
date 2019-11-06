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
        DataTable soloQuieroElValor = new DataTable();
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
            label4.Text = tblCaracteristicas.Rows[1].ItemArray[2].ToString();
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
                label4.Text = tblCaracteristicas.Rows[UwU].ItemArray[2].ToString();
                tblsubc = objConexion.getSubCarta(UwU).Tables["sub_caracteristicas"];
                cbxSubCaracteristica.DataSource = tblsubc;
                cbxSubCaracteristica.DisplayMember = "sub_caracteristica";
                cbxSubCaracteristica.ValueMember = "id_sc";

            }
            catch (Exception)
            {

                
            }
        }

        void addRow() {
            //soloQuieroElValor = objConexion.get_caracteristicas().Tables["caracteristicas"];

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgvHu);
            fila.Cells[0].Value = cbxSubCaracteristica.Text;
            fila.Cells[1].Value = txtHU.Text;

            dgvHu.Rows.Add(fila);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            addRow();
        }
    }
}
