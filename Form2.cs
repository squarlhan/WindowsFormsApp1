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
using HZH_Controls.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Util u = new Util();
        public Form2()
        {
            InitializeComponent();
            u.init();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ucListView1_SelectedItemEvent(object sender, EventArgs e)
        {

        }

        //阀值提交
        private void ucBtnExt8_BtnClick(object sender, EventArgs e)
        {
            try
            {
                if (ucTextBoxEx1.InputText.Length != 0)
                {
                    double value = double.Parse(ucTextBoxEx1.InputText);
                    u.SetValue(70, value);
                }
                if (ucTextBoxEx2.InputText.Length != 0)
                {
                    double value = double.Parse(ucTextBoxEx2.InputText);
                    u.SetValue(71, value);
                }
                if (ucTextBoxEx3.InputText.Length != 0)
                {
                    double value = double.Parse(ucTextBoxEx3.InputText);
                    u.SetValue(68, value);
                }
                if (ucTextBoxEx4.InputText.Length != 0)
                {
                    double value = double.Parse(ucTextBoxEx4.InputText);
                    u.SetValue(69, value);
                }
                if (ucTextBoxEx5.InputText.Length != 0)
                {
                    double value = double.Parse(ucTextBoxEx5.InputText);
                    u.SetValue(73, value);
                }
                if (ucTextBoxEx6.InputText.Length != 0)
                {
                    double value = double.Parse(ucTextBoxEx6.InputText);
                    u.SetValue(72, value);
                }
                if (ucTextBoxEx58.InputText.Length != 0)
                {
                    double value = double.Parse(ucTextBoxEx58.InputText);
                    u.SetValue(67, value);
                }
            }
            catch (Exception ecp)
            {
                FrmDialog.ShowDialog(this, "存在非法输入\n" + ecp.Message, "输入提示");
                return;
            }
            FrmDialog.ShowDialog(this, "数据库更新成功", "输入提示");
        }

        //阀值重置
        private void ucBtnExt7_BtnClick(object sender, EventArgs e)
        {
            ucTextBoxEx1.InputText = "";
            ucTextBoxEx2.InputText = "";
            ucTextBoxEx3.InputText = "";
            ucTextBoxEx4.InputText = "";
            ucTextBoxEx5.InputText = "";
            ucTextBoxEx6.InputText = "";
            ucTextBoxEx58.InputText = "";
        }

        //智能提交
        private void ucBtnExt2_BtnClick(object sender, EventArgs e)
        {
            try
            {
                if (ucTextBoxEx7.InputText.Length != 0) {
                    double value = double.Parse(ucTextBoxEx7.InputText);
                    u.SetValue(74, value);
                }
                if (ucTextBoxEx9.InputText.Length != 0)
                {
                    double value = double.Parse(ucTextBoxEx9.InputText);
                    u.SetValue(75, value);
                }
                if (ucTextBoxEx10.InputText.Length != 0)
                {
                    double value = double.Parse(ucTextBoxEx10.InputText);
                    u.SetValue(76, value);
                }
                if (ucTextBoxEx11.InputText.Length != 0)
                {
                    double value = double.Parse(ucTextBoxEx11.InputText);
                    u.SetValue(77, value);
                }
            }
            catch (Exception ecp) 
            {
                FrmDialog.ShowDialog(this, "存在非法输入\n" + ecp.Message, "输入提示");
                return;
            }
            FrmDialog.ShowDialog(this, "数据库更新成功", "输入提示");
            
        }
        //智能重置
        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            ucTextBoxEx7.InputText = "";
            ucTextBoxEx9.InputText = "";
            ucTextBoxEx10.InputText = "";
            ucTextBoxEx11.InputText = "";
        }
    }
}
