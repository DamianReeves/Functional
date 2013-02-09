namespace Functional.Runtime 
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Antlr.Runtime;
    using Antlr.Runtime.Tree;

    using Functional.Parser;

    using Microsoft.Scripting;
    using Microsoft.Scripting.Runtime;

    public sealed class FunctionalContext : LanguageContext
    {
        public FunctionalContext(ScriptDomainManager domainManager, IDictionary<string, object> options)
            : base(domainManager) 
        {
        }

        public override ScriptCode CompileSourceCode(SourceUnit sourceUnit, CompilerOptions options, ErrorSink errorSink)  
        {
            try
            {
                using (var reader = sourceUnit.GetReader())
                {
                    var input = new ANTLRReaderStream(reader);
                    var lexer = new FunctionalLexer(input);
                    var tokenStream = new CommonTokenStream(lexer);
                    var parser = new FunctionalParser(tokenStream);
                    var tree = parser.prog().Tree;
                    var nodes = new CommonTreeNodeStream(tree);
                    var eval = new FunctionalTreeParser(nodes, parser.FunctionDefinitions);
                    eval.prog();
                }

                return null;
            }
            catch (Exception ex) 
            {
                // Real language implementation would have a specific type
                // of exception.  Also, they would pass errorSink down into
                // the parser and add messages while doing tighter error
                // recovery and continuing to parse.
                errorSink.Add(sourceUnit, ex.Message, SourceSpan.None, 0,
                              Severity.FatalError);
                return null;
            }
        }
    }
}
