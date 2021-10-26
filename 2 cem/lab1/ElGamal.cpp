#include "ElGamal.h"
#include <iostream>

using namespace std;

ElGamal::ElGamal(int m)
{
    p = 3301;
    g = rand() % (p - 3) + 2;
    ya = fun(g, xa);
    yb = fun(g, xb);
    r = fun(g, k);
    e = fun(yb, k) * m % p;
    xa = rand() % (p - 3) + 1;
    xb = rand() % (p - 3) + 1;
    k = rand() % (p - 2) + 1;
}

int ElGamal::fun(int a, int b)
{
    int s = 1;
    for (int i = 1; i <= b; i++)
    {

        s = (s * a) % p;
    }
    return s;
}
int ElGamal::getxb() const
{
    return xb;
}

int ElGamal::getp() const
{
    return p;
}

int ElGamal::getr() const
{
    return r;
}

int ElGamal::gete() const
{
    return e;
}
