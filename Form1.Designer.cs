namespace PeachesGame
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuBase = new PictureBox();
            peach = new PictureBox();
            basket = new PictureBox();
            peach2 = new PictureBox();
            peach3 = new PictureBox();
            podrido = new PictureBox();
            startBtn = new Button();
            labelPuntos = new Label();
            award = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)menuBase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)basket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peach2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peach3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)podrido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)award).BeginInit();
            SuspendLayout();
            // 
            // menuBase
            // 
            menuBase.BackColor = Color.LightPink;
            menuBase.BorderStyle = BorderStyle.Fixed3D;
            menuBase.Location = new Point(-7, 539);
            menuBase.Name = "menuBase";
            menuBase.Size = new Size(400, 100);
            menuBase.TabIndex = 0;
            menuBase.TabStop = false;
            // 
            // peach
            // 
            peach.BackColor = Color.Transparent;
            peach.BackgroundImage = Properties.Resources.peach1;
            peach.Location = new Point(47, 197);
            peach.Name = "peach";
            peach.Size = new Size(55, 70);
            peach.TabIndex = 1;
            peach.TabStop = false;
            // 
            // basket
            // 
            basket.BackColor = Color.Transparent;
            basket.BackgroundImage = Properties.Resources.canasta;
            basket.Location = new Point(0, 475);
            basket.Name = "basket";
            basket.Size = new Size(120, 64);
            basket.TabIndex = 2;
            basket.TabStop = false;
            // 
            // peach2
            // 
            peach2.BackColor = Color.Transparent;
            peach2.BackgroundImage = Properties.Resources.peach1;
            peach2.Location = new Point(125, 281);
            peach2.Name = "peach2";
            peach2.Size = new Size(55, 70);
            peach2.TabIndex = 3;
            peach2.TabStop = false;
            // 
            // peach3
            // 
            peach3.BackColor = Color.Transparent;
            peach3.BackgroundImage = Properties.Resources.peach1;
            peach3.Location = new Point(296, -3);
            peach3.Name = "peach3";
            peach3.Size = new Size(55, 70);
            peach3.TabIndex = 4;
            peach3.TabStop = false;
            // 
            // podrido
            // 
            podrido.BackColor = Color.Transparent;
            podrido.BackgroundImage = Properties.Resources.podridorosa;
            podrido.Location = new Point(225, 330);
            podrido.Name = "podrido";
            podrido.Size = new Size(56, 70);
            podrido.TabIndex = 5;
            podrido.TabStop = false;
            // 
            // startBtn
            // 
            startBtn.Font = new Font("Gill Sans MT Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startBtn.ForeColor = Color.IndianRed;
            startBtn.Location = new Point(150, 580);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(100, 40);
            startBtn.TabIndex = 6;
            startBtn.Text = "Empezar";
            startBtn.UseMnemonic = false;
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += restartGame;
            // 
            // labelPuntos
            // 
            labelPuntos.AutoSize = true;
            labelPuntos.BackColor = Color.Pink;
            labelPuntos.Font = new Font("Gill Sans MT Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPuntos.Location = new Point(165, 552);
            labelPuntos.Name = "labelPuntos";
            labelPuntos.Size = new Size(74, 25);
            labelPuntos.TabIndex = 0;
            labelPuntos.Text = "Puntos: 0";
            // 
            // award
            // 
            award.BackgroundImage = Properties.Resources.wonBronce;
            award.Location = new Point(73, 142);
            award.Name = "award";
            award.Size = new Size(250, 275);
            award.TabIndex = 0;
            award.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 5;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg2;
            ClientSize = new Size(384, 631);
            Controls.Add(award);
            Controls.Add(labelPuntos);
            Controls.Add(startBtn);
            Controls.Add(podrido);
            Controls.Add(peach3);
            Controls.Add(peach2);
            Controls.Add(basket);
            Controls.Add(peach);
            Controls.Add(menuBase);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(440, 670);
            Name = "Form1";
            Text = "Peaches";
            KeyDown += keyisDown;
            ((System.ComponentModel.ISupportInitialize)menuBase).EndInit();
            ((System.ComponentModel.ISupportInitialize)peach).EndInit();
            ((System.ComponentModel.ISupportInitialize)basket).EndInit();
            ((System.ComponentModel.ISupportInitialize)peach2).EndInit();
            ((System.ComponentModel.ISupportInitialize)peach3).EndInit();
            ((System.ComponentModel.ISupportInitialize)podrido).EndInit();
            ((System.ComponentModel.ISupportInitialize)award).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox menuBase;
        private PictureBox peach;
        private PictureBox basket;
        private PictureBox peach2;
        private PictureBox peach3;
        private PictureBox podrido;
        private Button startBtn;
        private Label labelPuntos;
        private PictureBox award;
        private System.Windows.Forms.Timer gameTimer;
    }
}
