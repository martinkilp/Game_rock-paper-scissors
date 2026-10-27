using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Martinkilp
{
    public partial class MK_form1 : Form
    {
        public MK_form1()
        {
            InitializeComponent();
            this.ShowIcon = false;
            MK_lbl_mäng.Text = "...";
            

        }

        private void MartinKilp_Load(object sender, EventArgs e)
        {

        }

        private void MK_label1_Click(object sender, EventArgs e)
        {

        }

        private void MK_form1_button1_Click(object sender, EventArgs e)
        {
            if (MK_CB.SelectedItem != null && MK_CB.SelectedItem.ToString() == "Kivi-Paber-Käärid")
            {
                this.Hide();
                MK_Form2 form2 = new MK_Form2();
                form2.ShowDialog();
                this.Show();
            }
            else if (MK_CB.SelectedItem != null && MK_CB.SelectedItem.ToString() == "Memoriin-värvid")
            {
                this.Hide();
                MK_Form3 form3 = new MK_Form3();
                form3.ShowDialog();
                this.Show();
            }
            else
            {
                MK_lbl_mäng.Text = "...valige mäng!!";
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MK_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            MK_lbl_mäng.Text = MK_CB.Text;

            if (MK_CB.SelectedIndex == -1)
            {
                MK_form1_mängi.Enabled = false;
            }
            else
            {
                MK_form1_mängi.Enabled = true;
                MK_form1_mängi.BackColor = Color.Green;
            }
        }

        private void MK_lbl_info_Click(object sender, EventArgs e)
        {
            Info_Form form4 = new Info_Form();
            form4.ShowDialog();
        }

        private void MK_form1_välju_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
