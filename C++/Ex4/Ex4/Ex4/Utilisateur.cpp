#include "Utilisateur.h"
#include "FormesGeometriques.h"
#include "TriangleRectangle.h"
#include "Cercle.h"
#include "Rectangle.h"
#include <iostream>
#include <iomanip>


void Utilisateur::AfficherResultats()
// don't delete the following line as it's needed to preserve source code of this autogenerated element
// section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D40 begin
{
    if (m_CodeFormeChoisie == 0)
    {
        std::cout << "Pour un TriangleRectangle base = " << m_x1 << " hauteur = " << m_x2 << " surface = " << myFormesGeometriques->GetSurface() << " perimetre = " << myFormesGeometriques->GetPerimetre() << std::endl;
    }
    else if (m_CodeFormeChoisie == 1)
    {
        std::cout << "Pour un Rectangle largeur = " << m_x1 << " hauteur = " << m_x2 << " surface = " << myFormesGeometriques->GetSurface() << " perimetre = " << myFormesGeometriques->GetPerimetre() << std::endl;
    }
    else
    {
        std::cout << "Pour un Cercle diam�tre = " << m_x1 << " surface = " << myFormesGeometriques->GetSurface() << " perimetre = " << myFormesGeometriques->GetPerimetre() << std::endl;
    }
}
// section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D40 end
// don't delete the previous line as it's needed to preserve source code of this autogenerated element

int Utilisateur::ChoisirForme(int CodeForme)
// don't delete the following line as it's needed to preserve source code of this autogenerated element
// section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D42 begin
{
    if (CodeForme == 0)
    {
        myFormesGeometriques = new TriangleRectangle();
    }
    else if (CodeForme == 1)
    {
        myFormesGeometriques = new Rectangle();
    }
    else
    {
        myFormesGeometriques = new Cercle();
    }
    m_CodeFormeChoisie = CodeForme;

    return 0;
}
// section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D42 end
// don't delete the previous line as it's needed to preserve source code of this autogenerated element

void Utilisateur::SaisirLesParametres()
// don't delete the following line as it's needed to preserve source code of this autogenerated element
// section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D44 begin
{
    if (m_CodeFormeChoisie == 0)
    {
        std::cout << "Quel est la base de votre triangle?\n";
        std::cin >> m_x1;
        std::cout << "Quel est la hauteur de votre triangle?\n";
        std::cin >> m_x2;
    }
    else if (m_CodeFormeChoisie == 1)
    {
        std::cout << "Quel est la largeur de votre rectangle?\n";
        std::cin >> m_x1;
        std::cout << "Quel est la hauteur de votre rectangle?\n";
        std::cin >> m_x2;
    }
    else
    {
        std::cout << "Quel est le diam�tre de votre cercle?\n";
        std::cin >> m_x1;
     
        m_x2 = 0;
    }
}
// section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D44 end
// don't delete the previous line as it's needed to preserve source code of this autogenerated element

void Utilisateur::ExecuterLesCalculs()
// don't delete the following line as it's needed to preserve source code of this autogenerated element
// section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D47 begin
{
    myFormesGeometriques->CalculerPerimetre(m_x1, m_x2);
    myFormesGeometriques->CalculerSurface(m_x1, m_x2);
}
// section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D47 end
// don't delete the previous line as it's needed to preserve source code of this autogenerated element
