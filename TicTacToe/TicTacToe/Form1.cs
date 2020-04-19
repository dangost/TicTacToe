using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {

        bool player_win = false;

        bool pick = false;
        bool is_win = false;
        static int pack_id;
        public static int sign = 0;

        public static int[] grid = new int[TicTac.count_of_buttons + 1];

        public static bool[] clicked = new bool[TicTac.count_of_buttons + 1];

        public static void create_clicked(bool res)
        {
            for (int i = 0; i < clicked.Length; i++)
            {
                clicked[i] = res;
            }
        }

        public static void create_grid(int res)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                grid[i] = res;
            }
        }

        public Form1()
        {
            MessageBox.Show("Dev. by FAFAFA");
            InitializeComponent();
            create_clicked(false);
            pack_id = TicTac.pack();
            create_grid(-1);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int button_id = 1;
            click_logic(button_id);

            mp_click(button_id);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int button_id = 2;

            click_logic(button_id);
            mp_click(button_id);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int button_id = 3;

            click_logic(button_id);
            mp_click(button_id);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int button_id = 4;

            click_logic(button_id);
            mp_click(button_id);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int button_id = 5;

            click_logic(button_id);
            mp_click(button_id);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            int button_id = 6;

            click_logic(button_id);
            mp_click(button_id);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int button_id = 7;

            click_logic(button_id);
            mp_click(button_id);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            int button_id = 8;
            click_logic(button_id);
            mp_click(button_id);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            int button_id = 9;

            click_logic(button_id);
            mp_click(button_id);
        }

        public void single_mod(int button_id)
        {
            int[] hehave;
            int[] wepick;
            int[] planb;

            if (!is_win && TicTac.iter < 9)
            {


                if (button_id == 1)
                {
                    hehave = new int[] { 3, 2, 7, 4, 9, 5 };
                    wepick = new int[] { 2, 3, 4, 7, 5, 9 };

                    planb = new int[] { 5, 6, 8 };

                    Counter_Cross(button_id, hehave, wepick, planb);
                }

                else if (button_id == 2)
                {
                    hehave = new int[] { 4, 8, 1, 3, 5, 8 };
                    wepick = new int[] { 5, 5, 3, 1, 8, 5, };

                    planb = new int[] { 1, 3, 5, 6, 4, 1, 3, 2, 9, 7, 8 };

                    Counter_Cross(button_id, hehave, wepick, planb);

                }

                else if (button_id == 3)
                {
                    hehave = new int[] { 7, 5, 7, 1, 2, 6, 9 };
                    wepick = new int[] { 2, 7, 5, 2, 1, 9, 6 };

                    planb = new int[] { 5, 4, 8 };

                    Counter_Cross(button_id, hehave, wepick, planb);
                }

                else if (button_id == 4)
                {
                    hehave = new int[] { 2, 8, 1, 7, 6, 5 };
                    wepick = new int[] { 5, 5, 7, 1, 5, 6 };

                    planb = new int[] { 1, 7, 5, 1, 9, 6, 8, 7, 2, 3, 4 };

                    Counter_Cross(button_id, hehave, wepick, planb);
                }

                else if (button_id == 5)
                {
                    hehave = new int[] { 1, 9, 3, 7, 2, 8, 4, 6 };
                    wepick = new int[] { 9, 1, 7, 3, 8, 2, 6, 4 };

                    planb = new int[] { 1, 9, 3, 7, 2, 6, 4, 8 };

                    Counter_Cross(button_id, hehave, wepick, planb);
                }

                else if (button_id == 6)
                {
                    hehave = new int[] { 3, 9, 4, 5 };
                    wepick = new int[] { 9, 3, 5, 4 };

                    planb = new int[] {5, 3, 9, 1, 7, 2, 8, 3, 9, 4, 6 };

                    Counter_Cross(button_id, hehave, wepick, planb);
                }

                else if (button_id == 7)
                {
                    hehave = new int[] { 1, 4, 8, 9, 5, 3, 3 };
                    wepick = new int[] { 4, 1, 9, 8, 3, 5, 2 };

                    planb = new int[] { 5, 9, 1, 2, 6 };

                    Counter_Cross(button_id, hehave, wepick, planb);
                }

                else if (button_id == 8)
                {
                    hehave = new int[] { 4, 6, 7, 9, 2, 5 };
                    wepick = new int[] { 5, 5, 9, 7, 5, 2 };

                    planb = new int[] { 2, 7, 9, 5, 7, 5, 1, 3, 9, 7, 8, 4, 6, 2 };

                    Counter_Cross(button_id, hehave, wepick, planb);
                }

                else if (button_id == 9)
                {

                    hehave = new int[] { 5, 1, 5, 3, 6, 7, 8, 1 };
                    wepick = new int[] { 7, 5, 1, 6, 3, 8, 7, 2 };

                    planb = new int[] { 5, 8, 4, 1, 2, 3, 5, 6 };

                    Counter_Cross(button_id, hehave, wepick, planb);
                }
            }

            if (TicTac.iter >= 9)
            {
                TicTac.iter = 0;
            }

        }



        public void bot_iter(int button_id, int cell)
        {
            if (!player_win)
            {
                PictureBox pictureBox = pictureBox1;

                if (cell == 1)
                {
                    pictureBox = pictureBox1;
                }

                else if (cell == 2)
                {
                    pictureBox = pictureBox2;
                }

                else if (cell == 3)
                {
                    pictureBox = pictureBox3;
                }

                else if (cell == 4)
                {
                    pictureBox = pictureBox4;
                }

                else if (cell == 5)
                {
                    pictureBox = pictureBox5;
                }

                else if (cell == 6)
                {
                    pictureBox = pictureBox6;
                }

                else if (cell == 7)
                {
                    pictureBox = pictureBox7;
                }

                else if (cell == 8)
                {
                    pictureBox = pictureBox8;
                }

                else if (cell == 9)
                {
                    pictureBox = pictureBox9;
                }
                if (clicked[cell] == false)
                {
                    check_win();
                    if (!is_win)
                    {
                        check_win();
                        clicked[cell] = true;
                        grid[cell] = 0;

                        pictureBox.Image = Image.FromFile($"icons\\packs\\pack{pack_id}\\{sign % 2}.png");

                        sign++;
                        if (TicTac.iter == 9)
                        {

                            Newgame();
                            TicTac.iter = 0;
                        }

                        if (player_win)
                        {

                            Newgame();
                            TicTac.iter = 0;
                        }
                        TicTac.iter++;




                    }
                }
            }
        }


        public void click_logic(int button_id)
        {
            if (!TicTac.is_multyp)
            {
                label1.Text = "You: ";
                PictureBox pictureBox = pictureBox1;
                if (button_id == 1)
                {
                    pictureBox = pictureBox1;
                }

                else if (button_id == 2)
                {
                    pictureBox = pictureBox2;
                }

                else if (button_id == 3)
                {
                    pictureBox = pictureBox3;
                }

                else if (button_id == 4)
                {
                    pictureBox = pictureBox4;
                }

                else if (button_id == 5)
                {
                    pictureBox = pictureBox5;
                }

                else if (button_id == 6)
                {
                    pictureBox = pictureBox6;
                }

                else if (button_id == 7)
                {
                    pictureBox = pictureBox7;
                }

                else if (button_id == 8)
                {
                    pictureBox = pictureBox8;
                }

                else if (button_id == 9)
                {
                    pictureBox = pictureBox9;
                }




                if (clicked[button_id] == false)
                {
                    clicked[button_id] = true;

                    grid[button_id] = 1;
                    label();

                    pictureBox.Image = Image.FromFile($"icons\\packs\\pack{pack_id}\\{sign % 2}.png");

                    check_win();
                    sign++;
                    TicTac.iter++;

                    if (!is_win)
                    {
                        check_win();
                        if (TicTac.iter != 9)
                        {
                            check_win();
                            if (!is_win)
                            {

                                single_mod(button_id);
                                check_win();
                            }
                        }

                        if (TicTac.iter == 9)
                        {

                            Newgame();
                            TicTac.iter = 0;
                        }

                    }

                }
            }
        }

        public void ConterPick(int button_id, int hehave, int wepick)
        {


            if (grid[hehave] == 1 && grid[wepick] != 1)
            {
                bot_iter(button_id, wepick);

                pick = true;
            }

        }

        public void Counter_B(int button_id, int cell)
        {
            if (grid[cell] == -1)
            {
                bot_iter(button_id, cell);

                pick = true;
            }
        }

        public void Counter_Cross(int button_id, int[] hehave, int[] wepick, int[] planb)
        {

            int[] firstcell = { 1, 1, 2, 4, 4, 5, 7, 7, 8, 1, 1, 7, 2, 2, 8, 3, 3, 6, 1, 1, 9, 3, 3, 5 };
            int[] secondcell = { 2, 3, 3, 5, 6, 6, 8, 9, 9, 4, 7, 4, 5, 8, 5, 6, 9, 9, 5, 9, 5, 5, 7, 7 };
            int[] goalcell = { 3, 2, 1, 6, 5, 4, 9, 8, 7, 7, 4, 1, 8, 5, 2, 9, 6, 3, 9, 5, 1, 7, 5, 3 };


            //if (TicTac.iter < 9 && player_win == false)
            {
                //if (pick_if2(button_id))
                // return;
                while (pick == false)
                {



                    for (int i = 0; i < firstcell.Length; i++)
                    {
                        if (grid[firstcell[i]] == 0 && grid[secondcell[i]] == 0 && grid[goalcell[i]] == -1)
                        {
                            bot_iter(button_id, goalcell[i]);

                            pick = true;
                            break;
                        }

                    }

                    if (pick == true)
                    {
                        break;
                    }


                    for (int i = 0; i < hehave.Length; i++)
                    {
                        if (grid[hehave[i]] == 1 && grid[wepick[i]] == -1)
                        {
                            bot_iter(button_id, wepick[i]);

                            pick = true;
                            break;
                        }
                    }
                    if (pick == true)
                    {
                        break;
                    }

                    for (int i = 0; i < planb.Length; i++)
                    {

                        if (grid[planb[i]] == -1)
                        {
                            bot_iter(button_id, planb[i]);

                            pick = true;
                            break;
                        }
                        if (pick == true)
                        {
                            break;
                        }

                    }



                }

                pick = false;
            }
            player_win = true;
        }



        public void Newgame()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;

            pictureBox10.Image = null;
            pictureBox11.Image = null;
            label1.Text = null;
            label2.Text = null;
            is_win = false;
            TicTac.is_multyp = false;
            TicTac.mp_sign = 1;
            sign = TicTac.Creating();
            create_clicked(false);
            pack_id = TicTac.pack();
            create_grid(-1);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Newgame();
            TicTac.iter = 0;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
                "  Developed by FAFAFA Inc." +
                "\n");
        }

        public void Win()
        {
            MessageBox.Show("You Win!\n     :)");
        }

        public void Lose()
        {
            MessageBox.Show("You Lose.\n    :(");
        }

        public void DeadHead()
        {
            MessageBox.Show("Dead Heat!\n    :D");
        }

        public bool check_win()
        {
            player_win = false;
            bool res = false;

            PictureBox p1 = pictureBox1;
            PictureBox p2 = pictureBox2;
            PictureBox p3 = pictureBox3;
            PictureBox p4 = pictureBox4;
            PictureBox p5 = pictureBox5;
            PictureBox p6 = pictureBox6;
            PictureBox p7 = pictureBox7;
            PictureBox p8 = pictureBox8;
            PictureBox p9 = pictureBox9;

            int winner = -1;

            if (grid[1] == grid[5] && grid[1] == grid[9] && grid[5] == grid[9] && grid[1] != -1 && grid[5] != -1 && grid[9] != -1)
            {
                if (!TicTac.is_multyp)
                {
                    is_win = true;
                    winner = grid[1];
                    res = true;
                }

                else
                {
                    is_win = true;
                    winner = grid[1];
                }
            }

            else if (grid[3] == grid[5] && grid[3] == grid[7] && grid[5] == grid[7] && grid[3] != -1 && grid[5] != -1 && grid[7] != -1)
            {
                if (!TicTac.is_multyp)
                {
                    is_win = true;
                    winner = grid[3];
                    res = true;
                }

                else
                {
                    is_win = true;
                    winner = grid[3];
                }
            }

            else if (grid[1] == grid[2] && grid[1] == grid[3] && grid[2] == grid[3] && grid[1] != -1 && grid[2] != -1 && grid[3] != -1)
            {
                if (!TicTac.is_multyp)
                {
                    is_win = true;
                    winner = grid[1];
                    res = true;
                }

                else
                {
                    is_win = true;
                    winner = grid[1];
                }
            }

            else if (grid[4] == grid[5] && grid[4] == grid[6] && grid[5] == grid[6] && grid[4] != -1 && grid[5] != -1 && grid[5] != -1)
            {
                if (!TicTac.is_multyp)
                {
                    is_win = true;
                    winner = grid[4];
                    res = true;
                }

                else
                {
                    is_win = true;
                    winner = grid[4];
                }
            }

            else if (grid[7] == grid[8] && grid[7] == grid[9] && grid[8] == grid[9] && grid[7] != -1 && grid[8] != -1 && grid[9] != -1)
            {
                if (!TicTac.is_multyp)
                {
                    is_win = true;
                    winner = grid[7];
                    res = true;
                }

                else
                {
                    is_win = true;
                    winner = grid[7];
                }
            }

            else if (grid[1] == grid[4] && grid[1] == grid[7] && grid[4] == grid[7] && grid[1] != -1 && grid[4] != -1 && grid[7] != -1)
            {
                if (!TicTac.is_multyp)
                {
                    is_win = true;
                    winner = grid[1];
                    res = true;
                }

                else
                {
                    is_win = true;
                    winner = grid[1];
                }
            }

            else if (grid[2] == grid[5] && grid[2] == grid[8] && grid[5] == grid[8] && grid[2] != -1 && grid[5] != -1 && grid[8] != -1)
            {
                if (!TicTac.is_multyp)
                {
                    is_win = true;
                    winner = grid[2];
                    res = true;
                }

                else
                {
                    is_win = true;
                    winner = grid[2];
                }
            }

            else if (grid[3] == grid[6] && grid[3] == grid[9] && grid[6] == grid[9] && grid[3] != -1 && grid[6] != -1 && grid[9] != -1)
            {
                if (!TicTac.is_multyp)
                {
                    is_win = true;
                    winner = grid[3];
                    res = true;
                }

                else
                {
                    is_win = true;
                    winner = grid[3];
                }
            }

            if (!TicTac.is_multyp)
            {
                if (is_win)
                {
                    is_win = false;
                    if (winner == 0)
                    {
                        TicTac.iter = 0;
                        Lose();

                    }

                    else if (winner == 1)
                    {
                        TicTac.iter = 9;
                        Win();
                        player_win = true;
                    }



                    Newgame();

                }

                else if (TicTac.iter == 9)
                {
                    is_win = false;
                    DeadHead();
                    Newgame();


                    if (TicTac.iter == 9)
                    {

                        Newgame();

                    }
                }

                if (TicTac.iter == 9)
                {
                    is_win = false;

                    Newgame();


                    if (TicTac.iter == 9)
                    {

                        Newgame();

                    }
                }
            }
            else
            {

                if (is_win)
                {
                    if (winner == TicTac.player1_id)
                    {
                        pictureBox10.Image = null;
                        pictureBox11.Image = null;
                        TicTac.player1_score++;
                        MessageBox.Show($"{TicTac.player1} Win!");

                        label3.Text = $"{TicTac.player1_score} : {TicTac.player2_score}";

                        TicTac.mp_sign = 1;
                        newmp();
                    }

                    else if (winner == TicTac.player2_id)
                    {
                        pictureBox10.Image = null;
                        pictureBox11.Image = null;

                        TicTac.player2_score++;
                        MessageBox.Show($"{TicTac.player2} Win!");
                        label3.Text = $"{TicTac.player1_score} : {TicTac.player2_score}";

                        TicTac.mp_sign = 1;
                        newmp();
                    }
                    Newgame();
                    TicTac.is_multyp = true;
                    TicTac.iter = 0;
                    label1.Text = null;
                    pictureBox10.Image = null;

                    label2.Text = null;
                    pictureBox11.Image = null;
                    label1.Text = TicTac.player1;
                    pictureBox10.Image = Image.FromFile($"icons\\packs\\pack{pack_id}\\{TicTac.player1_id}.png");

                    label2.Text = TicTac.player2;
                    pictureBox11.Image = Image.FromFile($"icons\\packs\\pack{pack_id}\\{TicTac.player2_id}.png");
                }
                else if (TicTac.iter == 9)
                {
                    pictureBox10.Image = null;
                    pictureBox11.Image = null;
                    DeadHead();
                    Newgame();
                    TicTac.is_multyp = true;
                    TicTac.iter = 0;
                    label1.Text = null;
                    pictureBox10.Image = null;

                    label2.Text = null;
                    pictureBox11.Image = null;
                    label1.Text = TicTac.player1;
                    pictureBox10.Image = Image.FromFile($"icons\\packs\\pack{pack_id}\\{TicTac.player1_id}.png");

                    label2.Text = TicTac.player2;
                    pictureBox11.Image = Image.FromFile($"icons\\packs\\pack{pack_id}\\{TicTac.player2_id}.png");
                }
            }
            return res;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        public void label()
        {

            pictureBox10.Image = Image.FromFile($"icons\\packs\\pack{pack_id}\\{sign % 2}.png");
        }

        public bool pick_if2(int button_id)
        {
            bool res = false;
            int[] firstcell = { 1, 1, 2, 4, 4, 5, 7, 7, 8, 1, 1, 7, 2, 2, 8, 3, 3, 6, 1, 1, 9, 3, 3, 5 };
            int[] secondcell = { 2, 3, 3, 5, 6, 6, 8, 9, 9, 4, 7, 4, 5, 8, 5, 6, 9, 9, 5, 9, 5, 5, 7, 7 };
            int[] goalcell = { 3, 2, 1, 6, 5, 4, 9, 8, 7, 7, 4, 1, 8, 5, 2, 9, 6, 3, 9, 5, 1, 7, 5, 3 };
            int i = 0;

            while (!pick && i < firstcell.Length)
            {

                for (; i < firstcell.Length; i++)
                {
                    if (grid[firstcell[i]] == 0 && grid[secondcell[i]] == 0)
                    {
                        bot_iter(button_id, goalcell[i]);

                        pick = true;
                        break;
                    }

                }

                if (pick == true)
                {
                    res = true;
                    break;
                }
            }

            return res;
        }

        private void multiplayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            if (TicTac.is_multyp)
            {
                TicTac.player1_score = 0;
                TicTac.player2_score = 0;
                newmp();
            }
        }

        public void mp_click(int button_id)
        {
            if (TicTac.is_multyp)
            {
                if (!clicked[button_id])
                {

                    if(label1.ForeColor == Color.Red)
                    {
                        label1.ForeColor = Color.Black;
                        label2.ForeColor = Color.Red;
                    }

                    else if(label2.ForeColor == Color.Red)
                    {
                        label2.ForeColor = Color.Black;
                        label1.ForeColor = Color.Red;
                    }


                    /*label1.Text = TicTac.player1;
                    pictureBox10.Image = Image.FromFile($"icons\\packs\\pack{pack_id}\\{TicTac.player1_id}.png");

                    label2.Text = TicTac.player2;
                    pictureBox11.Image = Image.FromFile($"icons\\packs\\pack{pack_id}\\{TicTac.player2_id}.png");
                    */
                    clicked[button_id] = true;
                    grid[button_id] = TicTac.mp_sign % 2;
                    mp_draw(button_id);
                    TicTac.iter++;
                    TicTac.mp_sign++;
                    check_win();
                }
            }
        }

        public void mp_draw(int button_id)
        {
            PictureBox pictureBox = pictureBox1;
            if (button_id == 1)
            {
                pictureBox = pictureBox1;
            }

            else if (button_id == 2)
            {
                pictureBox = pictureBox2;
            }

            else if (button_id == 3)
            {
                pictureBox = pictureBox3;
            }

            else if (button_id == 4)
            {
                pictureBox = pictureBox4;
            }

            else if (button_id == 5)
            {
                pictureBox = pictureBox5;
            }

            else if (button_id == 6)
            {
                pictureBox = pictureBox6;
            }

            else if (button_id == 7)
            {
                pictureBox = pictureBox7;
            }

            else if (button_id == 8)
            {
                pictureBox = pictureBox8;
            }

            else if (button_id == 9)
            {
                pictureBox = pictureBox9;
            }





            {
                clicked[button_id] = true;

                pictureBox.Image = Image.FromFile($"icons\\packs\\pack{pack_id}\\{TicTac.mp_sign % 2}.png");
            }
        }

        public void newmp()
        {
            Newgame();
            TicTac.is_multyp = true;
            TicTac.iter = 0;
            label1.Text = null;
            pictureBox10.Image = null;
            label3.Text = $"{TicTac.player1_score} : {TicTac.player2_score}";
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            pictureBox10.Image = null;
            pictureBox11.Image = null;
            label2.Text = null;
            TicTac.mp_sign = 1;
            pictureBox11.Image = null;
            TicTac.FirstPlayer();
            label1.Text = TicTac.player1;
            pictureBox10.Image = Image.FromFile($"icons\\packs\\pack{pack_id}\\{TicTac.player1_id}.png");

            label2.Text = TicTac.player2;
            pictureBox11.Image = Image.FromFile($"icons\\packs\\pack{pack_id}\\{TicTac.player2_id}.png");

            //sign++;

            

            if (TicTac.player1_id == 1)
            {
                MP_Message(TicTac.player1);
                
            }
            else if (TicTac.player2_id == 1)
            {
                MP_Message(TicTac.player2);
                
            }


            if (TicTac.player1_id == 1)
            {
                label1.ForeColor = Color.Red;
            }
            else if (TicTac.player2_id == 1)
            {
                label2.ForeColor = Color.Red;
            }
        }


        public void MP_Message(string name)
        {
            MessageBox.Show($"{name} will be the first.");
        }


    }


}

