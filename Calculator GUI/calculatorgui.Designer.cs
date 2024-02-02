namespace Calculator_GUI
{
    partial class calculatorgui
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
            equals = new Button();
            divide = new Button();
            multiply = new Button();
            minus = new Button();
            plus = new Button();
            backspace = new Button();
            no_9 = new Button();
            no_8 = new Button();
            no_7 = new Button();
            no_6 = new Button();
            no_5 = new Button();
            no_4 = new Button();
            no_3 = new Button();
            no_2 = new Button();
            no_1 = new Button();
            no_0 = new Button();
            calculatebox = new TextBox();
            decimalpoint = new Button();
            SuspendLayout();
            // 
            // equals
            // 
            equals.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            equals.Location = new Point(257, 424);
            equals.Margin = new Padding(3, 4, 3, 4);
            equals.Name = "equals";
            equals.Size = new Size(70, 47);
            equals.TabIndex = 33;
            equals.Text = "=";
            equals.UseVisualStyleBackColor = true;
            equals.Click += equals_Click;
            // 
            // divide
            // 
            divide.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            divide.Location = new Point(258, 321);
            divide.Margin = new Padding(3, 4, 3, 4);
            divide.Name = "divide";
            divide.Size = new Size(69, 47);
            divide.TabIndex = 32;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.Click += divide_Click;
            // 
            // multiply
            // 
            multiply.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            multiply.Location = new Point(258, 233);
            multiply.Margin = new Padding(3, 4, 3, 4);
            multiply.Name = "multiply";
            multiply.Size = new Size(70, 47);
            multiply.TabIndex = 31;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += multiply_Click;
            // 
            // minus
            // 
            minus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minus.Location = new Point(258, 145);
            minus.Margin = new Padding(3, 4, 3, 4);
            minus.Name = "minus";
            minus.Size = new Size(70, 47);
            minus.TabIndex = 30;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // plus
            // 
            plus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            plus.Location = new Point(257, 83);
            plus.Margin = new Padding(3, 4, 3, 4);
            plus.Name = "plus";
            plus.Size = new Size(70, 47);
            plus.TabIndex = 29;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // backspace
            // 
            backspace.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backspace.Location = new Point(181, 83);
            backspace.Margin = new Padding(3, 4, 3, 4);
            backspace.Name = "backspace";
            backspace.Size = new Size(57, 47);
            backspace.TabIndex = 28;
            backspace.Text = "<-";
            backspace.UseVisualStyleBackColor = true;
            backspace.Click += backspace_Click;
            // 
            // no_9
            // 
            no_9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            no_9.Location = new Point(181, 145);
            no_9.Margin = new Padding(3, 4, 3, 4);
            no_9.Name = "no_9";
            no_9.Size = new Size(57, 47);
            no_9.TabIndex = 27;
            no_9.Text = "9";
            no_9.UseVisualStyleBackColor = true;
            no_9.Click += no_9_Click;
            // 
            // no_8
            // 
            no_8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            no_8.Location = new Point(103, 145);
            no_8.Margin = new Padding(3, 4, 3, 4);
            no_8.Name = "no_8";
            no_8.Size = new Size(57, 47);
            no_8.TabIndex = 26;
            no_8.Text = "8";
            no_8.UseVisualStyleBackColor = true;
            no_8.Click += no_8_Click;
            // 
            // no_7
            // 
            no_7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            no_7.Location = new Point(19, 145);
            no_7.Margin = new Padding(3, 4, 3, 4);
            no_7.Name = "no_7";
            no_7.Size = new Size(57, 47);
            no_7.TabIndex = 25;
            no_7.Text = "7";
            no_7.UseVisualStyleBackColor = true;
            no_7.Click += no_7_Click;
            // 
            // no_6
            // 
            no_6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            no_6.Location = new Point(181, 233);
            no_6.Margin = new Padding(3, 4, 3, 4);
            no_6.Name = "no_6";
            no_6.Size = new Size(57, 47);
            no_6.TabIndex = 24;
            no_6.Text = "6";
            no_6.UseVisualStyleBackColor = true;
            no_6.Click += no_6_Click;
            // 
            // no_5
            // 
            no_5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            no_5.Location = new Point(103, 233);
            no_5.Margin = new Padding(3, 4, 3, 4);
            no_5.Name = "no_5";
            no_5.Size = new Size(57, 47);
            no_5.TabIndex = 23;
            no_5.Text = "5";
            no_5.UseVisualStyleBackColor = true;
            no_5.Click += no_5_Click;
            // 
            // no_4
            // 
            no_4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            no_4.Location = new Point(19, 233);
            no_4.Margin = new Padding(3, 4, 3, 4);
            no_4.Name = "no_4";
            no_4.Size = new Size(57, 47);
            no_4.TabIndex = 22;
            no_4.Text = "4";
            no_4.UseVisualStyleBackColor = true;
            no_4.Click += no_4_Click;
            // 
            // no_3
            // 
            no_3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            no_3.Location = new Point(181, 321);
            no_3.Margin = new Padding(3, 4, 3, 4);
            no_3.Name = "no_3";
            no_3.Size = new Size(57, 47);
            no_3.TabIndex = 21;
            no_3.Text = "3";
            no_3.UseVisualStyleBackColor = true;
            no_3.Click += no_3_Click;
            // 
            // no_2
            // 
            no_2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            no_2.Location = new Point(103, 321);
            no_2.Margin = new Padding(3, 4, 3, 4);
            no_2.Name = "no_2";
            no_2.Size = new Size(57, 47);
            no_2.TabIndex = 20;
            no_2.Text = "2";
            no_2.UseVisualStyleBackColor = true;
            no_2.Click += no_2_Click;
            // 
            // no_1
            // 
            no_1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            no_1.Location = new Point(19, 321);
            no_1.Margin = new Padding(3, 4, 3, 4);
            no_1.Name = "no_1";
            no_1.Size = new Size(57, 47);
            no_1.TabIndex = 19;
            no_1.Text = "1";
            no_1.UseVisualStyleBackColor = true;
            no_1.Click += no_1_Click;
            // 
            // no_0
            // 
            no_0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            no_0.Location = new Point(103, 424);
            no_0.Margin = new Padding(3, 4, 3, 4);
            no_0.Name = "no_0";
            no_0.Size = new Size(57, 47);
            no_0.TabIndex = 18;
            no_0.Text = "0";
            no_0.UseVisualStyleBackColor = true;
            no_0.Click += no_0_Click;
            // 
            // calculatebox
            // 
            calculatebox.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calculatebox.Location = new Point(19, 31);
            calculatebox.Margin = new Padding(3, 4, 3, 4);
            calculatebox.Name = "calculatebox";
            calculatebox.Size = new Size(308, 39);
            calculatebox.TabIndex = 17;
            // 
            // decimalpoint
            // 
            decimalpoint.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            decimalpoint.Location = new Point(181, 425);
            decimalpoint.Margin = new Padding(3, 4, 3, 4);
            decimalpoint.Name = "decimalpoint";
            decimalpoint.Size = new Size(57, 47);
            decimalpoint.TabIndex = 34;
            decimalpoint.Text = ".";
            decimalpoint.UseVisualStyleBackColor = true;
            decimalpoint.Click += decimalpoint_Click;
            // 
            // calculatorgui
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 488);
            Controls.Add(decimalpoint);
            Controls.Add(equals);
            Controls.Add(divide);
            Controls.Add(multiply);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(backspace);
            Controls.Add(no_9);
            Controls.Add(no_8);
            Controls.Add(no_7);
            Controls.Add(no_6);
            Controls.Add(no_5);
            Controls.Add(no_4);
            Controls.Add(no_3);
            Controls.Add(no_2);
            Controls.Add(no_1);
            Controls.Add(no_0);
            Controls.Add(calculatebox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "calculatorgui";
            Text = "calculatorgui";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button equals;
        private Button divide;
        private Button multiply;
        private Button minus;
        private Button plus;
        private Button backspace;
        private Button no_9;
        private Button no_8;
        private Button no_7;
        private Button no_6;
        private Button no_5;
        private Button no_4;
        private Button no_3;
        private Button no_2;
        private Button no_1;
        private Button no_0;
        private TextBox calculatebox;
        private Button decimalpoint;
    }
}