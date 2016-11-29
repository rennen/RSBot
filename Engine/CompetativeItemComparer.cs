using System.Collections.Generic;
using Engine.Models;

namespace Engine
{
    public class CompetativeItemComparer : EqualityComparer<CompetativeItem>
    {
        public override bool Equals(CompetativeItem x, CompetativeItem y)
        {
            return x.EbayId == y.EbayId;
        }

        public override int GetHashCode(CompetativeItem obj)
        {
            return obj.EbayId.GetHashCode();
        }
    }
}