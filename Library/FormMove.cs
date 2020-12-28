using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public class FormMove
    {
        /// <summary>
        /// 给指定控件及其子控件添加事件
        /// </summary>
        /// <param name="Parent"></param>
        private void AddEvent(Control Parent)
        {
            // 排除一些类别的控件类型
            if (Parent is NumericUpDown || Parent is TextBox) return;

            // 给当前控件添加对象
            Parent.MouseDown += MouseDown;
            Parent.MouseUp += MouseUp;
            Parent.MouseMove += MouseMove;

            // 遍历当前控件的子控件
            if (Parent.Controls.Count > 0) 
                foreach (Control Item in Parent.Controls) AddEvent(Item);

        }

        /// <summary>
        /// 初始化对象
        /// </summary>
        /// <param name="MoveObj"></param>
        public FormMove(Form MoveObj)
        {
            this.MoveObj = MoveObj;
            AddEvent(MoveObj);
        }

        /// <summary>
        /// 要移动的窗口对象
        /// </summary>
        private Form MoveObj { get; }

        /// <summary>
        /// 判断当前鼠标是否按下
        /// </summary>
        private bool IsDown { get; set; } = false;

        /// <summary>
        /// 记录鼠标按下时X轴的偏移
        /// </summary>
        private int OffsetX { get; set; } = 0;

        /// <summary>
        /// 记录鼠标按下时Y轴的偏移
        /// </summary>
        private int OffsetY { get; set; } = 0;

        /// <summary>
        /// 鼠标按下时执行初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseDown(object sender, MouseEventArgs e)
        {
            OffsetX = Control.MousePosition.X - MoveObj.Left;
            OffsetY = Control.MousePosition.Y - MoveObj.Top;
            IsDown = true;
        }

        /// <summary>
        /// 鼠标移动时执行窗口移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDown)
            {
                MoveObj.Top = Control.MousePosition.Y - OffsetY;
                MoveObj.Left = Control.MousePosition.X - OffsetX;
            }
        }

        /// <summary>
        /// 鼠标抬起时复位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseUp(object sender, MouseEventArgs e)
        {
            IsDown = false;
            OffsetX = OffsetY = 0;
        }
    }
}
