#pragma once
#include <string>

class Shamir
{
private:
    int cb;
    int ca;
    int da;
    int db;
    int p;
    int k;
public:
    Shamir();
    void GenerateA(int p);
    void GenerateB(int p);
    int fun(int p, int a, int b);
    std::string crypt(int p, int k, std::string sKey);
    int getp() const;
    int getk() const;
};
