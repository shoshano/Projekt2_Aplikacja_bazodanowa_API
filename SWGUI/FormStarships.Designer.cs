namespace SWGUI
{
    partial class FormStarships
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStarships));
            TreeNode treeNode1 = new TreeNode("List of starships");
            pictureBox_LOGO = new PictureBox();
            button_return = new Button();
            label_starships = new Label();
            treeView_list = new TreeView();
            ((System.ComponentModel.ISupportInitialize)pictureBox_LOGO).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_LOGO
            // 
            pictureBox_LOGO.BackColor = Color.Transparent;
            pictureBox_LOGO.Image = Properties.Resources.logo;
            pictureBox_LOGO.Location = new Point(94, 12);
            pictureBox_LOGO.Name = "pictureBox_LOGO";
            pictureBox_LOGO.Size = new Size(96, 54);
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
            button_return.Location = new Point(23, 12);
            button_return.Name = "button_return";
            button_return.Size = new Size(54, 54);
            button_return.TabIndex = 3;
            button_return.UseVisualStyleBackColor = false;
            button_return.Click += button_return_Click;
            // 
            // label_starships
            // 
            label_starships.AutoSize = true;
            label_starships.BackColor = Color.Transparent;
            label_starships.Font = new Font("Microsoft YaHei", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_starships.ForeColor = Color.Yellow;
            label_starships.Location = new Point(363, 12);
            label_starships.Name = "label_starships";
            label_starships.Size = new Size(403, 86);
            label_starships.TabIndex = 4;
            label_starships.Text = "STARSHIPS";
            // 
            // treeView_list
            // 
            treeView_list.BackColor = Color.Black;
            treeView_list.ForeColor = Color.Yellow;
            treeView_list.Location = new Point(47, 121);
            treeView_list.Name = "treeView_list";
            treeNode1.Name = "Node0";
            treeNode1.Text = "List of starships";
            treeView_list.Nodes.AddRange(new TreeNode[] { treeNode1 });
            treeView_list.Size = new Size(406, 509);
            treeView_list.TabIndex = 5;
            // 
            // FormStarships
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1128, 673);
            Controls.Add(treeView_list);
            Controls.Add(label_starships);
            Controls.Add(button_return);
            Controls.Add(pictureBox_LOGO);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormStarships";
            Text = "Starships";
            ((System.ComponentModel.ISupportInitialize)pictureBox_LOGO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_LOGO;
        private Button button_return;
        private Label label_starships;
        private TreeView treeView_list;
    }
}