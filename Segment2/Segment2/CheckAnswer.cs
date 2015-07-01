using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segment2
{
    class CheckAnswer
    {
        public string Check(Int32 answer)
        {
            string message = "Incorrect";

            if (answer < 1 || answer > 100)
            {
                message = "Should be between 1 and 100";
                return message;
            }
            
            if (answer == 42)
            {
                message = "Correct";
            }

            return message;
        }
    }
}
