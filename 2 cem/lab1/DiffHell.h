#pragma once

class DiffHell
{
private:
    int a;
    int b;
    int p;
    int g;
    int alice;
    int bob;
    int k;
public:
    DiffHell();
    int fun(int a, int b);
    int crypt();
    void set_g(int g);
};
