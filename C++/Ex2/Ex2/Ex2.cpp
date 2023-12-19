// Canevas Ex2 SL228_POBJ language C++ 
// Visual Studio 2015
// 11.11.2016 C. Huber
// Modifié le 19.12.23 JAR

#include <iostream>
#include <iomanip>
using namespace std;


// Fonction Extract
unsigned short Extract(unsigned long Valin, short& heures, short& minutes)
{
	heures = Valin / 3600;
	minutes = (Valin % 3600) / 60;
	return Valin % 60;
}

// Fonction AfficheB
void AfficheB(long ValIn, char type = 'D', short taille = 5)
{
	//cout.width(taille);
	//cout.fill(' ');
	if (type != 'H')
	{
		//cout << "Nombre = " << dec << ValIn << " en decimal" << endl;
		cout << "Nombre = " << setw(taille) << dec << ValIn << " en decimal" << endl;
	}
	else
	{
		//cout << "Nombre = " << hex << ValIn << " en hexa" << endl;
		cout << "Nombre = " << setw(taille) << hex << ValIn << " en hexa" << endl;
	}
}

// Fonction CalculSurfaceRectangle
int CalculSurfaceRectangle(int x, int y)
{
	return (x * y);
}
double CalculSurfaceRectangle(double x, double y)
{
	return (x * y);
}
int CalculSurfaceRectangle(int X1, int Y1, int X2, int Y2)
{
	return (abs(X2-X1)*abs(Y2-Y1));
}

int main (void)
{
	char UserAnswer;
	int ValA, ValB;
	// Variables pour test A, B et C
	
	short heures, minutes, secondes;

	cout << "Exercice 2 : Affolter Jérémy" << endl;


	do {
		cout << "Test A, B ou C, Q pour Quitter" << endl;
		cin >> UserAnswer;
		
		switch (UserAnswer) {
			case 'A':
			case 'a':
				cout << "TestA: entrez un nombre de secondes" << endl;
				cin >> ValA;
				if (ValA < 0)
				{
					ValA = abs(ValA);
					cout << "La valeur entree est negative. Elle a ete rendue positive." << endl;
				}
				secondes = Extract(ValA, heures, minutes);
				cout << setiosflags(ios::left) << "ValA = " << setw(4) << ValA << "   NbHeures = " << setw(4) << heures << "   NbMinutes = " << setw(2) << minutes 
					<< "   Nbsecondes = " << setw(2) << secondes << resetiosflags(ios::left) << endl;
				
			break;

			case 'B':
			case 'b':
				cout << "TestB: entrez un nombre " <<  endl;
				cin >> ValB; 
				AfficheB(ValB);
				AfficheB(ValB, 'H');
				AfficheB(ValB, 'H', 8);

			break;

			case 'C':
			case 'c':
				cout << "TestC: calculs surface " <<  endl;

				// a)	Avec 2 paramètres int 25 et 45
				cout << "int hauteur = 25   int largeur = 45   surface = " << CalculSurfaceRectangle((int)25, (int)45) << endl;
				// b)	Avec 2 paramètres double 23.25 et 44.33'
				cout << "double hauteur = 23.25   double largeur = 44.33   surface = " << CalculSurfaceRectangle(23.25, 44.33) << endl;
				// c)	Avec 4 paramètres int 20,20, 60,40
				

			break;

		} // end switch
	
	} while (!(UserAnswer == 'Q' || UserAnswer == 'q'));

	return (0);
}