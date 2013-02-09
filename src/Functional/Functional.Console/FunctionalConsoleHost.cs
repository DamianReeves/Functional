namespace Functional.Console 
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Functional.Runtime;

    using Microsoft.Scripting.Hosting.Shell;

    internal class FunctionalConsoleHost : ConsoleHost
    {
        protected override Type Provider
        {
            get { return typeof(FunctionalContext); }
        }

        public static int Main(string[] args) 
        {
            return new FunctionalConsoleHost().Run(args);
        }

        protected override ConsoleOptions ParseOptions(string[] args, Microsoft.Scripting.Hosting.ScriptRuntimeSetup runtimeSetup, Microsoft.Scripting.Hosting.LanguageSetup languageSetup) 
        {
            var options = base.ParseOptions(args, runtimeSetup, languageSetup);
            options.TabCompletion = true;
            return options;
        }

        protected override IConsole CreateConsole(Microsoft.Scripting.Hosting.ScriptEngine engine, CommandLine commandLine, ConsoleOptions options) 
        {
            var console = base.CreateConsole(engine, commandLine, options);
            return console;
        }        
    }
}
