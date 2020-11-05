#include "Framer.h"
#include "Moto.h"
Framer::Framer()
{
    //ctor
}

Framer::~Framer()
{
    //dtor
}


void Framer::SetSpeed(Moto *moto,int speed)
{
    moto->speed = speed;

}
