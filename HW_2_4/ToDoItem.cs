using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW_2_2
{
    internal class ToDoItem
    {
        public int ID { get; init; }
        public string Message { get; set; }
        public ToDoItem(int id, string message) => (ID, Message) = (id, message);


        public override string ToString()
        {
            return $"{ID} {Message}";
        }
    }
}
