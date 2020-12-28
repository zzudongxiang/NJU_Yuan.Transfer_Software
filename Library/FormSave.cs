using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    /// <summary>
    /// 自动保存窗体的信息
    /// </summary>
    public class FormSave
    {
        /// <summary>
        /// 目标窗体对象
        /// </summary>
        public Form ObjForm { get; }

        /// <summary>
        /// 读写配置文件对象
        /// </summary>
        public Initializer INIFile { get; }

        /// <summary>
        /// 在配置文件中保存的章节信息
        /// </summary>
        public string Section { get; }

        /// <summary>
        /// 初始化对象
        /// </summary>
        /// <param name="ObjForm"></param>
        /// <param name="INIFile"></param>
        /// <param name="Section"></param>
        public FormSave(Form ObjForm, Initializer INIFile, string Section)
        {
            // 初始化对象
            this.ObjForm = ObjForm;
            this.INIFile = INIFile;
            this.Section = Section;

            // 绑定事件加载
            ObjForm.Load += ObjForm_Load;
            ObjForm.Visible = LoadConfig.LoadValue(INIFile, Section, "Visible", 1) > 0;
        }

        /// <summary>
        /// 窗体关闭时再次保存信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ObjForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ObjForm_VisibleChanged(ObjForm, new EventArgs());
            ObjForm_LocationChanged(ObjForm, new EventArgs());
            ObjForm_Resize(ObjForm, new EventArgs());
        }

        /// <summary>
        /// 窗体加载时初始化对象
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ObjForm_Load(object sender, EventArgs e)
        {
            // 初始化对象
            ObjForm.Width = LoadConfig.LoadValue(INIFile, Section, "Width", ObjForm.Width);
            ObjForm.Height = LoadConfig.LoadValue(INIFile, Section, "Height", ObjForm.Height);
            ObjForm.Top = LoadConfig.LoadValue(INIFile, Section, "Top", ObjForm.Top);
            ObjForm.Left = LoadConfig.LoadValue(INIFile, Section, "Left", ObjForm.Left);

            // 添加事件
            ObjForm.Resize += ObjForm_Resize;
            ObjForm.LocationChanged += ObjForm_LocationChanged;
            ObjForm.VisibleChanged += ObjForm_VisibleChanged;
            ObjForm.FormClosed += ObjForm_FormClosed; 
        }

        /// <summary>
        /// 窗体的可见性发生改变时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ObjForm_VisibleChanged(object sender, EventArgs e)
        {
            INIFile.SetValue(Section, "Visible", ObjForm.Visible ? "1" : "-1");
        }

        /// <summary>
        /// 窗体的位置发生改变时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ObjForm_LocationChanged(object sender, EventArgs e)
        {
            ObjForm.LocationChanged -= ObjForm_LocationChanged;
            INIFile.SetValue(Section, "Top", ObjForm.Top.ToString());
            INIFile.SetValue(Section, "Left", ObjForm.Left.ToString());
            ObjForm.LocationChanged += ObjForm_LocationChanged;
        }
        
        /// <summary>
        /// 窗体的大小发生改变时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ObjForm_Resize(object sender, EventArgs e)
        {
            ObjForm.Resize -= ObjForm_Resize;
            INIFile.SetValue(Section, "Width", ObjForm.Width.ToString());
            INIFile.SetValue(Section, "Height", ObjForm.Height.ToString());
            ObjForm.Resize += ObjForm_Resize;
        }
    }
}
