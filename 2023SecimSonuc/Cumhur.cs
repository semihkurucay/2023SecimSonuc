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
    public class Cumhur
    {
        string _mainUrlAA = "https://www.gazeteduvar.com.tr/secim/14-mayis-2023-genel-secim-sonuclari?", _mainUrlAnka = "https://www.gazeteduvar.com.tr/secim/14-mayis-2023-genel-secim-sonuclari?provider=anka", r = "", k = "", m = "", s = "", x = "";
        int i = 0, iAA = 0, iAnka = 0;

        public string getUrlAA()
        {
            return _mainUrlAA;
        }

        public string getUrlAnka()
        {
            return _mainUrlAnka;
        }

        public void cumhurbaskaniAA(Label lblOyRte, Label lblOyKk, Label lblOyMi, Label lblOySogan, Label lblOranRte, Label lblOranKk, Label lblOranMi, Label lblOranSogan, Label lblOranCumAcilanSandik, Label lblKatilimciSayiCum, Label lblOranCumKatilimci)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            client.Headers.Add("user-agent", Guid.NewGuid().ToString());
            string downloadString = client.DownloadString(_mainUrlAA);
            doc.LoadHtml(downloadString);

            string xpathKatilimci = "//div[1]/div[1]/div[5]/span";
            string xpathAcilmaOran = "/html/body/div[1]/div/main/div[2]/main/section[2]/div[1]/div[1]/div[3]/span";
            string xpathKatilimciOran = "//div[1]/div[1]/div[4]/span";

            //Recep Tayip Erdoğan
            string xpathRTEOran = "/html/body/div[1]/div/main/div[2]/main/section[2]/div[2]/div/div[1]/a/div[3]/div";
            string xpathRTEOy = "/html/body/div[1]/div/main/div[2]/main/section[2]/div[2]/div/div[1]/a/div[4]";

            //Kemal Kılıçdaroğlu
            string xpathKKOran = "/html/body/div[1]/div/main/div[2]/main/section[2]/div[2]/div/div[3]/a/div[3]/div";
            string xpathKKOy = "/html/body/div[1]/div/main/div[2]/main/section[2]/div[2]/div/div[3]/a/div[4]";

            //Muharrem İnce
            string xpathMIOran = "/html/body/div[1]/div/main/div[2]/main/section[2]/div[2]/div/div[2]/a/div[3]/div";
            string xpathMIOy = "/html/body/div[1]/div/main/div[2]/main/section[2]/div[2]/div/div[2]/a/div[4]";

            //Sinan Oğan
            string xpathSOOran = "/html/body/div[1]/div/main/div[2]/main/section[2]/div[2]/div/div[4]/a/div[3]/div";
            string xpathSOOy = "/html/body/div[1]/div/main/div[2]/main/section[2]/div[2]/div/div[4]/a/div[4]";


            lblKatilimciSayiCum.Text = doc.DocumentNode.SelectSingleNode(xpathKatilimci).InnerText;
            lblOranCumKatilimci.Text = doc.DocumentNode.SelectSingleNode(xpathKatilimciOran).InnerText;
            lblOranCumAcilanSandik.Text = doc.DocumentNode.SelectSingleNode(xpathAcilmaOran).InnerText;

            if(iAA == 0)
            {
                if (doc.DocumentNode.SelectSingleNode(xpathAcilmaOran).InnerText == "%100,00")
                {
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    MessageBox.Show("Sandıklar %100 açıldı", "Cumhurbaşkanlığı [Anadolu Ajans]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    iAA = 1;
                }
            }

            //Recep Tayip Erdoğan
            lblOranRte.Text = doc.DocumentNode.SelectSingleNode(xpathRTEOran).InnerText;
            x = doc.DocumentNode.SelectSingleNode(xpathRTEOy).InnerText;
            r = "";

            for (i = 0; i < x.Length - 3; i++)
            {
                r += x[i];
            }

            lblOyRte.Text = r;

            //Kemal Kılıçdaroğlu
            lblOranKk.Text = doc.DocumentNode.SelectSingleNode(xpathKKOran).InnerText;
            x = doc.DocumentNode.SelectSingleNode(xpathKKOy).InnerText;
            k = "";

            for (i = 0; i < x.Length - 3; i++)
            {
                k += x[i];
            }

            lblOyKk.Text = k;

            //Muharrem İnce
            lblOranMi.Text = doc.DocumentNode.SelectSingleNode(xpathMIOran).InnerText;
            x = doc.DocumentNode.SelectSingleNode(xpathMIOy).InnerText;
            m = "";

            for (i = 0; i < x.Length - 3; i++)
            {
                m += x[i];
            }

            lblOyMi.Text = m;

            //Sinan Oğan
            lblOranSogan.Text = doc.DocumentNode.SelectSingleNode(xpathSOOran).InnerText;
            x = doc.DocumentNode.SelectSingleNode(xpathSOOy).InnerText;
            s = "";

            for (i = 0; i < x.Length - 3; i++)
            {
                s += x[i];
            }

            lblOySogan.Text = s;
        }

        public void cumhurbaskaniAnka(Label lblOyRte, Label lblOyKk, Label lblOyMi, Label lblOySogan, Label lblOranRte, Label lblOranKk, Label lblOranMi, Label lblOranSogan, Label lblOranCumAcilanSandik, Label lblKatilimciSayiCum, Label lblOranCumKatilimci)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            client.Headers.Add("user-agent", Guid.NewGuid().ToString());
            string downloadString = client.DownloadString(_mainUrlAnka);
            doc.LoadHtml(downloadString);

            string xpathKatilimci = "//div[1]/div[1]/div[5]/span";
            string xpathAcilmaOran = "/html/body/div[1]/div/main/div[2]/main/section[2]/div[1]/div[1]/div[3]/span";
            string xpathKatilimciOran = "//div[1]/div[1]/div[4]/span";

            //Recep Tayip Erdoğan
            string xpathRTEOran = "/html/body/div[1]/div/main/div[2]/main/section[2]/div[2]/div/div[1]/a/div[3]/div";
            string xpathRTEOy = "/html/body/div[1]/div/main/div[2]/main/section[2]/div[2]/div/div[1]/a/div[4]";

            //Kemal Kılıçdaroğlu
            string xpathKKOran = "/html/body/div[1]/div/main/div[2]/main/section[2]/div[2]/div/div[3]/a/div[3]/div";
            string xpathKKOy = "/html/body/div[1]/div/main/div[2]/main/section[2]/div[2]/div/div[3]/a/div[4]";

            //Muharrem İnce
            string xpathMIOran = "/html/body/div[1]/div/main/div[2]/main/section[2]/div[2]/div/div[2]/a/div[3]/div";
            string xpathMIOy = "/html/body/div[1]/div/main/div[2]/main/section[2]/div[2]/div/div[2]/a/div[4]";

            //Sinan Oğan
            string xpathSOOran = "/html/body/div[1]/div/main/div[2]/main/section[2]/div[2]/div/div[4]/a/div[3]/div";
            string xpathSOOy = "/html/body/div[1]/div/main/div[2]/main/section[2]/div[2]/div/div[4]/a/div[4]";


            lblKatilimciSayiCum.Text = doc.DocumentNode.SelectSingleNode(xpathKatilimci).InnerText;
            lblOranCumKatilimci.Text = doc.DocumentNode.SelectSingleNode(xpathKatilimciOran).InnerText;
            lblOranCumAcilanSandik.Text = doc.DocumentNode.SelectSingleNode(xpathAcilmaOran).InnerText;

            if (iAnka == 0)
            {
                if (doc.DocumentNode.SelectSingleNode(xpathAcilmaOran).InnerText == "%100,00")
                {
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    MessageBox.Show("Sandıklar %100 açıldı", "Cumhurbaşkanlığı [Anka Ajans]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    iAnka = 1;
                }
            }

            //Recep Tayip Erdoğan
            lblOranRte.Text = doc.DocumentNode.SelectSingleNode(xpathRTEOran).InnerText;
            x = doc.DocumentNode.SelectSingleNode(xpathRTEOy).InnerText;
            r = "";

            for (i = 0; i < x.Length - 3; i++)
            {
                r += x[i];
            }

            lblOyRte.Text = r;

            //Kemal Kılıçdaroğlu
            lblOranKk.Text = doc.DocumentNode.SelectSingleNode(xpathKKOran).InnerText;
            x = doc.DocumentNode.SelectSingleNode(xpathKKOy).InnerText;
            k = "";

            for (i = 0; i < x.Length - 3; i++)
            {
                k += x[i];
            }

            lblOyKk.Text = k;

            //Muharrem İnce
            lblOranMi.Text = doc.DocumentNode.SelectSingleNode(xpathMIOran).InnerText;
            x = doc.DocumentNode.SelectSingleNode(xpathMIOy).InnerText;
            m = "";

            for (i = 0; i < x.Length - 3; i++)
            {
                m += x[i];
            }

            lblOyMi.Text = m;

            //Sinan Oğan
            lblOranSogan.Text = doc.DocumentNode.SelectSingleNode(xpathSOOran).InnerText;
            x = doc.DocumentNode.SelectSingleNode(xpathSOOy).InnerText;
            s = "";

            for (i = 0; i < x.Length - 3; i++)
            {
                s += x[i];
            }

            lblOySogan.Text = s;
        }
    }
}
