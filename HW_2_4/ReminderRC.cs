using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW_2_2
{
    internal class ReminderRC : Reminder
    {
        public string Repetition { get; set; }

        public ReminderRC(int id, string message, TimeOnly time, string repetition) : base(id, message, time) =>
            Repetition = repetition;

        public override string ToString()
        {
            return base.ToString() + " " + Repetition;
        }

    }
}
