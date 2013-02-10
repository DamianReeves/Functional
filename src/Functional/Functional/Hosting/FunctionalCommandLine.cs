namespace Functional.Hosting
{
    using System;
    using System.Linq;
    using System.Diagnostics.CodeAnalysis;
    using Functional.Runtime;
    using Microsoft.Scripting.Hosting.Shell;

    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Reviewed. Suppression is OK here.")]
    internal class FunctionalCommandLine : CommandLine
    {
        private const ConsoleColor ErrorColor = ConsoleColor.Red;

        private string prompt = "FN> ";

        protected override string Prompt 
        {
            get { return this.prompt; }
        }        

        public void PrintError(Exception e) 
        {
            ConsoleColor cc = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ErrorColor;

            this.Console.ErrorOutput.WriteLine("{0}: {1}", e.GetType().Name, e.Message);

            if (e.InnerException != null) 
            {
                this.Console.ErrorOutput.WriteLine("{0}: {1}", e.InnerException.GetType().Name, e.InnerException.Message);
            }

            System.Console.ForegroundColor = cc;
        }

        protected override void Initialize() 
        {
            base.Initialize();
            this.prompt = "FN> ";
        }        

        protected override string ReadLine(int autoIndentSize) 
        {
            var lastLine = base.ReadLine(autoIndentSize);

            if (!string.IsNullOrEmpty(lastLine))
            {
                var handled = this.ProcessLine(lastLine);
                if (handled)
                {
                    return string.Empty;
                }
            }

            return lastLine;
        }        

        protected override void UnhandledException(Exception e) 
        {
            if (e is FunctionalException)
            {
                this.PrintError(e);
            }
            else
            {
                base.UnhandledException(e);
            }
        }

        private bool ProcessLine(string line)
        {
            var parts =
                from part in line.Split(' ').Select(p => p.Trim())
                where !string.IsNullOrEmpty(part)
                select part;

            var commands = parts.ToArray();
            if (commands.Length == 0)
            {
                return false;
            }

            if (commands[0].Equals(":q", StringComparison.OrdinalIgnoreCase) 
                || commands[0].Equals(":quit", StringComparison.OrdinalIgnoreCase) 
                || commands[0].Equals(":exit", StringComparison.OrdinalIgnoreCase))
            {
                this.Terminate(0);
                return true;
            }

            return false;
        }
    }
}