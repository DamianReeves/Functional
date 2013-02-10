namespace Functional.Runtime
{
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;

    using Functional.Parsing;

    using Microsoft.Scripting.Runtime;

    public interface IFunctionalLanguageService
    {
        IList<Assembly> Assemblies { get; }

        Scope Globals { get; }

        object ExecuteExpression(string expressionString);

        ParseResult ParseExpression(TextReader reader);

        ParseResult ParseFile(string filename, TextReader reader);
    }

    public class FunctionalLanguageService : IFunctionalLanguageService
    {
        private readonly IList<Assembly> assemblies;

        private readonly Scope globals;

        public FunctionalLanguageService(IList<Assembly> assemblies, Scope globals)
        {
            this.assemblies = assemblies;
            this.globals = globals;
        }

        public IList<Assembly> Assemblies
        {
            get { return this.assemblies; }
        }

        public Scope Globals
        {
            get { return this.globals; }
        }

        public object ExecuteExpression(string expressionString)
        {
            return new Parser().ExecuteExpression(expressionString);
        }

        public ParseResult ParseExpression(TextReader reader)
        {
            return new ParseResult(new Parser().ParseExpression(reader));
        }

        public ParseResult ParseFile(string filename, TextReader reader)
        {            
            return new ParseResult(new Parser().ParseFile(filename, reader));
        }
    }
}