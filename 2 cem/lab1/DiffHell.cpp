#include "DiffHell.h"
#include <iostream>

using namespace std;

DiffHell::DiffHell()
{
    a = rand() % (p - 2) + 1;
    b = rand() % (p - 2) + 1;
    p = 127;
    g = 10;
}

int DiffHell::fun(int a, int b)
{
    int s = 1;
    for (int i = 1; i <= b; i++)
    {

        s = (s * a) % p;
    }
    return s;
}

int DiffHell::crypt()
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

void DiffHell::set_g(int g)
{
    this->g = g;
}
