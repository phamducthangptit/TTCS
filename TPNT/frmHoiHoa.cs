using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPNT
{
    public partial class frmHoiHoa : Form
    {
        public frmHoiHoa()
        {
            InitializeComponent();
        }

        private void hoiHoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsHoiHoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsTPNT);

        }

        private void frmHoiHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tPNTDataSet.HoiHoa' table. You can move, or remove it, as needed.
            dsTPNT.EnforceConstraints = false;
            this.HoiHoaTableAdapter.Fill(this.dsTPNT.HoiHoa);

        }
    }
}
