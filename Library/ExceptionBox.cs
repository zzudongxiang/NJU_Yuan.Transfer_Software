using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class ExceptionBox : Form
    {
        public ExceptionBox()
        {
            InitializeComponent();
        }

        public void ShowException(Exception Ex)
        {
            tbxEx.Text = Ex.Message;
            tbxTrack.Text = Ex.StackTrace;
            //MessageBox.Show(Ex.StackTrace, Ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.ShowDialog();
            Application.Exit();
        }

    }
}
