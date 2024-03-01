// FILE: C:/JAR_Code/GitHub/POBJ_SLO2_23_24/C#/Ex4//TriangleRectangle.cs

// In this section you can add your own using directives
// section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D5E begin
// section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D5E end

/// <summary>
///  A class that represents ...
/// 
///  @see OtherClasses
///  @author your_name_here
/// </summary>
namespace Ex4
{
    public class TriangleRectangle : FormesGeometriques
    {
        // Operations

        /// <summary>
        ///  An operation that does...
        /// 
        ///  @param firstParam a description of this parameter
        /// </summary>
        /// <param name="base">
        /// </param>
        /// <param name="hauteur">
        /// </param>
        /// <returns>
        /// </returns>
        override public double CalculerSurface(double vbase, double hauteur)
        {
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D60 begin
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D60 end
            Surface = vbase * hauteur / 2;
            return Surface;
        }

        /// <summary>
        ///  An operation that does...
        /// 
        ///  @param firstParam a description of this parameter
        /// </summary>
        /// <param name="base">
        /// </param>
        /// <param name="hauteur">
        /// </param>
        /// <returns>
        /// </returns>
        override public double CalculerPerimetre(double vbase, double hauteur)
        {
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D64 begin
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D64 end
            Perimetre = Math.Sqrt(Math.Pow(vbase, 2) + Math.Pow(hauteur, 2)) + vbase + hauteur;
            return Perimetre;
        }

        public TriangleRectangle()
        {
            Console.WriteLine("Constructeur de TriangleRectangle");
        }
    } /* end class TriangleRectangle */
}