using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FavourTomGame

{
    
    public partial class MarioGame : Form
    {
        bool right;
        bool left;
        int tomLife = 3;
        int SCORE;
        //Global variables to hold the instantaneous positions of the foods.

        public MarioGame()                      //This is a constructor.
        {
           InitializeComponent();          
            //This is where the initialise the members of the class (Form1)

            //Initialising the initial positions of the pictures
            brickPic1.Location = new Point(brickPic1.Location.X, brickPic1.Location.Y - 60);
            brickPic2.Location = new Point(brickPic2.Location.X, brickPic2.Location.Y - 120);
            brickPic3.Location = new Point(brickPic3.Location.X, brickPic3.Location.Y - 80);
            
            Chips.Location = new Point(598, 135);
            Chicken.Location = new Point(598, 135); Pizza.Location = new Point(598, 135);

            //Making the background of the food pictureBoxes to be transparent
            Burger.BackColor = Color.Transparent;   Chicken.BackColor = Color.Transparent;
            Pizza.BackColor = Color.Transparent;    Chips.BackColor = Color.Transparent;

            backPicTimer.Enabled = true;
            backPicTimer.Start();
            foodInstantTimer.Enabled = true;
            foodInstantTimer.Start();

            timer1.Enabled = true;
            timer1.Start();

            tomLife = 3;                        //Making MarioLife
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Chips.Visible = false; Chicken.Visible = false; Pizza.Visible = false; // make picturebox visible on screem.
        }

        private void backPicTimer_Tick(object sender, EventArgs e)
        {
            moveFallingObjects();

            if (SCORE == 20)                    //Take the player to the next level or display a congratulatory message.
            {
                backPicTimer.Stop(); backPicTimer.Enabled = false;

                MessageBox.Show("Level Complete you won");//show when you complete the game.

                this.Close();

                new MainMenu().Show();             //Take us to the main menu form.
            
            }

            if (tomLife <= 0)// function for Mario life 
            {
                Sound snd = new Sound();
                backPicTimer.Stop(); backPicTimer.Enabled = false;
                MessageBox.Show("Game Over\nMario is Dead!!!");//display if game is over or loss
                snd.PlaySound();
                this.Close();
                new MainMenu().Show();
              }
        }

        private void foodInstantTimer_Tick(object sender, EventArgs e)
        {
            //Incrementing and decrementing the foods' positions in order to slide them over.
            
        }

        private void moveFallingObjects()
        {
            //Making the bricks and foods to move from up to down as the time ticks.

            brickPic1.Location = new Point(brickPic1.Location.X, brickPic1.Location.Y + 10);
            brickPic2.Location = new Point(brickPic2.Location.X, brickPic2.Location.Y + 10);
            brickPic3.Location = new Point(brickPic3.Location.X, brickPic3.Location.Y + 10);

            if (brickPic1.Location.Y == 330)
            {
                brickPic1.Location = new Point(brickPic1.Location.X - 30, 0);

               // Check if the picturebox is going off the form.

                if (brickPic1.Location.X <= 0)
                {
                    //Make the brick to return to the initial X-axis position.

                    brickPic1.Location = new Point(185, 0);//lcation
                }
            }

            if (brickPic2.Location.Y == 330)//location for Y aixs brickpic2
            {
                brickPic2.Location = new Point(brickPic2.Location.X - 3, 0);//create new position location for brickpic3.

                if (brickPic2.Location.X <= 169)//location for X aixs brickpics
                {
                    brickPic2.Location = new Point(744, 0);//create new position location for brickpic3.
                }
            }

            if (brickPic3.Location.Y == 330)// location for Y aixs for brickpic3
            {
                brickPic3.Location = new Point(brickPic3.Location.X + 50);//create new position location for brickpic3.

                if (brickPic3.Location.X >= 776)//location for brickpic3 X aixs 
                {
                    brickPic3.Location = new Point(347, 0);//create new position location for brickpic3.
                }
            }

        }

        private void Chicken_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (right == true) 
            {
                MarioCharacter.Left += 5; // value set to move Mario.

                if (MarioCharacter.Location.X >= 808)//location for Mario character in X aixs.
                {
                    timer1.Stop();
                    timer1.Enabled = false;

                    right = false;
                }
                //pictureBox2.Left = pictureBox2.Left + 5;
            }

            if (left == true)
            {
                MarioCharacter.Left -= 5;// value set to move Mario.
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            Point MoveMario;//decare a point for player picturebox
            MoveMario = MarioCharacter.Location;//intilize the point with the picturebox location 

            if (e.KeyCode == Keys.Left)//using the leftarrow key to move the player
            {
                MoveMario.X -= 10;//decrement the X coordinate
                MarioCharacter.Location = MoveMario;//set the  new location to the new coordinate
            }
            if (e.KeyCode == Keys.Right)//using the leftarrow key to move the player
            {
                MoveMario.X += 10;//Increment the X coordinate
                MarioCharacter.Location = MoveMario;//set the  new location to the new coordinate
            }
           
            if (MoveMario.X <= -10) //decrement the X coordinate
            {
               MoveMario.X = 810;// position for mario in aixs
               MarioCharacter.Location = MoveMario;//set the  new location to the new coordinate
            }
           if(MoveMario.X >= 811)// position for mario in aixs
            {
               MoveMario.X = -11;//decrement the X coordinate
               MarioCharacter.Location = MoveMario;//set the  new location to the new coordinate
            }

            eatFood();                          //Method to eat the food
            stopGameLogic();
        }


        private void eatFood()
        {
            if (MarioCharacter.Bounds.IntersectsWith(Burger.Bounds)) // if mario bounds intersect with the food bounds than :
            {
                Burger.Visible = false;
                SCORE++;                                //Increment the score.
                scoreLbl.Text = "Score: " + SCORE.ToString();
                Burger.Location = new Point(598, 135);//Change the position of the Burger in a manner that the Mario Sprite will not touch it even though it is invisible.
                Pizza.Location = new Point(598, 240);//Change the position of the pizza in a manner that the Mario Sprite will not touch it even though it is invisible.
                Pizza.Visible = true;
            }

            if (MarioCharacter.Bounds.IntersectsWith(Pizza.Bounds))
            {
                Pizza.Visible = false;
                SCORE++;  //Increment the score.
                scoreLbl.Text = "Score: " + SCORE.ToString();
                Pizza.Location = new Point(598, 135);//Change the position of the pizza in a manner that the Mario Sprite will not touch it even though it is invisible.
                Chips.Location = new Point(343, 240);//Change the position of the chips in a manner that the Mario Sprite will not touch it even though it is invisible.
                Chips.Visible = true;
            }

            if (MarioCharacter.Bounds.IntersectsWith(Chips.Bounds))
            {
                Chips.Visible = false;
                SCORE++;  //Increment the score.
                scoreLbl.Text = "Score: " + SCORE.ToString();
                Chips.Location = new Point(598, 135);//Change the position of the chips in a manner that the Mario Sprite will not touch it even though it is invisible.
                Chicken.Location = new Point(12, 240);//Change the position of the chicken in a manner that the Mario Sprite will not touch it even though it is invisible.
                Chicken.Visible = true;
            }

            if (MarioCharacter.Bounds.IntersectsWith(Chicken.Bounds))
            {
                Chicken.Visible = false;
                SCORE++;  //Increment the score.
                scoreLbl.Text = "Score: " + SCORE.ToString();
                Chicken.Location = new Point(598, 135);//Change the position of the chicken in a manner that the Mario Sprite will not touch it even though it is invisible.
                Burger.Location = new Point(615, 240);//Change the position of the burger in a manner that the Mario Sprite will not touch it even though it is invisible.
                Burger.Visible = true;
            }
        }

        private void stopGameLogic()
        {
            if (MarioCharacter.Bounds.IntersectsWith(brickPic1.Bounds)) //Checking if the Brick is touching the Mario character.
            {
                //Pause the game for a while, Inform the user, and start all over again.
                backPicTimer.Enabled = false;
                backPicTimer.Stop();
                MessageBox.Show("OOPS!!!\n You've been hit");//messages to show if the player hit the rock

                tomLife--;

                lifeLbl.Text = "Life: " + tomLife.ToString();

                backPicTimer.Enabled = true;
                backPicTimer.Start();

                moveFallingObjects();

                //Take the bricks back to their initial location.
                brickPic1.Location = new Point(brickPic1.Location.X, brickPic1.Location.Y - 120);//initial new location X and Y aixs
                brickPic2.Location = new Point(brickPic2.Location.X, brickPic2.Location.Y - 240);//initial new location X and Y aixs
                brickPic3.Location = new Point(brickPic3.Location.X, brickPic3.Location.Y - 160);//initial new location X and Y aixs
            }

            if (MarioCharacter.Bounds.IntersectsWith(brickPic2.Bounds))
            {
                //Pause the game for a while, Inform the user, and start all over again.
                backPicTimer.Enabled = false;
                backPicTimer.Stop();
                MessageBox.Show("OOPS!!!\n You've been hit");//messages to show if the player hit the rock

                tomLife--;

                lifeLbl.Text = "Life: " + tomLife.ToString();

                backPicTimer.Enabled = true;
                backPicTimer.Start();

                moveFallingObjects();

                //Take the bricks back to their initial location.
                brickPic1.Location = new Point(brickPic1.Location.X, brickPic1.Location.Y - 120);//initial new location X and Y aixs
                brickPic2.Location = new Point(brickPic2.Location.X, brickPic2.Location.Y - 240);//initial new location X and Y aixs
                brickPic3.Location = new Point(brickPic3.Location.X, brickPic3.Location.Y - 160);//initial new location X and Y aixs
            }

            if (MarioCharacter.Bounds.IntersectsWith(brickPic3.Bounds))
            {
                //Pause the game for a while, Inform the user, and start all over again.
                backPicTimer.Enabled = false;
                backPicTimer.Stop();
                MessageBox.Show("OOPS!!!\n You've been hit");//messages to show if the player hit the rock

                tomLife--;

                lifeLbl.Text = "Life: " + tomLife.ToString();

                backPicTimer.Enabled = true;// time to enable the rocks to fall
                backPicTimer.Start();
                moveFallingObjects();//

                //Take the bricks back to their initial location.
                brickPic1.Location = new Point(brickPic1.Location.X, brickPic1.Location.Y - 120);//new location for brickpic1 X and Y axis
                brickPic2.Location = new Point(brickPic2.Location.X, brickPic2.Location.Y - 240);//new location for brickpic2 X and Y axis
                brickPic3.Location = new Point(brickPic3.Location.X, brickPic3.Location.Y - 160);//new location for brickpic3 X and Y axis
            }
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }//setting key to default 
            if (e.KeyCode == Keys.Left) { left = false; }//setting key to default 
        }
    }
}
