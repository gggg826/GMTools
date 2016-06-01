using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FengNiao.GameTools.Util
{
    public class Win32API
    {


        #region 热键
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();
        public const int MOD_ALT = 0x1;
        public const int MOD_CONTROL = 0x2;
        public const int MOD_SHIFT = 0x4;
        public const int MOD_WIN = 0x8;
        public const int WM_HOTKEY = 0x312;    //按下快捷键消息的ID

        [DllImport("user32.dll")]
        public static extern UInt32 RegisterHotKey(IntPtr hWnd, UInt32 id, UInt32 fsModifiers, Keys vk);

        [DllImport("user32.dll")]
        public static extern UInt32 UnregisterHotKey(IntPtr hWnd, UInt32 id);

        [DllImport("kernel32.dll")]
        public static extern UInt32 GlobalAddAtom(String lpString);
        [DllImport("kernel32.dll")]
        public static extern UInt32 GlobalDeleteAtom(UInt32 nAtom);

        #endregion


        #region 窗体相关常量定义
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;



        //改变窗体大小
        public const int WMSZ_LEFT = 0xF001;
        public const int WMSZ_RIGHT = 0xF002;
        public const int WMSZ_TOP = 0xF003;
        public const int WMSZ_TOPLEFT = 0xF004;
        public const int WMSZ_TOPRIGHT = 0xF005;
        public const int WMSZ_BOTTOM = 0xF006;
        public const int WMSZ_BOTTOMLEFT = 0xF007;
        public const int WMSZ_BOTTOMRIGHT = 0xF008;
        #endregion


        /// <summary>
        /// 启动控制台
        /// </summary>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();
        /// <summary>
        /// 释放控制台
        /// </summary>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        public static extern bool FreeConsole();


        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        [DllImport("kernel32.dll")]
        public extern static int GetPrivateProfileString(string segName, string keyName, string sDefault, byte[] buffer, int iLen, string fileName);

        [DllImport("kernel32.dll")]
        public extern static int GetPrivateProfileSection(string segName, StringBuilder buffer, int nSize, string fileName);

        [DllImport("kernel32.dll")]
        public extern static int WritePrivateProfileSection(string segName, string sValue, string fileName);

        [DllImport("kernel32.dll")]
        public extern static int WritePrivateProfileString(string segName, string keyName, string sValue, string fileName);

        [DllImport("kernel32.dll")]
        public extern static int GetPrivateProfileSectionNames(byte[] buffer, int iLen, string fileName);


        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        public extern static IntPtr FindWindow(string lpClassName, string lpWindowName);


        [DllImport("User32.dll")]
        //返回值：如果窗口原来可见，返回值为非零；如果函数原来被隐藏，返回值为零。
        public static extern bool ShowWindow(IntPtr hWnd, int cmdShow);

        [DllImport("Winmm.dll")]
        public static extern int waveOutSetVolume(int hwo, System.UInt32 pdwVolume);//设置音量

        [DllImport("Winmm.dll")]
        public static extern uint waveOutGetVolume(int hwo, out System.UInt32 pdwVolume); //获取音量

        public const int SW_SHOWMAXIMIZED = 0x0003;


        [DllImport("Winmm.dll")]
        public static extern bool PlaySound(string szSound, IntPtr hMod, int flags);


        public delegate void HotkeyEventHandler(int HotKeyID);

        public class Hotkey : IMessageFilter       //继承这个接口，才能用AddMessageFilter接收消息
        {
            System.Collections.Hashtable keyIDs = new System.Collections.Hashtable();
            IntPtr hWnd;
            public event HotkeyEventHandler OnHotkey;  //方便对快捷键进行处理

            public Hotkey(IntPtr hWnd)
            {
                this.hWnd = hWnd;
                Application.AddMessageFilter(this);    //这样this才会收到消息
            }

            public int RegisterHotkey(Keys Key, UInt32 KeyModifiers)
            {
                UInt32 hotkeyid = Win32API.GlobalAddAtom(System.Guid.NewGuid().ToString());
                Win32API.RegisterHotKey((IntPtr)hWnd, hotkeyid, KeyModifiers, Key);
                keyIDs.Add(hotkeyid, hotkeyid);
                return (int)hotkeyid;
            }

            public void UnregisterHotkeys()
            {
                Application.RemoveMessageFilter(this);
                foreach (UInt32 key in keyIDs.Values)
                {
                    Win32API.UnregisterHotKey(hWnd, key);
                    Win32API.GlobalDeleteAtom(key);
                }
            }

            /// <summary>
            /// 消息过滤器
            /// </summary>
            /// <param name="m">收到的消息</param>
            /// <returns>如果筛选消息并禁止消息被调度，则为true；如果允许消息继续到达下一个筛选器或控件，则为false。</returns>

            public bool PreFilterMessage(ref Message m)
            {
                if (m.Msg == Win32API.WM_HOTKEY)
                {
                    if (OnHotkey != null)
                    {
                        foreach (UInt32 key in keyIDs.Values)
                        {
                            if ((UInt32)m.WParam == key)
                            {
                                OnHotkey((int)m.WParam);
                                return true;
                            }
                        }
                    }
                }
                return false;
            }
        }

        public const long WM_GETMINMAXINFO = 0x24;

        public struct POINTAPI
        {
            public int x;
            public int y;
        }

        public struct MINMAXINFO
        {
            public POINTAPI ptReserved;
            public POINTAPI ptMaxSize;
            public POINTAPI ptMaxPosition;
            public POINTAPI ptMinTrackSize;
            public POINTAPI ptMaxTrackSize;
        }



        [StructLayout(LayoutKind.Sequential)]
        public class Overlapped
        {
        }

        [DllImport("kernel32", SetLastError = true)]
        public static extern IntPtr CreateNamedPipe(
            String lpName,							// pipe name
            uint dwOpenMode,							// pipe open mode
            uint dwPipeMode,							// pipe-specific modes
            uint nMaxInstances,						// maximum number of instances
            uint nOutBufferSize,						// output buffer size
            uint nInBufferSize,						// input buffer size
            uint nDefaultTimeOut,						// time-out interval
            IntPtr pipeSecurityDescriptor				// SD
            );

        [DllImport("kernel32", SetLastError = true)]
        public static extern bool ConnectNamedPipe(
            IntPtr hHandle,					// handle to named pipe
            Overlapped lpOverlapped					// overlapped structure
            );

        [DllImport("kernel32", SetLastError = true)]
        public static extern bool DisconnectNamedPipe(
            IntPtr hHandle
            );

        [DllImport("kernel32", SetLastError = true)]
        public static extern bool ReadFile(
            IntPtr hHandle,					// handle to file
            byte[] lpBuffer,							// data buffer
            uint nNumberOfBytesToRead,					// number of bytes to read
            byte[] lpNumberOfBytesRead,				// number of bytes read
            uint lpOverlapped							// overlapped buffer
            );

        public const int INVALID_HANDLE_VALUE = -1;
        public const uint PIPE_ACCESS_INBOUND = 0x00000001;
        public const uint PIPE_TYPE_BYTE = 0x00000000;
        public const uint PIPE_READMODE_BYTE = 0x00000000;


    }
}
