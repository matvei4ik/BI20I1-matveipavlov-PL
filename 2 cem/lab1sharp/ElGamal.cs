using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1_sharp
{
    class ElGamal
    {
        private int xa;
        private int xb;
        private int k;
        private int p;
        private int g;
        private int yb;
        private int r;
        private int e;


        public ElGamal(int m)
        {
            p = 3301;
            g = new Random().Next((p - 3) + 2);
            r = fun(g, k);
            yb = fun(g, xb);
            e = fun(yb, k) * m % p;
            xa = new Random().Next((p - 3) + 1);
            xb = new Random().Next((p - 3) + 1);
            k = new Random().Next((p - 2) + 1);
        }

        public int fun(int a, int b)
        {
            int s = 1;
            for (int i = 1; i <= b; i++)
            {

                s = (s * a) % p;
            }
            return s;
        }

        public int Xa
        {
            get => xa;
            set => xa = value;
        }

        public int Xb
        {
            get => xb;
            set => xb = value;
        }

        public int K
        {
            get => k;
            set => k = value;
        }

        public int P
        {
            get => p;
            set => p = value;
        }

        public int G
        {
            get => g;
            set => g = value;
        }

        public int Yb
        {
            get => yb;
            set => yb = value;
        }

        public int R
        {
            get => r;
            set => r = value;
        }

        public int E
        {
            get => e;
            set => e = value;
        }
    }
}
