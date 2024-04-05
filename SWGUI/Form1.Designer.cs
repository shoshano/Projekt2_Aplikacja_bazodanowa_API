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
            Label_people = new Label();
            Label_Spieces = new Label();
            Label_films = new Label();
            LAbel_Starships = new Label();
            Label_vehicles = new Label();
            Label_planets = new Label();
            textBox_title1 = new TextBox();
            SuspendLayout();
            // 
            // Label_people
            // 
            Label_people.AutoSize = true;
            Label_people.BackColor = SystemColors.ControlLight;
            Label_people.Font = new Font("Microsoft YaHei UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Label_people.Location = new Point(150, 291);
            Label_people.Name = "Label_people";
            Label_people.Size = new Size(139, 46);
            Label_people.TabIndex = 0;
            Label_people.Text = "People";
            Label_people.Click += Label_people_Click;
            // 
            // Label_Spieces
            // 
            Label_Spieces.AccessibleRole = AccessibleRole.Client;
            Label_Spieces.AutoSize = true;
            Label_Spieces.BackColor = SystemColors.ControlLight;
            Label_Spieces.Font = new Font("Microsoft YaHei UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Label_Spieces.Location = new Point(498, 291);
            Label_Spieces.Name = "Label_Spieces";
            Label_Spieces.Size = new Size(149, 46);
            Label_Spieces.TabIndex = 1;
            Label_Spieces.Text = "Spieces";
            // 
            // Label_films
            // 
            Label_films.AutoSize = true;
            Label_films.BackColor = SystemColors.ControlLight;
            Label_films.Font = new Font("Microsoft YaHei UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Label_films.Location = new Point(862, 291);
            Label_films.Name = "Label_films";
            Label_films.Size = new Size(111, 46);
            Label_films.TabIndex = 2;
            Label_films.Text = "Films";
            // 
            // LAbel_Starships
            // 
            LAbel_Starships.AutoSize = true;
            LAbel_Starships.BackColor = SystemColors.ControlLight;
            LAbel_Starships.Font = new Font("Microsoft YaHei UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LAbel_Starships.Location = new Point(131, 458);
            LAbel_Starships.Name = "LAbel_Starships";
            LAbel_Starships.Size = new Size(181, 46);
            LAbel_Starships.TabIndex = 3;
            LAbel_Starships.Text = "Starships";
            // 
            // Label_vehicles
            // 
            Label_vehicles.AutoSize = true;
            Label_vehicles.BackColor = SystemColors.ControlLight;
            Label_vehicles.Font = new Font("Microsoft YaHei UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Label_vehicles.Location = new Point(498, 458);
            Label_vehicles.Name = "Label_vehicles";
            Label_vehicles.Size = new Size(163, 46);
            Label_vehicles.TabIndex = 4;
            Label_vehicles.Text = "Vehicles";
            // 
            // Label_planets
            // 
            Label_planets.AutoSize = true;
            Label_planets.BackColor = SystemColors.ControlLight;
            Label_planets.Font = new Font("Microsoft YaHei UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Label_planets.Location = new Point(850, 458);
            Label_planets.Name = "Label_planets";
            Label_planets.Size = new Size(148, 46);
            Label_planets.TabIndex = 5;
            Label_planets.Text = "Planets";
            // 
            // textBox_title1
            // 
            textBox_title1.BackColor = SystemColors.InfoText;
            textBox_title1.BorderStyle = BorderStyle.None;
            textBox_title1.Font = new Font("Gill Sans Ultra Bold", 60F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox_title1.ForeColor = Color.FromArgb(248, 200, 7);
            textBox_title1.Location = new Point(280, 77);
            textBox_title1.Name = "textBox_title1";
            textBox_title1.Size = new Size(607, 100);
            textBox_title1.TabIndex = 6;
            textBox_title1.Text = "STAR \r\nWARS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(1143, 722);
            Controls.Add(textBox_title1);
            Controls.Add(Label_planets);
            Controls.Add(Label_vehicles);
            Controls.Add(LAbel_Starships);
            Controls.Add(Label_films);
            Controls.Add(Label_Spieces);
            Controls.Add(Label_people);
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.White;
            Load += Form1_Load_1;
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
        private TextBox textBox_title1;
    }
}
