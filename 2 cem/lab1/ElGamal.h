#pragma once
class ElGamal {
private:
    int xa;
    int xb;
    int k;
    int p;
    int g;
    int ya;
    int yb;
    int r;
    int e;
public:
    ElGamal(int m);
    int fun(int a, int b);
    int getxb() const;
    int getp() const;
    int getr() const;
    int gete() const;
};
