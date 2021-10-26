#include "Shamir.h"
#include <iostream>

using namespace std;

Shamir::Shamir()
    {
        GenerateA(p);
        GenerateB(p);
        cb = 1;
        ca = 1;
        da = 1;
        db = 1;
        p = 127;
        k = 0;
    }
    void Shamir::GenerateA(int p)
    {
        da = 1;
        ca = rand() % p;

        while (da < p)
        {
            if ((da * ca) % (p - 1) == 1)
                return;
            da = da + 1;
        }
        if (da == p)
            GenerateA(p);
    }
    void Shamir::GenerateB(int p)
    {
        db = 1;
        cb = rand() % p;

        while (db < p)
        {
            if ((db * cb) % (p - 1) == 1)
                return;
            db = db + 1;
        }
        if (db == p)
            GenerateB(p);
    }

    int Shamir::fun(int p, int a, int b)
    {
        int s = 1;
        for (int i = 1; i <= b; i++)
        {

            s = (s * a) % p;
        }
        return s;
    }
    string Shamir::crypt(int p, int k, string sKey)
    {


        string res1, result;
        for (int i = 0; i < sKey.length(); i++)
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
            result += k;

        }
        cout << res1 << " = Crypted text\n";
        return result;
    }

    int Shamir::getp() const
    {
        return p;
    }

    int Shamir::getk() const
    {
        return k;
    }
