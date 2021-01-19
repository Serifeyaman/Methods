using System;
using System.Linq;
namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Console.WriteLine("**********");

            Add2(2,5);   //int tipinde iki değer parametre alacak
            Console.WriteLine("**********");

            //overloading, aynı isimli metotların parametre sayısına göre kullanılması
            int result2 = Multiply(5, 8);
            Console.WriteLine(result2);
            int result3 = Multiply(5, 8, 10);
            Console.WriteLine(result3);
            Console.WriteLine("**********");

            //params keyword, çok parametreli metotlarda kullanım kolaylığı sağlar
            Console.WriteLine(Add4(1,2,3,4,5));
        
        }
        static void Add()   //static olmazsa yukarıda çağıramıyoruz
        {
            Console.WriteLine("Added!!!");
            // void ile oluşturulan metotlarda bir değer döndrmeye ihtiyaç olmaz
        }

        static int Add2(int number1, int number2)  //parametre ile metot kullanımı
        {
            int toplam = number1 + number2;
            Console.WriteLine(toplam);
            return toplam;
            //int ile tanımlanmıs bir metot için return ile dönecek değişken int tipinde olmalıdır
        }

        /*static int Add2(int number1, int number2=30)  //parametre ile metot kullanımı
        {
            // default değer ile metot tanımı, number2 değerine metot çağırılınca değer verilmezse default olarak verilen 30 değerini kullanır
            //Add2(4);  Add2(4,5); olarak kullanılabilir
        }*/

        // metot overloading
        static int Multiply(int say1, int say2)
        {
            return say1 * say2;
        }
        static int Multiply(int say1, int say2,  int say3)
        {
            return say1 * say2 * say3;
        }

        //params keywords
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }

    }
}
