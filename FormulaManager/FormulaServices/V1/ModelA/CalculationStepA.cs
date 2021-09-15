using FormulaManager.Interfaces;
using System.Threading.Tasks;

namespace FormulaManager.V1.ModelA
{

    public class CalculationStepA : ICalculationStep
    {
        public  string StepType { get { return CalculationStepType.StepA; } }
        public  ModelType ModelType { get { return ModelType.ModelA; } }
        private IAuditLogger _auditLogger;
        public CalculationStepA(IAuditLogger auditLogger)
        {
            _auditLogger = auditLogger;
        }
       
        public async Task<decimal> FetchData(decimal input1,decimal input2)
        {
            _auditLogger.LogFetchedData(ModelType.ToString(), StepType.ToString(), input1.ToString(), "10");
            return input1 + 10;
        }

        public async Task<decimal> Calculate(decimal input)
        {
            _auditLogger.LogFormula(ModelType.ToString(),StepType.ToString(), GetFormula(), input.ToString(), (input + 10).ToString());
            return input +10;
        }

        public string GetFormula()
        {
            return "[ input + 10 ]";
        }
    }


}
