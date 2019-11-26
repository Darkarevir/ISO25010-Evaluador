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
    public partial class Recuperacion : Form
    {
        mySqlConexion objConexion = new mySqlConexion();
        DataTable tblCaracteristicas = new DataTable();
        DataTable soloQuieroElValor = new DataTable();
        DataTable tblsubc = new DataTable();
        int UwU;
        public Recuperacion()
        {
            InitializeComponent();
        }

        private void Recuperacion_Load(object sender, EventArgs e)
        {
            showData();
            showDataSub();

        }
        void showData()
        {

            tblCaracteristicas = objConexion.get_caracteristicas().Tables["caracteristicas"];
            label4.Text = tblCaracteristicas.Rows[0].ItemArray[2].ToString();
            cbxCaracteristica.DataSource = tblCaracteristicas;
            cbxCaracteristica.DisplayMember = "caracteristica";
            cbxCaracteristica.ValueMember = "id_c";
        }
        void showDataSub()
        {
            tblsubc = objConexion.getSubCarta(1).Tables["sub_caracteristicas"];
            cbxSubCaracteristica.DataSource = tblsubc;
            cbxSubCaracteristica.DisplayMember = "sub_caracteristica";
            cbxSubCaracteristica.ValueMember = "id_sc";
        }

        private void CbxCaracteristica_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal giorno, Dio, Jotaro;

                UwU = Convert.ToInt32(cbxCaracteristica.SelectedValue);
                label4.Text = tblCaracteristicas.Rows[UwU - 1].ItemArray[2].ToString();
                label5.Text = tblCaracteristicas.Rows.Count.ToString();
                tblsubc = objConexion.getSubCarta(UwU).Tables["sub_caracteristicas"];
                label5.Text = tblsubc.Rows.Count.ToString();
                cbxSubCaracteristica.DataSource = tblsubc;
                cbxSubCaracteristica.DisplayMember = "sub_caracteristica";
                cbxSubCaracteristica.ValueMember = "id_sc";

                giorno = Convert.ToDecimal(label4.Text);
                Dio = Convert.ToDecimal(label5.Text);

                Jotaro = (giorno / Dio);

                label6.Text = Jotaro.ToString();

            }
            catch (Exception)
            {


            }
        }

        private void CbxSubCaracteristica_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                int idSub = Convert.ToInt32(cbxSubCaracteristica.SelectedValue);
                dgvChingueAsuMadreElAmerica.DataSource = objConexion.getOwO(idSub).Tables["hu"].DefaultView;
            }
            catch (Exception)
            {

               
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {


            try
             {

                 objConexion.deletehu(UwU);
                 foreach (DataGridViewRow row in dgvChingueAsuMadreElAmerica.Rows)
                 {

                     objConexion.insertHu(UwU,
                      row.Cells["nombre"].Value.ToString(),
                      (bool)row.Cells["cumple"].Value,
                      row.Cells["valor"].Value.ToString());

                 }
                 MessageBox.Show("HU guardadas", "Guardado");
             }
             catch (Exception)
             {
                 MessageBox.Show("Error");
             }
        }
    }
}
