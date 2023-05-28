namespace Good_Friends_Never_Starve
{
    partial class FormRestaurante
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
        public Button _button2
        {
            get { return button2; }
            set { button2 = value; }
        }



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRestaurante));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            button2 = new Button();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            label6 = new Label();
            button1 = new Button();
            panel4 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.LightSalmon;
            flowLayoutPanel1.Location = new Point(215, 48);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(752, 653);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(215, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 48);
            panel1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(14, 4);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Back\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(177, 9);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 0;
            label1.Text = "Nume ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(561, 9);
            label4.Name = "label4";
            label4.Size = new Size(135, 21);
            label4.TabIndex = 3;
            label4.Text = "Cost livrare";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(373, 9);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 1;
            label2.Text = "Program";
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Controls.Add(button3);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(222, 701);
            panel3.TabIndex = 4;
            // 
            // label8
            // 
            label8.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(0, 525);
            label8.Name = "label8";
            label8.Size = new Size(215, 31);
            label8.TabIndex = 7;
            label8.Text = "+Standard Delivery";
            label8.Visible = false;
            // 
            // label7
            // 
            label7.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(0, 556);
            label7.Name = "label7";
            label7.Size = new Size(219, 25);
            label7.TabIndex = 6;
            label7.Text = "MinimumOrder";
            label7.Visible = false;
            // 
            // label3
            // 
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(97, 489);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 5;
            label3.Text = "0";
            label3.Visible = false;
            // 
            // label6
            // 
            label6.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(0, 489);
            label6.Name = "label6";
            label6.Size = new Size(82, 36);
            label6.TabIndex = 4;
            label6.Text = "Total";
            label6.Visible = false;
            
            // 
            // button1
            // 
            button1.Location = new Point(39, 603);
            button1.Name = "button1";
            button1.Size = new Size(109, 53);
            button1.TabIndex = 3;
            button1.Text = "Yep , that's about it";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.Controls.Add(label5);
            panel4.Location = new Point(3, 295);
            panel4.Name = "panel4";
            panel4.Size = new Size(216, 191);
            panel4.TabIndex = 2;
            
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 13);
            label5.Name = "label5";
            label5.Size = new Size(53, 17);
            label5.TabIndex = 2;
            label5.Text = "label5";
            
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSalmon;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(22, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(160, 141);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 25);
            label9.Name = "label9";
            label9.Size = new Size(135, 20);
            label9.TabIndex = 8;
            label9.Text = "Unique Order code";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 27);
            textBox1.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(79, 81);
            button3.Name = "button3";
            button3.Size = new Size(49, 29);
            button3.TabIndex = 10;
            button3.Text = "Go!";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FormRestaurante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(968, 701);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "FormRestaurante";
            Text = "FormRestaurante";
            Load += FormRestaurante_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Panel panel2;
        public FlowLayoutPanel flowLayoutPanel1;
        public Panel panel1;
        public Label label1;
        public Label label4;
        public Label label2;
        public Panel panel3;
        public PictureBox pictureBox1;
        public Label label5;
        public Panel panel4;
        public Label label6;
        public Button button1;
        public Label label3;
        private Button button2;
        public Label label7;
        public Label label8;
        public TextBox textBox1;
        public Label label9;
        public Button button3;
    }
}