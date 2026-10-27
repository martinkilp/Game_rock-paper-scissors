using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martinkilp
{
    public partial class MK_Form3 : Form
    {
        public MK_Form3()
        {
            InitializeComponent();
            this.ShowIcon = false;
        }

        private void MK_Form3_Load(object sender, EventArgs e)
        {

        }

        private void MK_form3_btnsulge_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
