using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Martinkilp
{
    public partial class Info_Form : Form
    {
        public Info_Form()
        {
            InitializeComponent();
            MK_info_rtb.ReadOnly = true;

            MK_info_rtb.Font = new Font("Arial", 12);
            MK_info_rtb.Text = 
                "Tere tulemast kivi-paber-käärid mängu!\n" +
                "1. Valige rippmenust mäng ja seejärel kinnitage nupuga 'Mängi' \n" +
                "2. Valige Inimese sektsioonist vastav valik 'Kivi-Paber-Käärid' ja vajutage 'Mängi'\n" +
                "3. Seejärel hakkab arvuti random generaator tööle 3 sekundiks.\n" +
                "4. Programm kuvab sinistes kastides iga kolme katse tulemuse alusel võidud.\n" +
                "5. Ring1...Ring3 tulemused nullitakse igal uuel mängu ringil.\n" +
                "6. Võitude sinised kastid nullitakse kui lahkute esilehele.\n" +
                "7. Kui esimesed kaks käiku on viik, siis lõpptulemuse võidab viimase käigu tulemus.";
        }

        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MK_info_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Info_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
