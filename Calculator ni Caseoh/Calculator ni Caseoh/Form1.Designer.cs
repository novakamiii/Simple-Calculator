namespace Calculator_ni_Caseoh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            title = new Label();
            txtTotal = new TextBox();
            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnEquals = new Button();
            btnClear = new Button();
            btnPoint = new Button();
            btnsuprise = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            sqrt = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Lady Radical", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title.ForeColor = Color.White;
            title.Location = new Point(4, 10);
            title.Name = "title";
            title.Size = new Size(143, 21);
            title.TabIndex = 2;
            title.Text = "Calculator alpha 0.1";
            title.Click += label1_Click;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.White;
            txtTotal.Cursor = Cursors.No;
            txtTotal.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.ForeColor = SystemColors.WindowFrame;
            txtTotal.Location = new Point(4, 34);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(367, 63);
            txtTotal.TabIndex = 3;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Gray;
            btn0.FlatAppearance.BorderColor = Color.Gray;
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatStyle = FlatStyle.Popup;
            btn0.ForeColor = Color.White;
            btn0.Location = new Point(107, 413);
            btn0.Name = "btn0";
            btn0.Size = new Size(66, 60);
            btn0.TabIndex = 5;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += button2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Gray;
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(6, 332);
            btn1.Name = "btn1";
            btn1.Size = new Size(66, 60);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Gray;
            btn2.FlatStyle = FlatStyle.Popup;
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(107, 332);
            btn2.Name = "btn2";
            btn2.Size = new Size(66, 60);
            btn2.TabIndex = 7;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click_1;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Gray;
            btn3.FlatStyle = FlatStyle.Popup;
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(208, 332);
            btn3.Name = "btn3";
            btn3.Size = new Size(66, 60);
            btn3.TabIndex = 8;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += button4_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Gray;
            btn6.FlatStyle = FlatStyle.Popup;
            btn6.ForeColor = Color.White;
            btn6.Location = new Point(208, 251);
            btn6.Name = "btn6";
            btn6.Size = new Size(66, 60);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Gray;
            btn5.FlatStyle = FlatStyle.Popup;
            btn5.ForeColor = Color.White;
            btn5.Location = new Point(107, 251);
            btn5.Name = "btn5";
            btn5.Size = new Size(66, 60);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Gray;
            btn4.FlatStyle = FlatStyle.Popup;
            btn4.ForeColor = Color.White;
            btn4.Location = new Point(6, 251);
            btn4.Name = "btn4";
            btn4.Size = new Size(66, 60);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Gray;
            btn9.FlatStyle = FlatStyle.Popup;
            btn9.ForeColor = Color.White;
            btn9.Location = new Point(208, 169);
            btn9.Name = "btn9";
            btn9.Size = new Size(66, 60);
            btn9.TabIndex = 14;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Gray;
            btn8.FlatStyle = FlatStyle.Popup;
            btn8.ForeColor = Color.White;
            btn8.Location = new Point(107, 169);
            btn8.Name = "btn8";
            btn8.Size = new Size(66, 60);
            btn8.TabIndex = 13;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Gray;
            btn7.FlatStyle = FlatStyle.Popup;
            btn7.ForeColor = Color.White;
            btn7.Location = new Point(6, 169);
            btn7.Name = "btn7";
            btn7.Size = new Size(66, 60);
            btn7.TabIndex = 12;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.OrangeRed;
            btnEquals.FlatAppearance.BorderSize = 0;
            btnEquals.FlatStyle = FlatStyle.Flat;
            btnEquals.ForeColor = Color.White;
            btnEquals.Location = new Point(304, 332);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(66, 141);
            btnEquals.TabIndex = 18;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DimGray;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(304, 251);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(66, 60);
            btnClear.TabIndex = 20;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += button16_Click;
            // 
            // btnPoint
            // 
            btnPoint.BackColor = Color.DimGray;
            btnPoint.FlatStyle = FlatStyle.Popup;
            btnPoint.ForeColor = Color.White;
            btnPoint.Location = new Point(208, 413);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(66, 60);
            btnPoint.TabIndex = 21;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = false;
            btnPoint.Click += btnPoint_Click;
            // 
            // btnsuprise
            // 
            btnsuprise.BackColor = Color.DimGray;
            btnsuprise.FlatStyle = FlatStyle.Popup;
            btnsuprise.ForeColor = Color.White;
            btnsuprise.Location = new Point(6, 413);
            btnsuprise.Name = "btnsuprise";
            btnsuprise.Size = new Size(65, 60);
            btnsuprise.TabIndex = 23;
            btnsuprise.Text = "?";
            btnsuprise.UseVisualStyleBackColor = false;
            btnsuprise.Click += button1_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatAppearance.BorderColor = Color.DimGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(6, 110);
            button1.Name = "button1";
            button1.Size = new Size(66, 33);
            button1.TabIndex = 15;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnPlus_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.FlatAppearance.BorderColor = Color.DimGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(107, 110);
            button2.Name = "button2";
            button2.Size = new Size(66, 33);
            button2.TabIndex = 16;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnMinus_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.FlatAppearance.BorderColor = Color.DimGray;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(304, 110);
            button3.Name = "button3";
            button3.Size = new Size(66, 33);
            button3.TabIndex = 17;
            button3.Text = "/";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button13_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DimGray;
            button4.FlatAppearance.BorderColor = Color.DimGray;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(208, 110);
            button4.Name = "button4";
            button4.Size = new Size(66, 33);
            button4.TabIndex = 19;
            button4.Text = "*";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnMultiply_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DimGray;
            button5.FlatAppearance.BorderColor = Color.White;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Wingdings", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 2);
            button5.ForeColor = Color.White;
            button5.Location = new Point(304, 202);
            button5.Name = "button5";
            button5.Size = new Size(66, 27);
            button5.TabIndex = 22;
            button5.Text = "ß";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button18_Click;
            // 
            // sqrt
            // 
            sqrt.BackColor = Color.DimGray;
            sqrt.FlatAppearance.BorderColor = Color.DimGray;
            sqrt.FlatAppearance.BorderSize = 0;
            sqrt.FlatAppearance.MouseDownBackColor = Color.White;
            sqrt.FlatStyle = FlatStyle.Flat;
            sqrt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sqrt.ForeColor = Color.White;
            sqrt.Location = new Point(304, 169);
            sqrt.Name = "sqrt";
            sqrt.Size = new Size(66, 27);
            sqrt.TabIndex = 24;
            sqrt.Text = "sqrt";
            sqrt.UseVisualStyleBackColor = false;
            sqrt.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Determination Sans", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(170, 12);
            label1.Name = "label1";
            label1.Size = new Size(201, 13);
            label1.TabIndex = 25;
            label1.Text = "really simple, not that complicated.";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            ClientSize = new Size(393, 502);
            Controls.Add(label1);
            Controls.Add(sqrt);
            Controls.Add(button3);
            Controls.Add(btnsuprise);
            Controls.Add(button5);
            Controls.Add(btnPoint);
            Controls.Add(btnClear);
            Controls.Add(button4);
            Controls.Add(btnEquals);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn0);
            Controls.Add(txtTotal);
            Controls.Add(title);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Simple Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label title;
        private TextBox txtTotal;
        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnEquals;
        private Button btnClear;
        private Button btnPoint;
        private Button btnsuprise;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button sqrt;
        private Label label1;
    }
}
