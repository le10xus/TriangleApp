using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleLib
{
    public enum TriangleType
    {
        WrongType = -1,
        /// <summary>
        /// остроугольный
        /// </summary>
        Acute,
        /// <summary>
        /// прямоугольный
        /// </summary>
        Right,
        /// <summary>
        /// тупоугольный
        /// </summary>
        Obtuse
    }

    public class Triangle: TriangleFigure
    {
        private double SideA { get; set; }
        private double SideB { get; set; }
        private double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC) {
            if (sideA <= 0 || sideB <=0 || sideC <= 0)
            {
                throw new ArgumentException("Value should be greater than zero");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public TriangleType GetTriangleType()
        {
            var sqrC = Math.Round(Math.Pow(SideC, 2), 1);
            var sqrSum = Math.Round(Math.Pow(SideA, 2), 1) + Math.Round(Math.Pow(SideB, 2), 1);

            if (sqrC == sqrSum)
            {
                return TriangleType.Right;
            }
            else if (sqrC < sqrSum)
            {
                return TriangleType.Acute;
            }
            else {
                return TriangleType.Obtuse;
            }
        }
    }
}
