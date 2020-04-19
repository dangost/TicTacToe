using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTac
    {
        public static string player1 = "Egor";
        public static string player2 = "Artem";

        public static int player1_id = -1;
        public static int player2_id = -1;


        public static int player1_score = 0;
        public static int player2_score = 0;

        public static byte count_of_packs = 20;
        public static byte count_of_buttons = 9;

        public static byte sign = 1;
        public static byte mp_sign = 1;

        public static byte iter = 0;

        public static bool is_single = false;
        public static bool is_multyp = false;

        public static int time_of_waiting = 50;

        public static int Creating()
        {
            Random random = new Random();   //  0 - O
            sign = Convert.ToByte(random.Next(0, 1));       //  1 - X

            return sign;

        }   

        public static int pack()
        {
            int pack_id = 0;
            Random random = new Random();
            pack_id = random.Next(1, count_of_packs+1);

            return pack_id;
        }

        public static void FirstPlayer()
        {
            Random random = new Random();

            int player = random.Next(1, 3);
            
            switch(player)
            {
                case 1:
                    player1_id = 1;
                    player2_id = 0;
                    break;

                case 2:
                    player1_id = 0;
                    player2_id = 1;                    
                    break;
            }
        }
    }
}
