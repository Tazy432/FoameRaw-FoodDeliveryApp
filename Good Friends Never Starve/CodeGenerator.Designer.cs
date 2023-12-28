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
            checkStatusOrderButton = new Button();
            label2 = new Label();
            getUniqueCodeButton = new Button();
            codeTextBox = new TextBox();
            uniqueCodeInstructionsLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSalmon;
            panel1.Controls.Add(checkStatusOrderButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(getUniqueCodeButton);
            panel1.Controls.Add(codeTextBox);
            panel1.Controls.Add(uniqueCodeInstructionsLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 331);
            panel1.TabIndex = 0;
            // 
            // checkStatusOrderButton
            // 
            checkStatusOrderButton.Location = new Point(528, 195);
            checkStatusOrderButton.Margin = new Padding(3, 4, 3, 4);
            checkStatusOrderButton.Name = "checkStatusOrderButton";
            checkStatusOrderButton.Size = new Size(137, 59);
            checkStatusOrderButton.TabIndex = 4;
            checkStatusOrderButton.Text = "Go Back to check the order";
            checkStatusOrderButton.UseVisualStyleBackColor = true;
            checkStatusOrderButton.Visible = false;
            checkStatusOrderButton.Click += button2_Click;
            // 
            // label2
            // 
            label2.Location = new Point(399, 141);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 3;
            label2.Text = "Your code is -->";
            label2.Visible = false;
            // 
            // getUniqueCodeButton
            // 
            getUniqueCodeButton.Location = new Point(85, 161);
            getUniqueCodeButton.Margin = new Padding(3, 4, 3, 4);
            getUniqueCodeButton.Name = "getUniqueCodeButton";
            getUniqueCodeButton.Size = new Size(155, 57);
            getUniqueCodeButton.TabIndex = 2;
            getUniqueCodeButton.Text = "Get Code";
            getUniqueCodeButton.UseVisualStyleBackColor = true;
            getUniqueCodeButton.Click += GenerateCode_Click;
            // 
            // codeTextBox
            // 
            codeTextBox.Location = new Point(528, 141);
            codeTextBox.Margin = new Padding(3, 4, 3, 4);
            codeTextBox.Name = "codeTextBox";
            codeTextBox.Size = new Size(137, 27);
            codeTextBox.TabIndex = 1;
            codeTextBox.Visible = false;
            // 
            // uniqueCodeInstructionsLabel
            // 
            uniqueCodeInstructionsLabel.Location = new Point(27, 28);
            uniqueCodeInstructionsLabel.Name = "uniqueCodeInstructionsLabel";
            uniqueCodeInstructionsLabel.Size = new Size(305, 103);
            uniqueCodeInstructionsLabel.TabIndex = 0;
            uniqueCodeInstructionsLabel.Text = "Well done !\r\nPress the button below to receive your unique code .Use it after signing in to see the status of your order ";
            // 
            // CodeGenerator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CodeGenerator";
            Size = new Size(784, 331);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button getUniqueCodeButton;
        private TextBox codeTextBox;
        private Label uniqueCodeInstructionsLabel;
        private Label label2;
        private Button checkStatusOrderButton;
    }
}
