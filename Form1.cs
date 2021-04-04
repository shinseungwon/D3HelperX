using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D3HelperX
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        //[DllImport("kernel32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool AllocConsole();

        static Process p;
        static int state = 0;

        ComboBox[] boxes = new ComboBox[4];
        static string[] table = new string[4];

        public Form1()
        {
            InitializeComponent();
            //AllocConsole();

            boxes[0] = comboBox1;
            boxes[1] = comboBox2;
            boxes[2] = comboBox3;
            boxes[3] = comboBox4;

            comboBox1.SelectedIndex = 2;
            comboBox2.SelectedIndex = 2;
            comboBox3.SelectedIndex = 2;
            comboBox4.SelectedIndex = 2;

            p = Process.GetProcessesByName("Diablo III64").FirstOrDefault();
            if (p != null)
            {
                lb_state.Text = "Ready";
            }
            else
            {
                lb_state.Text = "Process Not Ready";
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                table[i] = "";
            }

            for (int i = 0; i < 4; i++)
            {
                int t = int.Parse(boxes[i].Text) / 250;
                int n = i + 1;
                if (t == 1)
                {
                    table[0] += n;
                    table[1] += n;
                    table[2] += n;
                    table[3] += n;
                }
                else if (t == 2)
                {
                    table[0] += n;
                    table[2] += n;
                }
                else if (t == 4)
                {
                    table[0] += n;
                }
            }



            Thread th = new Thread(() => Run());
            th.Start();

            lb_state.Text = "running";
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            state = 0;
            lb_state.Text = "stopped";
        }

        private static void Run()
        {
            IntPtr h = p.MainWindowHandle;
            SetForegroundWindow(h);
            state = 1;

            int seq = 0;
            while (state == 1)
            {
                SendKeys.SendWait(table[seq]);
                seq++;
                if (seq % 4 == 0)
                {
                    seq = 0;
                }
                Thread.Sleep(250);
            }
        }

        private void comboBox_KeyDown(object sender, KeyEventArgs e)
        {            
            e.Handled = true;
        }

        private void comboBox_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
