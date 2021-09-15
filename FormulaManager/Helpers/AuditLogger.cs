using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FormulaManager.Helpers
{

    public class AuditLogger : IAuditLogger
    {
        private readonly string _version;
        private readonly List<string> _jsonResult = new List<string>();

        public AuditLogger(string version)
        {
            _version = version;
        }
       
        public void LogFormula(string modelType, string calculationName, string formula, string inputData,string outputData)
        {
                var dto = new FormulaLog
                {
                    LogTime = DateTime.Now.ToString(),
                    Version=_version,
                    ModelType=modelType,
                    CalculationName=calculationName,
                    Output=outputData,
                    Input=inputData,
                    Formula=formula

                };
            _jsonResult.Add(JsonConvert.SerializeObject(dto));

        }

        public void LogFetchedData(string modelType, string calculationName, string inputData, string fetchedData)
        {
            var dto = new FetchedDataLog
            {
                LogTime = DateTime.Now.ToString(),
                Version = _version,
                ModelType = modelType,
                CalculationName = calculationName,
                FetchedData = fetchedData,
                Input = inputData,

            };
            _jsonResult.Add(JsonConvert.SerializeObject(dto));
        }

        public List<string> GetLogAsJson()
        {
          
            return _jsonResult;
        }
       


    }
}
