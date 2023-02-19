 
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_4
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
