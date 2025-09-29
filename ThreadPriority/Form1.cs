using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadPriority
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread threadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
            Thread ThreadB = new Thread(new ThreadStart(MyThreadClass.Thread1));
            Thread ThreadC = new Thread(new ThreadStart(MyThreadClass.Thread1));
            Thread ThreadD = new Thread(new ThreadStart(MyThreadClass.Thread1));
           
            ThreadA.Name = "Thread A Process";
            ThreadB.Name = "Thread B Process";
            ThreadB.Name = "Thread C Process";
            ThreadB.Name = "Thread D Process";

            threadA.Priority = ThreadPriority.Highest;
            ThreadB.Start();
            ThreadB.Start();
            ThreadB.Start();
           
            ThreadA.Join();
            ThreadB.Join();
            ThreadB.Join();
            ThreadB.Join();
            changinglbl.Text = "          E n d   O f   T h r e a d";
        }
    }
}
