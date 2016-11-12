using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class Xod
    {
        /*
         * 1 - X
         * 2 - O
         * 0 - N/A
         */
        public static int[,] combination = new int[8, 3] { { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 4, 8 }, { 6, 4, 2 } };
        public static int[] field = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int _Method;
        string _Text;
        bool _WhoseXod;
        public string win = "N/A";

        Source sourc = new Source(field, combination);
        public Xod(string Text, bool WhoseXod, int id_button)
        {
            _Method = id_button;
            _Text = Text;
            _WhoseXod = WhoseXod;
        }
        public string ReturnT
        {
            get
            {
                return _Text;
                
            }

        }// возвращает текст для кнопки
        public bool ReturnB {
            get
            {
                return _WhoseXod;
               
            }
        }//возвращает чей ход
        public static bool WorkAIComb(ref int cod) // false - опасности нет. true - опасность есть!
        {
            for(int i = 0; i < 8; i++)
            {
                if ( ( ( (field[combination[i, 0]]) == 1 && (field[combination[i, 1]]) == 1) ||
                        ((field[combination[i, 1]]) == 1 && (field[combination[i, 2]]) == 1) ||
                        ((field[combination[i, 0]]) == 1 && (field[combination[i, 2]]) == 1))  &&
                        ((field[combination[i,0]]) == 0 || (field[combination[i, 1]]) == 0 ||
                        (field[combination[i, 2]]) == 0 ))
                         
                    {
                        if(cod == i)
                        {
                            continue;
                        }
                        cod = i;
                        return true;
                    }
                   
            }
            return false;
        }
        public static bool WorkPlayerComb(ref int cod) // false - опасности нет. true - опасность есть!
        {
            for (int i = 0; i < 8; i++)
            {
                if ((((field[combination[i, 0]]) == 2 && (field[combination[i, 1]]) == 2) ||
                        ((field[combination[i, 1]]) == 2 && (field[combination[i, 2]]) == 2) ||
                        ((field[combination[i, 0]]) == 2 && (field[combination[i, 2]]) == 2)) &&
                        ((field[combination[i, 0]]) == 0 || (field[combination[i, 1]]) == 0 ||
                        (field[combination[i, 2]]) == 0))

                {
                    if (cod == i)
                    {
                        continue;
                    }
                    cod = i;
                    return true;
                }

            }
            return false;
        }
        public void Progress()
        {
            if(_Text == "N/A")
            {
                int val;
                if(_WhoseXod == false)
                {
                    val = 1;
                    _Text = "X";
                    _WhoseXod = true;
                    InputArray(val, _Method - 1);

                }
                else
                {
                    val = 2;
                    _Text = "O";
                    _WhoseXod = false;
                    InputArray(val, _Method - 1);
                }
            }
            win = sourc.Logick();// проверка выйгрыша.
        }// метод для совершения хода
        void InputArray(int val, int id)
        {
            if (val == 1)// X
            {
                field[id] = 1;
            }
            else // O
            {
                field[id] = 2;
            }
        }
       
    }
}
