using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023SecimSonuc
{
    public partial class Form1 : Form
    {
        Cumhur cum = new Cumhur();
        Millet mil = new Millet();
        
        int i = 0, c = 1, t = 1;
        

        public Form1()
        {
            InitializeComponent();
        }

        void clearLbl()
        {
            lblKatilimciSayiCum.Text = null;
            lblKatilimciSayiMil.Text = null;
            lblOranAkp.Text = null;
            lblOranChp.Text = null;
            lblOranCumAcilanSandik.Text = null;
            lblOranCumKatilimci.Text = null;
            lblOranIttifakAta.Text = null;
            lblOranIttifakCum.Text = null;
            lblOranIttifakEmk.Text = null;
            lblOranIttifakMil.Text = null;
            lblOranIyi.Text = null;
            lblOranKk.Text = null;
            lblOranMhp.Text = null;
            lblOranMi.Text = null;
            lblOranMilAcilanSandik.Text = null;
            lblOranMilKatilimci.Text = null;
            lblOranRte.Text = null;
            lblOranSogan.Text = null;
            lblOranYesil.Text = null;
            lblOyKk.Text = null;
            lblOyMi.Text = null;
            lblOyRte.Text = null;
            lblOySogan.Text = null;
        }

        void selectted(Button btn1, Button btn2)
        {
            btn1.Font = new Font(this.Font, FontStyle.Bold);
            btn2.Font = new Font(this.Font, FontStyle.Regular);
        }

        void resetAnka()
        {
            clearLbl();
            cum.cumhurbaskaniAnka(lblOyRte, lblOyKk, lblOyMi, lblOySogan, lblOranRte, lblOranKk, lblOranMi, lblOranSogan, lblOranCumAcilanSandik, lblKatilimciSayiCum, lblOranCumKatilimci);
            mil.milletvekiliAnka(lblOranMilAcilanSandik, lblKatilimciSayiMil, lblOranMilKatilimci, lblOranIttifakCum, lblOranIttifakMil, lblOranIttifakAta, lblOranIttifakEmk, lblOranAkp, lblOranMhp, lblOranChp, lblOranIyi, lblOranYesil, lblOranZafer, lblSayiIttifakCum, lblSayiIttifakAta, lblSayiIttifakMil, lblSayiIttifakEmk, lblOyIttifakCum, lblOyIttifakAta, lblOyIttifakMil, lblOyIttifakEmk, lblOyAkp, lblOyChp, lblOyMhp, lblOyIyi, lblOyYesil, lblOyZafer, lblSayiAkp, lblSayiMhp, lblSayiChp, lblSayiIyi, lblSayiYesil, lblSayiZafer);
            this.Text = "[Anka Ajans] 14 Mayıs 2023 Cumhurbaşkanlığı ve 28. Dönem Milletvekili Genel Seçimleri " + DateTime.Now.ToString();
        }

        void resetAA()
        {
            clearLbl();
            cum.cumhurbaskaniAA(lblOyRte, lblOyKk, lblOyMi, lblOySogan, lblOranRte, lblOranKk, lblOranMi, lblOranSogan, lblOranCumAcilanSandik, lblKatilimciSayiCum, lblOranCumKatilimci);
            mil.milletvekiliAA(lblOranMilAcilanSandik, lblKatilimciSayiMil, lblOranMilKatilimci, lblOranIttifakCum, lblOranIttifakMil, lblOranIttifakAta, lblOranIttifakEmk, lblOranAkp, lblOranMhp, lblOranChp, lblOranIyi, lblOranYesil, lblOranZafer, lblSayiIttifakCum, lblSayiIttifakAta, lblSayiIttifakMil, lblSayiIttifakEmk, lblOyIttifakCum, lblOyIttifakAta, lblOyIttifakMil, lblOyIttifakEmk, lblOyAkp, lblOyChp, lblOyMhp, lblOyIyi, lblOyYesil, lblOyZafer, lblSayiAkp, lblSayiMhp, lblSayiChp, lblSayiIyi, lblSayiYesil, lblSayiZafer);
            this.Text = "[Anadolu Ajans] 14 Mayıs 2023 Cumhurbaşkanlığı ve 28. Dönem Milletvekili Genel Seçimleri " + DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selectted(btnAnka, btnAA);

            if (c == 1)
            {
                resetAnka();
                c = 0;
                t = 1;
            }
            else
            {
                resetAA();
                c = 1;
                t = 0;
            }
            timer1.Start();
        }

        private void btnAnka_Click(object sender, EventArgs e)
        {
            
            selectted(btnAnka, btnAA);

            if (c == 1)
            {
                resetAnka();
                c = 0;
                t = 1;
            }
        }

        private void btnAA_Click(object sender, EventArgs e)
        {
            selectted(btnAA, btnAnka);

            if (c == 0)
            {
                resetAA();
                c = 1;
                t = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            
            if (i == 10)
            {
                
                i = 0;

                if (t == 1)
                {
                    resetAnka();
                }
                else
                {
                    resetAA();
                }
            }
        }

        private void btnWeb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(cum.getUrlAA());
            System.Diagnostics.Process.Start(cum.getUrlAnka());
        }
    }
}
