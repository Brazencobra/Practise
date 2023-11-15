using Class_practise.Models;

namespace Class_practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*User yaradirsiz:
            Username(6,25),Password(8,25), IsSignedIn, Products propertyleri olur

            Product yaradirsiz:
            Name, Price propertyleri olur

            CheckPassword methodu olur geriye bool qaytarir kicik boyuk herfleri,ve reqem olub olmadigini yoxluyur.
            Login methodu olur istifadeci deyerleri ekrandan daxil edir.
            Add methodu olur eger istifadeci login olubsa Products arrayina productu elave edir.
            Eger olmuyubsa bir basha Login methodunu cagirir*/

            User user = new User("Brazen","Yenisifre1");
            Product product = new Product("Limon",0.50f);
            Product product1 = new Product("Dondurma",1f);
            Product product2 = new Product("Cips",3f);
            Product product3 = new Product("Cola",1.2f);
            //user.Login("Brazen","Yenisifre1");
            user.Add(product);
        }
       
    }
}