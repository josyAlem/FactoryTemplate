
namespace FormulaManager.Interfaces
{
    public interface IFormulaFactory
    {
        IAuditLogger Initialize(string version, ModelType modelType);
        ICalculationStep GetFormula(string calculationName);
    }
}


