namespace Good_Friends_Never_Starve
{
    partial class CodeGenerator
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
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSalmon;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(686, 248);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(349, 106);
            label2.Name = "label2";
            label2.Size = new Size(108, 19);
            label2.TabIndex = 3;
            label2.Text = "Your code is -->";
            label2.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(74, 121);
            button1.Name = "button1";
            button1.Size = new Size(136, 43);
            button1.TabIndex = 2;
            button1.Text = "Get Code";
            button1.UseVisualStyleBackColor = true;
            button1.Click += GenerateCode_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(462, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 1;
            textBox1.Visible = false;
            // 
            // label1
            // 
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(267, 77);
            label1.TabIndex = 0;
            label1.Text = "Well done !\r\nPress the button below to receive your unique code .Use it after signing in to see the status of your order ";
            // 
            // button2
            // 
            button2.Location = new Point(462, 146);
            button2.Name = "button2";
            button2.Size = new Size(120, 44);
            button2.TabIndex = 4;
            button2.Text = "Go Back to check the order";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // CodeGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "CodeGenerator";
            Size = new Size(686, 248);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button2;
    }
}
