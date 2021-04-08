using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public delegate void MouseEventCallBack(IntPtr code, int x, int y);
    public delegate void KeyEventCallBack(IntPtr code, int key);

    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        static Task currentTask;
        static Process p;
        static bool running = false;
        static bool paused = false;

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

            HookEvents.EnableHook();
            HookEvents.Mc = new MouseEventCallBack(MCallback);
            HookEvents.Kc = new KeyEventCallBack(KCallback);

            btn_stop.Enabled = false;
        }

        private static void KCallback(IntPtr code, int key)
        {            
            if (key == 192)
            {
                paused = !paused;
            }
        }

        private static void MCallback(IntPtr code, int x, int y)
        {

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

            paused = true;

            IntPtr h = p.MainWindowHandle;
            SetForegroundWindow(h);
            running = true;

            Action action = new Action(Run);
            currentTask = Task.Factory.StartNew(action);

            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;

            cbp1.Enabled = false;
            cbp2.Enabled = false;
            cbp3.Enabled = false;
            cbp4.Enabled = false;
            cbpL.Enabled = false;
            cbpR.Enabled = false;

            lb_state.Text = "running";
            btn_start.Enabled = false;
            btn_stop.Enabled = true;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;

            cbp1.Enabled = true;
            cbp2.Enabled = true;
            cbp3.Enabled = true;
            cbp4.Enabled = true;
            cbpL.Enabled = true;
            cbpR.Enabled = true;

            running = false;
            lb_state.Text = "stopped";
            btn_stop.Enabled = false;
            while (!currentTask.IsCompleted) ;
            btn_start.Enabled = true;
        }

        private void Run()
        {
            int seq = 0;
            while (running)
            {
                if (paused)
                {
                }
                else if (SkipCheck())
                {                    
                    if (++seq % 4 == 0)
                    {
                        seq = 0;
                    }
                }
                else
                {
                    SendKeys.SendWait(table[seq]);
                    if (++seq % 4 == 0)
                    {
                        seq = 0;
                    }
                }
                Thread.Sleep(250);
            }
        }

        private bool SkipCheck()
        {            
            if(comboBox1.SelectedIndex == 0 && cbp1.Checked && HookEvents.keyPressing[49] == 1)
            {
                return true;
            }

            if (comboBox2.SelectedIndex == 0 && cbp2.Checked && HookEvents.keyPressing[50] == 1)
            {
                return true;
            }

            if (comboBox3.SelectedIndex == 0 && cbp3.Checked && HookEvents.keyPressing[51] == 1)
            {
                return true;
            }

            if (comboBox4.SelectedIndex == 0 && cbp4.Checked && HookEvents.keyPressing[52] == 1)
            {
                return true;
            }



            if (cbpL.Checked && HookEvents.mouseLPressing == 1)
            {
                return true;
            }

            if (cbpR.Checked && HookEvents.mouseRPressing == 1)
            {
                return true;
            }

            return false;
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            HookEvents.DisableHook();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email : ssw900528@gmail.com" + Environment.NewLine + "GitHub Source : shinseungwon/D3HelperX", "About");
        }
    }

    class HookEvents
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [StructLayout(LayoutKind.Sequential)]
        public class Point
        {
            public int x;
            public int y;
        }

        private const int WH_MOUSE_LL = 14;
        private const int WM_LBUTTONDOWN = 0x0201;
        private const int WM_RBUTTONDOWN = 0x0204;
        private const int WM_MBUTTONDOWN = 0x0207;

        private const int WM_LBUTTONUP = 0x0202;
        private const int WM_RBUTTONUP = 0x0205;
        private const int WM_MBUTTONUP = 0x0208;

        private const int WM_MOUSEMOVE = 0x0200;

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;

        private static LowLevelProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        private delegate IntPtr LowLevelProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static MouseEventCallBack mc;
        private static KeyEventCallBack kc;

        public static byte[] keyPressing = new byte[256];

        public static byte mouseLPressing;
        public static byte mouseRPressing;
        public static byte mouseMPressing;

        public static MouseEventCallBack Mc { get => mc; set => mc = value; }
        public static KeyEventCallBack Kc { get => kc; set => kc = value; }

        private static IntPtr SetHookKeyBoard(LowLevelProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private static IntPtr SetHookMouse(LowLevelProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_MOUSE_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                int keyCode = Marshal.ReadInt32(lParam);
                if (wParam == (IntPtr)WM_KEYDOWN)
                {                    
                    keyPressing[keyCode] = 1;                    
                }

                if (wParam == (IntPtr)WM_KEYUP)
                {                    
                    keyPressing[keyCode] = 0;
                    Kc(wParam, keyCode);
                }

                if (wParam == (IntPtr)WM_LBUTTONDOWN)
                {
                    mouseLPressing = 1;
                }
                if (wParam == (IntPtr)WM_LBUTTONUP)
                {
                    mouseLPressing = 0;
                    Mc((IntPtr)0, 0, 0);
                }

                if (wParam == (IntPtr)WM_RBUTTONDOWN)
                {
                    mouseRPressing = 1;
                }
                if (wParam == (IntPtr)WM_RBUTTONUP)
                {
                    mouseRPressing = 0;
                    Mc((IntPtr)1, 0, 0);
                }

                if (wParam == (IntPtr)WM_MBUTTONDOWN)
                {
                    mouseMPressing = 1;
                }
                if (wParam == (IntPtr)WM_MBUTTONUP)
                {
                    mouseMPressing = 0;
                    Mc((IntPtr)2, 0, 0);
                }
            }

            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        public static void EnableHook()
        {
            _hookID = SetHookKeyBoard(_proc);
            _hookID = SetHookMouse(_proc);
        }

        public static void DisableHook()
        {
            UnhookWindowsHookEx(_hookID);
        }
    }
}
