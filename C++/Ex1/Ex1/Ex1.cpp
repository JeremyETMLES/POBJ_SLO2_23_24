// Caneva Ex1 SL228_POBJ language C++ 
// Visual Studio 2015
// 11.11.2016 C. Huber
// Modifi� le 28.11.23 par Affolter J�r�my

#include <iostream>
#include <iomanip>

int main (void)
{
	char UserAnswer;
	int ValA, ValB;
	// Variables pour test A et B
	short i;
	short ValB1;
	double  ValB2;

	std::cout << "Exercice 1 : Affolter Jeremy" << std::endl;

	do {
		std::cout << "Test A ou B, Q pour Quitter " << std::endl;
		std::cin >> UserAnswer;
		
		switch (UserAnswer) {
			case 'A':
			case 'a':
				std::cout << "TestA: entrez un nombre entre 1 et 9" << std::endl;
				std::cin >> ValA;

				if (ValA > 9)
				{
					ValA = 9;
					std::cout << "TestA: ValA limitee a 9" << std::endl;
				}
				if (ValA == 0)
				{
					ValA = 1;
					std::cout << "TestA: ValA forcee a 1" << std::endl;
				}
				if (ValA > 0 )  
				{
					std::cout << ValA;
					for (i=0; i < ValA ; i++)
					{
						printf ("*");
					}
					std::cout << "" << std::endl; // saut de ligne
				}
				else 
				{
					std::cout << "TestA: ValA est negatif !" << std::endl;
				}
			break;

			case 'B':
			case 'b':
				std::cout << "TestB: entrez une valeur entre 0 et 9" << std::endl;
				std::cin >> ValB;
				
				if (ValB >= 0 && ValB <=9 )
				{
					for (i=0; i < ValB; i++) { 
						ValB1 = 100 + (10 * i);
						ValB2 = ValB1 / 10000.0;
						
						std::cout << "TestB: i= " << i << " ValB1 = " << ValB1 << " ValB2 = " << std::left << std::setw(7) << std::setfill('0') << ValB2 << std::endl;
						//std::cout.width(7);
						//std::cout.fill('0');
						//std::cout.precision(5);
					}
				}
				else
				{
					std::cout << "TestB: ValB n'est pas entre 0 et 9 !" << std::endl;
				}
		break;

		} // end switch
	
	} while (!(UserAnswer == 'Q' || UserAnswer == 'q'));

	return (0);
}