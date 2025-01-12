// Fichier Ex5.cpp
// Programme principal pour utiliser Dessinateur et Figure

#include <iostream>
using namespace std; 

#include "Dessinateur.h"

int main(void)
{
	char Rep = 'A';
	
	// D�claration et cr�ation des dessinateurs
	Dessinateur DessinateurA, DessinateurB, DessinateurC;

	cout << "Cours SL228_POBJ CPP exercice 5" << endl;
	while (Rep != 'Q' && Rep != 'q')
	{
		DessinateurA.ConstruireFigure('L');
		DessinateurA.SaisirPositionXY(1);
		DessinateurA.SaisirPositionXY(2);
		DessinateurA.DessinerFigure();
		DessinateurA.DetruireFigure();

		DessinateurB.ConstruireFigure('R');
		DessinateurB.SaisirPositionXY(1);
		DessinateurB.SaisirPositionXY(2);
		DessinateurB.DessinerFigure();
		DessinateurB.DetruireFigure();
		//delete DessinateurB.MaFigure;

		DessinateurC.ConstruireFigure('E');
		DessinateurC.SaisirPositionXY(1);
		DessinateurC.SaisirPositionXY(2);
		DessinateurC.DessinerFigure();
		DessinateurC.DetruireFigure();
		//delete DessinateurC.MaFigure;

		cout << "Entrez Q pour quitter !" << endl;
		cin >> Rep;
	}	
	return 0;
}

