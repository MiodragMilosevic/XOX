using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_OX
{

    public partial class Form3 : Form
    {
        public static int NUM_OF_FIELD = 9;
        public static int NUM_OF_GAME = 5;

        static Random random = new Random();
        static bool PlayerVsComputer = false;
        static string player1 = "Player1", player2 = "Player2";
        int count1 = 0, count2 = 0, count = 0, numOfGame = 0;
        bool turn = true;

        public static void ChangedPlayerVsComputer(bool value)
        {
            PlayerVsComputer = value;
        }

        private Button randomize()
        {
            Button btn = null;
            int r;
            do
            {
                r = random.Next(9);
                switch (r)
                {
                    case 0: btn = A1; break;
                    case 1: btn = A2; break;
                    case 2: btn = A3; break;
                    case 3: btn = B1; break;
                    case 4: btn = B2; break;
                    case 5: btn = B3; break;
                    case 6: btn = C1; break;
                    case 7: btn = C2; break;
                    case 8: btn = C3; break;
                    default: break;
                }
            }
            while (btn.Enabled != true);
            return btn;
        }

        private void NumOfGame(Button btn)
        {
            numOfGame++;
            if (numOfGame % 2 == 0) turn = true;
            else
            {
                turn = false;
                if (PlayerVsComputer == true)
                {
                    btn = randomize();
                    if (turn == true) btn.Text = "X";
                    else btn.Text = "O";
                    btn.Enabled = false;
                    turn = !turn;
                }
            }
        }

        private void CheckIfPlayerVsComputer()
        {
            Button btn;
            DateTime time = DateTime.Now;

            while ((DateTime.Now - time).Seconds < 1);

            if (PlayerVsComputer == true)
            {
                btn = randomize();
                clickButtonAndDraw(btn);
                if (this.CheckIfWeHaveWinner())
                {
                    WhoIsTheWinner();
                    if ((count1 == NUM_OF_GAME) || (count2 == NUM_OF_GAME)) { EndGame(); return; }
                    else Reset();
                    NumOfGame(btn);
                    return;
                }
                count++;
                if (count == NUM_OF_FIELD)
                {
                    Reset();
                    NumOfGame(btn);
                    return;
                }
                turn = !turn;
            }
        }

        private bool CheckIfWeHaveWinner()
        {
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (A1.Text != "") && (A2.Text != "") && (A3.Text != "")) return true;
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (B1.Text != "") && (B2.Text != "") && (B3.Text != "")) return true;
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (C1.Text != "") && (C2.Text != "") && (C3.Text != "")) return true;

            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (A1.Text != "") && (B1.Text != "") && (C1.Text != "")) return true;
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (A2.Text != "") && (B2.Text != "") && (C2.Text != "")) return true;
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (A3.Text != "") && (B3.Text != "") && (C3.Text != "")) return true;

            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (A1.Text != "") && (B2.Text != "") && (C3.Text != "")) return true;
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (A3.Text != "") && (B2.Text != "") && (C1.Text != "")) return true;

            return false;
        }

        private void WhoIsTheWinner()
        {
            if (turn == true) count1++;
            else count2++;
            lbl3.Text = count1.ToString();
            lbl4.Text = count2.ToString();
        }

        private void EndGame()
        {
            if (lbl3.Text == "5") MessageBox.Show("Winner is " + lbl1.Text, "Winner");
            else MessageBox.Show("Winner is " + lbl2.Text, "Winner");
            count = 0;
            foreach (Control control in Controls)
            {
                Button btn;
                try
                {
                    btn = (Button)control;
                    btn.Text = "";
                    btn.Enabled = false;
                }
                catch (Exception) { }
            }
        }

        private void Reset()
        {
            count = 0;
            foreach (Control control in Controls)
            {
                Button btn;
                try
                {
                    btn = (Button)control;
                    btn.Text = "";
                    btn.Enabled = true;
                }
                catch (Exception) { }
            }
        }

        private void clickButtonAndDraw(Button btn)
        {
            if (turn == true) btn.Text = "X";
            else btn.Text = "O";
            btn.Enabled = false;
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Enabled == false) return;
            if (turn == true) btn.Text = "X";
            else btn.Text = "O";
            btn.ForeColor = Color.Orange;
        }

        private void Mouse_Leave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Enabled == false) return;
            btn.Text = "";
            btn.ForeColor = Color.Orange;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn =  (Button)sender;
            clickButtonAndDraw(btn);

            if (this.CheckIfWeHaveWinner())
            {
                WhoIsTheWinner();
                if ((count1 == NUM_OF_GAME) || (count2 == NUM_OF_GAME)) { EndGame(); return; }
                else Reset();
                NumOfGame(btn);
                return;
            }

            count++;
            if (count == NUM_OF_FIELD)
            {
                Reset();
                NumOfGame(btn);
                return;
            }
            turn = !turn;
            CheckIfPlayerVsComputer();
        }

        public static void ChangePlayer1(string name1)
        {
            player1 = name1;
        }

        public static void ChangePlayer2(string name2)
        {
            player2 = name2;
        }

        public Form3()
        {
            InitializeComponent();
            lbl1.Text = player1;
            lbl2.Text = player2;
            lbl3.Text = count1.ToString();
            lbl4.Text = count2.ToString();
        }

    }
}
