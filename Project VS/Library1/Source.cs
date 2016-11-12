using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    class Source
    {
        //string _Method;
        int[] field;
        int[,] combination;
        string win = "N/A";

        public Source(int[] field, int[,] combination)
        {
            this.field = field;
            this.combination = combination;
        }
        public string Logick()
        {
            for (int i = 0; i < 8; i++)
            {
                //for (int k = 0; k < 3; k++)
                //{
                    if (field[combination[i, 0]] == 1 && field[combination[i, 1]] == 1 && field[combination[i, 2]] == 1)
                    {
                        
                        win = "X";
                        break;
                    }
                    else if (field[combination[i, 0]] == 2 && field[combination[i, 1]] == 2 && field[combination[i, 2]] == 2)
                    {
                        
                        win = "O";
                        break;
                    }
                //}
            }
            return win;
        }
    }
}
