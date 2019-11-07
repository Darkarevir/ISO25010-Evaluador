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
            label4.Text = tblCaracteristicas.Rows[0].ItemArray[2].ToString();
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
                decimal giorno, Dio, Jotaro;
                
                UwU = Convert.ToInt32(cbxCaracteristica.SelectedValue);                
                label4.Text = tblCaracteristicas.Rows[UwU-1].ItemArray[2].ToString();
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

        void updatePorcentaje() {
            decimal stickyFingers;
            foreach (DataGridViewRow row in dgvHu.Rows) {
               // stickyFingers += Convert.ToDecimal();
            }
        }

        void addRow() {
            //soloQuieroElValor = objConexion.get_caracteristicas().Tables["caracteristicas"];
            

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgvHu);
            fila.Cells[0].Value = cbxSubCaracteristica.Text;
            fila.Cells[1].Value = txtHU.Text;
            fila.Cells[2].Value = cbCumple.Checked;

            dgvHu.Rows.Add(fila);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            addRow();

            int ewe = dgvHu.Rows.Count;

            decimal FinTheChat;

            FinTheChat = Convert.ToDecimal(label6.Text) / ewe;

            valorHU.Text = String.Format("{0:0.0000}", FinTheChat);

            label7.Text = "Cada HU vale: "+ String.Format("{0:0.0000}", FinTheChat);
            int suma = Convert.ToInt32(dgvHu.Rows.Count);

            decimal fOwO = 0.00M;
            foreach (DataGridViewRow row in dgvHu.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells[2] as DataGridViewCheckBoxCell;
                if (cell.Value != null)
                {
                    
                        fOwO = FinTheChat + suma;
                    
                    
                }
                label8.Text = fOwO.ToString();
            }
            
        }

        private void TbnOk_Click(object sender, EventArgs e)
        {
            try
            {

                objConexion.deletehu(UwU);
                foreach (DataGridViewRow row in dgvHu.Rows)
                {
                  
                    objConexion.insertHu(UwU,
                       row.Cells["huName"].Value.ToString(),
                      (bool)row.Cells["cumple"].Value,
                      valorHU.Text.ToString());
                    
                }
                MessageBox.Show("HU guardadas", "Guardado");
            }
            catch (Exception)
            {

            }
        }
    }
}
