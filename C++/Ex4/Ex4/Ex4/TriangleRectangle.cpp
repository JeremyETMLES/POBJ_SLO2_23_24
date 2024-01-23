#include "TriangleRectangle.h"
#include <cmath>
#include <iostream>
#include <iomanip>


double TriangleRectangle::CalculerSurface(double base, double hauteur)
// don't delete the following line as it's needed to preserve source code of this autogenerated element
// section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D60 begin
{
    Surface = base * hauteur / 2;
    return Surface;
}
// section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D60 end
// don't delete the previous line as it's needed to preserve source code of this autogenerated element

double TriangleRectangle::CalculerPerimetre(double base, double hauteur)
// don't delete the following line as it's needed to preserve source code of this autogenerated element
// section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D64 begin
{
    Perimetre = sqrt(pow(base, 2) + pow(hauteur, 2)) + base + hauteur;
    return Perimetre;
}
// section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D64 end
// don't delete the previous line as it's needed to preserve source code of this autogenerated element

TriangleRectangle::TriangleRectangle()
{
    std::cout << "Constructeur de TriangleRectangle" << std::endl;
}