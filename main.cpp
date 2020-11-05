#include <iostream>

#include "Framer.h"
#include "Moto.h"

using namespace std;

int main()
{
    Moto *m1  = new Moto();
    Moto *m2  = new Moto();


    Framer *framer = new Framer();

    framer->SetSpeed(m1,1);

    m1->Dump(); //debug for view

    framer->SetSpeed(m2,5);
    m1->Dump();
    framer->SetSpeed(m2,6);


    cout << m2->speed << endl;
    framer->SetSpeed(m1,8);
    cout << m1->speed << endl;
    return 0;
}
