#include <iostream>
#include <string>
#include <vector>
#include <cmath>
#include "Shamir.h"
#include "DiffHell.h"
#include "ElGamal.h"
#include "Rsa.h"
using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");
    int m;
    string sKey;
        Shamir shamir;
        cout << "Введите текст для шифрования" << endl;
        getline(cin, sKey);
        cout << shamir.crypt(shamir.getp(), shamir.getk(), sKey) << " = Uncrypted text\n";

        
        DiffHell diffy;
        cout << "Введите число" << endl;
        int a;
        cin >> a;
        diffy.set_g(a);
        if (diffy.crypt() == -1)
            cout << "Ключи не сходятся!" << "\n";
        else cout << diffy.crypt() << " Ключи сошлись!\n";


        cout << "Введите любое число не более 3301" << "\n";
        cin >> m;
        ElGamal el_gamal(m);
        cout << el_gamal.fun(el_gamal.getr(), el_gamal.getp() - 1 - el_gamal.getxb()) * el_gamal.gete()%el_gamal.getp() << " Расшифрованный текст\n";


        cout << "Введите любое число" << "\n";
        cin >> m;
        Rsa rsa(m);
        cout << rsa.cryptmget() << " Зашифрованное число\n";
        rsa.euclid();
        cout << rsa.fun(rsa.cryptmget(), rsa.dget(), rsa.nget()) << " Расшифрованное число\n";

}
