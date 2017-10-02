using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            bool isControlThere = pnl_container.Controls.Count > 0;
            if (isControlThere)
            {
                pnl_container.Controls.Clear();
            }
            TwoWheeler tv = new TwoWheeler();
            tv.TopLevel = false;
            tv.FormBorderStyle = FormBorderStyle.None;
            pnl_container.Controls.Add(tv);
            tv.Visible = true;
        }
    }
}
