﻿namespace HW_2_1;

using HelloWorld;
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
        
        Logger.getLogger().LogLevel = LogStatus.Info;
        Logger.getLogger().Output();

        using(StreamWriter writer = new StreamWriter("logs.txt"))
        {
            Logger.getLogger().Output(writer);
            writer.Close();
        }
    }
}
