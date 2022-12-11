using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SR
{
    public class Employee
    {
        public Employee()
        {
            //ayarlar.txt'yi aç, içerisindeki ayarlar değişkeninin değerini oku
            int deger = 1;

            if (deger == 1)
                loglama = new LoglamaTxt();
            else if (deger == 2)
                loglama = new LoglamaCiviYazisi();
        }


        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }

        //YANLIŞŞŞ
        //private Loglama loglama = new Loglama();

        private ILoglama loglama = new LoglamaElastic();

        public void Create()
        {
            try
            {
                //kaydet
                string kayit = $"{Id} - {FirstName} {LastName} - {HireDate}";
                //employee.Id + " - " + employee.FirstName + " "

                int asd = Convert.ToInt32("ahmet");

                File.WriteAllText(Environment.CurrentDirectory + "\\EmployeeData.txt", kayit);

                //if(ayarlar.logtipi == 1)
                //loglama.LogYaz("Kayıt Tarihi: " + DateTime.Now + " - EmployeeId: " + Id, LogTipi.Db);
                loglama.LogYaz("Kayıt Tarihi: " + DateTime.Now + " - EmployeeId: " + Id);
                //loglama
            }
            catch(Exception ex)
            {
                //loglama.LogYaz($"Hata mesajı: {ex.Message} - Tarih: {DateTime.Now}", LogTipi.Elastic);
                loglama.LogYaz($"Hata mesajı: {ex.Message} - Tarih: {DateTime.Now}");
            }
        }

        public void Update(int id, Employee employee)
        {
            //güncelle
            //loglama
        }

        //HATA
        //public void LogYaz(string mesaj)
        //{

        //}
    }
}