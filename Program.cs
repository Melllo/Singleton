using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var text1 = FileStreamSingleton.getInstance();
            string s = "";
            for (; ;) {
                
                Console.WriteLine("Write new task in list(write / for show all list)");
                s = Console.ReadLine();
                if (s.Equals("/"))
                {
                    text1.ReadText();
                }
                else {
                    text1.WriteTask("+ " + s);
                    text1.Save();
                }
            }
            
            
           // text1.WriteTask("dsfdfsdf");
            //text1.Save();
            text1.ReadText();
        }
    }
}
