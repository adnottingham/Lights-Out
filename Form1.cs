using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightsOut
{
    public partial class Form1 : Form
    {
        Light[,] lightArray = new Light[5, 5];
        int currentLevel = 1;
        int moves = 0;
        GamePuzzles game;
        public Form1()
        {
            InitializeComponent();
            game = new GamePuzzles();

            for (int r = 0; r< 5; r++)
            {
                for(int c =0; c < 5; c++)
                {
                    lightArray[r, c] = new Light(r, c, false);
                }
            }
            redraw();

            nextLevel();
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            Char[] chars = b.Name.ToCharArray();

            char row = chars[6];
            char column = chars[7];

            pressButton(row, column);
            
        }

        public void pressButton(char r, char c)
        {
            moves++;
            int row = (int)Char.GetNumericValue(r);
            int column =  (int)Char.GetNumericValue(c);
            lightArray[row, column].reverseLight();
            
            if (row != 0)
            {
                lightArray[row - 1, column].reverseLight();
            }
            if (row != 4)
            {
                lightArray[row + 1, column].reverseLight();
            }
            if (column != 0)
            {
                lightArray[row, column - 1].reverseLight();
            }
            if (column != 4)
            {
                lightArray[row, column + 1].reverseLight();
            }
            redraw();
            checkWin();

        }
        public void nextLevel()
        {
            game.createPuzzle();
            
            Tuple<int, int> next = game.getNextLight();
            
            //turn on the lights for the puzzle
            while (next.Item1 != 5)
            {
                lightArray[next.Item1, next.Item2].reverseLight();
                next = game.getNextLight();
            }
            redraw();

           
        }

        public void restartLevel()
        {
            moves = 0;
            game.restartPuzzle();
            Tuple<int, int> next = game.getNextLight();

            //turn off all lights
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    lightArray[r, c].lightOff();
                }
            }
            redraw();
            while (next.Item1 != 5)
            {
                lightArray[next.Item1, next.Item2].reverseLight();
                next = game.getNextLight();
            }
            redraw();
        }

        public void redraw()
        {
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(lightArray[r, c].onString());
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {

                    
                        foreach (Button s in panel1.Controls)
                        {

                            if (s.Name == "button" + r.ToString() + c.ToString())
                            {
                                if (lightArray[r, c].on)
                                {
                                    s.BackColor = Color.White;

                                }
                                else 
                                {
                                    s.BackColor = Color.Black;

                                }
                            }
                        }
                    
                    
                }
            }
        }



        public void checkWin()
        {
            bool finish = true;
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (lightArray[r,c].on)
                    {
                        finish = false;
                    }
                }
            }

            if (finish)
            {
                currentLevel++;
                MessageBox.Show("finished in " + moves + " moves!");
                moves = 0;

                if (currentLevel == 26)
                {
                    MessageBox.Show("You beat all the Levels!");
                }
                else
                {
                    nextLevel();
                }
            }
        }

        private void restartPuzzleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restartLevel();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game = new GamePuzzles();
            moves = 0;
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    lightArray[r, c] = new Light(r, c, false);
                }
            }
            redraw();

            nextLevel();
        }
    }
}
