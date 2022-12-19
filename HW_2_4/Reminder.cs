using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW_2_2
{
    internal class Reminder : ToDoItem
    {
        public TimeOnly Time { get; set; }
        public Reminder(int id, string message, TimeOnly time) : base(id, message) => Time = time;
        public override string ToString()
        {
            return base.ToString() + " " + Time.ToString();
        }

    }
}
