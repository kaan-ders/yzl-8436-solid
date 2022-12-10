using Solid.SR;

namespace Solid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 -> personel kaydet
            //2 -> personel güncelle
            //3 -> yapılan işlemleri logla

            Employee personel = new Employee
            {
                FirstName = "Ayşe",
                LastName = "Balcı",
                HireDate = DateTime.Now,
                Id = 13
            };

            personel.Create();
        }
    }
}