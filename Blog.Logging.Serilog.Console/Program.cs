using System;
using Serilog;

namespace Blog.Logging.Serilog.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            Log.Logger = log;

            var a = 2;
            var b = 0;

            try
            {
                var c = a / b;
            }
            catch (Exception e)
            {
                Log.Fatal(e, "@{Message} a = @{a} b = @{b}",e.Message, a, b);
                //throw;
            }
        }
    }
}