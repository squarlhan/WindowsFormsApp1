using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        int ZuanGan = 1;//钻杆的数量
        int ZuanTing = 1;//钻铤的数量
        int TaoGuan = 1;//套管的数量
        const int MaxRow = 10;//最多十行
        const int MinRow = 1;//最少一行
        //钻杆
        int FirstTextBox = 36;//最初等于36
        int SecondTextBox = 37;//最初等于37
        int ThirdTextBox = 38;//最初等于38
        int ForthTextBox = 39;//最初等于39
        int FifthTextBox = 40;//最初等于40
        //钻铤
        int FirstTextBoxZuanTing = 100;
        int SecondTextBoxZuanTing = 101;
        int ThirdTextBoxZuanTing = 102;
        int ForthTextBoxZuanTing = 103;
        int FifthTextBoxZuanTing = 104;
        //套管
        int FirstTextBoxTaoGuan = 200;
        int SecondTextBoxTaoGuan = 201;
        public Form3()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void ucControlBase1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ucDataGridView1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucBtnExt13_BtnClick(object sender, EventArgs e)
        {
            //套管增加
            if (TaoGuan < MaxRow)
            {
                Label newLabel = new Label();//初始化label
                this.panelEx7.Controls.Add(newLabel);//将label添加到面板中
                                                     //设置该label的属性
                newLabel.AutoSize = true;
                newLabel.Font = new Font("微软雅黑", 15F);
                newLabel.ForeColor = Color.White;
                Label temp = null;
                HZH_Controls.Controls.UCTextBoxEx temp1 = null;
                HZH_Controls.Controls.UCTextBoxEx temp2 = null;
                //先把六个目标找到
                foreach (Control ctrl in this.panelEx7.Controls)//在这个面板中找到最新的label
                {
                    if (ctrl is Label)
                    {
                        if (string.Equals(ctrl.Text, "套管" + TaoGuan))
                        {
                            temp = (Label)ctrl;
                        }
                    }
                    if (ctrl is HZH_Controls.Controls.UCTextBoxEx)
                    {
                        if (string.Equals(ctrl.Name, "ucTextBoxEx" + FirstTextBoxTaoGuan))
                        {
                            temp1 = (HZH_Controls.Controls.UCTextBoxEx)ctrl;
                        }
                        else if (string.Equals(ctrl.Name, "ucTextBoxEx" + SecondTextBoxTaoGuan))
                        {
                            temp2 = (HZH_Controls.Controls.UCTextBoxEx)ctrl;
                        }
                    }
                }
                if (temp != null)
                {
                    newLabel.Location = new Point(temp.Location.X, temp.Location.Y + temp.Size.Height + 30);
                }
                newLabel.Name = "label" + (200 + TaoGuan - 1);//从label50开始命名
                newLabel.Size = new Size(80, 32);
                newLabel.Text = "套管" + (++TaoGuan);

                //初始化一到五个文本框
                HZH_Controls.Controls.UCTextBoxEx newTextBox1 = new HZH_Controls.Controls.UCTextBoxEx();
                HZH_Controls.Controls.UCTextBoxEx newTextBox2 = new HZH_Controls.Controls.UCTextBoxEx();
                List<HZH_Controls.Controls.UCTextBoxEx> newList = new List<HZH_Controls.Controls.UCTextBoxEx>();
                newList.Add(newTextBox1); newList.Add(newTextBox2); 

                for (int i = 0; i < 2; i++)
                {
                    this.panelEx7.Controls.Add(newList[i]);
                    newList[i].BackColor = System.Drawing.SystemColors.ControlDarkDark;
                    newList[i].ConerRadius = 5;
                    newList[i].Cursor = System.Windows.Forms.Cursors.IBeam;
                    newList[i].DecLength = 2;
                    newList[i].FillColor = System.Drawing.SystemColors.ControlDarkDark;
                    newList[i].FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
                    newList[i].Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                    newList[i].InputText = "";
                    newList[i].InputType = HZH_Controls.TextInputType.NotControl;
                    newList[i].IsFocusColor = true;
                    newList[i].IsRadius = true;
                    newList[i].IsShowClearBtn = true;
                    newList[i].IsShowKeyboard = false;
                    newList[i].IsShowRect = true;
                    newList[i].IsShowSearchBtn = false;
                    newList[i].BackColor = System.Drawing.SystemColors.ControlDarkDark;
                    newList[i].ConerRadius = 5;
                    newList[i].Cursor = System.Windows.Forms.Cursors.IBeam;
                    newList[i].DecLength = 2;
                    newList[i].FillColor = System.Drawing.SystemColors.ControlDarkDark;
                    newList[i].FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
                    newList[i].Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                    newList[i].InputText = "";
                    newList[i].InputType = HZH_Controls.TextInputType.NotControl;
                    newList[i].IsFocusColor = true;
                    newList[i].IsRadius = true;
                    newList[i].IsShowClearBtn = true;
                    newList[i].IsShowKeyboard = false;
                    newList[i].IsShowRect = true;
                    newList[i].IsShowSearchBtn = false;
                    newList[i].KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
                    if (i == 0)
                    {
                        newList[i].Location = new Point(temp1.Location.X, temp1.Location.Y + temp1.Size.Height + 20);
                        FirstTextBoxTaoGuan += 5;
                        newList[i].Name = "ucTextBoxEx" + FirstTextBoxTaoGuan;
                    }
                    else if (i == 1)
                    {
                        newList[i].Location = new Point(temp2.Location.X, temp2.Location.Y + temp2.Size.Height + 20);
                        SecondTextBoxTaoGuan += 5;
                        newList[i].Name = "ucTextBoxEx" + SecondTextBoxTaoGuan;
                    }
                    
                    newList[i].MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
                    newList[i].MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
                    newList[i].Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
                    newList[i].Padding = new System.Windows.Forms.Padding(5);
                    newList[i].PromptColor = System.Drawing.Color.Gray;
                    newList[i].PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                    newList[i].PromptText = "";
                    newList[i].RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
                    newList[i].RectWidth = 1;
                    newList[i].RegexPattern = "";
                    newList[i].Size = new System.Drawing.Size(156, 42);

                }

            }

        }

        private void ucBtnExt10_BtnClick(object sender, EventArgs e)
        {
            //钻杆增加
            if (ZuanGan < MaxRow)
            {
                Label newLabel = new Label();//初始化label
                this.panelEx5.Controls.Add(newLabel);//将label添加到面板中
                                                     //设置该label的属性
                newLabel.AutoSize = true;
                newLabel.Font = new Font("微软雅黑", 10F);
                newLabel.ForeColor = Color.White;
                Label temp = null;
                HZH_Controls.Controls.UCTextBoxEx temp1 = null;
                HZH_Controls.Controls.UCTextBoxEx temp2 = null;
                HZH_Controls.Controls.UCTextBoxEx temp3 = null;
                HZH_Controls.Controls.UCTextBoxEx temp4 = null;
                HZH_Controls.Controls.UCTextBoxEx temp5 = null;
                //先把六个目标找到
                foreach (Control ctrl in this.panelEx5.Controls)//在这个面板中找到最新的label
                {
                    if (ctrl is Label)
                    {
                        if (string.Equals(ctrl.Text, "钻杆" + ZuanGan))
                        {
                            temp = (Label)ctrl;
                        }
                    }
                    if (ctrl is HZH_Controls.Controls.UCTextBoxEx)
                    {
                        if (string.Equals(ctrl.Name, "ucTextBoxEx" + FirstTextBox))
                        {
                            temp1 = (HZH_Controls.Controls.UCTextBoxEx)ctrl;
                        }
                        else if (string.Equals(ctrl.Name, "ucTextBoxEx" + SecondTextBox))
                        {
                            temp2 = (HZH_Controls.Controls.UCTextBoxEx)ctrl;
                        }
                        else if (string.Equals(ctrl.Name, "ucTextBoxEx" + ThirdTextBox))
                        {
                            temp3 = (HZH_Controls.Controls.UCTextBoxEx)ctrl;
                        }
                        else if (string.Equals(ctrl.Name, "ucTextBoxEx" + ForthTextBox))
                        {
                            temp4 = (HZH_Controls.Controls.UCTextBoxEx)ctrl;
                        }
                        else if (string.Equals(ctrl.Name, "ucTextBoxEx" + FifthTextBox))
                        {
                            temp5 = (HZH_Controls.Controls.UCTextBoxEx)ctrl;
                        }
                    }
                }
                if (temp != null)
                {
                    newLabel.Location = new Point(temp.Location.X, temp.Location.Y + temp.Size.Height + 40);
                }
                newLabel.Name = "label" + (50 + ZuanGan - 1);//从label50开始命名
                newLabel.Size = new Size(54, 23);
                newLabel.Text = "钻杆" + (++ZuanGan);

                //初始化一到五个文本框
                HZH_Controls.Controls.UCTextBoxEx newTextBox1 = new HZH_Controls.Controls.UCTextBoxEx();
                HZH_Controls.Controls.UCTextBoxEx newTextBox2 = new HZH_Controls.Controls.UCTextBoxEx();
                HZH_Controls.Controls.UCTextBoxEx newTextBox3 = new HZH_Controls.Controls.UCTextBoxEx();
                HZH_Controls.Controls.UCTextBoxEx newTextBox4 = new HZH_Controls.Controls.UCTextBoxEx();
                HZH_Controls.Controls.UCTextBoxEx newTextBox5 = new HZH_Controls.Controls.UCTextBoxEx();
                List<HZH_Controls.Controls.UCTextBoxEx> newList = new List<HZH_Controls.Controls.UCTextBoxEx>();
                newList.Add(newTextBox1); newList.Add(newTextBox2); newList.Add(newTextBox3); newList.Add(newTextBox4); newList.Add(newTextBox5);

                for (int i = 0; i < 5; i++)
                {
                    this.panelEx5.Controls.Add(newList[i]);
                    newList[i].BackColor = System.Drawing.SystemColors.ControlDarkDark;
                    newList[i].ConerRadius = 5;
                    newList[i].Cursor = System.Windows.Forms.Cursors.IBeam;
                    newList[i].DecLength = 2;
                    newList[i].FillColor = System.Drawing.SystemColors.ControlDarkDark;
                    newList[i].FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
                    newList[i].Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                    newList[i].InputText = "";
                    newList[i].InputType = HZH_Controls.TextInputType.NotControl;
                    newList[i].IsFocusColor = true;
                    newList[i].IsRadius = true;
                    newList[i].IsShowClearBtn = true;
                    newList[i].IsShowKeyboard = false;
                    newList[i].IsShowRect = true;
                    newList[i].IsShowSearchBtn = false;
                    newList[i].BackColor = System.Drawing.SystemColors.ControlDarkDark;
                    newList[i].ConerRadius = 5;
                    newList[i].Cursor = System.Windows.Forms.Cursors.IBeam;
                    newList[i].DecLength = 2;
                    newList[i].FillColor = System.Drawing.SystemColors.ControlDarkDark;
                    newList[i].FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
                    newList[i].Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                    newList[i].InputText = "";
                    newList[i].InputType = HZH_Controls.TextInputType.NotControl;
                    newList[i].IsFocusColor = true;
                    newList[i].IsRadius = true;
                    newList[i].IsShowClearBtn = true;
                    newList[i].IsShowKeyboard = false;
                    newList[i].IsShowRect = true;
                    newList[i].IsShowSearchBtn = false;
                    newList[i].KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
                    if (i == 0)
                    {
                        newList[i].Location = new Point(temp1.Location.X, temp1.Location.Y + temp1.Size.Height + 20);
                        FirstTextBox += 5;
                        newList[i].Name = "ucTextBoxEx" + FirstTextBox;
                    }
                    else if (i == 1)
                    {
                        newList[i].Location = new Point(temp2.Location.X, temp2.Location.Y + temp2.Size.Height + 20);
                        SecondTextBox += 5;
                        newList[i].Name = "ucTextBoxEx" + SecondTextBox;
                    }
                    else if (i == 2)
                    {
                        newList[i].Location = new Point(temp3.Location.X, temp3.Location.Y + temp3.Size.Height + 20);
                        ThirdTextBox += 5;
                        newList[i].Name = "ucTextBoxEx" + ThirdTextBox;
                    }
                    else if (i == 3)
                    {
                        newList[i].Location = new Point(temp4.Location.X, temp4.Location.Y + temp4.Size.Height + 20);
                        ForthTextBox += 5;
                        newList[i].Name = "ucTextBoxEx" + ForthTextBox;
                    }
                    else if (i == 4)
                    {
                        newList[i].Location = new Point(temp5.Location.X, temp5.Location.Y + temp5.Size.Height + 20);
                        FifthTextBox += 5;
                        newList[i].Name = "ucTextBoxEx" + FifthTextBox;
                    }
                    newList[i].MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
                    newList[i].MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
                    newList[i].Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
                    newList[i].Padding = new System.Windows.Forms.Padding(5);
                    newList[i].PromptColor = System.Drawing.Color.Gray;
                    newList[i].PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                    newList[i].PromptText = "";
                    newList[i].RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
                    newList[i].RectWidth = 1;
                    newList[i].RegexPattern = "";
                    newList[i].Size = new System.Drawing.Size(156, 42);

                }

            }






        }

        private void ucBtnExt11_BtnClick(object sender, EventArgs e)
        {
            //钻杆减少
            if (ZuanGan > MinRow)
            {
                RemoveControl(this.panelEx5.Controls);
            }
        }

        void RemoveControl(Control.ControlCollection list)
        {
            //钻杆减少的函数
            foreach (Control ctrl in list)
            {
                if(ctrl is Label)
                {
                    if (string.Equals(ctrl.Text, "钻杆" + ZuanGan))
                    {
                        list.Remove(ctrl);
                        ZuanGan--;
                        break;
                    }
                }
            }
            foreach(Control ctrl in list)
            {
                if(ctrl is HZH_Controls.Controls.UCTextBoxEx)
                {
                    if (string.Equals(ctrl.Name, "ucTextBoxEx" + FirstTextBox))
                    {
                        list.Remove(ctrl);
                        FirstTextBox = FirstTextBox - 5; ;
                        break;
                    }
                }
            }
            foreach (Control ctrl in list)
            {
                if (ctrl is HZH_Controls.Controls.UCTextBoxEx)
                {
                    if (string.Equals(ctrl.Name, "ucTextBoxEx" + SecondTextBox))
                    {
                        list.Remove(ctrl);
                        SecondTextBox = SecondTextBox - 5;
                        break;
                    }
                }
            }
            foreach (Control ctrl in list)
            {
                if (ctrl is HZH_Controls.Controls.UCTextBoxEx)
                {
                    if (string.Equals(ctrl.Name, "ucTextBoxEx" + ThirdTextBox))
                    {
                        list.Remove(ctrl);
                        ThirdTextBox = ThirdTextBox - 5; 
                        break;
                    }
                }
            }
            foreach (Control ctrl in list)
            {
                if (ctrl is HZH_Controls.Controls.UCTextBoxEx)
                {
                    if (string.Equals(ctrl.Name, "ucTextBoxEx" + ForthTextBox))
                    {
                        list.Remove(ctrl);
                        ForthTextBox = ForthTextBox - 5;
                        break;
                    }
                }
            }
            foreach (Control ctrl in list)
            {
                if (ctrl is HZH_Controls.Controls.UCTextBoxEx)
                {
                    if (string.Equals(ctrl.Name, "ucTextBoxEx" + FifthTextBox))
                    {
                        list.Remove(ctrl);
                        FifthTextBox = FifthTextBox - 5;
                        break;
                    }
                }
            }
        }

        private void ucBtnExt15_BtnClick(object sender, EventArgs e)
        {
            //钻铤增加
            if (ZuanTing < MaxRow)
            {
                Label newLabel = new Label();//初始化label
                this.panelEx6.Controls.Add(newLabel);//将label添加到面板中
                                                     //设置该label的属性
                newLabel.AutoSize = true;
                newLabel.Font = new Font("微软雅黑", 10F);
                newLabel.ForeColor = Color.White;
                Label temp = null;
                HZH_Controls.Controls.UCTextBoxEx temp1 = null;
                HZH_Controls.Controls.UCTextBoxEx temp2 = null;
                HZH_Controls.Controls.UCTextBoxEx temp3 = null;
                HZH_Controls.Controls.UCTextBoxEx temp4 = null;
                HZH_Controls.Controls.UCTextBoxEx temp5 = null;
                //先把六个目标找到
                foreach (Control ctrl in this.panelEx6.Controls)//在这个面板中找到最新的label
                {
                    if (ctrl is Label)
                    {
                        if (string.Equals(ctrl.Text, "钻铤" + ZuanTing))
                        {
                            temp = (Label)ctrl;
                        }
                    }
                    if (ctrl is HZH_Controls.Controls.UCTextBoxEx)
                    {
                        if (string.Equals(ctrl.Name, "ucTextBoxEx" + FirstTextBoxZuanTing))
                        {
                            temp1 = (HZH_Controls.Controls.UCTextBoxEx)ctrl;
                        }
                        else if (string.Equals(ctrl.Name, "ucTextBoxEx" + SecondTextBoxZuanTing))
                        {
                            temp2 = (HZH_Controls.Controls.UCTextBoxEx)ctrl;
                        }
                        else if (string.Equals(ctrl.Name, "ucTextBoxEx" + ThirdTextBoxZuanTing))
                        {
                            temp3 = (HZH_Controls.Controls.UCTextBoxEx)ctrl;
                        }
                        else if (string.Equals(ctrl.Name, "ucTextBoxEx" + ForthTextBoxZuanTing))
                        {
                            temp4 = (HZH_Controls.Controls.UCTextBoxEx)ctrl;
                        }
                        else if (string.Equals(ctrl.Name, "ucTextBoxEx" + FifthTextBoxZuanTing))
                        {
                            temp5 = (HZH_Controls.Controls.UCTextBoxEx)ctrl;
                        }
                    }
                }
                if (temp != null)
                {
                    newLabel.Location = new Point(temp.Location.X, temp.Location.Y + temp.Size.Height + 40);
                }
                newLabel.Name = "label" + (100 + ZuanTing - 1);//从label50开始命名
                newLabel.Size = new Size(54, 23);
                newLabel.Text = "钻铤" + (++ZuanTing);

                //初始化一到五个文本框
                HZH_Controls.Controls.UCTextBoxEx newTextBox1 = new HZH_Controls.Controls.UCTextBoxEx();
                HZH_Controls.Controls.UCTextBoxEx newTextBox2 = new HZH_Controls.Controls.UCTextBoxEx();
                HZH_Controls.Controls.UCTextBoxEx newTextBox3 = new HZH_Controls.Controls.UCTextBoxEx();
                HZH_Controls.Controls.UCTextBoxEx newTextBox4 = new HZH_Controls.Controls.UCTextBoxEx();
                HZH_Controls.Controls.UCTextBoxEx newTextBox5 = new HZH_Controls.Controls.UCTextBoxEx();
                List<HZH_Controls.Controls.UCTextBoxEx> newList = new List<HZH_Controls.Controls.UCTextBoxEx>();
                newList.Add(newTextBox1); newList.Add(newTextBox2); newList.Add(newTextBox3); newList.Add(newTextBox4); newList.Add(newTextBox5);

                for (int i = 0; i < 5; i++)
                {
                    this.panelEx6.Controls.Add(newList[i]);
                    newList[i].BackColor = System.Drawing.SystemColors.ControlDarkDark;
                    newList[i].ConerRadius = 5;
                    newList[i].Cursor = System.Windows.Forms.Cursors.IBeam;
                    newList[i].DecLength = 2;
                    newList[i].FillColor = System.Drawing.SystemColors.ControlDarkDark;
                    newList[i].FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
                    newList[i].Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                    newList[i].InputText = "";
                    newList[i].InputType = HZH_Controls.TextInputType.NotControl;
                    newList[i].IsFocusColor = true;
                    newList[i].IsRadius = true;
                    newList[i].IsShowClearBtn = true;
                    newList[i].IsShowKeyboard = false;
                    newList[i].IsShowRect = true;
                    newList[i].IsShowSearchBtn = false;
                    newList[i].BackColor = System.Drawing.SystemColors.ControlDarkDark;
                    newList[i].ConerRadius = 5;
                    newList[i].Cursor = System.Windows.Forms.Cursors.IBeam;
                    newList[i].DecLength = 2;
                    newList[i].FillColor = System.Drawing.SystemColors.ControlDarkDark;
                    newList[i].FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
                    newList[i].Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                    newList[i].InputText = "";
                    newList[i].InputType = HZH_Controls.TextInputType.NotControl;
                    newList[i].IsFocusColor = true;
                    newList[i].IsRadius = true;
                    newList[i].IsShowClearBtn = true;
                    newList[i].IsShowKeyboard = false;
                    newList[i].IsShowRect = true;
                    newList[i].IsShowSearchBtn = false;
                    newList[i].KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
                    if (i == 0)
                    {
                        newList[i].Location = new Point(temp1.Location.X, temp1.Location.Y + temp1.Size.Height + 20);
                        FirstTextBoxZuanTing += 5;
                        newList[i].Name = "ucTextBoxEx" + FirstTextBoxZuanTing;
                    }
                    else if (i == 1)
                    {
                        newList[i].Location = new Point(temp2.Location.X, temp2.Location.Y + temp2.Size.Height + 20);
                        SecondTextBoxZuanTing += 5;
                        newList[i].Name = "ucTextBoxEx" + SecondTextBoxZuanTing;
                    }
                    else if (i == 2)
                    {
                        newList[i].Location = new Point(temp3.Location.X, temp3.Location.Y + temp3.Size.Height + 20);
                        ThirdTextBoxZuanTing += 5;
                        newList[i].Name = "ucTextBoxEx" + ThirdTextBoxZuanTing;
                    }
                    else if (i == 3)
                    {
                        newList[i].Location = new Point(temp4.Location.X, temp4.Location.Y + temp4.Size.Height + 20);
                        ForthTextBoxZuanTing += 5;
                        newList[i].Name = "ucTextBoxEx" +  ForthTextBoxZuanTing;
                    }
                    else if (i == 4)
                    {
                        newList[i].Location = new Point(temp5.Location.X, temp5.Location.Y + temp5.Size.Height + 20);
                        FifthTextBoxZuanTing += 5;
                        newList[i].Name = "ucTextBoxEx" +FifthTextBoxZuanTing;
                    }
                    newList[i].MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
                    newList[i].MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
                    newList[i].Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
                    newList[i].Padding = new System.Windows.Forms.Padding(5);
                    newList[i].PromptColor = System.Drawing.Color.Gray;
                    newList[i].PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                    newList[i].PromptText = "";
                    newList[i].RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
                    newList[i].RectWidth = 1;
                    newList[i].RegexPattern = "";
                    newList[i].Size = new System.Drawing.Size(156, 42);

                }

            }


        }

        private void ucBtnExt14_BtnClick(object sender, EventArgs e)
        {
            //钻铤减少
            if (ZuanTing > MinRow)
            {
                RemoveControlZuanTing(this.panelEx6.Controls);
            }
        }

        void RemoveControlZuanTing(Control.ControlCollection list)
        {
            //钻铤减少的函数
            foreach (Control ctrl in list)
            {
                if (ctrl is Label)
                {
                    if (string.Equals(ctrl.Text, "钻铤" + ZuanTing))
                    {
                        list.Remove(ctrl);
                        ZuanTing--;
                        break;
                    }
                }
            }
            foreach (Control ctrl in list)
            {
                if (ctrl is HZH_Controls.Controls.UCTextBoxEx)
                {
                    if (string.Equals(ctrl.Name, "ucTextBoxEx" + FirstTextBoxZuanTing))
                    {
                        list.Remove(ctrl);
                        FirstTextBoxZuanTing = FirstTextBoxZuanTing - 5; ;
                        break;
                    }
                }
            }
            foreach (Control ctrl in list)
            {
                if (ctrl is HZH_Controls.Controls.UCTextBoxEx)
                {
                    if (string.Equals(ctrl.Name, "ucTextBoxEx" + SecondTextBoxZuanTing))
                    {
                        list.Remove(ctrl);
                        SecondTextBoxZuanTing = SecondTextBoxZuanTing - 5;
                        break;
                    }
                }
            }
            foreach (Control ctrl in list)
            {
                if (ctrl is HZH_Controls.Controls.UCTextBoxEx)
                {
                    if (string.Equals(ctrl.Name, "ucTextBoxEx" + ThirdTextBoxZuanTing))
                    {
                        list.Remove(ctrl);
                        ThirdTextBoxZuanTing = ThirdTextBoxZuanTing - 5;
                        break;
                    }
                }
            }
            foreach (Control ctrl in list)
            {
                if (ctrl is HZH_Controls.Controls.UCTextBoxEx)
                {
                    if (string.Equals(ctrl.Name, "ucTextBoxEx" + ForthTextBoxZuanTing))
                    {
                        list.Remove(ctrl);
                        ForthTextBoxZuanTing = ForthTextBoxZuanTing - 5;
                        break;
                    }
                }
            }
            foreach (Control ctrl in list)
            {
                if (ctrl is HZH_Controls.Controls.UCTextBoxEx)
                {
                    if (string.Equals(ctrl.Name, "ucTextBoxEx" + FifthTextBoxZuanTing))
                    {
                        list.Remove(ctrl);
                        FifthTextBoxZuanTing = FifthTextBoxZuanTing - 5;
                        break;
                    }
                }
            }
        }

        private void ucBtnExt12_BtnClick(object sender, EventArgs e)
        {
            //套管减少
            if (TaoGuan > MinRow)
            {
                RemoveControlTaoGuan(this.panelEx7.Controls);
            }
        }

        void RemoveControlTaoGuan(Control.ControlCollection list)
        {
            //套管减少的函数
            foreach (Control ctrl in list)
            {
                if (ctrl is Label)
                {
                    if (string.Equals(ctrl.Text, "套管" + TaoGuan))
                    {
                        list.Remove(ctrl);
                        TaoGuan--;
                        break;
                    }
                }
            }
            foreach (Control ctrl in list)
            {
                if (ctrl is HZH_Controls.Controls.UCTextBoxEx)
                {
                    if (string.Equals(ctrl.Name, "ucTextBoxEx" + FirstTextBoxTaoGuan))
                    {
                        list.Remove(ctrl);
                        FirstTextBoxTaoGuan = FirstTextBoxTaoGuan - 5; ;
                        break;
                    }
                }
            }
            foreach (Control ctrl in list)
            {
                if (ctrl is HZH_Controls.Controls.UCTextBoxEx)
                {
                    if (string.Equals(ctrl.Name, "ucTextBoxEx" + SecondTextBoxTaoGuan))
                    {
                        list.Remove(ctrl);
                        SecondTextBoxTaoGuan = SecondTextBoxTaoGuan - 5;
                        break;
                    }
                }
            }
        }
    }
}
