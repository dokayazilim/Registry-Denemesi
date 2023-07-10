using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registry_DegerEkleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //yeni bir değer oluşturma...>>>>>
            //Registry.CurrentUser.SetValue("Anahtar","Merhaba Registry");
            //oluşturulan değeri okuma...>>>>>>>>

            //string GelenDeger = Registry.CurrentUser.GetValue("Anahtar").ToString();
            //Console.WriteLine($"Registry içerisindeki değer {GelenDeger}");

            ////registry i silme işlemi...>>>>>

            //Registry.CurrentUser.DeleteValue("Anahtar");

            //Console.ReadLine();


            //registry yeni klasör ekleme...>>>>

            //Registry.CurrentUser.CreateSubKey("XYZProjesi");

            //RegistryKey XYZProjesi = Registry.CurrentUser.OpenSubKey("XYZProjesi",true);
            //XYZProjesi.SetValue("HardDiskSeriNumarasi","15841545");

            //string SeriNumarasi = XYZProjesi.GetValue("HardDiskSeriNumarasi").ToString();
            //Console.WriteLine(SeriNumarasi);
            //Console.ReadLine();

            //subkey değer listeleme....>>>>>>>>>>>>>>>>>>>>>><

            RegistryKey XYZProjesi = Registry.CurrentUser.OpenSubKey("XYZProjesi",false);
            string[] KEYS = XYZProjesi.GetValueNames();
            for (int i = 0; i < KEYS.Length; i++) 
            {
                Console.WriteLine($"Anahtar : {KEYS[i]} Value : {XYZProjesi.GetValue(KEYS[i])}"); 
            }
            Console.ReadLine();
        }
    }
}
