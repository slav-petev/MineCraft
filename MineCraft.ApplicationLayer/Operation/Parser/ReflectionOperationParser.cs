using MineCraft.ApplicationLayer.Extensions;
using MineCraft.Core.Operation;
using MineCraft.Core.Operation.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MineCraft.ApplicationLayer.Operation.Parser
{
    public class ReflectionOperationParser : IOperationParser
    {
        private static readonly Dictionary<string, Type> _commonOperationTypes;
        private static readonly Dictionary<string, Type> _registerOperations;

        static ReflectionOperationParser()
        {
            _commonOperationTypes = Assembly
                .GetExecutingAssembly()
                .GetConcreteTypesAssignableFrom(typeof(IOperation))
                .ToDictionary(
                    key => key.Name.Replace("Operation", string.Empty),
                    value => value);
        }

        public IOperation Parse(string input)
        {
            var operationParameters = input.Split();
            var operationName = operationParameters[0];
            if (operationName != "Register")
            {
                var parameters = operationParameters.Skip(1)
                    .ToArray();
                return (IOperation)Activator.CreateInstance(
                    _commonOperationTypes[operationName],
                    parameters);
            }

            throw new System.NotImplementedException();
        }
    }
}
