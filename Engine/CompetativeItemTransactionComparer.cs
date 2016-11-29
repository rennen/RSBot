using System.Collections.Generic;
using Engine.Models;

namespace Engine
{
    public class CompetativeItemTransactionComparer : EqualityComparer<CompetativeItemTransaction>
    {
        public override bool Equals(CompetativeItemTransaction x, CompetativeItemTransaction y)
        {
            return x.TransactionId == y.TransactionId;
        }

        public override int GetHashCode(CompetativeItemTransaction obj)
        {
            return obj.TransactionId.GetHashCode();
        }
    }
}