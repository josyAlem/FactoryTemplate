using FormulaManager.Interfaces;
using System.Threading.Tasks;

namespace FormulaManager.V1.ModelA
{

    public class CalculationStepB : ICalculationStep
    {
        public  string StepType { get { return CalculationStepType.StepB; } }
        public  ModelType ModelType { get { return ModelType.ModelA; } }
        private IAuditLogger _auditLogger;
        public CalculationStepB(IAuditLogger auditLogger)
        {
            _auditLogger = auditLogger;
        }

        public async Task<decimal> FetchData(int input)
        {
            _auditLogger.LogFetchedData(ModelType.ToString(), StepType.ToString(), input.ToString(), "-10");
            return input - 10;
        }

        public async Task<decimal> Calculate(int input)
        {
            _auditLogger.LogFormula(ModelType.ToString(), StepType.ToString(), "[ input - 10 ]", input.ToString(), (input - 10).ToString());
            return input - 10;
        }
        public string GetFormula()
        {
            return "[ input - 10 ]";
        }

    }

}



