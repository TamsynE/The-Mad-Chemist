/*
    * Mad Chemist
    *   Parses chemical formulas like H2O or NaCl and calculates their total molecular mass.
    *
    *   file:   CalculateMass.cs
    *   author: Tamsyn Evezard
    */


using System;

namespace MadChemist
{
    public static class PeriodicFormula
    {
        public static double CalculateMass(string molecule, PeriodicTable pt)
        {
            string m = molecule;
            int A = 0;
            int Z = 1;
            int n = 1;
            int L = m.Length - 1;
            double totalMass = 0;

            //if no number on last element
            if (!char.IsDigit(m[L]))
            {
                m = molecule + "1";
            }

            //reads entire molecule
            while (Z < m.Length)
            {

                while (Z < m.Length && char.IsLower(m[Z]))
                {
                    Z++;
                }

                string atom = m.Substring(A, Z - A);
                A = Z;

                //finds end of each atom
                while (Z < m.Length && char.IsDigit(m[Z]))
                {
                    Z++;
                }

                //if no number on elements
                if (!int.TryParse(m.Substring(A, Z - A), out n))
                {
                    n = 1;
                }

                //adds all elements together
                totalMass += n * pt.GetAtomicMass(atom);

                A = Z;

                if (Z < m.Length && char.IsUpper(m[Z]))
                {
                    Z++;
                }
            }
            return totalMass;
        }
    }
}
