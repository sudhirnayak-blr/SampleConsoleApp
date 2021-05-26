using System;
using System.Threading.Tasks;


namespace SampleConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var counter=0; 
            var max = args.Length==0? -1: Convert.ToInt32(args[0]);
            while(max == -1 || counter < max){
                Console.WriteLine($"Counter: {++counter}");
                await Task.Delay(1000);
            }
        }
    }
}
