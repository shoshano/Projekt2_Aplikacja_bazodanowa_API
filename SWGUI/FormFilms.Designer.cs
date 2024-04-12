namespace SWGUI
{
    partial class FormFilms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFilms));
            pictureBox_LOGO = new PictureBox();
            button_return = new Button();
            label_films = new Label();
            listBox_plist = new ListBox();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox_search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_LOGO).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_LOGO
            // 
            pictureBox_LOGO.BackColor = Color.Transparent;
            pictureBox_LOGO.Image = Properties.Resources.logo;
            pictureBox_LOGO.Location = new Point(107, 16);
            pictureBox_LOGO.Margin = new Padding(3, 4, 3, 4);
            pictureBox_LOGO.Name = "pictureBox_LOGO";
            pictureBox_LOGO.Size = new Size(110, 72);
            pictureBox_LOGO.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_LOGO.TabIndex = 1;
            pictureBox_LOGO.TabStop = false;
            // 
            // button_return
            // 
            button_return.BackColor = Color.Black;
            button_return.BackgroundImage = (Image)resources.GetObject("button_return.BackgroundImage");
            button_return.BackgroundImageLayout = ImageLayout.Zoom;
            button_return.FlatStyle = FlatStyle.Flat;
            button_return.ImageAlign = ContentAlignment.TopLeft;
            button_return.Location = new Point(26, 16);
            button_return.Margin = new Padding(3, 4, 3, 4);
            button_return.Name = "button_return";
            button_return.Size = new Size(62, 72);
            button_return.TabIndex = 3;
            button_return.UseVisualStyleBackColor = false;
            button_return.Click += button_return_Click;
            // 
            // label_films
            // 
            label_films.AutoSize = true;
            label_films.BackColor = Color.Transparent;
            label_films.Font = new Font("Microsoft YaHei", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_films.ForeColor = Color.Yellow;
            label_films.Location = new Point(458, 16);
            label_films.Name = "label_films";
            label_films.Size = new Size(291, 106);
            label_films.TabIndex = 4;
            label_films.Text = "FILMS";
            // 
            // listBox_plist
            // 
            listBox_plist.BackColor = Color.Black;
            listBox_plist.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            listBox_plist.ForeColor = Color.Yellow;
            listBox_plist.FormattingEnabled = true;
            listBox_plist.ItemHeight = 34;
            listBox_plist.Location = new Point(77, 239);
            listBox_plist.Margin = new Padding(3, 4, 3, 4);
            listBox_plist.Name = "listBox_plist";
            listBox_plist.Size = new Size(429, 616);
            listBox_plist.TabIndex = 5;
            listBox_plist.SelectedIndexChanged += listBox_plist_SelectedIndexChanged;
            listBox_plist.MouseDoubleClick += listBox_plist_MouseDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft YaHei", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(703, 167);
            label2.Name = "label2";
            label2.Size = new Size(123, 58);
            label2.TabIndex = 6;
            label2.Text = "Title";
            label2.Visible = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gold;
            textBox1.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textBox1.Location = new Point(703, 248);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(497, 557);
            textBox1.TabIndex = 7;
            textBox1.Visible = false;
            // 
            // textBox_search
            // 
            textBox_search.BackColor = Color.Black;
            textBox_search.Font = new Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox_search.ForeColor = Color.Yellow;
            textBox_search.Location = new Point(77, 179);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(429, 47);
            textBox_search.TabIndex = 8;
            textBox_search.TextChanged += textBox_search_TextChanged;
            // 
            // FormFilms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1289, 897);
            Controls.Add(textBox_search);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(listBox_plist);
            Controls.Add(label_films);
            Controls.Add(button_return);
            Controls.Add(pictureBox_LOGO);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormFilms";
            Text = "Films";
            ((System.ComponentModel.ISupportInitialize)pictureBox_LOGO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_LOGO;
        private Button button_return;
        private Label label_films;
        private ListBox listBox_plist;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox_search;
    }
}