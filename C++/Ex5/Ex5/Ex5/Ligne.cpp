#include "Ligne.h"
#include <iostream>



void Ligne::EffectuerSaisie(int NoPoint)
// don't delete the following line as it's needed to preserve source code of this autogenerated element
// section -64--88-1-58-75afad:13c59679ed7:-8000:0000000000000D8F begin
{
    double X, Y;
    if (NoPoint == 1)
    {
        std::cout << "Entrez la position X et Y du debut de la ligne: " << std::endl;
    }
    else
    {
        std::cout << "Entrez la position X et Y de la fin de la ligne: " << std::endl;
    }
    std::cin >> X >> Y;
    PairePoints[NoPoint - 1].SetXY(X, Y);
}
// section -64--88-1-58-75afad:13c59679ed7:-8000:0000000000000D8F end
// don't delete the previous line as it's needed to preserve source code of this autogenerated element

void Ligne::Dessiner()
// don't delete the following line as it's needed to preserve source code of this autogenerated element
// section -64--88-1-58-75afad:13c59679ed7:-8000:0000000000000D92 begin
{
    std::cout << "Dessin d'une Ligne:" << std::endl;
    std::cout << "Debut de la ligne: ";
    PairePoints[0].AfficherPoint();
    std::cout << "Fin de la ligne: ";
    PairePoints[1].AfficherPoint();
}
// section -64--88-1-58-75afad:13c59679ed7:-8000:0000000000000D92 end
// don't delete the previous line as it's needed to preserve source code of this autogenerated element

Ligne::Ligne()
// don't delete the following line as it's needed to preserve source code of this autogenerated element
// section -64--88-1-58-75afad:13c59679ed7:-8000:0000000000000D94 begin
{
    std::cout << "Constructeur de Ligne" << std::endl;
}
// section -64--88-1-58-75afad:13c59679ed7:-8000:0000000000000D94 end
// don't delete the previous line as it's needed to preserve source code of this autogenerated element

Ligne::~Ligne()
// don't delete the following line as it's needed to preserve source code of this autogenerated element
// section -64--88-1-58-75afad:13c59679ed7:-8000:0000000000000D99 begin
{
    std::cout << "Destructeur de Ligne" << std::endl;
}
// section -64--88-1-58-75afad:13c59679ed7:-8000:0000000000000D99 end
// don't delete the previous line as it's needed to preserve source code of this autogenerated element
