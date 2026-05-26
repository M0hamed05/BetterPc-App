using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsLogicLayer
{
    public class FolderPaths
    {
        private static string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        public static string usertempPatch = Path.GetTempPath();
        public static string tempPatch = @"C:\Windows\Temp";
        public static string prefecthPatch = @"C:\Windows\Prefetch";
        public static string memoryDumpsPath = @"C:\\Windows\\LiveKernelReports";

    }
}
