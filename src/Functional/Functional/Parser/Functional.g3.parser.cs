namespace Functional.Parser 
{
    using System.Collections.Generic;

    using Antlr.Runtime.Tree;

    public partial class FunctionalParser 
    {
        private readonly IList<CommonTree> functionDefinitions = new List<CommonTree>();

        public IList<CommonTree> FunctionDefinitions
        {
            get { return this.functionDefinitions; }
        }
    }
}
