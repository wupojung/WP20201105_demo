#ifndef FRAMER_H
#define FRAMER_H
#include "Moto.h"

class Framer
{
    public:
        Framer();
        virtual ~Framer();

        void SetSpeed(Moto *moto,int speed);

    protected:

    private:
};

#endif // FRAMER_H
