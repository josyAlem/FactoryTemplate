﻿using FormulaManager.Interfaces;
using System.Threading.Tasks;

namespace FormulaManager.V2.ModelA
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
