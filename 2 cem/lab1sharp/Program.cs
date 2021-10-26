using System;

namespace LB1_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            string sKey;
            Shamir shamir = new Shamir();
            Console.WriteLine("Введите текст для шифрования");
            sKey = Console.ReadLine();
            Console.WriteLine(shamir.crypt(shamir.P, sKey) + " = Uncrypted text");


            DiffHell diffy = new DiffHell();
            Console.WriteLine("Введите число");
            diffy.G = Convert.ToInt32(Console.ReadLine());
            if (diffy.crypt() == -1)
                Console.WriteLine("Ключи не сходятся!");
            else Console.WriteLine(diffy.crypt() + " Ключи сошлись!");


            Console.WriteLine("Введите любое число не более 3301");
            m=Convert.ToInt32(Console.ReadLine());
            ElGamal el_gamal = new ElGamal(m);
            Console.WriteLine(el_gamal.fun(el_gamal.R, el_gamal.P - 1 - el_gamal.Xb) * el_gamal.E % el_gamal.P + " Расшифрованный текст");


            Console.WriteLine("Введите любое число");
            m = Convert.ToInt32(Console.ReadLine());
            RSA rsa = new RSA(m);
            Console.WriteLine(rsa.Cryptm + " Зашифрованное число");
            rsa.euclid();
            Console.WriteLine(rsa.fun(Convert.ToInt32(rsa.Cryptm), rsa.D, rsa.N) + " Расшифрованное число");
        }
    }
}
