namespace Functional.Runtime 
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.ComponentModel.Composition.Hosting;
    using System.Linq;
    using System.Text;

    using Antlr.Runtime;
    using Antlr.Runtime.Tree;

    using Microsoft.Scripting;
    using Microsoft.Scripting.Runtime;
    using Microsoft.Scripting.Utils;

    public sealed class FunctionalContext : LanguageContext
    {
        private readonly CompositionContainer container;

        public FunctionalContext(ScriptDomainManager domainManager, IDictionary<string, object> options)
            : base(domainManager)
        {
            this.container = this.CreateContainer();
            this.ConfigureContainer(this.container, domainManager);
        }

        public override ScriptCode CompileSourceCode(SourceUnit sourceUnit, CompilerOptions options, ErrorSink errorSink)  
        {
            try
            {
                var languageService = this.GetService<IFunctionalLanguageService>();
                ParseResult parseResult;
                using (var reader = sourceUnit.GetReader())
                {                    
                    switch (sourceUnit.Kind)
                    {
                        case SourceCodeKind.SingleStatement:
                        case SourceCodeKind.Expression:
                        case SourceCodeKind.AutoDetect:
                        case SourceCodeKind.InteractiveCode:
                            parseResult = languageService.ParseExpression(reader);
                            break;
                        case SourceCodeKind.Statements:
                        case SourceCodeKind.File:
                            parseResult = languageService.ParseFile(sourceUnit.Path, reader);
                            break;
                        default:
                            throw Assert.Unreachable;
                    }
                }

                return new FunctionalScriptCode(parseResult, sourceUnit);
            }
            catch (Exception ex) 
            {
                // Real language implementation would have a specific type
                // of exception.  Also, they would pass errorSink down into
                // the parser and add messages while doing tighter error
                // recovery and continuing to parse.
                errorSink.Add(sourceUnit, ex.Message, SourceSpan.None, 0, Severity.FatalError);
                return null;
            }
        }

        public override TService GetService<TService>(params object[] args)
        {
            var contractName = args.Length == 0 ? default(string) : args[0] as string;
            if (contractName == null)
            {
                return this.container.GetExportedValueOrDefault<TService>();
            }

            return this.container.GetExportedValueOrDefault<TService>(contractName);
        }        

        private CompositionContainer CreateContainer()
        {
            var assemblyCatalog = new AssemblyCatalog(this.GetType().Assembly);
            var aggregateCatalog = new AggregateCatalog(assemblyCatalog);
            return new CompositionContainer(aggregateCatalog);
        }

        private void ConfigureContainer(CompositionContainer theContainer, ScriptDomainManager domainManager)
        {
            var batch = new CompositionBatch();
            batch.AddExportedValue<IFunctionalLanguageService>(new FunctionalLanguageService(domainManager.GetLoadedAssemblyList(), domainManager.Globals));
            theContainer.Compose(batch);
        }
    }
}
