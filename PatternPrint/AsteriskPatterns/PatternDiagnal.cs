﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrint.AsteriskPatterns
{
    public class PatternDiagnal : PatternBase
    {
        public override string Print(int height)
        {
            StringBuilder asterisk = new StringBuilder();
            for (int row = 0; row < height; row++)
            {
                for (int column = 1; column <= (height * 2) - 1; column++)
                {
                    if (column >= (height - row) && column <= (height * 2) - 1 - row)
                    {
                        asterisk.Append("*");
                    }
                    else
                    {
                        asterisk.Append(" ");
                    }
                }
                asterisk.Append("\n");
            }

            return asterisk.ToString();
        }
    }
}
