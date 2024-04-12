namespace SWGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Label_people = new Label();
            Label_Spieces = new Label();
            Label_films = new Label();
            LAbel_Starships = new Label();
            Label_vehicles = new Label();
            Label_planets = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Label_people
            // 
            Label_people.AutoSize = true;
            Label_people.BackColor = Color.Transparent;
            Label_people.Font = new Font("Microsoft YaHei UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Label_people.ForeColor = Color.Yellow;
            Label_people.Location = new Point(150, 411);
            Label_people.Name = "Label_people";
            Label_people.Size = new Size(240, 80);
            Label_people.TabIndex = 0;
            Label_people.Text = "People";
            Label_people.Click += Label_people_Click;
            // 
            // Label_Spieces
            // 
            Label_Spieces.AccessibleRole = AccessibleRole.Client;
            Label_Spieces.AutoSize = true;
            Label_Spieces.BackColor = Color.Transparent;
            Label_Spieces.Font = new Font("Microsoft YaHei UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Label_Spieces.ForeColor = Color.Yellow;
            Label_Spieces.Location = new Point(544, 411);
            Label_Spieces.Name = "Label_Spieces";
            Label_Spieces.Size = new Size(259, 80);
            Label_Spieces.TabIndex = 1;
            Label_Spieces.Text = "Spieces";
            Label_Spieces.Click += Label_Spieces_Click;
            // 
            // Label_films
            // 
            Label_films.AutoSize = true;
            Label_films.BackColor = Color.Transparent;
            Label_films.Font = new Font("Microsoft YaHei UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Label_films.ForeColor = Color.Yellow;
            Label_films.Location = new Point(971, 411);
            Label_films.Name = "Label_films";
            Label_films.Size = new Size(192, 80);
            Label_films.TabIndex = 2;
            Label_films.Text = "Films";
            Label_films.Click += Label_films_Click;
            // 
            // LAbel_Starships
            // 
            LAbel_Starships.AutoSize = true;
            LAbel_Starships.BackColor = Color.Transparent;
            LAbel_Starships.Font = new Font("Microsoft YaHei UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LAbel_Starships.ForeColor = Color.Yellow;
            LAbel_Starships.Location = new Point(120, 611);
            LAbel_Starships.Name = "LAbel_Starships";
            LAbel_Starships.Size = new Size(312, 80);
            LAbel_Starships.TabIndex = 3;
            LAbel_Starships.Text = "Starships";
            LAbel_Starships.Click += LAbel_Starships_Click;
            // 
            // Label_vehicles
            // 
            Label_vehicles.AutoSize = true;
            Label_vehicles.BackColor = Color.Transparent;
            Label_vehicles.Font = new Font("Microsoft YaHei UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Label_vehicles.ForeColor = Color.Yellow;
            Label_vehicles.Location = new Point(544, 611);
            Label_vehicles.Name = "Label_vehicles";
            Label_vehicles.Size = new Size(283, 80);
            Label_vehicles.TabIndex = 4;
            Label_vehicles.Text = "Vehicles";
            Label_vehicles.Click += Label_vehicles_Click;
            // 
            // Label_planets
            // 
            Label_planets.AutoSize = true;
            Label_planets.BackColor = Color.Transparent;
            Label_planets.Font = new Font("Microsoft YaHei UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Label_planets.ForeColor = Color.Yellow;
            Label_planets.Location = new Point(957, 611);
            Label_planets.Name = "Label_planets";
            Label_planets.Size = new Size(255, 80);
            Label_planets.TabIndex = 5;
            Label_planets.Text = "Planets";
            Label_planets.Click += Label_planets_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(353, 37);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(594, 299);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1289, 897);
            Controls.Add(pictureBox1);
            Controls.Add(Label_planets);
            Controls.Add(Label_vehicles);
            Controls.Add(LAbel_Starships);
            Controls.Add(Label_films);
            Controls.Add(Label_Spieces);
            Controls.Add(Label_people);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "STAR WARS App";
            TransparencyKey = Color.White;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_people;
        private Label Label_Spieces;
        private Label Label_films;
        private Label LAbel_Starships;
        private Label Label_vehicles;
        private Label Label_planets;
        private PictureBox pictureBox1;
    }
}
