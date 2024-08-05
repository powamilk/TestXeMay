using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XeMay.PL
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadFormData()
        {
            dgv_xemay.Columns.Clear();
            dgv_xemay.Columns.Add("clm1", "STT");
            dgv_xemay.Columns.Add("clm2", "Ma");
            dgv_xemay.Columns.Add("clm3", "Ten");
            dgv_xemay.Columns.Add("clm4", "Gia");
            dgv_xemay.Columns.Add("clm5", "Hang");
        }

        private void LoadGridData()
        {
            dgv_xemay.Rows.Clear();
            _
        }
    }
}
