using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using HtmlAgilityPack;
using System.Windows.Forms;

namespace _2023SecimSonuc
{
    class Millet
    {
        string _mainUrlAA = "https://www.gazeteduvar.com.tr/secim/14-mayis-2023-genel-secim-sonuclari?", _mainUrlAnka = "https://www.gazeteduvar.com.tr/secim/14-mayis-2023-genel-secim-sonuclari?provider=anka";
        int iAA = 0, iAnka = 0;

        public string getUrlAA()
        {
            return _mainUrlAA;
        }

        public string getUrlAnka()
        {
            return _mainUrlAnka;
        }

        public void milletvekiliAA(Label lblOranMilAcilanSandik, Label lblKatilimciSayiMil, Label lblOranMilKatilimci, Label lblOranIttifakCum, Label lblOranIttifakMil, Label lblOranIttifakAta, Label lblOranIttifakEmk, Label lblOranAkp, Label lblOranMhp, Label lblOranChp, Label lblOranIyi, Label lblOranYesil, Label lblOranZafer, Label lblSayiIttifakCum, Label lblSayiIttifakAta, Label lblSayiIttifakMil, Label lblSayiIttifakEmk, Label lblOyIttifakCum, Label lblOyIttifakAta, Label lblOyIttifakMil, Label lblOyIttifakEmk, Label lblOyAkp, Label lblOyChp, Label lblOyMhp, Label lblOyIyi, Label lblOyYesil, Label lblOyZafer, Label lblSayiAkp, Label lblSayiMhp, Label lblSayiChp, Label lblSayiIyi, Label lblSayiYesil, Label lblSayiZafer)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            client.Headers.Add("user-agent", Guid.NewGuid().ToString());


            string xpathOranMilAcilanSandik = "//div[2]/div[1]/div[1]/span";
            string xpathOranMilKatilimci = "//div[2]/div[1]/div[4]/span";
            string xpathlblKatilimciSayiMil = "//div[2]/div[1]/div[5]/span";

            //Cumhur İttifakı
            string xpathOranIttifakCum = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[1]/td[3]";
            string xpathOyIttifakCum = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[1]/td[2]";
            string xpathSayiIttifakCum = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[1]/td[5]";

            //Millet İttifakı
            string xpathOranIttifakMil = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[9]/td[3]";
            string xpathOyIttifakMil = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[9]/td[2]";
            string xpathSayiIttifakMil = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[9]/td[5]";

            //Ata İttifakı
            string xpathOranIttifakAta = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[12]/td[3]";
            string xpathOyIttifakAta = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[12]/td[2]";
            string xpathSayiIttifakAta = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[12]/td[5]";

            //Emek ve Özgürlük İttifakı
            string xpathOranIttifakEmk = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[6]/td[3]";
            string xpathOyIttifakEmk = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[6]/td[2]";
            string xpathSayiIttifakEmk = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[6]/td[5]";

            //Akp
            string xpathOranAkp = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[3]/td[3]";
            string xpathOyAkp = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[3]/td[2]";
            string xpathSayiAkp = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[3]/td[5]";
            //Mhp
            string xpathOranMhp = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[5]/td[3]";
            string xpathOyMhp = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[5]/td[2]";
            string xpathSayiMhp = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[5]/td[5]";
            //Chp
            string xpathOranChp = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[10]/td[3]";
            string xpathOyChp = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[10]/td[2]";
            string xpathSayiChp = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[10]/td[5]";
            //İyi
            string xpathOranIyi = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[11]/td[3]";
            string xpathOyIyi = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[11]/td[2]";
            string xpathSayiIyi = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[11]/td[5]";
            //YeşiL
            string xpathOranYesil = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[7]/td[3]";
            string xpathOyYesil = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[7]/td[2]";
            string xpathSayiYesil = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[7]/td[5]";
            //Zefer
            string xpathOranZafer = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[14]/td[3]";
            string xpathOyZafer = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[14]/td[2]";
            string xpathSayiZafer = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[14]/td[5]";

            string downloadString = client.DownloadString(_mainUrlAA);
            doc.LoadHtml(downloadString);

            lblOranMilAcilanSandik.Text = doc.DocumentNode.SelectSingleNode(xpathOranMilAcilanSandik).InnerText;
            lblKatilimciSayiMil.Text = doc.DocumentNode.SelectSingleNode(xpathlblKatilimciSayiMil).InnerText;
            lblOranMilKatilimci.Text = doc.DocumentNode.SelectSingleNode(xpathOranMilKatilimci).InnerText;

            if (iAA == 0)
            {
                if (doc.DocumentNode.SelectSingleNode(xpathOranMilAcilanSandik).InnerText == "%100,00")
                {
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    MessageBox.Show("Sandıklar %100 açıldı", "Milletvekili [Anadolu Ajans]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    iAA = 1;
                }
            }

            //İttifak

            //Cumhur İttifakı
            lblOranIttifakCum.Text = doc.DocumentNode.SelectSingleNode(xpathOranIttifakCum).InnerText;
            lblOyIttifakCum.Text = doc.DocumentNode.SelectSingleNode(xpathOyIttifakCum).InnerText;
            lblSayiIttifakCum.Text = doc.DocumentNode.SelectSingleNode(xpathSayiIttifakCum).InnerText;

            //Millet İttifakı
            lblOranIttifakMil.Text = doc.DocumentNode.SelectSingleNode(xpathOranIttifakMil).InnerText;
            lblOyIttifakMil.Text = doc.DocumentNode.SelectSingleNode(xpathOyIttifakMil).InnerText;
            lblSayiIttifakMil.Text = doc.DocumentNode.SelectSingleNode(xpathSayiIttifakMil).InnerText;


            //Ata İttifakı 
            lblOranIttifakAta.Text = doc.DocumentNode.SelectSingleNode(xpathOranIttifakAta).InnerText;
            lblOyIttifakAta.Text = doc.DocumentNode.SelectSingleNode(xpathOyIttifakAta).InnerText;
            lblSayiIttifakAta.Text = doc.DocumentNode.SelectSingleNode(xpathSayiIttifakAta).InnerText;


            //Emek ve Özgürlük İttifakı
            lblOranIttifakEmk.Text = doc.DocumentNode.SelectSingleNode(xpathOranIttifakEmk).InnerText;
            lblOyIttifakEmk.Text = doc.DocumentNode.SelectSingleNode(xpathOyIttifakEmk).InnerText;
            lblSayiIttifakEmk.Text = doc.DocumentNode.SelectSingleNode(xpathSayiIttifakEmk).InnerText;


            //Parti

            //Akp
            lblOranAkp.Text = doc.DocumentNode.SelectSingleNode(xpathOranAkp).InnerText;
            lblOyAkp.Text = doc.DocumentNode.SelectSingleNode(xpathOyAkp).InnerText;
            lblSayiAkp.Text = doc.DocumentNode.SelectSingleNode(xpathSayiAkp).InnerText;

            //Mhp
            lblOranMhp.Text = doc.DocumentNode.SelectSingleNode(xpathOranMhp).InnerText;
            lblOyMhp.Text = doc.DocumentNode.SelectSingleNode(xpathOyMhp).InnerText;
            lblSayiMhp.Text = doc.DocumentNode.SelectSingleNode(xpathSayiMhp).InnerText;

            //Chp
            lblOranChp.Text = doc.DocumentNode.SelectSingleNode(xpathOranChp).InnerText;
            lblOyChp.Text = doc.DocumentNode.SelectSingleNode(xpathOyChp).InnerText;
            lblSayiChp.Text = doc.DocumentNode.SelectSingleNode(xpathSayiChp).InnerText;

            //İyi
            lblOranIyi.Text = doc.DocumentNode.SelectSingleNode(xpathOranIyi).InnerText;
            lblOyIyi.Text = doc.DocumentNode.SelectSingleNode(xpathOyIyi).InnerText;
            lblSayiIyi.Text = doc.DocumentNode.SelectSingleNode(xpathSayiIyi).InnerText;

            //Yeşil
            lblOranYesil.Text = doc.DocumentNode.SelectSingleNode(xpathOranYesil).InnerText;
            lblOyYesil.Text = doc.DocumentNode.SelectSingleNode(xpathOyYesil).InnerText;
            lblSayiYesil.Text = doc.DocumentNode.SelectSingleNode(xpathSayiYesil).InnerText;

            //Zafer
            lblOranZafer.Text = doc.DocumentNode.SelectSingleNode(xpathOranZafer).InnerText;
            lblOyZafer.Text = doc.DocumentNode.SelectSingleNode(xpathOyZafer).InnerText;
            lblSayiZafer.Text = doc.DocumentNode.SelectSingleNode(xpathSayiZafer).InnerText;
        }

        public void milletvekiliAnka(Label lblOranMilAcilanSandik, Label lblKatilimciSayiMil, Label lblOranMilKatilimci, Label lblOranIttifakCum, Label lblOranIttifakMil, Label lblOranIttifakAta, Label lblOranIttifakEmk, Label lblOranAkp, Label lblOranMhp, Label lblOranChp, Label lblOranIyi, Label lblOranYesil, Label lblOranZafer, Label lblSayiIttifakCum, Label lblSayiIttifakAta, Label lblSayiIttifakMil, Label lblSayiIttifakEmk, Label lblOyIttifakCum, Label lblOyIttifakAta, Label lblOyIttifakMil, Label lblOyIttifakEmk, Label lblOyAkp, Label lblOyChp, Label lblOyMhp, Label lblOyIyi, Label lblOyYesil, Label lblOyZafer, Label lblSayiAkp, Label lblSayiMhp, Label lblSayiChp, Label lblSayiIyi, Label lblSayiYesil, Label lblSayiZafer)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            client.Headers.Add("user-agent", Guid.NewGuid().ToString());


            string xpathOranMilAcilanSandik = "//div[2]/div[1]/div[1]/span";
            string xpathOranMilKatilimci = "//div[2]/div[1]/div[4]/span";
            string xpathlblKatilimciSayiMil = "//div[2]/div[1]/div[5]/span";

            //Cumhur İttifakı
            string xpathOranIttifakCum = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[1]/td[3]";
            string xpathOyIttifakCum = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[1]/td[2]";
            string xpathSayiIttifakCum = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[1]/td[5]";

            //Millet İttifakı
            string xpathOranIttifakMil = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[9]/td[3]";
            string xpathOyIttifakMil = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[9]/td[2]";
            string xpathSayiIttifakMil = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[9]/td[5]";

            //Ata İttifakı
            string xpathOranIttifakAta = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[12]/td[3]";
            string xpathOyIttifakAta = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[12]/td[2]";
            string xpathSayiIttifakAta = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[12]/td[5]";

            //Emek ve Özgürlük İttifakı
            string xpathOranIttifakEmk = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[6]/td[3]";
            string xpathOyIttifakEmk = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[6]/td[2]";
            string xpathSayiIttifakEmk = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[6]/td[5]";

            //Akp
            string xpathOranAkp = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[3]/td[3]";
            string xpathOyAkp = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[3]/td[2]";
            string xpathSayiAkp = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[3]/td[5]";

            //Mhp
            string xpathOranMhp = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[5]/td[3]";
            string xpathOyMhp = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[5]/td[2]";
            string xpathSayiMhp = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[5]/td[5]";

            //Chp
            string xpathOranChp = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[10]/td[3]";
            string xpathOyChp = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[10]/td[2]";
            string xpathSayiChp = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[10]/td[5]";

            //İyi
            string xpathOranIyi = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[11]/td[3]";
            string xpathOyIyi = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[11]/td[2]";
            string xpathSayiIyi = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[11]/td[5]";

            //YeşiL
            string xpathOranYesil = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[7]/td[3]";
            string xpathOyYesil = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[7]/td[2]";
            string xpathSayiYesil = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[7]/td[5]";

            //Zefer
            string xpathOranZafer = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[14]/td[3]";
            string xpathOyZafer = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[14]/td[2]";
            string xpathSayiZafer = "/html/body/div[1]/div/main/div[2]/main/section[5]/div[2]/table/tbody/tr[14]/td[5]";

            string downloadString = client.DownloadString(_mainUrlAnka);
            doc.LoadHtml(downloadString);

            lblOranMilAcilanSandik.Text = doc.DocumentNode.SelectSingleNode(xpathOranMilAcilanSandik).InnerText;
            lblKatilimciSayiMil.Text = doc.DocumentNode.SelectSingleNode(xpathlblKatilimciSayiMil).InnerText;
            lblOranMilKatilimci.Text = doc.DocumentNode.SelectSingleNode(xpathOranMilKatilimci).InnerText;

            if (iAnka == 0)
            {
                if (doc.DocumentNode.SelectSingleNode(xpathOranMilAcilanSandik).InnerText == "%100,00")
                {
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    MessageBox.Show("Sandıklar %100 açıldı", "Milletvekili [Anka Ajans]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    iAnka = 1;
                }
            }

            //İttifak

            //Cumhur İttifakı
            lblOranIttifakCum.Text = doc.DocumentNode.SelectSingleNode(xpathOranIttifakCum).InnerText;
            lblOyIttifakCum.Text = doc.DocumentNode.SelectSingleNode(xpathOyIttifakCum).InnerText;
            lblSayiIttifakCum.Text = doc.DocumentNode.SelectSingleNode(xpathSayiIttifakCum).InnerText;

            //Millet İttifakı
            lblOranIttifakMil.Text = doc.DocumentNode.SelectSingleNode(xpathOranIttifakMil).InnerText;
            lblOyIttifakMil.Text = doc.DocumentNode.SelectSingleNode(xpathOyIttifakMil).InnerText;
            lblSayiIttifakMil.Text = doc.DocumentNode.SelectSingleNode(xpathSayiIttifakMil).InnerText;


            //Ata İttifakı 
            lblOranIttifakAta.Text = doc.DocumentNode.SelectSingleNode(xpathOranIttifakAta).InnerText;
            lblOyIttifakAta.Text = doc.DocumentNode.SelectSingleNode(xpathOyIttifakAta).InnerText;
            lblSayiIttifakAta.Text = doc.DocumentNode.SelectSingleNode(xpathSayiIttifakAta).InnerText;


            //Emek ve Özgürlük İttifakı
            lblOranIttifakEmk.Text = doc.DocumentNode.SelectSingleNode(xpathOranIttifakEmk).InnerText;
            lblOyIttifakEmk.Text = doc.DocumentNode.SelectSingleNode(xpathOyIttifakEmk).InnerText;
            lblSayiIttifakEmk.Text = doc.DocumentNode.SelectSingleNode(xpathSayiIttifakEmk).InnerText;


            //Parti

            //Akp
            lblOranAkp.Text = doc.DocumentNode.SelectSingleNode(xpathOranAkp).InnerText;
            lblOyAkp.Text = doc.DocumentNode.SelectSingleNode(xpathOyAkp).InnerText;
            lblSayiAkp.Text = doc.DocumentNode.SelectSingleNode(xpathSayiAkp).InnerText;

            //Mhp
            lblOranMhp.Text = doc.DocumentNode.SelectSingleNode(xpathOranMhp).InnerText;
            lblOyMhp.Text = doc.DocumentNode.SelectSingleNode(xpathOyMhp).InnerText;
            lblSayiMhp.Text = doc.DocumentNode.SelectSingleNode(xpathSayiMhp).InnerText;

            //Chp
            lblOranChp.Text = doc.DocumentNode.SelectSingleNode(xpathOranChp).InnerText;
            lblOyChp.Text = doc.DocumentNode.SelectSingleNode(xpathOyChp).InnerText;
            lblSayiChp.Text = doc.DocumentNode.SelectSingleNode(xpathSayiChp).InnerText;

            //İyi
            lblOranIyi.Text = doc.DocumentNode.SelectSingleNode(xpathOranIyi).InnerText;
            lblOyIyi.Text = doc.DocumentNode.SelectSingleNode(xpathOyIyi).InnerText;
            lblSayiIyi.Text = doc.DocumentNode.SelectSingleNode(xpathSayiIyi).InnerText;

            //Yeşil
            lblOranYesil.Text = doc.DocumentNode.SelectSingleNode(xpathOranYesil).InnerText;
            lblOyYesil.Text = doc.DocumentNode.SelectSingleNode(xpathOyYesil).InnerText;
            lblSayiYesil.Text = doc.DocumentNode.SelectSingleNode(xpathSayiYesil).InnerText;

            //Zafer
            lblOranZafer.Text = doc.DocumentNode.SelectSingleNode(xpathOranZafer).InnerText;
            lblOyZafer.Text = doc.DocumentNode.SelectSingleNode(xpathOyZafer).InnerText;
            lblSayiZafer.Text = doc.DocumentNode.SelectSingleNode(xpathSayiZafer).InnerText;
        }

    }
}
