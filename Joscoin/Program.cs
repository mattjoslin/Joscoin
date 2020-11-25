using System;
using Newtonsoft.Json;

namespace Joscoin
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Console.WriteLine(@"
            //    _____                                          __                   ______                                   __               
            //   |     \                                        |  \                 /      \                                 |  \              
            //    \$$$$$  ______    _______   _______   ______   \$$ _______        |  $$$$$$\  ______   __    __   ______   _| $$_     ______  
            //      | $$ /      \  /       \ /       \ /      \ |  \|       \       | $$   \$$ /      \ |  \  |  \ /      \ |   $$ \   /      \ 
            // __   | $$|  $$$$$$\|  $$$$$$$|  $$$$$$$|  $$$$$$\| $$| $$$$$$$\      | $$      |  $$$$$$\| $$  | $$|  $$$$$$\ \$$$$$$  |  $$$$$$\
            //|  \  | $$| $$  | $$ \$$    \ | $$      | $$  | $$| $$| $$  | $$      | $$   __ | $$   \$$| $$  | $$| $$  | $$  | $$ __ | $$  | $$
            //| $$__| $$| $$__/ $$ _\$$$$$$\| $$_____ | $$__/ $$| $$| $$  | $$      | $$__/  \| $$      | $$__/ $$| $$__/ $$  | $$|  \| $$__/ $$
            // \$$    $$ \$$    $$|       $$ \$$     \ \$$    $$| $$| $$  | $$       \$$    $$| $$       \$$    $$| $$    $$   \$$  $$ \$$    $$
            //  \$$$$$$   \$$$$$$  \$$$$$$$   \$$$$$$$  \$$$$$$  \$$ \$$   \$$        \$$$$$$  \$$       _\$$$$$$$| $$$$$$$     \$$$$   \$$$$$$ 
            //                                                                                          |  \__| $$| $$                          
            //                                                                                           \$$    $$| $$                          
            //                                                                                            \$$$$$$  \$$                          
            //");


            var startTime = DateTime.Now;

            Blockchain joscoin = new Blockchain();
            joscoin.CreateTransaction(new Transaction("Ryan", "Nick", 10));
            joscoin.ProcessPendingTransactions("Matt");
            Console.WriteLine(JsonConvert.SerializeObject(joscoin, Formatting.Indented));

            joscoin.CreateTransaction(new Transaction("Nick", "Ryan", 5));
            joscoin.CreateTransaction(new Transaction("Nick", "Ryan", 5));
            joscoin.ProcessPendingTransactions("Matt");

            var endTime = DateTime.Now;

            Console.WriteLine($"Duration: {endTime - startTime}");

            Console.WriteLine("=========================");
            Console.WriteLine($"Ryan' balance: {joscoin.GetBalance("Ryan")}");
            Console.WriteLine($"Nick' balance: {joscoin.GetBalance("Nick")}");
            Console.WriteLine($"Matt' balance: {joscoin.GetBalance("Matt")}");

            Console.WriteLine("=========================");
            Console.WriteLine($"joscoin");
            Console.WriteLine(JsonConvert.SerializeObject(joscoin, Formatting.Indented));

            Console.ReadKey();

            Console.ReadLine();
        }
    }
}
