using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsLogicLayer
{
    public class Tools
    {
        public static bool OpenFolderInExplorer(string path)
        {
            if (!Directory.Exists(path)) return false;

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = path,
                    UseShellExecute = true
                });
                return true;
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.LogType.Error);
            }
            return false;
        }

        public static void RunDiskCleanup()
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cleanmgr.exe",
                    Arguments = "/d c /sagerun:1",// to do the operation auto
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Logger.Log($"Failed to start Disk Cleanup: {ex.Message}", Logger.LogType.Error);
            }
        }

        public static bool IsHibernateEnabledFromRegistry()
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Power"))
                    if (key != null)
                        return (key.GetValue("HibernateEnabled") is int value && value == 1);

            }
            catch (Exception ex)
            {
                Logger.Log($"Error reading registry for hibernate: {ex.Message}", Logger.LogType.Error);
            }

            return false;
        }

        public static void SetHibernate(bool enable)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = enable ? "/c powercfg -h on && powercfg -h /type full" : "/c powercfg -h off",//added after && to make sure that appear again after disabling it
                    WindowStyle = ProcessWindowStyle.Hidden, //make it disapper
                    CreateNoWindow = true
                };

                Process.Start(psi);

                Logger.Log($"Hibernate set to: {enable}", Logger.LogType.Information);
            }
            catch (Exception ex)
            {
                Logger.Log($"Failed to change Hibernate state: {ex.Message}", Logger.LogType.Error);
            }
        }

        public static void OpenAppFeatures()
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "ms-settings:appsfeatures",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Logger.Log($"Failed to open Apps & Features: {ex.Message}", Logger.LogType.Error);
            }
        }

        public static void OpenStorageSettings()
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "ms-settings:storagesense",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Logger.Log($"Failed to open Windows Storage settings: {ex.Message}", Logger.LogType.Error);
            }
        }

        public static void OpenStartupSettings()
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "ms-settings:startupapps",
                    UseShellExecute = true
                });
            }
            catch {  }
        }

        public static void OpenBackgroundAppsSettings()
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "ms-settings:privacy-backgroundapps",
                    UseShellExecute = true
                });
            }
            catch { }
        }

        public static void RunMsConfig()
        {
            string system32Path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "System32");
            string msconfigPath = Path.Combine(system32Path, "msconfig.exe");

            try
            {
                if (Environment.Is64BitOperatingSystem && !Environment.Is64BitProcess)
                {
                    msconfigPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "sysnative", "msconfig.exe");
                }

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = msconfigPath,
                    UseShellExecute = true,
                    Verb = "runas" 
                };

                Process.Start(psi);
            }
            catch { }
        }

        public static bool FlushDNS()
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c ipconfig /flushdns",
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                using (Process p = Process.Start(psi))
                {
                    p.WaitForExit();
                    return p.ExitCode == 0;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool OpenVisualPerformanceSettings()
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "SystemPropertiesPerformance.exe",
                    UseShellExecute = true
                };

                Process.Start(psi);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
