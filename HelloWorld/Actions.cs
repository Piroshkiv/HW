using HW_2_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal static class Actions
    {
        public static Result InfoAction()
        {
            return new (LogStatus.Info, "some info", DateTime.Now);
        }
        public static Result WarningAction()
        {
            return new(LogStatus.Warning, "some warning", DateTime.Now);
        }
        public static Result ErrorAction()
        {
            return new(LogStatus.Error, "some error", DateTime.Now);
        }
    }
}
