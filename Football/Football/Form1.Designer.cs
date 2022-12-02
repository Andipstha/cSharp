namespace Football
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Left = new System.Windows.Forms.PictureBox();
            this.Right = new System.Windows.Forms.PictureBox();
            this.topLeft = new System.Windows.Forms.PictureBox();
            this.topRight = new System.Windows.Forms.PictureBox();
            this.Top = new System.Windows.Forms.PictureBox();
            this.goalKeeper = new System.Windows.Forms.PictureBox();
            this.football = new System.Windows.Forms.PictureBox();
            this.keeperTimer = new System.Windows.Forms.Timer(this.components);
            this.ballTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalKeeper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.football)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(457, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Missed: 0";
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.Yellow;
            this.Left.Image = global::Football.Properties.Resources.target;
            this.Left.Location = new System.Drawing.Point(130, 155);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(31, 29);
            this.Left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Left.TabIndex = 1;
            this.Left.TabStop = false;
            this.Left.Tag = "Left";
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.Color.Yellow;
            this.Right.Image = global::Football.Properties.Resources.target;
            this.Right.Location = new System.Drawing.Point(424, 155);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(31, 29);
            this.Right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Right.TabIndex = 1;
            this.Right.TabStop = false;
            this.Right.Tag = "Right";
            // 
            // topLeft
            // 
            this.topLeft.BackColor = System.Drawing.Color.Yellow;
            this.topLeft.Image = global::Football.Properties.Resources.target;
            this.topLeft.Location = new System.Drawing.Point(130, 50);
            this.topLeft.Name = "topLeft";
            this.topLeft.Size = new System.Drawing.Size(31, 29);
            this.topLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topLeft.TabIndex = 1;
            this.topLeft.TabStop = false;
            this.topLeft.Tag = "topLeft";
            // 
            // topRight
            // 
            this.topRight.BackColor = System.Drawing.Color.Yellow;
            this.topRight.Image = global::Football.Properties.Resources.target;
            this.topRight.Location = new System.Drawing.Point(424, 50);
            this.topRight.Name = "topRight";
            this.topRight.Size = new System.Drawing.Size(31, 29);
            this.topRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topRight.TabIndex = 1;
            this.topRight.TabStop = false;
            this.topRight.Tag = "topRight";
            // 
            // Top
            // 
            this.Top.BackColor = System.Drawing.Color.Yellow;
            this.Top.Image = global::Football.Properties.Resources.target;
            this.Top.Location = new System.Drawing.Point(278, 50);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(31, 29);
            this.Top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Top.TabIndex = 1;
            this.Top.TabStop = false;
            this.Top.Tag = "Top";
            // 
            // goalKeeper
            // 
            this.goalKeeper.BackColor = System.Drawing.Color.Transparent;
            this.goalKeeper.Image = global::Football.Properties.Resources.stand_small;
            this.goalKeeper.Location = new System.Drawing.Point(248, 99);
            this.goalKeeper.Name = "goalKeeper";
            this.goalKeeper.Size = new System.Drawing.Size(61, 85);
            this.goalKeeper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goalKeeper.TabIndex = 2;
            this.goalKeeper.TabStop = false;
            // 
            // football
            // 
            this.football.BackColor = System.Drawing.Color.Transparent;
            this.football.Image = global::Football.Properties.Resources.football;
            this.football.Location = new System.Drawing.Point(259, 326);
            this.football.Name = "football";
            this.football.Size = new System.Drawing.Size(50, 51);
            this.football.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.football.TabIndex = 2;
            this.football.TabStop = false;
            // 
            // keeperTimer
            // 
            this.keeperTimer.Interval = 20;
            // 
            // ballTimer
            // 
            this.ballTimer.Interval = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Football.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.football);
            this.Controls.Add(this.goalKeeper);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.topRight);
            this.Controls.Add(this.topLeft);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Tag = "left";
            this.Text = "Football";
            ((System.ComponentModel.ISupportInitialize)(this.Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalKeeper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.football)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox Left;
        private PictureBox Right;
        private PictureBox topLeft;
        private PictureBox topRight;
        private PictureBox Top;
        private PictureBox goalKeeper;
        private PictureBox football;
        private System.Windows.Forms.Timer keeperTimer;
        private System.Windows.Forms.Timer ballTimer;
    }
}