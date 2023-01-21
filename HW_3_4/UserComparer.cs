using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_4
{
    internal class UserComparer : IEqualityComparer<User>
    {
        public bool Equals(User? x, User? y) => x.ID == y.ID;
        public int GetHashCode([DisallowNull] User obj) => obj.ID;
    }
}
