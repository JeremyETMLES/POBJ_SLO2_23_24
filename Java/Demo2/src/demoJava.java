import java.lang.*;
import java.util.Scanner;

public class demoJava {

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub

		// Types primitifs
		
		// Entiers
		boolean valB;	// -> 1 octet	uiniquement true ou false
		byte valb;		// -> 1 octet
		char valC;		// -> 2 octets
						// -> table étendue ASCII -> unicode -> \u0000 (hexadécimal)
		short valS;		// -> 2 octets
		int valI;		// -> 4 octets
		long valL;		// -> 8 octets
		
		// Réels
		float valF;		// -> 4 octets
		double valD;	// -> 8 octets
		
		// Chaine de caractères
		String maChaine = "Hello Slo2";
		String Recuperation;
		
		// Objet pour la récupération clavier
		Scanner monClavier = new Scanner(System.in);
		
		// Exemple instruction / déclaration
		valB = true;
		valC = 'A';
		valC = '\u0061';
		
		System.out.print(maChaine);
		System.out.println(" Exemple Demo ");
		
		// Lecture clavier
		Recuperation = monClavier.nextLine();
		
		try
		{
			valI = System.in.read();
		}
		catch(Exception data)
		{
			// Message erreur utilisateur
		}
		finally
		{
			
		}
	}

}
