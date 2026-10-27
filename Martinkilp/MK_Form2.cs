using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Martinkilp
{
    public partial class MK_Form2 : Form
    {

        Random rnd = new Random();
        int aktiivne = 0;

        int loendur = 0;
        int maxVilkumised = 20;

        PictureBox[] valikud;

        Timer timer1 = new Timer();


        string inimeseValik = "";
        string arvutiValik = "";
        string[] inimeseMalu = new string[5];
        string[] arvutiMalu = new string[5];
        int voor = 0;

        // Käesoleva mängu käikude võidud
        int inimeseVooruVoidud = 0;
        int arvutiVooruVoidud = 0;

        // Kogu mängu tulemused
        int inimeseMangud = 0;
        int viigid = 0;
        int arvutiMangud = 0;



        public MK_Form2()
        {
            InitializeComponent();
            this.ShowIcon = false;


            valikud = new PictureBox[]
            {
                MK_F2_piltarvutikivi,
                MK_F2_piltarvutipaber,
                MK_F2_piltarvutikäärid
            };


            timer1.Interval = 150; // 0.2 sekundit
            timer1.Tick += timer1_Tick;

            MK_F2_Bmängi.Enabled = false;


        }



        private void MK_Form2_Load(object sender, EventArgs e)
        {

        }

        private void MK_form2_btnsulge_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MK_form2_btnsulge2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MK_form2_kivi2_Click(object sender, EventArgs e)
        {

        }

        private void MK_F2_piltarvutikivi_Click(object sender, EventArgs e)
        {

        }

        private void MK_F2_piltarvutipaber_Click(object sender, EventArgs e)
        {

        }

        private void MK_F2_piltarvutikäärid_Click(object sender, EventArgs e)
        {

        }

        private void MK_F2_Bkivi_Click(object sender, EventArgs e)
        {
            MK_F2_piltinimene.Image = MK_F2_piltarvutikivi.Image;
            MK_F2_Bmängi.BackColor = Color.ForestGreen;
            MK_F2_valitud.Text = "Kivi";

            inimeseValik = "Kivi";
            MK_F2_Bmängi.Enabled = true;

        }

        private void MK_F2_Bpaber_Click(object sender, EventArgs e)
        {
            MK_F2_piltinimene.Image = MK_F2_piltarvutipaber.Image;
            MK_F2_Bmängi.BackColor = Color.ForestGreen;
            MK_F2_valitud.Text = "Paber";

            inimeseValik = "Paber";
            MK_F2_Bmängi.Enabled = true;
        }

        private void MK_F2_Bkäärid_Click(object sender, EventArgs e)
        {
            MK_F2_piltinimene.Image = MK_F2_piltarvutikäärid.Image;
            MK_F2_Bmängi.BackColor = Color.ForestGreen;
            MK_F2_valitud.Text = "Käärid";

            inimeseValik = "Käärid";
            MK_F2_Bmängi.Enabled = true;
        }

        private void MK_F2_Bmängi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inimeseValik))
            return;

            loendur = 0;
            aktiivne = 0;

            if (voor == 0)
            {
                inimeseVooruVoidud = 0;
                arvutiVooruVoidud = 0;
                NulliRingiSildid();
                UuendaTulemusteKaste();
            }

            timer1.Start();
        }


        private int SelgitaVooruTulemus()
        {
            // 1 = inimene võidab
            // 0 = viik
            // -1 = arvuti võidab

            if (inimeseValik == arvutiValik)
                return 0;

            if ((inimeseValik == "Kivi" && arvutiValik == "Käärid") ||
                (inimeseValik == "Paber" && arvutiValik == "Kivi") ||
                (inimeseValik == "Käärid" && arvutiValik == "Paber"))
            {
                return 1;
            }

            return -1;
        }



        private void UuendaTulemusteKaste()
        {
            // Valged kastid: käesoleva mängu võidud
            MK_F2_inimenevõit1.Text = inimeseVooruVoidud.ToString();
            MK_F2_arvutivõit1.Text = arvutiVooruVoidud.ToString();

            // Sinised kastid tulemused
            MK_form2_nrinimene.Text = inimeseMangud.ToString();
            MK_form2_viiknr.Text = viigid.ToString();
            MK_form2_nrarvuti.Text = arvutiMangud.ToString();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox pb in valikud)
            {
                pb.BorderStyle = BorderStyle.None;
            }

            valikud[aktiivne].BorderStyle = BorderStyle.FixedSingle;

            MK_F2_piltarvuti.Image = valikud[aktiivne].Image;

            aktiivne++;


            if (aktiivne >= 3)
                aktiivne = 0;

            loendur++;

            if (loendur >= maxVilkumised)
            {
                timer1.Stop();

                int arvutiValikNumber = rnd.Next(3);

                foreach (PictureBox pb in valikud)
                {
                    pb.BorderStyle = BorderStyle.None;
                }

                valikud[arvutiValikNumber].BorderStyle = BorderStyle.Fixed3D;

                MK_F2_piltarvuti.Image = valikud[arvutiValikNumber].Image;

                if (arvutiValikNumber == 0)
                    arvutiValik = "Kivi";
                else if (arvutiValikNumber == 1)
                    arvutiValik = "Paber";
                else
                    arvutiValik = "Käärid";

                // Salvesta käigu valikud
                inimeseMalu[voor] = inimeseValik;
                arvutiMalu[voor] = arvutiValik;

                // Näita mõlema valikut
                MK_F2_VõitisKes.Text =
                    inimeseValik + " - " + arvutiValik;

                // Selgita välja käigu tulemus
                int tulemus = SelgitaVooruTulemus();
                
                
                voor++;
                KuvaRingiTulemus(voor, tulemus);



                if (tulemus == 1)
                {
                    inimeseVooruVoidud++;
                    MK_F2_VõitisKes.Text = "Inimene võitis käigu!";
                }
                else if (tulemus == -1)
                {
                    arvutiVooruVoidud++;
                    MK_F2_VõitisKes.Text = "Arvuti võitis käigu!";
                }
                else
                {
                    MK_F2_VõitisKes.Text = "Viik!";
                }
                         
                
                
                UuendaTulemusteKaste();

                if (voor == 3)
                {
                    if (inimeseVooruVoidud > arvutiVooruVoidud)
                    {
                        inimeseMangud++;
                        MK_F2_VõitisKes.Text = "INIMENE VÕITIS MÄNGU!";
                    }
                    else if (arvutiVooruVoidud > inimeseVooruVoidud)
                    {
                        arvutiMangud++;
                        MK_F2_VõitisKes.Text = "ARVUTI VÕITIS MÄNGU!";
                    }
                    else
                    {
                        viigid++;
                        MK_F2_VõitisKes.Text = "MÄNG JÄI VIIKI!";
                    }

                    UuendaTulemusteKaste();

                    inimeseVooruVoidud = 0;
                    arvutiVooruVoidud = 0;


                    UuendaTulemusteKaste();


                    voor = 0;
                }


            }

        }

        private void KuvaRingiTulemus(int ring, int tulemus)
        {
            Label[] ringid =
            {
                MK_F2_ring1,
                MK_F2_ring2,
                MK_F2_ring3
            };

            if (ring < 1 || ring > 3)
                return;

            if (tulemus == 1)
                ringid[ring - 1].Text = "Inimene";
            else if (tulemus == -1)
                ringid[ring - 1].Text = "Arvuti";
            else
                ringid[ring - 1].Text = "Viik";
        }

        private void NulliRingiSildid()
        {
            MK_F2_ring1.Text = "Ring 1";
            MK_F2_ring2.Text = "Ring 2";
            MK_F2_ring3.Text = "Ring 3";
        }

    }
}

