using FormulaManager.Interfaces;
using System.Threading.Tasks;

namespace FormulaManager.V2.ModelB
{

    public class CalculationStepB : ICalculationStep
    {
        public  string StepType { get { return CalculationStepType.StepB; } }
        public  ModelType ModelType { get { return ModelType.ModelB; } }

        private IAuditLogger _auditLogger;
        public CalculationStepB(IAuditLogger auditLogger)
        {
            _auditLogger = auditLogger;
        }
        public async Task<decimal> FetchData(decimal input)
        {
            _auditLogger.LogFetchedData(ModelType.ToString(), StepType.ToString(), input.ToString(), "-20");
            return input - 20;
        }

        public async Task<decimal> Calculate(decimal input)
        {
            _auditLogger.LogFormula(ModelType.ToString(), StepType.ToString(), "[ input - 20 ]", input.ToString(), (input - 20).ToString());
            return input - 20;
        }
        public string GetFormula()
        {
            return "[ input - 20 ]";
        }
    }


}
