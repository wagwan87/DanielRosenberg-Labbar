using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Animal
{
    public class Frog : Amphibian
    {
        public int JumpLength
        { get; set; }

        public string Pattern
        { get; set; }

        public override string Move()
        {
            return String.Format(" {0} jumps all day :", base.Move());
        }

    }
}
