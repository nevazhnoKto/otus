using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spacebattle
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var lastCommand = new LastCommand();
            var command3 = new Command3(lastCommand);
            var command2 = new Command2(command3);
            var command1 = new Command1(command2);

            await command1.ExecuteAsync();
            Console.ReadKey();
        }
    }
}
