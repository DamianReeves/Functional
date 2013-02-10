namespace Functional.Parsing 
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    using Antlr.Runtime;
    using Antlr.Runtime.Tree;

    internal class Parser 
    {
        public object ExecuteExpression(string expressionString) 
        {
            using (var reader = new StringReader(expressionString))
            {
                return this.ParseExpression(reader);
            }
        }

        public object ParseExpression(TextReader reader)
        {
            var input = new ANTLRReaderStream(reader);
            var lexer = new FunctionalLexer(input);
            var tokenStream = new CommonTokenStream(lexer);
            var parser = new FunctionalParser(tokenStream);
            var tree = parser.prog().Tree;
            var nodes = new CommonTreeNodeStream(tree);
            var eval = new FunctionalTreeParser(nodes, parser.FunctionDefinitions);
            eval.prog();
            return default(BigInteger);
        }

        public object ParseFile(string filename, TextReader reader) 
        {
            var input = new ANTLRReaderStream(reader);
            var lexer = new FunctionalLexer(input);
            var tokenStream = new CommonTokenStream(lexer);
            var parser = new FunctionalParser(tokenStream);
            var tree = parser.prog().Tree;
            var nodes = new CommonTreeNodeStream(tree);
            var eval = new FunctionalTreeParser(nodes, parser.FunctionDefinitions);
            eval.prog();
            return default(BigInteger);
        }        
    }
}
