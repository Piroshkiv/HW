namespace HW_2_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal static class Starter
{
    static Starter() => _random = new();

    private static Random _random; 
    private static Result getRandomLog()
    {
            
        switch (_random.Next(3))
        {
            case 0:
                return Actions.ErrorAction();
            case 1:
                return Actions.WarningAction();
            case 2:
                return Actions.InfoAction();
            default:
                throw new Exception("No method wih that number");
        }
    }

    public static void Run()
    {
        int n = 15;
        for (int i = 0; i < n; i++)
            Logger.GetLogger().AddLog(getRandomLog());
    }
}
