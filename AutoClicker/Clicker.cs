using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace AutoClicker
{
    public class Clicker
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [Flags]
        private enum MouseEventFlags
        {
            LEFT_DOWN = 0x00000002,
            LEFT_UP = 0x00000004,
            MIDDLE_DOWN = 0x00000020,
            MIDDLE_UP = 0x00000040,
            RIGHT_DOWN = 0x00000008,
            RIGHT_UP = 0x00000010
        }

        public static bool isStopped = true;
        public static bool isInsideAppWindow = false;

        public static int clickCount = 0;

        public static void StartLeftClicking(int delay)
        {
            while (!isStopped)
            {
                if (!isInsideAppWindow)
                {
                    mouse_event((int)MouseEventFlags.LEFT_DOWN, Cursor.Position.X, Cursor.Position.Y, 0, 0);
                    mouse_event((int)MouseEventFlags.LEFT_UP, Cursor.Position.X, Cursor.Position.Y, 0, 0);

                    Debug.WriteLine("Click Count: " + ++clickCount);
                }

                Thread.Sleep(delay);
            }
        }
    }
}
