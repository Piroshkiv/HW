namespace HW_2_1;

using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

/// <summary>
/// the main program class.
/// </summary>
internal class Program
{
    private static void Main()
    {
        Starter.Run();
        
        Logger.GetLogger().LogLevel = LogStatus.Info;
        Logger.GetLogger().Output();

        using(StreamWriter writer = new StreamWriter("logs.txt"))
        {
            Logger.GetLogger().Output(writer);
            writer.Close();
        }
        Console.ReadLine();
    }
}
