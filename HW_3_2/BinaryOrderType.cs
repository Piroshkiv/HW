 
using System.Collections;
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_2
{
    public enum BinaryOrderType
    {
        InOrder,
        PreOrder,
        PostOrder
    }

    internal enum BinaryReturnOrder
    {
        left,
        value,
        right
    }

    internal static class BinaryOrderTypeHashtable
    {
        static BinaryOrderTypeHashtable()
        {

            Value = new();
            Value.Add(BinaryOrderType.InOrder, 
                new BinaryReturnOrder[] { BinaryReturnOrder.value, BinaryReturnOrder.left, BinaryReturnOrder.right });
            Value.Add(BinaryOrderType.InOrder,
                new BinaryReturnOrder[] { BinaryReturnOrder.left, BinaryReturnOrder.value, BinaryReturnOrder.right });
            Value.Add(BinaryOrderType.InOrder,
                new BinaryReturnOrder[] { BinaryReturnOrder.right, BinaryReturnOrder.value, BinaryReturnOrder.left });


        }

        internal static Dictionary<BinaryOrderType, BinaryReturnOrder[]> Value { get; private set; }

    }
}
