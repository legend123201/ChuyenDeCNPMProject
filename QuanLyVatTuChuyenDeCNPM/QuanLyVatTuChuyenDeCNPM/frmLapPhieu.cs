using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatTuChuyenDeCNPM
{
    public partial class frmLapPhieu : Form
    {
        public frmLapPhieu()
        {
            InitializeComponent();
        }

        private void phatSinhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_PhatSinh.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmLapPhieu_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.PhatSinh' table. You can move, or remove it, as needed.
            this.phatSinhTableAdapter.Connection.ConnectionString = "Data Source=DESKTOP-D1DKRD0\\LUU;Initial Catalog=QLVT_CHUYENDE;User ID=sa;Password=123456";
            this.phatSinhTableAdapter.Fill(this.dS.PhatSinh);

        }
    }
}
