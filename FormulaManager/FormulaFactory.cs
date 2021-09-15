
using FormulaManager.Helpers;
using FormulaManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FormulaManager
{

    public class FormulaFactory :IFormulaFactory
    {
        private Dictionary<string, Type> FormulaManagerTypes;
        private List<ICalculationStep> FormulaManagers;
        private IAuditLogger _auditLogger;

        public FormulaFactory()
        {
            LoadAvailableTypes();
        }

        public IAuditLogger Initialize(string version, ModelType modelType)
        {
            FormulaManagers = new List<ICalculationStep>();
            _auditLogger = new AuditLogger(version);

            List<Type> matchingTypes = GetTypesToCreate(version, modelType);
            foreach (var typ in matchingTypes)
            {
                var managerInstance = CreateInstance(typ);
                if (managerInstance != null)
                {
                    FormulaManagers.Add(managerInstance);
                }
            }
            return _auditLogger;
        }

        public ICalculationStep GetFormula(string calculationName)
        {
            return FormulaManagers.FirstOrDefault(c => c.StepType == calculationName.ToString());
        }

        private ICalculationStep CreateInstance(Type typ)
        {
            return Activator.CreateInstance(typ, _auditLogger) as ICalculationStep;
        }

        private List<Type> GetTypesToCreate(string version, ModelType modelType)
        {
            string searchName = version + "." + modelType.ToString();
            List<Type> matchingTypes = new List<Type>();
            foreach (var ota in FormulaManagerTypes)
            {
                if (ota.Key.Contains(searchName))
                {
                    matchingTypes.Add(FormulaManagerTypes[ota.Key]);
                }
            }

            return matchingTypes;
        }

        private void LoadAvailableTypes()
        {
            FormulaManagerTypes = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typesInThisAssembly)
            {
                if (typeof(ICalculationStep).IsAssignableFrom(type))
                {
                    FormulaManagerTypes.Add(type.FullName, type);
                }
            }
        }
    }
}
