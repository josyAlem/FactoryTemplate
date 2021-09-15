using FormulaManager;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FormulaImplementationA.Test(CalculationVersion.Version1, ModelType.ModelA);
                 FormulaImplementationB.Test(CalculationVersion.Version1, ModelType.ModelB);

                 FormulaImplementationC.Test(CalculationVersion.Version2, ModelType.ModelA);
                FormulaImplementationD.Test(CalculationVersion.Version2, ModelType.ModelB);
            }
            catch (Exception ex) {
                Environment.Exit(0);
            }
        }
    }
}
