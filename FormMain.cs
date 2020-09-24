using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fingerprint
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnregistrasi_Click(object sender, EventArgs e)
        {
            FormRegistrasi fr = new FormRegistrasi();
            fr.ShowDialog();
        }

        private void btnverify_Click(object sender, EventArgs e)
        {
            FormVerify fv = new FormVerify();
            fv.ShowDialog();
        }
    }
}
