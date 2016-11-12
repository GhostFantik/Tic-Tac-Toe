using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF
{
    public partial class StartGame : Form
    {
        System.Int32 _mode = 3;
        System.Int32 _levelC = 0;
        public bool InMethod;
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

        public StartGame()
        {
            InitializeComponent();
           
        }
       /* public int Mode
        {
            get { return mode; }

        }  */  
        
       

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (checkTP.Checked)
                _mode = 0;
            else if (checkAI.Checked)
            {
                _mode = 1;
            }
            Form1.SetMode(_mode);
            if (_levelC != 0 || _mode == 0)
            {
                Form1.SetLevel(_levelC);
                this.Close();
            }
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkTP_CheckedChanged(object sender, EventArgs e)
        {
            Complexity.Enabled = false;
            LevelC_IZI.Checked = false;
            LevelC_Norm.Checked = false;
            buttonStart.Enabled = true;
        }

        private void checkAI_CheckedChanged(object sender, EventArgs e)
        {
            Complexity.Enabled = true;
            buttonStart.Enabled = false;
        }

        private void LevelC_IZI_CheckedChanged(object sender, EventArgs e)
        {
            buttonStart.Enabled = true;
            _levelC = 1;
        }

        private void LevelC_Norm_CheckedChanged(object sender, EventArgs e)
        {
            buttonStart.Enabled = true;
            _levelC = 2;
        }
    }
}
