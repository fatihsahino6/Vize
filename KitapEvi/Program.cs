using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KitapEvi
{
    class Program
    {
        static void Main(string[] args)
        {
            byte secim;
            Console.WriteLine("1 - Kitap Ekleme işlemi\n2 - Kitapevindeki kitapların listesini görüntüleme");
            secim = byte.Parse(Console.ReadLine());
            if (secim == 1)
            {
                Console.Write("Kaç kitap eklemek istersiniz : ");
                byte kitapsayisi = byte.Parse(Console.ReadLine());
                string[,] kitapbilgileri = new string[kitapsayisi,5];
                KitapBilgileri kitap = new KitapBilgileri();
                
                
                    for (int satir = 0; satir <=kitapbilgileri.GetLength(0); satir++)
                    {
                  
                        Console.WriteLine(satir + 1 + " . Kitap Bilgileri");

                        for (int sutun = 0; sutun < kitapbilgileri.GetLength(1); sutun++)
                        {
                        
                        break;
                        }
                }
            }
            else if(secim==2)
            {
                StreamReader sr = new StreamReader("D:\\KitapBilgileri.txt");
                Console.WriteLine(sr.ReadToEnd());

            }

            

            Console.ReadKey();

        }
       
    }

}
