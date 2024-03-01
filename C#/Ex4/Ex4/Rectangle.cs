// FILE: C:/JAR_Code/GitHub/POBJ_SLO2_23_24/C#/Ex4//Rectangle.cs

// In this section you can add your own using directives
// section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D68 begin
// section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D68 end

/// <summary>
///  A class that represents ...
/// 
///  @see OtherClasses
///  @author your_name_here
/// </summary>
namespace Ex4
{
    public class Rectangle : FormesGeometriques
    {
        // Operations

        /// <summary>
        ///  An operation that does...
        /// 
        ///  @param firstParam a description of this parameter
        /// </summary>
        /// <param name="largeur">
        /// </param>
        /// <param name="hauteur">
        /// </param>
        /// <returns>
        /// </returns>
        override public double CalculerSurface(double largeur, double hauteur)
        {
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D6A begin
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D6A end
            Surface = largeur * hauteur;
            return Surface;
        }

        /// <summary>
        ///  An operation that does...
        /// 
        ///  @param firstParam a description of this parameter
        /// </summary>
        /// <param name="largeur">
        /// </param>
        /// <param name="hauteur">
        /// </param>
        /// <returns>
        /// </returns>
        override public double CalculerPerimetre(double largeur, double hauteur)
        {
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D6C begin
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D6C end
            Perimetre = 2 * largeur + 2 * hauteur;
            return Perimetre;
        }

        public Rectangle()
        {
            Console.WriteLine("Constructeur de Rectangle");
        }
    } /* end class Rectangle */
}