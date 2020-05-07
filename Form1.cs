using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using Sunisoft.IrisSkin;

using MySql.Data;
using MySql.Data.MySqlClient;
using DBTestCs;
using LiveCharts;
using LiveCharts.Wpf;
using HZH_Controls.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Util u;
        Oil obj;
        static int i = 1;//计数器
        Double RuKouLiuLiangLeiJi = 0;//入口流量累积值
        Double ChuKouLiuLiangLeiJi = 0;//出口流量累积值
        bool flag = true;
        // System.Timers.Timer timer2 = new System.Timers.Timer();
        static int JianGe = 0;//如果到10秒，则画一条线
        const int ConstJianGe = 300;
        private float X, Y;

        Form3 form3 = null;//form3窗体

        public Form1()
        {
            InitializeComponent();
            //调用皮肤效果
            //this.skinEngine1 = new SkinEngine(((System.ComponentModel.Component)(this)));
            //this.skinEngine1.SkinFile = Application.StartupPath + "/SteelBlue.ssk";
            //skinEngine1.Active = true;
            //设置在其他界面中的效果同步
            //SkinEngine skinEngine = null;
            //skinEngine = new SkinEngine();
            // skinEngine.SkinAllForm = true;

            List<String> StrList = new List<string>();
            this.cartesianChart1.Series = new SeriesCollection
                 {
                     new LineSeries
                     {
                         Title="测量值",
                         Values=new ChartValues<double>{ },
                         PointGeometry=null,
                         FontSize=20,


                     },
                     new LineSeries
                     {
                         Title = "设定值",
                         Values =new ChartValues<double>{ },
                         PointGeometry = null,
                         FontSize=20,
                     }
                 };
            //  List<String> StrList1 = new List<string>();
            this.cartesianChart1.AxisX.Add(new Axis
            {
                Title = "时间",
                Labels = StrList.ToArray(),
                FontSize = 15,
              
            }) ;

            Axis PowerY = new Axis
            {
                Title = "压力(MPa)",
                //LabelFormatter = value => value.ToString("C")
                FontSize=15,
            };
            this.cartesianChart1.AxisY.Add(PowerY);
            this.cartesianChart1.LegendLocation = LegendLocation.Top;
            this.cartesianChart2.LegendLocation = LegendLocation.Top;
            //this.cartesianChart1.Controls[""];
            //this.cartesianChart1.DefaultLegend.Background = System.Windows.Media.Brushes.White;
            //this.cartesianChart1.


            this.cartesianChart2.Series = new SeriesCollection
                 {
                     new LineSeries
                     {
                         Title="入口流量",
                         Values=new ChartValues<double>{ },
                         PointGeometry=null

                     },
                     new LineSeries
                     {
                         Title = "出口流量",
                         Values =new ChartValues<double>{ },
                         PointGeometry = null
                     }
                 };



            this.cartesianChart2.AxisX.Add(new Axis
            {
                Title = "时间",
                Labels = StrList.ToArray(),
                FontSize=15,
                
            });

            Axis WellDepY = new Axis
            {
                Title = "流量(L/s)",
                // LabelFormatter = value => value.ToString("C")
                LabelFormatter=value=>value.ToString("F2"),
                FontSize=15,
                
            };

            this.cartesianChart2.AxisY.Add(WellDepY);
            

        }

        private void ucNumTextBox1_NumChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cartesianChart3_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            if (form3 == null)
            {
                form3 = new Form3();
                form3.ShowDialog();
            }
            else
            {
                form3.Show();
            }
            
        }

        private void textBoxEx1_DoubleClick(object sender, EventArgs e)
        {
      
        }

        private void ucBtnExt2_BtnClick(object sender, EventArgs e)
        {
            Form2 form2= new Form2();
            form2.ShowDialog();
        }

        private void panelEx4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucNumTextBox3_NumChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
            u = new Util();
            u.init();

            //扩大
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true); // 双缓冲DoubleBuffer
            this.Resize += new EventHandler(Form1_Resize);//执行Form1_Resize方法
            X = this.Width;
            Y = this.Height;
            setTag(this);

        }
    

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           
                obj = u.GetOilFromDB(i);
                //  Console.WriteLine(obj.toString());
                //ucNumTextBox2.Num = Convert.ToDecimal(obj.getDepthOfTheDrillBit());//钻头深度
                //ucNumTextBox3.Num = Convert.ToDecimal(obj.getInletFlowlog());//出口流量
                //ucNumTextBox4.Num = Convert.ToDecimal(obj.getInletDensitylog());//入口密度
                ucNumTextBox11.Num = Convert.ToDecimal(obj.getMeasurementOfBackPressure());//回压测量，对应测量回压
                ucTextBoxEx1.InputText = Convert.ToString(obj.getOutletFlowlog());//出口流量
                ucTextBoxEx3.InputText = Convert.ToString(obj.getLayTime());//迟到时间
                ucTextBoxEx2.InputText = Convert.ToString(obj.getOutletDensitylog());//出口密度
                ucNumTextBox7.Num = Convert.ToDecimal(obj.getStandpipePressurelog());//立管压力，对应立压log
            textBoxEx7.Text = Convert.ToString(obj.getWellMouthAdjustment() - Convert.ToDouble(ucNumTextBox9.Num));//压力差值
            textBoxEx8.Text = Convert.ToString(obj.getOutletFlow()- Convert.ToDouble(this.ucNumTextBox3.Num));//流量差值
            u.SetOilToDB(obj);
                i++;
            this.label28.Text = (20 + obj.getDateTime().Substring(0,8));
           // this.label29.Text = (20 + obj.getDateTime().Substring(0, 8));
            this.cartesianChart2.Series[0].Values.Add(Convert.ToDouble(this.ucNumTextBox3.Num));//获得入口流量
            if (this.cartesianChart2.Series[0].Values.Count >= 1200)
            {
                this.cartesianChart2.Series[0].Values.RemoveAt(0);
            }
            
            this.cartesianChart2.Series[1].Values.Add(Convert.ToDouble((Convert.ToDouble(obj.getOutletFlow())).ToString("F2")));//获得出口流量
            if (this.cartesianChart2.Series[1].Values.Count >= 1200)
            {
                this.cartesianChart2.Series[1].Values.RemoveAt(0);
            }

            List<String> newList = new List<string>(this.cartesianChart2.AxisX[0].Labels);
            String JianGeString = obj.getDateTime().Substring(9, 5);//获取需要放置分割线的时间节点
            newList.Add(JianGeString);//获取时间,HH:MM
            if (newList.Count >= 1200)
            {
                newList.RemoveAt(0);
            }
            this.cartesianChart2.AxisX[0].Labels = newList.ToArray();
            this.cartesianChart1.AxisX[0].Labels = newList.ToArray();


            this.cartesianChart1.Series[0].Values.Add(Convert.ToDouble(obj.getWellMouthAdjustment()));//测量值，获取井口调节压力
            if (this.cartesianChart1.Series[0].Values.Count >= 1200)
            {
                this.cartesianChart1.Series[0].Values.RemoveAt(0);
            }

            //回压设置
            this.cartesianChart1.Series[1].Values.Add(Convert.ToDouble(ucNumTextBox9.Num));
            if (this.cartesianChart1.Series[1].Values.Count >= 1200)
            {
                this.cartesianChart1.Series[1].Values.RemoveAt(0);
            }
            JianGe++;//代表输入了一条数据
            //每十条数据添加一条线
            if (JianGe == ConstJianGe)
            {
                JianGe = 0;
                this.cartesianChart1.AxisX[0].Separator = new Separator
                {
                    Step = ConstJianGe,
                    
                };
                this.cartesianChart2.AxisX[0].Separator = new Separator
                {
                    Step = ConstJianGe,
                };
            }
            


            //再写一个计时器，用来更新累计值
           
           
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void ucSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            
            if(ucSwitch1.Checked){
                //this.timer3.Stop();
                this.timer3.Enabled =false;
                flag = true;
            }
            else
            {
                //this.timer3.Start();
                this.timer3.Enabled = true;
                RuKouLiuLiangLeiJi = 0;//入口流量累积值
                ChuKouLiuLiangLeiJi = 0;//出口流量累积值
                flag = false;

            }
        }

        public void timer2EventProcessor(object source, EventArgs e)
        {
           
        }

        private void ucSwitch1_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
                if (obj != null)
                {
                    RuKouLiuLiangLeiJi += obj.getInletFlow();
                    ChuKouLiuLiangLeiJi += obj.getOutletFlow();
                }

                this.textBoxEx4.Text = Convert.ToString(RuKouLiuLiangLeiJi);
                this.textBoxEx5.Text = Convert.ToString(ChuKouLiuLiangLeiJi);
                this.textBoxEx6.Text = Convert.ToString(RuKouLiuLiangLeiJi - ChuKouLiuLiangLeiJi);
            
            //更新累积值
            
        }

        private void ucTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.ucNumTextBox14.Num =Convert.ToDecimal(this.ucTrackBar1.Value);

        }

        private void ucTrackBar2_ValueChanged(object sender, EventArgs e)
        {
            this.ucNumTextBox13.Num = Convert.ToDecimal(this.ucTrackBar2.Value);
        }

        private void ucTrackBar3_ValueChanged(object sender, EventArgs e)
        {
            this.ucNumTextBox12.Num = Convert.ToDecimal(this.ucTrackBar3.Value);
            /*
             * this.ucSwitch1.CheckedChanged += new System.EventHandler(this.ucSwitch1_CheckedChanged);
            this.ucTrackBar1.ValueChanged += new System.EventHandler(this.ucTrackBar1_ValueChanged);
            this.ucTrackBar2.ValueChanged += new System.EventHandler(this.ucTrackBar2_ValueChanged);
            this.ucTrackBar3.ValueChanged += new System.EventHandler(this.ucTrackBar3_ValueChanged);
                 List<String> StrList = new List<string>();
                 this.cartesianChart1.Series = new SeriesCollection
                 {
                     new LineSeries
                     {
                         Title="测量值",
                         Values=new ChartValues<double>{ },
                         PointGeometry=null

                     },
                     new LineSeries
                     {
                         Title = "设定值",
                         Values =new ChartValues<double>{ },
                         PointGeometry = null
                     }
                 };
                 //  List<String> StrList1 = new List<string>();
                 this.cartesianChart1.AxisX.Add(new Axis
                 {
                     Title = "时间",
                     Labels = StrList.ToArray()
                 });

                 Axis PowerY = new Axis
                 {
                     Title = "压力",
                     //LabelFormatter = value => value.ToString("C")
                 };
                 this.cartesianChart1.AxisY.Add(PowerY);




                 this.cartesianChart2.Series = new SeriesCollection
                 {
                     new LineSeries
                     {
                         Title="入口流量",
                         Values=new ChartValues<double>{ },
                         PointGeometry=null

                     },
                     new LineSeries
                     {
                         Title = "出口流量",
                         Values =new ChartValues<double>{ },
                         PointGeometry = null
                     }
                 };



                 this.cartesianChart2.AxisX.Add(new Axis
                 {
                     Title = "时间",
                     Labels = StrList.ToArray()
                 });

                 Axis WellDepY = new Axis
                 {
                     Title = "流量",
                    // LabelFormatter = value => value.ToString("C")
                 };

                 this.cartesianChart2.AxisY.Add(WellDepY);
                 */
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

            float newx = (this.Width) / X;//当前宽度与变化前宽度之比
            float newy = this.Height / Y;//当前高度与变化前宽度之比
            
                setControls(newx, newy, this);
           
            
            //this.Text = this.Width.ToString() + " " + this.Height.ToString(); //窗体标题显示长度和宽度

        }


        private void setControls(float newx, float newy, Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
                float a = Convert.ToSingle(mytag[0]) * newx;
                con.Width = (int)a;
                a = Convert.ToSingle(mytag[1]) * newy;
                con.Height = (int)(a);
                a = Convert.ToSingle(mytag[2]) * newx;
                con.Left = (int)(a);
                a = Convert.ToSingle(mytag[3]) * newy;
                con.Top = (int)(a);
                Single currentSize = Convert.ToSingle(mytag[4]) * Math.Min(newx, newy);
                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                if (con.Controls.Count > 0)
                {
                    setControls(newx, newy, con);
                }
            }
        }
 

        //获得控件的长度、宽度、位置、字体大小的数据
        private void setTag(Control cons)//Control类，定义控件的基类
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;//获取或设置包含有关控件的数据的对象
                if (con.Controls.Count > 0)
                    setTag(con);//递归算法
            }
        }
        public static void SetDouble(Control cc)
        {

            cc.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance |
                         System.Reflection.BindingFlags.NonPublic).SetValue(cc, true, null);

        }

        private void ucBtnExt6_BtnClick(object sender, EventArgs e)
        {
            int tempLocation2 = this.panelEx2.Location.Y;
            if (string.Equals(this.ucBtnExt6.BtnText, "隐藏"))
            {
                this.ucBtnExt6.BtnText = "显示";
                this.panelEx5.Visible = false;
                int newLocation2FangDa = this.panelEx5.Location.Y + this.panelEx5.Size.Height - this.panelEx2.Size.Height;
                this.panelEx2.Location = new Point(3, newLocation2FangDa);//修改坐标位置
                int newLocation1FangDa = newLocation2FangDa - (tempLocation2 - this.panelEx1.Location.Y);
                this.panelEx1.Location = new Point(3, newLocation1FangDa);

                //曲线
                //  this.cartesianChart2.Size = new Size(this.cartesianChart2.Size.Width,this.panelEx1.Location.Y - this.cartesianChart1.Location.Y - this.cartesianChart1.Size.Height);
                // this.cartesianChart2.Location = new Point(this.cartesianChart1.Location.X, this.cartesianChart1.Location.Y + this.cartesianChart1.Size.Height);
                this.cartesianChart1.Size = new Size(this.cartesianChart1.Size.Width, this.panelEx1.Location.Y - this.cartesianChart1.Location.Y);
                this.cartesianChart2.Size = new Size(this.cartesianChart2.Size.Width, this.panelEx1.Location.Y - this.cartesianChart2.Location.Y);

                //中间的面板
                this.panelEx6.Location = new Point(this.panelEx6.Location.X, this.cartesianChart1.Location.Y + this.cartesianChart1.Height / 2 - this.panelEx6.Height / 2);
            }
            else
            {
                this.ucBtnExt6.BtnText = "隐藏";
                this.panelEx5.Visible = true;
                int newLocation2HuiFu = this.panelEx5.Location.Y - (this.panelEx2.Size.Height);
                this.panelEx2.Location = new Point(3, newLocation2HuiFu);
                int newLocation1HuiFu = newLocation2HuiFu - this.panelEx1.Size.Height;
                this.panelEx1.Location = new Point(3, newLocation1HuiFu);

                //曲线
                // this.cartesianChart2.Location = new Point((this.label26.Location.X +this.label26.Size.Width+(this.label26.Location.X-this.cartesianChart1.Location.X-this.cartesianChart1.Size.Width)),this.cartesianChart1.Location.Y);
                this.cartesianChart1.Size = new Size(this.cartesianChart1.Size.Width, this.panelEx1.Location.Y - 2 * this.cartesianChart1.Location.Y);
                this.cartesianChart2.Size = new Size(this.cartesianChart2.Size.Width, this.panelEx1.Location.Y - 2 * this.cartesianChart2.Location.Y);

                //中间的面板
                this.panelEx6.Location = new Point(this.panelEx6.Location.X, this.cartesianChart1.Location.Y);
            }
        }

        private void panelEx5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void ucNumTextBox5_NumChanged(object sender, EventArgs e)
        {

        }

        private void ucNumTextBox2_NumChanged(object sender, EventArgs e)
        {

        }

        private void Form1_DpiChanged(object sender, DpiChangedEventArgs e)
        {
            Hello hello = new Hello();
            hello.ShowDialog();
        }


        bool auto_flag = true;
        private void ucSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (ucSwitch1.SwitchType == HZH_Controls.Controls.SwitchType.Ellipse)
            {
                auto_flag = !auto_flag;
                if (auto_flag)
                {
                    u.SetValue(15, 0);
                }
                else 
                {
                    u.SetValue(15, 1);
                }
                
            }
            
        }

        private void ucBtnExt5_BtnClick(object sender, EventArgs e)
        {
            if (string.Equals(this.ucBtnExt5.BtnText, "全屏"))
            {
                this.FormBorderStyle = FormBorderStyle.None;     //设置窗体为无边框样式
                this.WindowState = FormWindowState.Maximized;    //最大化窗体 
                this.ucBtnExt5.BtnText = "退出";
                if (!this.panelEx5.Visible)
                {
                    this.panelEx5.Visible = true;
                    ucBtnExt6.BtnText = "隐藏";
                }

                
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.WindowState = FormWindowState.Normal;    //最大化窗体 
                this.ucBtnExt5.BtnText = "全屏";
                if (!this.panelEx5.Visible)
                {
                    this.panelEx5.Visible = true;
                    ucBtnExt6.BtnText = "隐藏";
                }
            }
            
        }

        //点击手动控制，提交数据
        private void ucBtnExt4_BtnClick(object sender, EventArgs e)
        {
            submit();
            FrmDialog.ShowDialog(this, "数据库更新成功", "输入提示");
        }

        void submit() {
            //上
            if (ucNumTextBox3.Num != 0) 
            {
                double value = (double)ucNumTextBox3.Num;
                u.SetValue(4, value);
            }
            if (ucNumTextBox9.Num != 1)
            {
                double value = (double)ucNumTextBox9.Num;
                u.SetValue(10, value);
            }

            //中
            if (ucNumTextBox1.Num != 1)
            {
                double value = (double)ucNumTextBox1.Num;
                u.SetValue(2, value);
            }
            if (ucNumTextBox2.Num != 1)
            {
                double value = (double)ucNumTextBox2.Num;
                u.SetValue(1, value);
            }
            //13
            if (ucNumTextBox6.Num != 1)
            {
                double value = (double)ucNumTextBox6.Num;
                u.SetValue(8, value);
            }
            if (ucNumTextBox8.Num != 1)
            {
                double value = (double)ucNumTextBox8.Num;
                u.SetValue(9, value);
            }
            if (ucNumTextBox10.Num != 1)
            {
                double value = (double)ucNumTextBox10.Num;
                u.SetValue(11, value);
            }
            //31
            if (ucNumTextBox4.Num != 1)
            {
                double value = (double)ucNumTextBox4.Num;
                u.SetValue(5, value);
            }
            if (ucNumTextBox5.Num != 1)
            {
                double value = (double)ucNumTextBox5.Num;
                u.SetValue(7, value);
            }

            //下
            if (ucNumTextBox14.Num != 1)
            {
                double value = (double)ucNumTextBox14.Num;
                u.SetValue(12, value);
            }
            if (ucNumTextBox13.Num != 1)
            {
                double value = (double)ucNumTextBox13.Num;
                u.SetValue(13, value);
            }
            if (ucNumTextBox12.Num != 1)
            {
                double value = (double)ucNumTextBox12.Num;
                u.SetValue(14, value);
            }

            try 
            {
                if (ucTextBoxEx2.InputText.Length != 0)
                {
                    double value = double.Parse(ucTextBoxEx2.InputText);
                    if (value != 0) 
                    {
                        u.SetValue(3, value);
                    }
                }
            } 
            catch (Exception ex) 
            {
                FrmDialog.ShowDialog(this, "存在非法输入\n" + ex.Message, "输入提示");
            }

            if (ucCombox1.SelectedText.Equals("泥浆泵1")) 
            {
                u.SetValue(6, 1.0);
            }
            else if(ucCombox1.SelectedText.Equals("泥浆泵2"))
            {
                u.SetValue(6, 2.0);
            }
            else if (ucCombox1.SelectedText.Equals("泥浆泵3"))
            {
                u.SetValue(6, 3.0);
            }

        }
    }
}

