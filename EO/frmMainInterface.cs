using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EO
{
    public partial class frmMainInterface : Form
    {
        String nameDB = "";
        public frmMainInterface(String nameDB)
        {
            InitializeComponent();
            this.nameDB = nameDB;
        }

        private void frmMainInterface_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisterCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer formCustomer = new frmCustomer();
            formCustomer.ShowDialog();
        }

        private void btnRancanganCustomer_Click(object sender, EventArgs e)
        {
            frmRancangCustomer formRancangCustomer = new frmRancangCustomer();
            formRancangCustomer.ShowDialog();
        }

        private void btnPerjanjianKerja_Click(object sender, EventArgs e)
        {
            frmPerjanjianKerja formPerjanjianKerja = new frmPerjanjianKerja();
            formPerjanjianKerja.ShowDialog();
        }

        private void btnPembayaranDP_Click(object sender, EventArgs e)
        {
            frmBuktiDP formBuktiDP = new frmBuktiDP();
            formBuktiDP.ShowDialog();
        }

        private void btnJatuhTempo_Click(object sender, EventArgs e)
        {
            frmJatuhTempo formJatuhTempo = new frmJatuhTempo();
            formJatuhTempo.ShowDialog();
        }

        private void btnBuktiPelunasan_Click(object sender, EventArgs e)
        {
            frmPelunasan formPelunasan = new frmPelunasan();
            formPelunasan.ShowDialog();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            frmLaporan formLaporan = new frmLaporan();
            formLaporan.ShowDialog();
        }

        private void btnSuratPerizinan_Click(object sender, EventArgs e)
        {
            frmSuratPerizinan formSuratPerizinan = new frmSuratPerizinan(nameDB);
            formSuratPerizinan.ShowDialog();
        }
    }
}
