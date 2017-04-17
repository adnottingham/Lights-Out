using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightsOut
{
    class GamePuzzles
    {
        Puzzle[] list = new Puzzle[26];
        int currentPuzzle = 0;

        public GamePuzzles()
        {
            list[1] = new Puzzle(4);
            Puzzle p = list[1];
            p.addLight(2,0);
            p.addLight(2,2);
            p.addLight(2,4);
            p.addLight(5, 5);

            list[2] = new Puzzle(13);
            p = list[2];
            p.addLight(0, 0);
            p.addLight(0, 2);
            p.addLight(0, 4);
            p.addLight(1, 0);
            p.addLight(1, 2);
            p.addLight(1,4);
            p.addLight(3,0);
            p.addLight(3,2);
            p.addLight(3,4);
            p.addLight(4,0);
            p.addLight(4,2);
            p.addLight(4,4);
            p.addLight(5, 5);

            list[3] = new Puzzle(17);
            p = list[3];
            p.addLight(0, 1);
            p.addLight(0, 3);
            p.addLight(1,0);
            p.addLight(1,1);
            p.addLight(1,3);
            p.addLight(1,4);
            p.addLight(2,0);
            p.addLight(2,1);
            p.addLight(2,3);
            p.addLight(2,4);
            p.addLight(3,0);
            p.addLight(3,1);
            p.addLight(3,3);
            p.addLight(3,4);
            p.addLight(4,1);
            p.addLight(4,3);
            p.addLight(5, 5);

            list[4] = new Puzzle(11);
            p = list[4];
            p.addLight(1,0);
            p.addLight(1, 1);
            p.addLight(1, 3);
            p.addLight(1, 4);
            p.addLight(3,0);
            p.addLight(3,4);
            p.addLight(4,0);
            p.addLight(4,1);
            p.addLight(4,3);
            p.addLight(4,4);
            p.addLight(5, 5);

            list[5] = new Puzzle(19);
            p = list[5];
            p.addLight(0, 0);
            p.addLight(0, 1);
            p.addLight(0,2);
            p.addLight(0,3);
            p.addLight(1, 0);
            p.addLight(1,1);
            p.addLight(1, 2);
            p.addLight(1, 4);
            p.addLight(2, 0);
            p.addLight(2, 1);
            p.addLight(2, 2);
            p.addLight(2, 4);
            p.addLight(3, 3);
            p.addLight(3, 4);
            p.addLight(4, 0);
            p.addLight(4, 1);
            p.addLight(4, 3);
            p.addLight(4, 4);
            p.addLight(5, 5);


            list[6] = new Puzzle(10);
            p = list[6];
            p.addLight(2,0);
            p.addLight(2,2);
            p.addLight(2,4);
            p.addLight(3,0);
            p.addLight(3,2);
            p.addLight(3,4);
            p.addLight(4,1);
            p.addLight(4,2);
            p.addLight(4,3);
            p.addLight(5,5);


            list[7] = new Puzzle(15);
            p = list[7];
            p.addLight(0, 0);
            p.addLight(0, 1);
            p.addLight(0, 2);
            p.addLight(0, 3);
            p.addLight(1, 0);
            p.addLight(1, 4);
            p.addLight(2, 0);
            p.addLight(2, 4);
            p.addLight(3, 0);
            p.addLight(3, 4);
            p.addLight(4, 0);
            p.addLight(4, 1);
            p.addLight(4, 2);
            p.addLight(4, 3);
            p.addLight(5, 5);

            list[8] = new Puzzle(9);
            p = list[8];
            p.addLight(1, 2);
            p.addLight(2, 1);
            p.addLight(2, 3);
            p.addLight(3, 0);
            p.addLight(3, 2);
            p.addLight(3, 4);
            p.addLight(4, 1);
            p.addLight(4, 3);
            p.addLight(5, 5);

            list[9] = new Puzzle(17);
            p = list[9];
            p.addLight(0, 1);
            p.addLight(0, 3);
            p.addLight(1, 0);
            p.addLight(1, 1);
            p.addLight(1, 2);
            p.addLight(1, 3);
            p.addLight(1, 4);
            p.addLight(2, 1);
            p.addLight(2, 2);
            p.addLight(2, 3);
            p.addLight(3, 1);
            p.addLight(3, 3);
            p.addLight(3, 4);
            p.addLight(4, 0);
            p.addLight(4, 1);
            p.addLight(4, 2);
            p.addLight(5, 5);

            list[10] = new Puzzle(10);
            p = list[10];
            p.addLight(0, 1);
            p.addLight(0, 2);
            p.addLight(0, 3);
            p.addLight(1, 1);
            p.addLight(1, 2);
            p.addLight(1, 3);
            p.addLight(2, 1);
            p.addLight(2, 2);
            p.addLight(2, 3);
            p.addLight(5, 5);


            list[11] = new Puzzle(16);
            p = list[11];
            p.addLight(0, 0);
            p.addLight(0, 2);
            p.addLight(0, 4);
            p.addLight(1, 0);
            p.addLight(1, 2);
            p.addLight(1, 4);
            p.addLight(2, 0);
            p.addLight(2, 2);
            p.addLight(2, 4);
            p.addLight(3,0);
            p.addLight(3, 2);
            p.addLight(3, 4);
            p.addLight(4, 1);
            p.addLight(4, 2);
            p.addLight(4, 3);
            p.addLight(5, 5);

            list[12] = new Puzzle(17);
            p = list[12];
            p.addLight(0, 0);
            p.addLight(0, 1);
            p.addLight(0, 2);
            p.addLight(0, 3);
            p.addLight(0, 4);
            p.addLight(1, 1);
            p.addLight(1, 3);
            p.addLight(2, 0);
            p.addLight(2, 1);
            p.addLight(2,3);
            p.addLight(2, 4);
            p.addLight(3, 1);
            p.addLight(3,2);
            p.addLight(3,3);
            p.addLight(4, 1);
            p.addLight(4, 3);
            p.addLight(5, 5);

            list[13] = new Puzzle(9);
            p = list[13];
            p.addLight(0, 3);
            p.addLight(1,2);
            p.addLight(1, 4);
            p.addLight(2, 1);
            p.addLight(2, 4);
            p.addLight(3, 0);
            p.addLight(3, 2);
            p.addLight(4, 1);
            p.addLight(5,5);

            list[14] = new Puzzle(4);
            p = list[14];
            p.addLight(2,1);
            p.addLight(3,1);
            p.addLight(4,1);
            p.addLight(5, 5);

            list[15] = new Puzzle(3);
            p = list[15];
            p.addLight(1,1);
            p.addLight(3,1);
            p.addLight(5,5);

            list[16] = new Puzzle(10);
            p = list[16];
            p.addLight(0,0);
            p.addLight(1, 0);
            p.addLight(2,0);
            p.addLight(3,0);
            p.addLight(4,0);
            p.addLight(4,1);
            p.addLight(4,2);
            p.addLight(4,3);
            p.addLight(4,4);
            p.addLight(5, 5);

            list[17] = new Puzzle(10);
            p = list[17];
            p.addLight(2, 2);
            p.addLight(3,1);
            p.addLight(3,2);
            p.addLight(3,3);
            p.addLight(4,0);
            p.addLight(4,1);
            p.addLight(4,2);
            p.addLight(4, 3);
            p.addLight(4, 4);
            p.addLight(5, 5);


            list[18] = new Puzzle(10);
            p = list[18];
            p.addLight(0, 2);
            p.addLight(1, 1);
            p.addLight(1, 3);
            p.addLight(2,0);
            p.addLight(2,2);
            p.addLight(2,4);
            p.addLight(3,1);
            p.addLight(3,3);
            p.addLight(4, 2);
            p.addLight(5, 5);

            list[19] = new Puzzle(10);
            p = list[19];
            p.addLight(0, 0);
            p.addLight(0, 2);
            p.addLight(0,4);
            p.addLight(2,0);
            p.addLight(2,2);
            p.addLight(2, 4);
            p.addLight(4,0);
            p.addLight(4,2);
            p.addLight(4, 4);
            p.addLight(5, 5);

            list[20] = new Puzzle(3);
            p = list[20];
            p.addLight(2, 0);
            p.addLight(2, 4);
            p.addLight(5,5);

            list[21] = new Puzzle(11);
            p = list[21];
            p.addLight(0, 11);
            p.addLight(0, 2);
            p.addLight(0, 3);
            p.addLight(0, 4);
            p.addLight(1, 1);
            p.addLight(2, 1);
            p.addLight(2,2);
            p.addLight(2, 3);
            p.addLight(3,1);
            p.addLight(4, 1);
            p.addLight(5, 5);

            list[22] = new Puzzle(13);
            p = list[22];
            p.addLight(0, 1);
            p.addLight(0, 2);
            p.addLight(0, 3);
            p.addLight(1, 0);
            p.addLight(1, 4);
            p.addLight(2, 0);
            p.addLight(2, 4);
            p.addLight(3, 0);
            p.addLight(3, 4);
            p.addLight(4, 1);
            p.addLight(4, 2);
            p.addLight(4, 3);
            p.addLight(5, 5);

            list[23] = new Puzzle(7);
            p = list[23];
            p.addLight(2,2);
            p.addLight(2, 3);
            p.addLight(2, 4);
            p.addLight(3, 2);
            p.addLight(3,3);
            p.addLight(4, 2);
            p.addLight(5, 5);

            list[24] = new Puzzle(10);
            p = list[24];
            p.addLight(2, 0);
            p.addLight(2, 4);
            p.addLight(3, 0);
            p.addLight(3, 1);
            p.addLight(3, 2);
            p.addLight(3, 3);
            p.addLight(3, 4);
            p.addLight(4, 1);
            p.addLight(4, 4);
            p.addLight(5, 5);

            list[25] = new Puzzle(15);
            p = list[25];
            p.addLight(0, 0);
            p.addLight(1, 0);
            p.addLight(1, 1);
            p.addLight(2, 0);
            p.addLight(2, 1);
            p.addLight(2, 2);
            p.addLight(3, 0);
            p.addLight(3, 1);
            p.addLight(3, 2);
            p.addLight(3, 3);
            p.addLight(4, 1);
            p.addLight(4, 2);
            p.addLight(4, 3);
            p.addLight(4, 4);
            p.addLight(5, 5);





        }


        public void createPuzzle()
        {
            currentPuzzle++;
            //return list[currentPuzzle];
        }

        public Tuple<int, int> getNextLight()
        {
            return list[currentPuzzle].getNext();


        }

        public void restartPuzzle()
        {
            list[currentPuzzle].restart();
             
        }
    }
}
