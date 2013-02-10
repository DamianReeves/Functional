namespace Functional.Parsing
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    using Antlr.Runtime.Tree;

    public partial class FunctionalTreeParser
    {
        private readonly IDictionary<string, BigInteger> localMemory = new Dictionary<string, BigInteger>();
        private readonly IDictionary<string, BigInteger> globalMemory = new Dictionary<string, BigInteger>();
        private IList<CommonTree> functionDefinitions;

        public FunctionalTreeParser(ITreeNodeStream nodes, IList<CommonTree> functionDefinitions) : base(nodes)
        {
            this.functionDefinitions = functionDefinitions;
        }
         
        /// <summary>
        /// Set up a local evaluator for a nested function call. The evaluator gets the definition
        ///  tree of the function; the set of all defined functions (to find locally called ones); a
        /// pointer to the global variable memory; and the value of the function parameter to be
        /// added to the local memory.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="functionDefinitions"></param>
        /// <param name="globalMemory"></param>
        /// <param name="paramValue"></param>
        private FunctionalTreeParser(
            CommonTree function,
            IList<CommonTree> functionDefinitions,
            IDictionary<string, BigInteger> globalMemory,
            BigInteger paramValue)
            : this(// Expected tree for function: ^(FUNC ID ( INT | ID ) expr)
                new CommonTreeNodeStream(function.GetChild(2)), functionDefinitions)
        {
            //this.globalMemory = globalMemory;
            this.localMemory.Add(function.GetChild(1).Text, paramValue);
        }

        /** Get value of name up call stack. */
        public BigInteger GetValue(string name)
        {
            BigInteger value;
            if (this.localMemory.TryGetValue(name, out value))
            {
                return value;
            }

            if (globalMemory.TryGetValue(name, out value))
            {
                return value;
            }
                        
            // not found in local memory or global memory
            Console.Error.WriteLine("undefined variable " + name);
            return BigInteger.Zero;
        }

        /// <summary>
        /// Find matching function definition for a function name and parameter
        /// value. The first definition is returned where (a) the name matches
        /// and (b) the formal parameter agrees if it is defined as constant.
        /// </summary>
        private CommonTree FindFunction(string name, BigInteger paramValue)
        {
            foreach (var f in this.functionDefinitions)
            {
                // Expected tree for f: ^(FUNC ID (ID | INT) expr)
                if (f.GetChild(0).Text.Equals(name)) 
                {
                    // Check whether parameter matches
                    var formalPar = (CommonTree)f.GetChild(1);
                    if (formalPar.Token.Type == INT)
                    {
                        BigInteger bigInt;
                        
                        if (BigInteger.TryParse(formalPar.Token.Text, out bigInt))
                        {
                            if (bigInt != paramValue)
                            {
                                // Constant in formalPar list does not match actual value -> no match.
                                continue;
                            }                            
                        }                        
                    }
                    
                    // Parameter (value for INT formal arg) as well as fct name agrees!
                    return f;
                }
            }

            return null;
        }        
    }
}
