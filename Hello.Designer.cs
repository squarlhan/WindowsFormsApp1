namespace WindowsFormsApp1
{
    partial class Hello
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ucNumTextBox11 = new HZH_Controls.Controls.UCNumTextBox();
            this.ucNumTextBox9 = new HZH_Controls.Controls.UCNumTextBox();
            this.ucTextBoxEx2 = new HZH_Controls.Controls.UCTextBoxEx();
            this.ucNumTextBox3 = new HZH_Controls.Controls.UCNumTextBox();
            this.ucTextBoxEx1 = new HZH_Controls.Controls.UCTextBoxEx();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ucNumTextBox7 = new HZH_Controls.Controls.UCNumTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello World！";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ucNumTextBox11);
            this.flowLayoutPanel1.Controls.Add(this.ucNumTextBox9);
            this.flowLayoutPanel1.Controls.Add(this.ucTextBoxEx2);
            this.flowLayoutPanel1.Controls.Add(this.ucNumTextBox3);
            this.flowLayoutPanel1.Controls.Add(this.ucTextBoxEx1);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.ucNumTextBox7);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 67);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(715, 371);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // ucNumTextBox11
            // 
            this.ucNumTextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucNumTextBox11.ForeColor = System.Drawing.Color.White;
            this.ucNumTextBox11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ucNumTextBox11.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucNumTextBox11.InputType = HZH_Controls.TextInputType.Number;
            this.ucNumTextBox11.IsNumCanInput = true;
            this.ucNumTextBox11.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderNum;
            this.ucNumTextBox11.Location = new System.Drawing.Point(4, 4);
            this.ucNumTextBox11.Margin = new System.Windows.Forms.Padding(4);
            this.ucNumTextBox11.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ucNumTextBox11.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucNumTextBox11.Name = "ucNumTextBox11";
            this.ucNumTextBox11.Num = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucNumTextBox11.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucNumTextBox11.Size = new System.Drawing.Size(186, 40);
            this.ucNumTextBox11.TabIndex = 48;
            // 
            // ucNumTextBox9
            // 
            this.ucNumTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucNumTextBox9.ForeColor = System.Drawing.Color.White;
            this.ucNumTextBox9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ucNumTextBox9.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucNumTextBox9.InputType = HZH_Controls.TextInputType.Number;
            this.ucNumTextBox9.IsNumCanInput = true;
            this.ucNumTextBox9.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderNum;
            this.ucNumTextBox9.Location = new System.Drawing.Point(198, 4);
            this.ucNumTextBox9.Margin = new System.Windows.Forms.Padding(4);
            this.ucNumTextBox9.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ucNumTextBox9.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucNumTextBox9.Name = "ucNumTextBox9";
            this.ucNumTextBox9.Num = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucNumTextBox9.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucNumTextBox9.Size = new System.Drawing.Size(186, 40);
            this.ucNumTextBox9.TabIndex = 47;
            // 
            // ucTextBoxEx2
            // 
            this.ucTextBoxEx2.BackColor = System.Drawing.Color.DimGray;
            this.ucTextBoxEx2.ConerRadius = 5;
            this.ucTextBoxEx2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucTextBoxEx2.DecLength = 2;
            this.ucTextBoxEx2.FillColor = System.Drawing.Color.DimGray;
            this.ucTextBoxEx2.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucTextBoxEx2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx2.InputText = "";
            this.ucTextBoxEx2.InputType = HZH_Controls.TextInputType.NotControl;
            this.ucTextBoxEx2.IsFocusColor = true;
            this.ucTextBoxEx2.IsRadius = true;
            this.ucTextBoxEx2.IsShowClearBtn = true;
            this.ucTextBoxEx2.IsShowKeyboard = true;
            this.ucTextBoxEx2.IsShowRect = true;
            this.ucTextBoxEx2.IsShowSearchBtn = false;
            this.ucTextBoxEx2.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderNum;
            this.ucTextBoxEx2.Location = new System.Drawing.Point(392, 5);
            this.ucTextBoxEx2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucTextBoxEx2.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ucTextBoxEx2.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.ucTextBoxEx2.Name = "ucTextBoxEx2";
            this.ucTextBoxEx2.Padding = new System.Windows.Forms.Padding(5);
            this.ucTextBoxEx2.PromptColor = System.Drawing.Color.Gray;
            this.ucTextBoxEx2.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx2.PromptText = "";
            this.ucTextBoxEx2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucTextBoxEx2.RectWidth = 1;
            this.ucTextBoxEx2.RegexPattern = "";
            this.ucTextBoxEx2.Size = new System.Drawing.Size(186, 40);
            this.ucTextBoxEx2.TabIndex = 46;
            // 
            // ucNumTextBox3
            // 
            this.ucNumTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucNumTextBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.ucNumTextBox3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucNumTextBox3.InputType = HZH_Controls.TextInputType.UnsignNumber;
            this.ucNumTextBox3.IsNumCanInput = true;
            this.ucNumTextBox3.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderNum;
            this.ucNumTextBox3.Location = new System.Drawing.Point(4, 54);
            this.ucNumTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.ucNumTextBox3.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ucNumTextBox3.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucNumTextBox3.Name = "ucNumTextBox3";
            this.ucNumTextBox3.Num = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucNumTextBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucNumTextBox3.Size = new System.Drawing.Size(186, 40);
            this.ucNumTextBox3.TabIndex = 45;
            // 
            // ucTextBoxEx1
            // 
            this.ucTextBoxEx1.BackColor = System.Drawing.Color.DimGray;
            this.ucTextBoxEx1.ConerRadius = 5;
            this.ucTextBoxEx1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucTextBoxEx1.DecLength = 2;
            this.ucTextBoxEx1.FillColor = System.Drawing.Color.DimGray;
            this.ucTextBoxEx1.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucTextBoxEx1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx1.InputText = "";
            this.ucTextBoxEx1.InputType = HZH_Controls.TextInputType.NotControl;
            this.ucTextBoxEx1.IsFocusColor = true;
            this.ucTextBoxEx1.IsRadius = true;
            this.ucTextBoxEx1.IsShowClearBtn = true;
            this.ucTextBoxEx1.IsShowKeyboard = true;
            this.ucTextBoxEx1.IsShowRect = true;
            this.ucTextBoxEx1.IsShowSearchBtn = false;
            this.ucTextBoxEx1.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderNum;
            this.ucTextBoxEx1.Location = new System.Drawing.Point(198, 55);
            this.ucTextBoxEx1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucTextBoxEx1.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ucTextBoxEx1.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.ucTextBoxEx1.Name = "ucTextBoxEx1";
            this.ucTextBoxEx1.Padding = new System.Windows.Forms.Padding(5);
            this.ucTextBoxEx1.PromptColor = System.Drawing.Color.Gray;
            this.ucTextBoxEx1.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx1.PromptText = "";
            this.ucTextBoxEx1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucTextBoxEx1.RectWidth = 1;
            this.ucTextBoxEx1.RegexPattern = "";
            this.ucTextBoxEx1.Size = new System.Drawing.Size(186, 40);
            this.ucTextBoxEx1.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(392, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 19);
            this.label8.TabIndex = 42;
            this.label8.Text = "回压测量（MPa）";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 11.25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(4, 100);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 19);
            this.label9.TabIndex = 41;
            this.label9.Text = "出口密度（g/cm³）";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(185, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "回压设置（MPa）";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 11.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(346, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 19);
            this.label6.TabIndex = 39;
            this.label6.Text = "出口流量（L/s）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(507, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "立管压力（MPa）";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "入口流量（L/s）";
            // 
            // ucNumTextBox7
            // 
            this.ucNumTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucNumTextBox7.ForeColor = System.Drawing.Color.White;
            this.ucNumTextBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ucNumTextBox7.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucNumTextBox7.InputType = HZH_Controls.TextInputType.Number;
            this.ucNumTextBox7.IsNumCanInput = true;
            this.ucNumTextBox7.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderNum;
            this.ucNumTextBox7.Location = new System.Drawing.Point(165, 123);
            this.ucNumTextBox7.Margin = new System.Windows.Forms.Padding(4);
            this.ucNumTextBox7.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ucNumTextBox7.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucNumTextBox7.Name = "ucNumTextBox7";
            this.ucNumTextBox7.Num = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucNumTextBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucNumTextBox7.Size = new System.Drawing.Size(186, 40);
            this.ucNumTextBox7.TabIndex = 44;
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "Hello";
            this.Text = "Hello";
            this.TopMost = true;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private HZH_Controls.Controls.UCNumTextBox ucNumTextBox11;
        private HZH_Controls.Controls.UCNumTextBox ucNumTextBox9;
        private HZH_Controls.Controls.UCTextBoxEx ucTextBoxEx2;
        private HZH_Controls.Controls.UCNumTextBox ucNumTextBox3;
        private HZH_Controls.Controls.UCTextBoxEx ucTextBoxEx1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private HZH_Controls.Controls.UCNumTextBox ucNumTextBox7;
    }
}