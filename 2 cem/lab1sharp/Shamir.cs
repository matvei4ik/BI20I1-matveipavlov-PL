using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1_sharp
{
    class Shamir
    {
        private int cb;
        private int ca;
        private int da;
        private int db;
        private int p;

        public Shamir()
        {
            cb = 1;
            ca = 1;
            da = 1;
            db = 1;
            p = 127;
            GenerateA(p);
            GenerateB(p);
        }
        void GenerateA(int p)
        {
            da = 1;
            ca = new Random().Next(p);

            while (da < p)
            {
                if ((da * ca) % (p - 1) == 1)
                    return;
                da = da + 1;
            }
            if (da == p)
                GenerateA(p);
        }
        void GenerateB(int p)
        {
            db = 1;
            cb = new Random().Next(p);

            while (db < p)
            {
                if ((db * cb) % (p - 1) == 1)
                    return;
                db = db + 1;
            }
            if (db == p)
                GenerateB(p);
        }

        int fun(int p, int a, int b)
        {
            int s = 1;
            for (int i = 1; i <= b; i++)
            {

                s = (s * a) % p;
            }
            return s;
        }
        public string crypt(int p, string sKey)
        {
            int k;

            string res1="", result="";
            for (int i = 0; i < sKey.Length; i++)
            {
                k = (int)sKey[i];
                // Step 1
                k = fun(p, k, ca);

                // Step 2
                k = fun(p, k, cb);
                res1 += k;
                // Step 3
                k = fun(p, k, da);
                // Step 4
                k = fun(p, k, db);
                result += (Char)k;

            }
            Console.WriteLine( res1 + " = Crypted text");
            return result;
        }
        public int Cb
        {
            get => cb;
            set => cb = value;
        }

        public int Ca
        {
            get => ca;
            set => ca = value;
        }

        public int Da
        {
            get => da;
            set => da = value;
        }

        public int Db
        {
            get => db;
            set => db = value;
        }

        public int P
        {
            get => p;
            set => p = value;
        }
    }
}
