// FILE: C:/JAR_Code/GitHub/POBJ_SLO2_23_24/C#/Ex4//FormesGeometriques.cs

// In this section you can add your own using directives
// section -64--88-1-34--36b44aa6:13b1361d152:-8000:0000000000000869 begin
// section -64--88-1-34--36b44aa6:13b1361d152:-8000:0000000000000869 end

/// <summary>
///  A class that represents ...
/// 
///  @see OtherClasses
///  @author your_name_here
/// </summary>
namespace Ex4
{
    public class FormesGeometriques
    {
        // Attributes

        protected double Surface;

        protected double Perimetre;

        // Associations

        /// <summary> 
        /// </summary>

        // Operations

        /// <summary>
        ///  An operation that does...
        /// 
        ///  @param firstParam a description of this parameter
        /// </summary>
        /// <param name="x1">
        /// </param>
        /// <param name="x2">
        /// </param>
        /// <returns>
        /// </returns>
        virtual public double CalculerSurface(double x1, double x2)
        {
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D50 begin
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D50 end
            return 0.0;
        }

        /// <summary>
        ///  An operation that does...
        /// 
        ///  @param firstParam a description of this parameter
        /// </summary>
        /// <param name="x1">
        /// </param>
        /// <param name="x2">
        /// </param>
        /// <returns>
        /// </returns>
        virtual public double CalculerPerimetre(double x1, double x2)
        {
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D54 begin
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D54 end
            return 0.0;
        }

        /// <summary>
        ///  An operation that does...
        /// 
        ///  @param firstParam a description of this parameter
        /// </summary>
        /// <returns>
        /// </returns>
        public double GetSurface()
        {
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D7D begin
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D7D end
            return Surface;
        }

        /// <summary>
        ///  An operation that does...
        /// 
        ///  @param firstParam a description of this parameter
        /// </summary>
        /// <returns>
        /// </returns>
        public double GetPerimetre()
        {
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D7F begin
            // section -64--88-1-58--553bbdf8:13b14881301:-8000:0000000000000D7F end
            return Perimetre;
        }

        public FormesGeometriques()
        {
            Console.WriteLine("Constructeur de FormeGeometrique");
        }
    } /* end class FormesGeometriques */
}