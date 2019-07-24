namespace FavourTomGame
{
    partial class MarioGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarioGame));
            this.backPicTimer = new System.Windows.Forms.Timer(this.components);
            this.brickPic1 = new System.Windows.Forms.PictureBox();
            this.brickPic2 = new System.Windows.Forms.PictureBox();
            this.brickPic3 = new System.Windows.Forms.PictureBox();
            this.Burger = new System.Windows.Forms.PictureBox();
            this.Chips = new System.Windows.Forms.PictureBox();
            this.Chicken = new System.Windows.Forms.PictureBox();
            this.Pizza = new System.Windows.Forms.PictureBox();
            this.foodInstantTimer = new System.Windows.Forms.Timer(this.components);
            this.MarioCharacter = new System.Windows.Forms.PictureBox();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.lifeLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.brickPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickPic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Burger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chicken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarioCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // backPicTimer
            // 
            this.backPicTimer.Tick += new System.EventHandler(this.backPicTimer_Tick);
            // 
            // brickPic1
            // 
            this.brickPic1.BackgroundImage = global::FavourTomGame.Properties.Resources.osa_firewall1;
            this.brickPic1.Location = new System.Drawing.Point(200, 10);
            this.brickPic1.Name = "brickPic1";
            this.brickPic1.Size = new System.Drawing.Size(59, 32);
            this.brickPic1.TabIndex = 2;
            this.brickPic1.TabStop = false;
            // 
            // brickPic2
            // 
            this.brickPic2.BackgroundImage = global::FavourTomGame.Properties.Resources.osa_firewall1;
            this.brickPic2.Location = new System.Drawing.Point(393, 0);
            this.brickPic2.Name = "brickPic2";
            this.brickPic2.Size = new System.Drawing.Size(59, 32);
            this.brickPic2.TabIndex = 3;
            this.brickPic2.TabStop = false;
            // 
            // brickPic3
            // 
            this.brickPic3.BackgroundImage = global::FavourTomGame.Properties.Resources.osa_firewall1;
            this.brickPic3.Location = new System.Drawing.Point(582, 0);
            this.brickPic3.Name = "brickPic3";
            this.brickPic3.Size = new System.Drawing.Size(59, 32);
            this.brickPic3.TabIndex = 4;
            this.brickPic3.TabStop = false;
            // 
            // Burger
            // 
            this.Burger.BackColor = System.Drawing.Color.Transparent;
            this.Burger.BackgroundImage = global::FavourTomGame.Properties.Resources.burger;
            this.Burger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Burger.Location = new System.Drawing.Point(102, 239);
            this.Burger.Name = "Burger";
            this.Burger.Size = new System.Drawing.Size(43, 32);
            this.Burger.TabIndex = 5;
            this.Burger.TabStop = false;
            // 
            // Chips
            // 
            this.Chips.BackColor = System.Drawing.Color.Transparent;
            this.Chips.BackgroundImage = global::FavourTomGame.Properties.Resources.chips;
            this.Chips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Chips.Location = new System.Drawing.Point(343, 239);
            this.Chips.Name = "Chips";
            this.Chips.Size = new System.Drawing.Size(39, 32);
            this.Chips.TabIndex = 6;
            this.Chips.TabStop = false;
            // 
            // Chicken
            // 
            this.Chicken.BackColor = System.Drawing.Color.Transparent;
            this.Chicken.BackgroundImage = global::FavourTomGame.Properties.Resources.chicken;
            this.Chicken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Chicken.Location = new System.Drawing.Point(498, 239);
            this.Chicken.Name = "Chicken";
            this.Chicken.Size = new System.Drawing.Size(40, 32);
            this.Chicken.TabIndex = 7;
            this.Chicken.TabStop = false;
            this.Chicken.Click += new System.EventHandler(this.Chicken_Click);
            // 
            // Pizza
            // 
            this.Pizza.BackColor = System.Drawing.Color.Transparent;
            this.Pizza.BackgroundImage = global::FavourTomGame.Properties.Resources.Pizza;
            this.Pizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pizza.Location = new System.Drawing.Point(685, 229);
            this.Pizza.Name = "Pizza";
            this.Pizza.Size = new System.Drawing.Size(45, 42);
            this.Pizza.TabIndex = 8;
            this.Pizza.TabStop = false;
            // 
            // foodInstantTimer
            // 
            this.foodInstantTimer.Interval = 700;
            this.foodInstantTimer.Tick += new System.EventHandler(this.foodInstantTimer_Tick);
            // 
            // MarioCharacter
            // 
            this.MarioCharacter.BackColor = System.Drawing.Color.Transparent;
            this.MarioCharacter.BackgroundImage = global::FavourTomGame.Properties.Resources.mario_sprite_by_bowserboy123;
            this.MarioCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MarioCharacter.Location = new System.Drawing.Point(200, 239);
            this.MarioCharacter.Name = "MarioCharacter";
            this.MarioCharacter.Size = new System.Drawing.Size(27, 79);
            this.MarioCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MarioCharacter.TabIndex = 10;
            this.MarioCharacter.TabStop = false;
            this.MarioCharacter.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.BackColor = System.Drawing.Color.Transparent;
            this.scoreLbl.Location = new System.Drawing.Point(762, 10);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(38, 13);
            this.scoreLbl.TabIndex = 11;
            this.scoreLbl.Text = "Score:";
            // 
            // lifeLbl
            // 
            this.lifeLbl.AutoSize = true;
            this.lifeLbl.BackColor = System.Drawing.Color.Transparent;
            this.lifeLbl.Location = new System.Drawing.Point(764, 52);
            this.lifeLbl.Name = "lifeLbl";
            this.lifeLbl.Size = new System.Drawing.Size(36, 13);
            this.lifeLbl.TabIndex = 12;
            this.lifeLbl.Text = "Life: 3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MarioGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(830, 320);
            this.Controls.Add(this.lifeLbl);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.MarioCharacter);
            this.Controls.Add(this.Pizza);
            this.Controls.Add(this.Chicken);
            this.Controls.Add(this.Chips);
            this.Controls.Add(this.Burger);
            this.Controls.Add(this.brickPic3);
            this.Controls.Add(this.brickPic2);
            this.Controls.Add(this.brickPic1);
            this.MaximizeBox = false;
            this.Name = "MarioGame";
            this.Text = "Mario Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.brickPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brickPic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Burger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chicken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarioCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer backPicTimer;
        private System.Windows.Forms.PictureBox brickPic1;
        private System.Windows.Forms.PictureBox brickPic2;
        private System.Windows.Forms.PictureBox brickPic3;
        private System.Windows.Forms.PictureBox Burger;
        private System.Windows.Forms.PictureBox Chips;
        private System.Windows.Forms.PictureBox Chicken;
        private System.Windows.Forms.PictureBox Pizza;
        private System.Windows.Forms.Timer foodInstantTimer;
        private System.Windows.Forms.PictureBox MarioCharacter;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label lifeLbl;
        private System.Windows.Forms.Timer timer1;

    }
}

