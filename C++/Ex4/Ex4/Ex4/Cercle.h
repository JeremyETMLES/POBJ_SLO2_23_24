#ifndef Cercle_h
#define Cercle_h

#include "FormesGeometriques.h"


class Cercle : public FormesGeometriques {

 public:

    double CalculerSurface(double diametre, double nul);

    double CalculerPerimetre(double diametre, double nul);

    Cercle();
};

#endif // Cercle_h
