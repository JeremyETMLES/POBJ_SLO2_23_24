#ifndef TriangleRectangle_h
#define TriangleRectangle_h

#include "FormesGeometriques.h"


class TriangleRectangle : public FormesGeometriques {

 public:

    double CalculerSurface(double base, double hauteur);

    double CalculerPerimetre(double base, char hauteur);
};

#endif // TriangleRectangle_h
