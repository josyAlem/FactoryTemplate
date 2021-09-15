using System.Threading.Tasks;

namespace FormulaManager.Interfaces
{
    public interface  ICalculationStep
    {
        public  string StepType { get; }
        public  ModelType ModelType { get; }

        public string GetFormula();

    }
}


