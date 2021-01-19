using System;

namespace ref_out_keywords
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add3() metodunda ref kullanımı;
            int say1 = 50;                          // ref keywords için burada değer vermek zorunludur
            int say2 = 30;
            int result = Add3(ref say1, say2);      // say1 ref olduğu için, say1 değeri fonksiyon içinde değiştirilirse say1 buradada aynı değeri alır.
            Console.WriteLine(result);
            Console.WriteLine(say1);                // 50 olan değer 99 olacak 

            //Add4() metotunda out kullanımı
            int number1;                            //ilk değer ataması yapılmasa da çalışır
            int number2 = 5;
            int result2 = Add4(out number1, number2);
            Console.WriteLine(result2);

        }

        //ref kullanımı için oluşturulmuş metot
        static int Add3(ref int say1, int say2)
        {
            say1 = 99;                               // değer değişmezse say1 yukarıda verilen değerde kalır
            return say1 + say2;
        }

        //out kullanımı için oluşturulmuş metot
        static int Add4(out int number1, int number2)
        {
            number1 = 5;                             //out da bu işlem zorunludur yoksa hata verir
            return number1 + number2;
        }

    }
}
