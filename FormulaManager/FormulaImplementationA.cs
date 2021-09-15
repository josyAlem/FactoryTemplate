using FormulaManager.V1.ModelA;
using System;
using System.Collections.Generic;

namespace FormulaManager
{
    public static class FormulaImplementationA
    {
        public static void Test(string version, ModelType modelType)
        {
            try
            {
                var factory = new FormulaFactory();
                var auditLogger = factory.Initialize(version, modelType);

                CalculationStepA stepACalc = factory.GetFormula(CalculationStepType.StepA) as CalculationStepA;
                var result = stepACalc.FetchData(3,4);
                var result2 = stepACalc.Calculate(4);

                CalculationStepB stepBCalc = factory.GetFormula(CalculationStepType.StepB) as CalculationStepB;
                var result3 = stepBCalc.FetchData(5);
                var result4 = stepBCalc.Calculate(6);


                List<string> jsonResult = auditLogger.GetLogAsJson();
                foreach (var json in jsonResult)
                {
                    Console.WriteLine();
                    Console.WriteLine(json);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
