namespace Functional.Console
{
    using Functional.Hosting;

    internal class Host 
    {    
        public static int Main(string[] args) 
        {
            return FunctionalConsoleHost.Execute(args);
        }    
    }
}

