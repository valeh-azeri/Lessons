using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XadnOGames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button firstClick, secondClick;
        int firstGamerScore, secondGamerScore = 0;

                
        private void ButtonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (firstClick==null)
            {
                firstClick = btn;
                firstClick.ForeColor = Color.Green;
                firstClick.Text = "X";
                CheckScore();
                secondClick = null;
                
                return;
            }

            secondClick = btn;
            secondClick.ForeColor = Color.Red;
            secondClick.Text = "O";
            CheckScore();
            firstClick = null;
        }

        private void btnScoreClear_Click(object sender, EventArgs e)
        {
            firstGamerScore = 0;
            secondGamerScore = 0;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is Button)
                {
                    Controls[i].Text = "";
                }
            }
            lblScoreFirsGamer1.Text = "";
            lblScoreGamer2.Text = "";
            btnReload.Text = "Oyuna Yenidən başla";
            btnScoreClear.Text = "Scoru Sıfırla";
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is Button)
                {
                    Controls[i].Enabled = true;
                }
            }
            btnReload.Enabled = true;
            btnScoreClear.Enabled = true;
        }

        public void CheckScore()
        {
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X"
                || btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X"
                || btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X"
                || btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X"
                || btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X"
                || btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X"
                || btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X"
                || btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    if (this.Controls[i] is Button)
                    {
                        Controls[i].Enabled = false;
                    }
                }
                btnReload.Enabled = true;
                btnScoreClear.Enabled = true;
                lblScoreFirsGamer1.ForeColor = Color.Green;
                firstGamerScore++;
                lblScoreFirsGamer1.Text = firstGamerScore + "Bal";
            }
            else if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O"
                || btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O"
                || btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O"
                || btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O"
                || btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O"
                || btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O"
                || btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O"
                || btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    if (this.Controls[i] is Button)
                    {
                        Controls[i].Enabled = false;
                    }
                }
                btnReload.Enabled = true;
                btnScoreClear.Enabled = true;
                lblScoreGamer2.ForeColor = Color.Red;
                secondGamerScore++;
                lblScoreGamer2.Text = secondGamerScore + " bal";
            }
            
            


        }
    }
}
