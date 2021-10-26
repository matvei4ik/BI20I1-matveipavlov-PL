using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1_sharp
{
    class RSA
    {
        private int d;
        private int p;
        private int q;
        private int n;
        private int eil;
        private int e;
        private long cryptm;
        public RSA(int m)
        {
            p = 17;
            q = 11;
            n = p * q;
            eil = (p - 1) * (q - 1);
            e = 13;
            cryptm = fun(m, e, n);
            d = euclid();
        }
        public long fun(int a, int b, int n)
        {
            long s = 1;
            for (int i = 1; i <= b; i++)
            {

                s = (s * a) % n;
            }
            return s;
        }
        public int euclid()
        {
            List<int> X = new List<int>();
            List<int> Y = new List<int>();
            List<int> T = new List<int>();
            int q;
            X.Add(e); X.Add(1); X.Add(0);
            Y.Add(eil); Y.Add(0); Y.Add(1);
            T.Add(0); T.Add(0); T.Add(0);
            while (Y[0] != 0)
            {
                q = X[0] / Y[0];
                T[0]= (X[0] % Y[0]);
                T[1]= (X[1] - q * Y[1]);
                T[2] = (X[2] - q * Y[2]);
                X = new List<int>(Y); Y = new List<int>(T);
            }
            return X[1];
        }

        public int D
        {
            get => d;
            set => d = value;
        }

        public int P
        {
            get => p;
            set => p = value;
        }

        public int Q
        {
            get => q;
            set => q = value;
        }

        public int N
        {
            get => n;
            set => n = value;
        }

        public int Eil
        {
            get => eil;
            set => eil = value;
        }

        public int E
        {
            get => e;
            set => e = value;
        }

        public long Cryptm
        {
            get => cryptm;
            set => cryptm = value;
        }
    }
}
