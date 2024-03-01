// FILE: C:/JAR_Code/GitHub/POBJ_SLO2_23_24/C#/Ex4//Cercle.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// In this section you can add your own using directives
// section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D72 begin
// section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D72 end

/// <summary>
///  A class that represents ...
/// 
///  @see OtherClasses
///  @author your_name_here
/// </summary>
namespace Ex4
{
    public class Cercle : FormesGeometriques
    {
        // Operations

        /// <summary>
        ///  An operation that does...
        /// 
        ///  @param firstParam a description of this parameter
        /// </summary>
        /// <param name="diametre">
        /// </param>
        /// <returns>
        /// </returns>
        override public double CalculerSurface(double diametre, double nul)
        {
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D74 begin
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D74 end
            Surface = 3.14159265 * (Math.Pow(diametre, 2)) / 4;
            return Surface;
        }

        /// <summary>
        ///  An operation that does...
        /// 
        ///  @param firstParam a description of this parameter
        /// </summary>
        /// <param name="diametre">
        /// </param>
        /// <returns>
        /// </returns>
        override public double CalculerPerimetre(double diametre, double nul)
        {
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D7A begin
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D7A end
            Perimetre = 3.14159265 * diametre;
            return Perimetre;
        }

        public Cercle()
        {
            Console.WriteLine("Constructeur de Cercle");
        }
    } /* end class Cercle */
}