using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace AutoWordSearch {
    static class Program {
        static Viewer viewer;
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ClipboardMonitor.Start();
            ClipboardMonitor.OnClipboardChange += new ClipboardMonitor.OnClipboardChangeEventHandler(ClipboardMonitor_OnClipboardChange);
            
            viewer = new Viewer();
            
            Application.Run(viewer);
        }

        static void ClipboardMonitor_OnClipboardChange(ClipboardFormat format, object data) {
            if (viewer == null)
                return;
            if (format.ToString().Equals("Text"))
                viewer.Search((string)data);
        }
    }
}
