using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlaCar
{
    public partial class frmAracKaydet : Form
    {
        public frmAracKaydet()
        {
            InitializeComponent();
        }
        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarka.SelectedItem.ToString() == "A")
            {
                cmbModel.Items.Clear();
                cmbModel.Items.Add("A");
                cmbModel.Items.Add("B");
                cmbModel.Items.Add("C");
                cmbModel.Items.Add("D");
            }
            else if (cmbMarka.SelectedItem.ToString() == "B")
            {
                cmbModel.Items.Clear();
                cmbModel.Items.Add("E");
                cmbModel.Items.Add("F");
                cmbModel.Items.Add("G");
                cmbModel.Items.Add("H");
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            BlaCar blacar = new BlaCar();
            blacar.Marka = cmbMarka.SelectedItem.ToString();
            blacar.Model = cmbModel.SelectedItem.ToString();
            blacar.AracKaydet();
        }
    }
}
