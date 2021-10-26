#pragma once
#include <vector>

class Rsa
{
private:
    int d;
    int p;
    int q;
    int n;
    int eil;
    int e;
    int cryptm;
public:
    Rsa(int m);
    long long fun(int a, int b, int n);
    int euclid();
    int cryptmget() const;
    int nget() const;
    int dget() const;
};
