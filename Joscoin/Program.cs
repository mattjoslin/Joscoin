using System;
using Newtonsoft.Json;
using Formatting = System.Xml.Formatting;

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
            joscoin.AddBlock(new Block(DateTime.Now, null, "{sender:Henry,receiver:MaHesh,amount:10}"));
            joscoin.AddBlock(new Block(DateTime.Now, null, "{sender:MaHesh,receiver:Henry,amount:5}"));
            joscoin.AddBlock(new Block(DateTime.Now, null, "{sender:Mahesh,receiver:Henry,amount:5}"));

            var endTime = DateTime.Now;

            Console.WriteLine($"Duration: {endTime - startTime}");


            var json = JsonConvert.SerializeObject(joscoin, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine(json);


            Console.WriteLine($"Is Chain Valid: {joscoin.IsValid()}");

            Console.WriteLine($"Update amount to 1000");
            joscoin.Chain[1].Data = "{sender:Henry,receiver:MaHesh,amount:1000}";

            Console.WriteLine($"Is Chain Valid: {joscoin.IsValid()}");

           


            Console.ReadLine();
        }
    }
}
