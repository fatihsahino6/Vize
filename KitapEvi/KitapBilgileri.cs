using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KitapEvi
{
    class KitapBilgileri
    {
        public  string kitapadi;
        string yazar;
        DateTime btarihi;
        string kturu;
        public void SetKitapAdi(string kitapadi)
        {
            this.kitapadi = kitapadi;
        }
        public string GetKitapAdi()
        {
            return this.kitapadi;
        }
        public void SetYazar(string yazar)
        {
            this.yazar = yazar;
        }
        public string GetYazar()
        {
            return this.yazar;
        }
        public void SetBTarihi(DateTime btarihi)
        {
            this.btarihi = btarihi;
        }
        public DateTime GetBTarihi()
        {
            return this.btarihi;
        }
        public void SetKTuru(string kturu)
        {
            this.kturu = kturu;
        }
        public string GetKTuru()
        {
            return this.kturu;
        }
        public void Dongu()
        {
            FileStream fs = new FileStream(@"D:\KitapBilgileri.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("--------------------\n");
            Console.Write("Kitap Adı : ");
            sw.Write("Kitap Adı : " + (kitapbilgileri[satir, sutun] = Console.ReadLine()) + "\n");
            Console.Write("Kitabın Yazarı : ");
            sw.Write("Kitap Yazarı : " + (kitapbilgileri[satir, sutun] = Console.ReadLine()) + "\n");
            Console.Write("Kitabın Basım Tarihi : ");
            sw.Write("Kitap Basım Tarihi : " + (kitapbilgileri[satir, sutun] = Console.ReadLine()) + "\n");
            Console.Write("Kitabın Türü : ");
            sw.Write("Kitabın Türü : " + (kitapbilgileri[satir, sutun] = Console.ReadLine()) + "\n");
            fs.Flush();
            sw.Close();
            fs.Close();
        }
        public string KitapBilgileriGetir() => $"Kitap Adi:{this.kitapadi}\nKitap Yazarı:{this.yazar}\nBasım Tarihi:{this.btarihi}\nKitap Türü:{this.kturu}";

       }

       

    }

