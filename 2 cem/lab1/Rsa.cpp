#include "Rsa.h"
#include <iostream>
#include <vector>

using namespace std;

    Rsa::Rsa(int m)
    {
        p = 17;
        q = 11;
        n = p * q;
        eil = (p - 1) * (q - 1);
        e = 13;
        d = euclid();
        cryptm = fun(m, e, n);
    }
    long long Rsa::fun(int a, int b, int n)
    {
        long long s = 1;
        for (int i = 1; i <= b; i++)
        {

            s = (s * a) % n;
        }
        return s;
    }
    int Rsa::euclid() {
        int q;
        vector<int> X = { eil,1,0 }, Y = { e,0,1 }, T = { 0,0,0 };
        while (Y[0] != 0) {
            q = X[0] / Y[0];
            T = { X[0] % Y[0], X[1] - q * Y[1], X[2] - q * Y[2] };
            X = Y; Y = T;
        }
        while (X[1] < 0)
        {
            X[1] += eil;
        }
        return X[1];
    }

    int Rsa::cryptmget() const
    {
        return cryptm;
    }
    int Rsa::nget() const
    {
        return n;
    }
    int Rsa::dget() const
    {
        return d;
    }
