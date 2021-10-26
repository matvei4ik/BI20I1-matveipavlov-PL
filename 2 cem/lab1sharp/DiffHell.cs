using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1_sharp
{
    class DiffHell
    {
        private int a;
        private int b;
        private int p;
        private int g;
        private int alice;
        private int bob;
        private int k;
        public DiffHell()
        {
            p = 127;
            a = new Random().Next(p - 1);
            b = new Random().Next(p-1);
            g = 10;
        }

        int fun(int a, int b)
        {
            int s = 1;
            for (int i = 1; i <= b; i++)
            {

                s = (s * a) % p;
            }
            return s;
        }

        public int crypt()
        {
            alice = fun(g, a);
            bob = fun(g, b);
            k = fun(bob, a);
            bob = fun(alice, b);
            if (k == bob)
            {
                return k;
            }
            else return -1;
        }
        public int A
        {
            get => a;
            set => a = value;
        }

        public int B
        {
            get => b;
            set => b = value;
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

        public int Alice
        {
            get => alice;
            set => alice = value;
        }

        public int Bob
        {
            get => bob;
            set => bob = value;
        }

        public int K
        {
            get => k;
            set => k = value;
        }
    }
}
