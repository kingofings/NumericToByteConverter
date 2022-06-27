using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumToByte
{
    internal class NumericToByte
    {
        public async Task<string> ConvertNumericToByteAsync(string input)
        {
            string returnVal = "Invalid entry";
            float floatValue;
            int intValue;
            if (float.TryParse(input, out floatValue))
            {
                returnVal = BitConverter.ToString(BitConverter.GetBytes(floatValue));
            }
            else if (int.TryParse(input, out intValue))
            {
                returnVal = BitConverter.ToString(BitConverter.GetBytes(intValue));
            }
            return returnVal = await FormatToSourcemodSyntaxAsync(returnVal);
        }

        private Task<string> FormatToSourcemodSyntaxAsync(string input)
        {
            string returnVal = input;
            if (input != "Invalid entry")
            {
                returnVal = "\\x" + input.Replace("-", "\\x");
            }
            return Task.FromResult<string>(returnVal);
        }
    }
}
