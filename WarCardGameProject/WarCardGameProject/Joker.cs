using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCardGameProject
{
    public class Joker : Card
    {
        public Joker(int value) : base(value, 14) { }

        public override string GetSuitAsString() => "Joker";

        public override string GetValueAsString() => "Joker";

        public override string ToString() => "Joker";
    }
}
