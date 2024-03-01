// FILE: C:/JAR_Code/GitHub/POBJ_SLO2_23_24/C#/Ex4//Utilisateur.cs

// In this section you can add your own using directives
// section -64--88-1-34--36b44aa6:13b1361d152:-8000:0000000000000868 begin
// section -64--88-1-34--36b44aa6:13b1361d152:-8000:0000000000000868 end

/// <summary>
///  A class that represents ...
/// 
///  @see OtherClasses
///  @author your_name_here
/// </summary>

namespace Ex4
{ 
    public class Utilisateur
    {
        // Attributes
    
        private int m_CodeFormeChoisie;
        private double m_x1;
        private double m_x2;

        // Associations

        /// <summary> 
        /// </summary>
        public FormesGeometriques myFormesGeometriques = new FormesGeometriques();
    
        // Operations
    
        /// <summary>
        ///  An operation that does...
        /// 
        ///  @param firstParam a description of this parameter
        /// </summary>
        /// <returns>
        /// </returns>
        public void AfficherResultats()
        {
        // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D40 begin
        // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D40 end
            
            if (m_CodeFormeChoisie == 0)
            {
                Console.WriteLine("Pour un TriangleRectangle base = {0:D} hauteur = {0:D} surface = {0:D} perimetre = {0:D}", m_x1, m_x2, myFormesGeometriques.GetSurface(), myFormesGeometriques.GetPerimetre());
            }
            else if (m_CodeFormeChoisie == 1)
            {
                Console.WriteLine("Pour un Rectangle largeur = {0:D} hauteur = {0:D} surface = {0:D} perimetre = {0:D}", m_x1, m_x2, myFormesGeometriques.GetSurface(), myFormesGeometriques.GetPerimetre());
            }
            else
            {
                Console.WriteLine("Pour un Cercle diamètre = {0:D} surface = {0:D} perimetre = {0:D}", m_x1, myFormesGeometriques.GetSurface(), myFormesGeometriques.GetPerimetre());
            }
        }
    
        /// <summary>
        ///  An operation that does...
        /// 
        ///  @param firstParam a description of this parameter
        /// </summary>
        /// <param name="CodeForme">
        /// </param>
        /// <returns>
        /// </returns>
        public int ChoisirForme(int CodeForme)
        {
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D42 begin
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D42 end
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
    
        /// <summary>
        ///  An operation that does...
        /// 
        ///  @param firstParam a description of this parameter
        /// </summary>
        /// <returns>
        /// </returns>
        public void SaisirLesParametres()
        {
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D44 begin
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D44 end
            if (m_CodeFormeChoisie == 0)
            {
                Console.WriteLine("Quel est la base de votre triangle?");
                m_x1 = Console.Read();
                Console.WriteLine("Quel est la hauteur de votre triangle?");
                m_x2 = Console.Read();
            }
            else if (m_CodeFormeChoisie == 1)
            {
                Console.WriteLine("Quel est la largeur de votre rectangle?");
                m_x1 = Console.Read();
                Console.WriteLine("Quel est la hauteur de votre rectangle?");
                m_x2 = Console.Read();
            }
            else
            {
                Console.WriteLine("Quel est le diamètre de votre cercle?");
                m_x1 = Console.Read();

                m_x2 = 0;
            }
        }
    
        /// <summary>
        ///  An operation that does...
        /// 
        ///  @param firstParam a description of this parameter
        /// </summary>
        /// <returns>
        /// </returns>
        public void ExecuterLesCalculs()
        {
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D47 begin
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D47 end
            myFormesGeometriques.CalculerPerimetre(m_x1, m_x2);
            myFormesGeometriques.CalculerSurface(m_x1, m_x2);
        }
    } /* end class Utilisateur */
}
