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
            joscoin.CreateTransaction(new Transaction("Henry", "MaHesh", 10));
            joscoin.ProcessPendingTransactions("Bill");
            Console.WriteLine(JsonConvert.SerializeObject(joscoin, Formatting.Indented));

            joscoin.CreateTransaction(new Transaction("MaHesh", "Henry", 5));
            joscoin.CreateTransaction(new Transaction("MaHesh", "Henry", 5));
            joscoin.ProcessPendingTransactions("Bill");

            var endTime = DateTime.Now;

            Console.WriteLine($"Duration: {endTime - startTime}");

            Console.WriteLine("=========================");
            Console.WriteLine($"Henry' balance: {joscoin.GetBalance("Henry")}");
            Console.WriteLine($"MaHesh' balance: {joscoin.GetBalance("MaHesh")}");
            Console.WriteLine($"Bill' balance: {joscoin.GetBalance("Bill")}");

            Console.WriteLine("=========================");
            Console.WriteLine($"phillyCoin");
            Console.WriteLine(JsonConvert.SerializeObject(joscoin, Formatting.Indented));

            Console.ReadKey();

            Console.ReadLine();
        }
    }
}
