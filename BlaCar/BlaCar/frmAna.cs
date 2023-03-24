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
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }
        private void btnAracKaydet_Click(object sender, EventArgs e)
        {
            frmAracKaydet frm = new frmAracKaydet();
            frm.ShowDialog();
        }
        private void btnIlanVer_Click(object sender, EventArgs e)
        {
            frmIlanVer frm = new frmIlanVer();
            frm.ShowDialog();
        }
        private void btnYolculukGor_Click(object sender, EventArgs e)
        {
            frmYolculukGor frm = new frmYolculukGor();
            frm.ShowDialog();
        }
    }
}
