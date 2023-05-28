namespace Good_Friends_Never_Starve
{
    partial class listaDeProduserestaurant
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(127, 23);
            label1.Name = "label1";
            label1.Size = new Size(166, 21);
            label1.TabIndex = 0;
            label1.Text = "denumireProdus";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(326, 23);
            label2.Name = "label2";
            label2.Size = new Size(121, 21);
            label2.TabIndex = 1;
            label2.Text = "pretProdus";
            // 
            // label3
            // 
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(477, 23);
            label3.Name = "label3";
            label3.Size = new Size(220, 102);
            label3.TabIndex = 2;
            label3.Text = "DescriereProdus";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(687, 43);
            button1.Name = "button1";
            button1.Size = new Size(115, 48);
            button1.TabIndex = 3;
            button1.Text = "Add to cart";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tomato;
            panel1.Location = new Point(0, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 10);
            panel1.TabIndex = 4;
            // 
            // listaDeProduserestaurant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "listaDeProduserestaurant";
            Size = new Size(833, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public Label label2;
        public Label label3;
        public Button button1;
        public Panel panel1;
    }
}
