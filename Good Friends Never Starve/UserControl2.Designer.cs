namespace Good_Friends_Never_Starve
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(162, 40);
            label1.Name = "label1";
            label1.Size = new Size(54, 18);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.MouseEnter += afisareRestaurant;
            label1.MouseLeave += afisareRestaurant2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(342, 40);
            label2.Name = "label2";
            label2.Size = new Size(54, 18);
            label2.TabIndex = 2;
            label2.Text = "label2";
            label2.MouseEnter += afisareRestaurant;
            label2.MouseLeave += afisareRestaurant2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(532, 40);
            label3.Name = "label3";
            label3.Size = new Size(55, 18);
            label3.TabIndex = 3;
            label3.Text = "label3";
            label3.MouseEnter += afisareRestaurant;
            label3.MouseLeave += afisareRestaurant2;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.MenuBar;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 16);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += afisareRestaurant;
            pictureBox1.MouseLeave += afisareRestaurant2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Tomato;
            panel1.Location = new Point(1, 104);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(636, 8);
            panel1.TabIndex = 5;
            panel1.MouseDoubleClick += AfisareProduseRestaurant;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControl2";
            Size = new Size(639, 114);
            MouseDoubleClick += AfisareProduseRestaurant;
            MouseEnter += afisareRestaurant;
            MouseLeave += afisareRestaurant2;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label label1;
        public Label label2;
        public Label label3;
        public PictureBox pictureBox1;
        public Panel panel1;
        public string idUserControl;
        //public Form parentForm;
    }
}
