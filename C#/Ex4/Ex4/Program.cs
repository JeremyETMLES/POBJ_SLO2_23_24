namespace Ex4
{
	public class Program
	{ 
		public static int Main(string[] args)
		{
			Utilisateur UserA = new Utilisateur();
			Utilisateur UserB = new Utilisateur();
			Utilisateur UserC = new Utilisateur();

			UserA.ChoisirForme(0);
			UserA.SaisirLesParametres();
			UserA.ExecuterLesCalculs();
			UserA.AfficherResultats();

			UserB.ChoisirForme(1);
			UserB.SaisirLesParametres();
			UserB.ExecuterLesCalculs();
			UserB.AfficherResultats();

			UserC.ChoisirForme(2);
			UserC.SaisirLesParametres();
			UserC.ExecuterLesCalculs();
			UserC.AfficherResultats();

			return 0;
		}
	}
}