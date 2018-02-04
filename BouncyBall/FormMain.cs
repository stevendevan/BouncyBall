using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncyBall
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
            //this.MouseClick += new MouseEventHandler(Form1_MouseClick);
            this.MouseDown += new MouseEventHandler(FormMain_MouseDown);
            this.MouseUp   += new MouseEventHandler(FormMain_MouseUp);
            //this.OnResize += new ContentsResizedEventHandler
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.label1.Location = new Point((int)(this.Width - this.label1.Width) / 2, (int)(this.Height - this.label1.Height) / 2);
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.label1.Visible = true;
            }
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.label1.Visible = false;
            }
        }

        //private void Form1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        this.textBox1.Visible = false;
        //    }
        //}
    }
}
