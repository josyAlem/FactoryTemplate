using System.Collections.Generic;

namespace FormulaManager
{
    public interface IAuditLogger
    {
        List<string> GetLogAsJson();
        void LogFormula(string modelType, string calculationName, string formula, string inputData, string outputData);
        void LogFetchedData(string modelType, string calculationName, string inputData, string fetchedData);
    }
}
