namespace Functional.Runtime
{
    using System;

    using Microsoft.Scripting;
    using Microsoft.Scripting.Runtime;    

    public class FunctionalScriptCode : ScriptCode
    {
        private readonly ParseResult parseResult;

        public FunctionalScriptCode(ParseResult parseResult, SourceUnit sourceUnit)
            : base(sourceUnit)
        {
            this.parseResult = parseResult;
        }

        public ParseResult ParseResult
        {
            get
            {
                return this.parseResult;
            }
        }

        public override object Run(Scope scope)
        {
            return parseResult.Evaluate(scope);
        }
    }
}