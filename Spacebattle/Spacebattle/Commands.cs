using Spacebattle.Interface;

namespace Spacebattle
{
    class Command1 : ICommand
    {
        ICommand _next;
        public Command1(ICommand next) => _next = next;
        public async Task ExecuteAsync()
        {
            await _next.ExecuteAsync();
            Console.WriteLine("Команда1");
        }
    }

    class Command2 : ICommand
    {
        ICommand _next;
        public Command2(ICommand next) => _next = next;

        public async Task ExecuteAsync()
        {
            Console.WriteLine("Команда2");
            if (_next != null)
                await _next.ExecuteAsync();
        }
    }

    class Command3 : ICommand
    {
        ICommand _next;
        public Command3(ICommand next) => _next = next;

        public async Task ExecuteAsync()
        {
            Console.WriteLine("Команда3");
            if (_next != null)
                await _next.ExecuteAsync();
        }
    }

    class LastCommand : ICommand
    {
        public async Task ExecuteAsync()
        {
            await Task.Delay(500);
        }
    }
}
