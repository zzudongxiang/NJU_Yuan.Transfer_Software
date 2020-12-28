using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharpDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MT_API.MT_Init();
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            MT_API.MT_Close_UART();
            MT_API.MT_Close_USB();
            if(0!=MT_API.MT_Open_UART(txt_Port.Text))
            {
                MessageBox.Show("串口连接错误");
                return;
            }


            if(0==MT_API.MT_Check())
            {
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("NO card");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MT_API.MT_DeInit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Acc_Click(object sender, EventArgs e)
        {
            Int32 iResult;
            iResult=MT_API.MT_Set_Axis_Acc(0, Convert.ToInt32(txt_Acc.Text));
            if(0==iResult)
            {
                MessageBox.Show("ok");
            }
        }

        private void btn_Dec_Click(object sender, EventArgs e)
        {
            Int32 iResult;
            iResult=MT_API.MT_Set_Axis_Dec(0, Convert.ToInt32(txt_Dec.Text));
            if (0 == iResult)
            {
                MessageBox.Show("ok");
            }
        }

        private void btn_MaxV_Click(object sender, EventArgs e)
        {
            Int32 iResult;
            iResult=MT_API.MT_Set_Axis_Position_V_Max(0, Convert.ToInt32(txt_MaxV.Text));
            if (0 == iResult)
            {
                MessageBox.Show("ok");
            }
        }

        private void btn_Ref_Click(object sender, EventArgs e)
        {
            Int32 iResult;
            MT_API.MT_Set_Axis_Mode_Position(0);
            iResult = MT_API.MT_Set_Axis_Position_P_Target_Rel(0, Convert.ToInt32(txt_Ref.Text));
            if (0 == iResult)
            {
                MessageBox.Show("ok");
            }
        }

        private void btn_Abs_Click(object sender, EventArgs e)
        {
            Int32 iResult;
            MT_API.MT_Set_Axis_Mode_Position(0);
            iResult=MT_API.MT_Set_Axis_Position_P_Target_Abs(0, Convert.ToInt32(txt_Abs.Text));
            if (0 == iResult)
            {
                MessageBox.Show("ok");
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            Int32 iResult;
            iResult=MT_API.MT_Set_Axis_Position_Stop(0);
            if (0 == iResult)
            {
                MessageBox.Show("ok");
            }
        }

        private void btn_Halt_Click(object sender, EventArgs e)
        {
            Int32 iResult;
            iResult=MT_API.MT_Set_Axis_Halt(0);
            if (0 == iResult)
            {
                MessageBox.Show("ok");
            }
        }

        private void btn_Status_Click(object sender, EventArgs e)
        {

        }
    }
}
