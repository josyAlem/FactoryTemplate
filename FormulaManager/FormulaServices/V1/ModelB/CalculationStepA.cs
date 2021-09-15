using FormulaManager.Interfaces;
using System.Threading.Tasks;

namespace FormulaManager.V1.ModelB
{

    public class CalculationStepA : ICalculationStep
    {
        public  string StepType { get { return CalculationStepType.StepA; } }
        public  ModelType ModelType { get { return ModelType.ModelB; } }

        private IAuditLogger _auditLogger;
        public CalculationStepA(IAuditLogger auditLogger)
        {
            _auditLogger = auditLogger;
        }

        public async Task<decimal> FetchData(decimal input)
        {
            return 0;
        }

        public async Task<decimal> Calculate(decimal input)
        {
            return 0;
        }
        public string GetFormula()
        {
            return "";
        }
    }


}
