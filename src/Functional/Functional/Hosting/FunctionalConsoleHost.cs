namespace Functional.Hosting 
{
    using System;

    using Functional.Runtime;

    using Microsoft.Scripting.Hosting.Shell;

    public class FunctionalConsoleHost : ConsoleHost
    {        
        protected override Type Provider
        {
            get { return typeof(FunctionalContext); }
        }

        public static int Execute(string[] args) 
        {
            return new FunctionalConsoleHost().Run(args);
        }

        protected override CommandLine CreateCommandLine() 
        {
            return new FunctionalCommandLine();
        }

        protected override ConsoleOptions ParseOptions(string[] args, Microsoft.Scripting.Hosting.ScriptRuntimeSetup runtimeSetup, Microsoft.Scripting.Hosting.LanguageSetup languageSetup) 
        {
            var options = base.ParseOptions(args, runtimeSetup, languageSetup);
            options.TabCompletion = true;
            options.ColorfulConsole = true;
            return options;
        }
    }
}
