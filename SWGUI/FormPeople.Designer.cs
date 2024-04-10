namespace SWGUI
{
    partial class FormPeople
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
            TreeNode treeNode1 = new TreeNode("List of people");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPeople));
            pictureBox_LOGO = new PictureBox();
            treeView_list = new TreeView();
            button_return = new Button();
            label_people = new Label();
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
            pictureBox_LOGO.TabIndex = 0;
            pictureBox_LOGO.TabStop = false;
            // 
            // treeView_list
            // 
            treeView_list.BackColor = Color.Black;
            treeView_list.ForeColor = Color.Yellow;
            treeView_list.Location = new Point(47, 121);
            treeView_list.Name = "treeView_list";
            treeNode1.Name = "Node0";
            treeNode1.Text = "List of people";
            treeView_list.Nodes.AddRange(new TreeNode[] { treeNode1 });
            treeView_list.Size = new Size(406, 509);
            treeView_list.TabIndex = 1;
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
            button_return.TabIndex = 2;
            button_return.UseVisualStyleBackColor = false;
            button_return.Click += button_return_Click;
            // 
            // label_people
            // 
            label_people.AutoSize = true;
            label_people.BackColor = Color.Transparent;
            label_people.Font = new Font("Microsoft YaHei", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_people.ForeColor = Color.Yellow;
            label_people.Location = new Point(401, 12);
            label_people.Name = "label_people";
            label_people.Size = new Size(282, 86);
            label_people.TabIndex = 3;
            label_people.Text = "PEOPLE";
            // 
            // FormPeople
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1128, 673);
            Controls.Add(label_people);
            Controls.Add(button_return);
            Controls.Add(treeView_list);
            Controls.Add(pictureBox_LOGO);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPeople";
            Text = "People ";
            ((System.ComponentModel.ISupportInitialize)pictureBox_LOGO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_LOGO;
        private TreeView treeView_list;
        private Button button_return;
        private Label label_people;
    }
}