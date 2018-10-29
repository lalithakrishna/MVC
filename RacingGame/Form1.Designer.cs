namespace RacingGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.RoadMover = new System.Windows.Forms.Timer(this.components);
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.Car = new System.Windows.Forms.PictureBox();
            this.LeftMover = new System.Windows.Forms.Timer(this.components);
            this.RightMover = new System.Windows.Forms.Timer(this.components);
            this.EnemyCar1 = new System.Windows.Forms.PictureBox();
            this.Enemycar2 = new System.Windows.Forms.PictureBox();
            this.EnemyCar3 = new System.Windows.Forms.PictureBox();
            this.Enemytimer1 = new System.Windows.Forms.Timer(this.components);
            this.Enemytimer2 = new System.Windows.Forms.Timer(this.components);
            this.Enemytimer3 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Score_Text = new System.Windows.Forms.Label();
            this.Replay = new System.Windows.Forms.Button();
            this.Speed_Text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemycar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(49, -31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox5.Location = new System.Drawing.Point(49, 88);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(17, 100);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox6.Location = new System.Drawing.Point(-62, 87);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(17, 95);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox9.Location = new System.Drawing.Point(148, 424);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(17, 95);
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            // 
            // RoadMover
            // 
            this.RoadMover.Enabled = true;
            this.RoadMover.Interval = 10;
            this.RoadMover.Tick += new System.EventHandler(this.RoadMover_Tick);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox8.Location = new System.Drawing.Point(49, 206);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(17, 100);
            this.pictureBox8.TabIndex = 1;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.Location = new System.Drawing.Point(49, 326);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(17, 100);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox7.Location = new System.Drawing.Point(155, 326);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(17, 100);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox11.Location = new System.Drawing.Point(155, 206);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(17, 100);
            this.pictureBox11.TabIndex = 6;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox12.Location = new System.Drawing.Point(155, 88);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(17, 100);
            this.pictureBox12.TabIndex = 4;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox13.Location = new System.Drawing.Point(155, -31);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(17, 100);
            this.pictureBox13.TabIndex = 5;
            this.pictureBox13.TabStop = false;
            // 
            // Car
            // 
            this.Car.Image = ((System.Drawing.Image)(resources.GetObject("Car.Image")));
            this.Car.Location = new System.Drawing.Point(92, 272);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(42, 77);
            this.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car.TabIndex = 8;
            this.Car.TabStop = false;
            // 
            // LeftMover
            // 
            this.LeftMover.Interval = 10;
            this.LeftMover.Tick += new System.EventHandler(this.LeftMover_Tick);
            // 
            // RightMover
            // 
            this.RightMover.Interval = 10;
            this.RightMover.Tick += new System.EventHandler(this.RightMover_Tick);
            // 
            // EnemyCar1
            // 
            this.EnemyCar1.Image = ((System.Drawing.Image)(resources.GetObject("EnemyCar1.Image")));
            this.EnemyCar1.Location = new System.Drawing.Point(1, 172);
            this.EnemyCar1.Name = "EnemyCar1";
            this.EnemyCar1.Size = new System.Drawing.Size(42, 77);
            this.EnemyCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyCar1.TabIndex = 9;
            this.EnemyCar1.TabStop = false;
            // 
            // Enemycar2
            // 
            this.Enemycar2.Image = ((System.Drawing.Image)(resources.GetObject("Enemycar2.Image")));
            this.Enemycar2.Location = new System.Drawing.Point(107, -31);
            this.Enemycar2.Name = "Enemycar2";
            this.Enemycar2.Size = new System.Drawing.Size(42, 77);
            this.Enemycar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemycar2.TabIndex = 10;
            this.Enemycar2.TabStop = false;
            // 
            // EnemyCar3
            // 
            this.EnemyCar3.Image = ((System.Drawing.Image)(resources.GetObject("EnemyCar3.Image")));
            this.EnemyCar3.Location = new System.Drawing.Point(170, 72);
            this.EnemyCar3.Name = "EnemyCar3";
            this.EnemyCar3.Size = new System.Drawing.Size(42, 77);
            this.EnemyCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyCar3.TabIndex = 11;
            this.EnemyCar3.TabStop = false;
            // 
            // Enemytimer1
            // 
            this.Enemytimer1.Enabled = true;
            this.Enemytimer1.Interval = 10;
            this.Enemytimer1.Tick += new System.EventHandler(this.Enemytimer1_Tick);
            // 
            // Enemytimer2
            // 
            this.Enemytimer2.Enabled = true;
            this.Enemytimer2.Interval = 10;
            this.Enemytimer2.Tick += new System.EventHandler(this.Enemytimer2_Tick);
            // 
            // Enemytimer3
            // 
            this.Enemytimer3.Enabled = true;
            this.Enemytimer3.Interval = 10;
            this.Enemytimer3.Tick += new System.EventHandler(this.Enemytimer3_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(39, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 59);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Score_Text
            // 
            this.Score_Text.AutoSize = true;
            this.Score_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Score_Text.Location = new System.Drawing.Point(-1, 9);
            this.Score_Text.Name = "Score_Text";
            this.Score_Text.Size = new System.Drawing.Size(67, 18);
            this.Score_Text.TabIndex = 13;
            this.Score_Text.Text = "Score 0";
            // 
            // Replay
            // 
            this.Replay.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Replay.ForeColor = System.Drawing.Color.Red;
            this.Replay.Location = new System.Drawing.Point(74, 177);
            this.Replay.Name = "Replay";
            this.Replay.Size = new System.Drawing.Size(75, 31);
            this.Replay.TabIndex = 14;
            this.Replay.Text = "Replay";
            this.Replay.UseVisualStyleBackColor = true;
            this.Replay.Visible = false;
            this.Replay.Click += new System.EventHandler(this.Replay_Click);
            // 
            // Speed_Text
            // 
            this.Speed_Text.AutoSize = true;
            this.Speed_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speed_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Speed_Text.Location = new System.Drawing.Point(143, 9);
            this.Speed_Text.Name = "Speed_Text";
            this.Speed_Text.Size = new System.Drawing.Size(69, 18);
            this.Speed_Text.TabIndex = 15;
            this.Speed_Text.Text = "Speed 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(224, 361);
            this.Controls.Add(this.Speed_Text);
            this.Controls.Add(this.Replay);
            this.Controls.Add(this.Score_Text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnemyCar3);
            this.Controls.Add(this.Enemycar2);
            this.Controls.Add(this.EnemyCar1);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemycar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Timer RoadMover;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox Car;
        private System.Windows.Forms.Timer LeftMover;
        private System.Windows.Forms.Timer RightMover;
        private System.Windows.Forms.PictureBox EnemyCar1;
        private System.Windows.Forms.PictureBox Enemycar2;
        private System.Windows.Forms.PictureBox EnemyCar3;
        private System.Windows.Forms.Timer Enemytimer1;
        private System.Windows.Forms.Timer Enemytimer2;
        private System.Windows.Forms.Timer Enemytimer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Score_Text;
        private System.Windows.Forms.Button Replay;
        private System.Windows.Forms.Label Speed_Text;
    }
}

