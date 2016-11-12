using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library1;

namespace WF
{
    public partial class Form1 : Form
    {
       // public string Win = "N/A";
        public bool WhoseXod = false;
        bool[] draw = new bool[] {false, false, false, false, false,
                                    false, false, false ,false };// false - Text == N/A
                                                                 // true - Text != N/A
        bool[] XodAI = new bool[9];//это тоже для ИИ. 
        int cod = -1; // переменная хранит в какой из 8 комбинаций возникла опасность. -1 - опасности нет
        int cod2 = -1; // возможность выйграть
        int[] VD = new int[3]; // Победы/Ничьи. i = 0 - победы X; i = 1 - победы O; i = 2 - кол-во ничьих.

        /* False - X
           True - O    
             */
        static int _mode = 3;
        static int _levelC = 0;
        /* Описания кодов _levelC
         * Код 0 - не задан(2 игрока)
         * Код 1 - Izi
         * Код 2 - Normal
         */
        /*
         * Описание кодов _mode
         * Код 0 - 2 игрока
         * Код 1 - AI, игрок за X
         * Код 2 - AI, игрок за O(нет)
         * Код 3 - ожидание
         * */
        public Form1()
        {
            InitializeComponent();
            
        }
        
        public static void SetMode(int mode)
        {
            _mode = mode;
            
        }
        public static void SetLevel(int levelC)
        {
            _levelC = levelC;

        }

        void StartXod(Button b, int id_button)
        {
            //modeTest.Text = Convert.ToString(_mode);//for testing. Comment out the string!
            if (winner.Text == "N/A")
            {
                Xod x = new Xod(b.Text, WhoseXod, id_button);
                x.Progress();
                b.Text = x.ReturnT;
                WhoseXod = x.ReturnB;
                
                
                switch (WhoseXod)
                {
                    case false:
                        XodW.Text = "X";
                        break;
                    case true:
                        XodW.Text = "O";
                        if(_mode == 1)
                            AI(1);
                        break;
                }
                winner.Text = x.win;
                StatusButton();
                if (CheckButton() == true && winner.Text == "N/A")
                {
                    VD[2] += 1;
                    winner.Text = "Ничья";
                    EndGame(winner.Text);
                }
                else if (winner.Text != "N/A")
                {
                    if (winner.Text == "X")
                        VD[0] += 1;
                    else if (winner.Text == "O")
                        VD[1] += 1;
                    EndGame(winner.Text);

                }

            }
        }
        void EndGame(string WhoWin)
        {
            string premessage = "Выйграл: ";
            if (winner.Text == "Ничья")
                premessage = "Результат игры: ";


            string message = "Начать заного? " + premessage + WhoWin;
            DialogResult StartOver = MessageBox.Show(message, "Game", MessageBoxButtons.YesNo);
            if (StartOver == DialogResult.Yes)
            {
                 Restart();
                this.Restart();
               

            }
            else if (StartOver == DialogResult.No)
            {

                Form2 form = new Form2();
                form.Statistics(VD);
                form.ShowDialog();
                

            }
        }
        /*
        1 2 3
        4 5 6
        7 8 9
        */
        /*
           0 1 2
           3 4 5
           6 7 8
       */
        void AI(int player)// 1 - Х; 2 - О. 0 - N/A Для определение стороны за которую играет ИИ
        {
            
            bool danger = false; // название говорит само за себя:)
            bool winners = false; // если есть возможность выйграть
            int[] comb = new int[3];
            int[] field = Xod.field;
            if(field[4] == 1 && !XodAI[0])
            {
                AIXod(1);
                XodAI[0] = true;
                return;
            }
            else if(field[4] == 0 && !XodAI[0])
            {
                AIXod(5);
                XodAI[0] = true;
                return;
            }
            if(field[8] == 1 && !XodAI[1])
            {
                RandomAIXod();
                XodAI[1] = true;
                
            }
            
            if (_levelC == 2)//если ИЗИ то не выполнять это...
            {


                winners = Xod.WorkPlayerComb(ref cod2);

                if (winners)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        
                        if (field[Xod.combination[cod2, i]] == 0)
                        {
                            AIXod(Xod.combination[cod2, i] + 1);
                            return;
                        }
                    }
                }
            }
            
            danger = Xod.WorkAIComb(ref cod);
            if (danger)
            {
                for(int i = 0; i < 3; i++)
                {
                    /*
                    if(field[Xod.combination[cod,i]] == 1)
                    {
                        comb[i] = Xod.combination[cod, i];
                    }*/
                    if (field[Xod.combination[cod,i]] == 0)
                    {
                        AIXod(Xod.combination[cod, i] + 1);
                    }
                }

            }
            else
            {
                RandomAIXod();
            }
            
        }
        void RandomAIXod()
        {
            for (int i = 0; i < 9; i++)
                if (Xod.field[i] == 0)
                {
                    AIXod(i + 1);
                    break;
                }
        }// рандомный ход для ИИ.
        void AIXod(int number)
        {
           
           switch (number)
            {
                case 1:
                    if (Xod.field[number - 1] == 0)
                    {
                        button1_Click(null, null);
                    }
                    break;
                case 2:
                    if (Xod.field[number - 1] == 0)
                    {
                        button2_Click(null, null);
                    }
                    break;
                case 3:
                    if (Xod.field[number - 1] == 0)
                    {
                        button3_Click(null, null);
                    }
                    break;
                case 4:
                    if (Xod.field[number - 1] == 0)
                    {
                        button4_Click(null, null);
                    }
                    break;
                case 5:
                    if (Xod.field[number - 1] == 0)
                    {
                        button5_Click(null, null);
                    }
                    break;
                case 6:
                    if (Xod.field[number - 1] == 0)
                    {
                        button6_Click(null, null);
                    }
                    break;
                case 7:
                    if (Xod.field[number - 1] == 0)
                    {
                        button7_Click(null, null);
                    }
                    break;
                case 8:
                    if (Xod.field[number - 1] == 0)
                    {
                        button8_Click(null, null);
                    }
                    break;
                case 9:
                    if (Xod.field[number - 1] == 0)
                    {
                        button9_Click(null, null);
                    }
                    break;
            }
        }//метод для исполнения хода ИИ. Осторожно! Быдлокод. Рекомендую не открывать
        void Restart()
        {
            Button[] butt = new Button[9] { button1, button2, button3, button4, button5,
                                            button6, button7, button8, button9 };
            for (int i = 0; i < 9; i++)
            {
                Library1.Xod.field[i] = 0;
                butt[i].Text = "N/A";
                StatusButton();
                WhoseXod = false;
                winner.Text = "N/A";
               
                XodAI[i] = false;
                
            }
        }
        void StatusButton()
        {
            string[] status = new string[9] {button1.Text, button2.Text, button3.Text, button4.Text,
                                            button5.Text, button6.Text, button7.Text, button8.Text, button9.Text };
            for (int i = 0; i < 9; i++)
            {
                if (status[i] != "N/A")
                {
                    draw[i] = true;
                }
                else if (status[i] == "N/A")
                {
                    draw[i] = false;
                }
            }

        }
        bool CheckButton()
        {
            bool Normal = false;
            foreach (bool i in draw)
            {
                if (i == true)
                {
                    continue;
                }
                else if (i == false)
                {
                    Normal = false;
                    return Normal;
                }
            }
            Normal = true;
            return Normal;
        }
        //events
        #region
        private void button1_Click(object sender, EventArgs e)
        {
            
            StartXod(button1, 1);
            
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            StartXod(button2,2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartXod(button3, 3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StartXod(button4, 4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StartXod(button5, 5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StartXod(button6,6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StartXod(button7, 7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            StartXod(button8,8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            StartXod(button9, 9);
        }

        #endregion//events...
    }
}
