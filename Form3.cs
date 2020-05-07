using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBTestCs;
using HZH_Controls.Controls;
using HZH_Controls.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        int ZuanGan = 1;//钻杆的数量
        int ZuanTing = 1;//钻铤的数量
        int TaoGuan = 1;//套管的数量
        const int MaxRow = 3;//最多三行
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
        Util u = new Util();
        public Form3()
        {
            InitializeComponent();
            
            u.init();
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
                        FirstTextBoxTaoGuan += 2;
                        newList[i].Name = "ucTextBoxEx" + FirstTextBoxTaoGuan;
                    }
                    else if (i == 1)
                    {
                        newList[i].Location = new Point(temp2.Location.X, temp2.Location.Y + temp2.Size.Height + 20);
                        SecondTextBoxTaoGuan += 2;
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

        //管柱设置
        private void ucBtnExt3_BtnClick(object sender, EventArgs e)
        {
            
            //环空容积
            try
            {
                if (ucTextBoxEx28.InputText.Length != 0)
                {
                    double hkrj = double.Parse(ucTextBoxEx28.InputText);
                    u.SetValue(37, hkrj);
                }
            }
            catch (Exception excep)
            {
                FrmDialog.ShowDialog(this, "环空容积设置存在非法输入\n" + excep.Message, "输入提示");
                return;
            }
            //裸眼段
            try
            {
                if (ucTextBoxEx27.InputText.Length != 0)
                {
                    double nj = double.Parse(ucTextBoxEx28.InputText);
                    u.SetValue(35, nj);
                }
                if (ucTextBoxEx26.InputText.Length != 0)
                {
                    double xs = double.Parse(ucTextBoxEx26.InputText);
                    u.SetValue(36, xs);
                }
            }
            catch (Exception excep)
            {
                FrmDialog.ShowDialog(this, "裸眼段存在非法输入\n" + excep.Message, "输入提示");
                return;
            }

            //套管
            try
            {
                UCTextBoxEx temp = null;
                foreach (Control ctrl in this.panelEx7.Controls)//在这个面板中找到最新的label
                {
                    int index = 200;
                    while (index <= 205) {
                        if (string.Equals(ctrl.Name, "ucTextBoxEx" + index))
                        {
                            temp = (HZH_Controls.Controls.UCTextBoxEx)ctrl;

                            if (temp.InputText.Length != 0) 
                            {
                                double value = double.Parse(temp.InputText);
                                u.SetValue(index - 171, value);
                            }
                        }
                        index++;
                    }
                    
                }
            }
            catch (Exception excep)
            {
                FrmDialog.ShowDialog(this, "套管存在非法输入\n" + excep.Message, "输入提示");
                return;
            }

            //钻杆
            try
            {
                UCTextBoxEx temp = null;
                foreach (Control ctrl in this.panelEx5.Controls)//在这个面板中找到最新的label
                {
                    int index = 36;
                    while (index <= 45)
                    {
                        if (string.Equals(ctrl.Name, "ucTextBoxEx" + index))
                        {
                            temp = (HZH_Controls.Controls.UCTextBoxEx)ctrl;

                            if (temp.InputText.Length != 0)
                            {
                                double value = double.Parse(temp.InputText);
                                u.SetValue(index + 2, value);
                            }
                        }
                        index++;
                    }

                }
            }
            catch (Exception excep)
            {
                FrmDialog.ShowDialog(this, "钻杆存在非法输入\n" + excep.Message, "输入提示");
                return;
            }
            //钻铤
            try
            {
                UCTextBoxEx temp = null;
                foreach (Control ctrl in this.panelEx6.Controls)//在这个面板中找到最新的label
                {
                    int index = 100;
                    while (index <= 114)
                    {
                        if (string.Equals(ctrl.Name, "ucTextBoxEx" + index))
                        {
                            temp = (HZH_Controls.Controls.UCTextBoxEx)ctrl;

                            if (temp.InputText.Length != 0)
                            {
                                double value = double.Parse(temp.InputText);
                                u.SetValue(index - 52, value);
                            }
                        }
                        index++;
                    }

                }
            }
            catch (Exception excep)
            {
                FrmDialog.ShowDialog(this, "钻铤存在非法输入\n" + excep.Message, "输入提示");
                return;
            }
            FrmDialog.ShowDialog(this, "数据库更新成功", "输入提示");
            FrmDialog.ShowDialog(this, "按照之前的表，钻杆最多两个、钻铤和套管最多三个", "输入提示");

        }

        //基本参数设置
        private void ucBtnExt1_BtnClick_1(object sender, EventArgs e)
        {
            //泵设置
            try
            {
                if (ucTextBoxEx11.InputText.Length != 0)
                {
                    double gtzj1 = double.Parse(ucTextBoxEx11.InputText);
                    u.SetValue(16, gtzj1);
                }
                if (ucTextBoxEx12.InputText.Length != 0)
                {
                    double gtsl1 = double.Parse(ucTextBoxEx12.InputText);
                    u.SetValue(17, gtsl1);
                }
                if (ucTextBoxEx13.InputText.Length != 0)
                {
                    double cc1 = double.Parse(ucTextBoxEx13.InputText);
                    u.SetValue(18, cc1);
                }
                if (ucTextBoxEx16.InputText.Length != 0)
                {
                    double gtzj2 = double.Parse(ucTextBoxEx16.InputText);
                    u.SetValue(19, gtzj2);
                }
                if (ucTextBoxEx15.InputText.Length != 0)
                {
                    double gtsl2 = double.Parse(ucTextBoxEx15.InputText);
                    u.SetValue(20, gtsl2);
                }
                if (ucTextBoxEx14.InputText.Length != 0)
                {
                    double cc2 = double.Parse(ucTextBoxEx14.InputText);
                    u.SetValue(21, cc2);
                }
                if (ucTextBoxEx19.InputText.Length != 0)
                {
                    double gtzj3 = double.Parse(ucTextBoxEx19.InputText);
                    u.SetValue(22, gtzj3);
                }
                if (ucTextBoxEx18.InputText.Length != 0)
                {
                    double gtsl3 = double.Parse(ucTextBoxEx18.InputText);
                    u.SetValue(23, gtsl3);
                }
                if (ucTextBoxEx17.InputText.Length != 0)
                {
                    double cc3 = double.Parse(ucTextBoxEx17.InputText);
                    u.SetValue(24, cc3);
                }
            }
            catch (Exception excep) {
                FrmDialog.ShowDialog(this, "泵设置存在非法输入\n" + excep.Message, "输入提示");
                return;
            }

        
            //判断值设置
            try
            {
                if (ucTextBoxEx7.InputText.Length != 0)
                {
                    double njbgl = double.Parse(ucTextBoxEx7.InputText);
                    u.SetValue(25, njbgl);
                }
                if (ucTextBoxEx8.InputText.Length != 0)
                {
                    double qdsy = double.Parse(ucTextBoxEx8.InputText);
                    u.SetValue(27, qdsy);
                }
                if (ucTextBoxEx9.InputText.Length != 0)
                {
                    double tzjy = double.Parse(ucTextBoxEx9.InputText);
                    u.SetValue(26, tzjy);
                }
                if (ucTextBoxEx10.InputText.Length != 0)
                {
                    double llpd = double.Parse(ucTextBoxEx10.InputText);
                    u.SetValue(28, llpd);
                }
            }
            catch (Exception excep)
            {
                FrmDialog.ShowDialog(this, "判断值设置存在非法输入\n" + excep.Message, "输入提示");
            }
            FrmDialog.ShowDialog(this, "数据库更新成功", "输入提示");

        }

        //图形显示设置
        private void ucBtnExt6_BtnClick(object sender, EventArgs e)
        {
            //流量图形
            try
            {
                if (ucTextBoxEx29.InputText.Length != 0)
                {
                    double nj = double.Parse(ucTextBoxEx29.InputText);
                    u.SetValue(63, nj);
                }
                if (ucTextBoxEx30.InputText.Length != 0)
                {
                    double xs = double.Parse(ucTextBoxEx30.InputText);
                    u.SetValue(64, xs);
                }
            }
            catch (Exception excep)
            {
                FrmDialog.ShowDialog(this, "流量图形设置存在非法输入\n" + excep.Message, "输入提示");
                return;
            }
            //压力图形
            try
            {
                if (ucTextBoxEx31.InputText.Length != 0)
                {
                    double nj = double.Parse(ucTextBoxEx31.InputText);
                    u.SetValue(65, nj);
                }
                if (ucTextBoxEx32.InputText.Length != 0)
                {
                    double xs = double.Parse(ucTextBoxEx32.InputText);
                    u.SetValue(66, xs);
                }
            }
            catch (Exception excep)
            {
                FrmDialog.ShowDialog(this, "压力图形设置存在非法输入\n" + excep.Message, "输入提示");
                return;
            }
            FrmDialog.ShowDialog(this, "数据库更新成功", "输入提示");
        }

        private void ucBtnExt8_BtnClick(object sender, EventArgs e)
        {

        }
        //图形显示设置--重置
        private void ucBtnExt5_BtnClick(object sender, EventArgs e)
        {
            ucTextBoxEx29.InputText = "";
            ucTextBoxEx30.InputText = "";
            ucTextBoxEx31.InputText = "";
            ucTextBoxEx32.InputText = "";
        }

        //管柱设置--重置
        private void ucBtnExt4_BtnClick(object sender, EventArgs e)
        {
            ucTextBoxEx28.InputText = "";
            ucTextBoxEx27.InputText = "";
            ucTextBoxEx26.InputText = "";

            //套管
            UCTextBoxEx temp = null;
            foreach (Control ctrl in this.panelEx7.Controls)//在这个面板中找到最新的label
            {
                int index = 200;
                while (index <= 205)
                {
                    if (string.Equals(ctrl.Name, "ucTextBoxEx" + index))
                    {
                        temp = (HZH_Controls.Controls.UCTextBoxEx)ctrl;
                        temp.InputText = "";
                    }
                    index++;
                }

            }

            //钻杆
            foreach (Control ctrl in this.panelEx5.Controls)//在这个面板中找到最新的label
            {
                int index = 36;
                while (index <= 50)
                {
                    if (string.Equals(ctrl.Name, "ucTextBoxEx" + index))
                    {
                        temp = (HZH_Controls.Controls.UCTextBoxEx)ctrl;
                        temp.InputText = "";
                    }
                    index++;
                }
            }
            //钻铤
            foreach (Control ctrl in this.panelEx6.Controls)//在这个面板中找到最新的label
            {
                int index = 100;
                while (index <= 114)
                {
                    if (string.Equals(ctrl.Name, "ucTextBoxEx" + index))
                    {
                        temp = (HZH_Controls.Controls.UCTextBoxEx)ctrl;
                        temp.InputText = "";
                    }
                    index++;
                }

            }
        }
        //基本参数--重置
        private void ucBtnExt2_BtnClick(object sender, EventArgs e)
        {
            ucTextBoxEx1.InputText = "";
            ucTextBoxEx2.InputText = "";
            ucTextBoxEx3.InputText = "";
            ucTextBoxEx4.InputText = "";
            ucTextBoxEx5.InputText = "";
            ucTextBoxEx6.InputText = "";
            ucTextBoxEx7.InputText = "";
            ucTextBoxEx8.InputText = "";
            ucTextBoxEx9.InputText = "";
            ucTextBoxEx10.InputText = "";
            ucTextBoxEx11.InputText = "";
            ucTextBoxEx12.InputText = "";
            ucTextBoxEx13.InputText = "";
            ucTextBoxEx14.InputText = "";
            ucTextBoxEx15.InputText = "";
            ucTextBoxEx16.InputText = "";
            ucTextBoxEx17.InputText = "";
            ucTextBoxEx18.InputText = "";
            ucTextBoxEx19.InputText = "";
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = true;
            this.Hide();
        }
    }
}
