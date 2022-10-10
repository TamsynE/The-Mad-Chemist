/*
    * Mad Chemist
    *   Parses chemical formulas like H2O or NaCl and calculates their total molecular mass.
    *
    *   file:   PeriodicTable.cs
    *   author: Tamsyn Evezard
    */


using System;

namespace MadChemist
{
    public class PeriodicTable
    {
        private string[] syms = {
            "H","He","Li","Be","B","C","N","O","F","Ne","Na","Mg","Al","Si","P",
            "S","Cl","Ar","K","Ca","Sc","Ti","V","Cr","Mn","Fe","Co","Ni","Cu",
            "Zn","Ga","Ge","As","Se","Br","Kr","Rb","Sr","Y","Zr","Nb","Mo","Tc",
            "Ru","Rh","Pd","Ag","Cd","In","Sn","Sb","Te","I","Xe","Cs","Ba","La",
            "Ce","Pr","Nd","Pm","Sm","Eu","Gd","Tb","Dy","Ho","Er","Tm","Yb","Lu",
            "Hf","Ta","W","Re","Os","Ir","Pt","Au","Hg","Tl","Pb","Bi","Po","At",
            "Rn","Fr","Ra","Ac","Th","Pa","U","Np","Pu","Am","Cm","Bk","Cf","Es",
            "Fm","Md","No","Lr","Rf","Db","Sg","Bh","Hs","Mt","Ds","Rg","Cn","Nh",
            "Fl","Mc","Lv","Ts","Og"
        };
        private double[] mass = {
            1.008,4.0026,6.94,9.0122,10.81,12.011,14.007,15.999,18.998,20.18,22.99,
            24.305,26.982,28.085,30.974,32.06,35.45,39.88,39.098,40.078,44.956,47.867,
            50.942,51.996,54.938,55.845,58.933,58.693,63.546,65.38,69.723,72.63,74.922,
            78.971,79.904,83.798,85.468,87.62,88.906,91.224,92.906,95.95,97,101.07,
            102.91,106.42,107.87,112.41,114.82,118.71,121.76,127.6,126.9,131.29,132.91,
            137.33,138.91,140.12,140.91,144.24,145,150.36,151.96,157.25,158.93,162.5,
            164.93,167.26,168.93,173.05,174.97,178.49,180.95,183.84,186.21,190.23,
            192.22,195.08,196.97,200.59,204.38,207.2,208.98,209,210,222,233,226,227,
            232.04,231.04,238.03,237,244,243,247,247,251,252,257,258,259,266,267,268,
            269,270,269,278,281,282,285,286,289,290,293,294,294
        };

        public PeriodicTable()
        {
        }

        public double GetAtomicMass(string symbol)
        {
            int idx = Array.IndexOf(syms, symbol);
            if (idx < 0 || idx >= syms.Length)
            {
                throw new ArgumentException($"Symbol '{symbol}' is not in the periodic table");
            }
            return mass[idx];
        }
    }

    class TestProgram
    {
        public static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                string program = System.AppDomain.CurrentDomain.FriendlyName;
                Console.WriteLine($"Error: {program} requires Molecular Formula search term (e.g., 'H2O' or 'NaCl')");
                Console.WriteLine($"Usage: {program} <SEARCH_TERM>");
                return;
            }

            try
            {
                string molecule = args[0];
                double mass = PeriodicFormula.CalculateMass(molecule, new PeriodicTable());
                Console.WriteLine($"{molecule}: {mass}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Lookup error occured: {e.Message}");
                Console.WriteLine($"Quitting");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
                Console.WriteLine($"Quitting");
                return;
            }
        }
    }
}

