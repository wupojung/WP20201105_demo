#include "Moto.h"

#include <iostream>
using namespace std;

Moto::Moto()
{
    //ctor
    speed = 0;
}

Moto::~Moto()
{
    //dtor
}


void Moto::Dump()
{
    cout << "speed="<<speed <<endl;
}
