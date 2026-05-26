using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;

namespace ToolsLogicLayer
{
    public class TempFolders
    {
        //define the event
        public event Action<int, long> OnFileDeletedEvent;
        public TempFolders()
        {
            refershData();
        }

        public long UsertempSize { get; private set; }
        public long tempSize { get; private set; }
        public long prefetchSize { get; private set; }

        public long browsersCachSize { get; private set; }

        public long memoryDumpSize { get; private set; }


        public int UsertempFilesCount { get; private set; }
        public int tempFilesCount { get; private set; }
        public int prefetchFilesCount { get; private set; }

        public int browsersCachCount { get; private set; }

        public int memoryDumpCount { get; private set; }


        public void refershData()
        {
            UpdateSize();
            UpdateFoldersCount();
        }

        public void DeleteFiles(string path)
        {
            if (!Directory.Exists(path)) return;

            try
            {
                string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
                int count = 0;
                long totalSizeDeleted = 0;

                foreach (string file in files)
                {
                    try
                    {
                        FileInfo fi = new FileInfo(file);
                        long fileSize = fi.Length;

                        File.Delete(file);

                        count++;
                        totalSizeDeleted += fileSize;

                        OnFileDeletedEvent?.Invoke(count, totalSizeDeleted);
                    }
                    catch (Exception ex)
                    {
                        Logger.Log(ex.Message, Logger.LogType.Error);
                        continue;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.LogType.Error);
            }
            try
            {
                string[] subDirectories = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

                //move from button of the floder to upper
                for (int i = subDirectories.Length - 1; i >= 0; i--)
                {
                    try
                    {
                        if (Directory.GetFiles(subDirectories[i]).Length == 0 && Directory.GetDirectories(subDirectories[i]).Length == 0)
                        {
                            Directory.Delete(subDirectories[i]);
                        }
                    }
                    catch //if there a folder in user pass it
                    {
                        continue;
                    }
                }
            } catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.LogType.Error);
            }
        }

        public void DeleteBrowsersCash()
        {
            DeleteEdgeCache();
            DeleteChromeCache();
            DeleteBraveCache();
            DeleteOperaCache();
            DeleteFirefoxCache();
            Logger.Log("Browser Cache Cleanup Completed Successfully.", Logger.LogType.Information);
        }

        private void DeleteEdgeCache()
        {
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string edgeDefaultPath = Path.Combine(localAppData, @"Microsoft\Edge\User Data\Default");

            string[] edgeFolders = new string[]
            {
        Path.Combine(edgeDefaultPath, "Cache"),
        Path.Combine(edgeDefaultPath, "Code Cache"),
        Path.Combine(edgeDefaultPath, "GPUCache"),
        Path.Combine(edgeDefaultPath, @"Service Worker\CacheStorage")
            };

            foreach (string folder in edgeFolders)
            {
                DeleteFiles(folder);
            }
        }

        private void DeleteChromeCache()
        {
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string chromeDefaultPath = Path.Combine(localAppData, @"Google\Chrome\User Data\Default");

            string[] chromeFolders = new string[]
            {
        Path.Combine(chromeDefaultPath, "Cache"),
        Path.Combine(chromeDefaultPath, "Code Cache"),
        Path.Combine(chromeDefaultPath, "GPUCache"),
        Path.Combine(chromeDefaultPath, @"Service Worker\CacheStorage")
            };

            foreach (string folder in chromeFolders)
            {
                DeleteFiles(folder);
            }
        }

        private void DeleteBraveCache()
        {
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string braveDefaultPath = Path.Combine(localAppData, @"BraveSoftware\Brave-Browser\User Data\Default");

            string[] braveFolders = new string[]
            {
        Path.Combine(braveDefaultPath, "Cache"),
        Path.Combine(braveDefaultPath, "Code Cache"),
        Path.Combine(braveDefaultPath, "GPUCache"),
        Path.Combine(braveDefaultPath, @"Service Worker\CacheStorage")
            };

            foreach (string folder in braveFolders)
            {
                DeleteFiles(folder);
            }
        }

        private void DeleteOperaCache()
        {
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string operaDefaultPath = Path.Combine(localAppData, @"Opera Software\Opera Stable");

            string[] operaFolders = new string[]
            {
        Path.Combine(operaDefaultPath, "Cache"),
        Path.Combine(operaDefaultPath, "System Cache"),
        Path.Combine(operaDefaultPath, "Code Cache"),
        Path.Combine(operaDefaultPath, "GPUCache"),
        Path.Combine(operaDefaultPath, @"Service Worker\CacheStorage")
            };

            foreach (string folder in operaFolders)
            {
                DeleteFiles(folder);
            }
        }

        private void DeleteFirefoxCache()
        {
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string firefoxProfilesPath = Path.Combine(localAppData, @"Mozilla\Firefox\Profiles");

            if (!Directory.Exists(firefoxProfilesPath)) return;

            try
            {
                foreach (string profileDir in Directory.GetDirectories(firefoxProfilesPath))
                {
                    string[] fxFolders = new string[]
                    {
                Path.Combine(profileDir, "cache2"),
                Path.Combine(profileDir, "startupCache"),
                Path.Combine(profileDir, "OfflineCache")
                    };

                    foreach (string folder in fxFolders)
                    {
                        DeleteFiles(folder);
                    }
                }
            }
            catch { }
        }

        private void UpdateSize()
        {
            UsertempSize = GetFolderSize(FolderPaths.usertempPatch);
            tempSize = GetFolderSize(FolderPaths.tempPatch);
            prefetchSize = GetFolderSize(FolderPaths.prefecthPatch);
            memoryDumpSize = GetFolderSize(FolderPaths.memoryDumpsPath);

            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            long totalBrowsersSize = 0;

            // 1. Chrome
            string chromeDefaultPath = Path.Combine(localAppData, @"Google\Chrome\User Data\Default");
            string[] chromeFolders = { "Cache", "Code Cache", "GPUCache", @"Service Worker\CacheStorage" };
            foreach (string folder in chromeFolders) totalBrowsersSize += GetFolderSize(Path.Combine(chromeDefaultPath, folder));

            // 2. Edge
            string edgeDefaultPath = Path.Combine(localAppData, @"Microsoft\Edge\User Data\Default");
            string[] edgeFolders = { "Cache", "Code Cache", "GPUCache", @"Service Worker\CacheStorage" };
            foreach (string folder in edgeFolders) totalBrowsersSize += GetFolderSize(Path.Combine(edgeDefaultPath, folder));

            // 3. Brave
            string braveDefaultPath = Path.Combine(localAppData, @"BraveSoftware\Brave-Browser\User Data\Default");
            string[] braveFolders = { "Cache", "Code Cache", "GPUCache", @"Service Worker\CacheStorage" };
            foreach (string folder in braveFolders) totalBrowsersSize += GetFolderSize(Path.Combine(braveDefaultPath, folder));

            // 4. Opera
            string operaDefaultPath = Path.Combine(localAppData, @"Opera Software\Opera Stable");
            string[] operaFolders = { "Cache", "System Cache", "Code Cache", "GPUCache", @"Service Worker\CacheStorage" };
            foreach (string folder in operaFolders) totalBrowsersSize += GetFolderSize(Path.Combine(operaDefaultPath, folder));

            // 5. Firefox
            string firefoxProfilesPath = Path.Combine(localAppData, @"Mozilla\Firefox\Profiles");
            if (Directory.Exists(firefoxProfilesPath))
            {
                try
                {
                    foreach (string profileDir in Directory.GetDirectories(firefoxProfilesPath))
                    {
                        string[] fxFolders = { "cache2", "startupCache", "OfflineCache" };
                        foreach (string folder in fxFolders) totalBrowsersSize += GetFolderSize(Path.Combine(profileDir, folder));
                    }
                }
                catch { }
            }

            browsersCachSize = totalBrowsersSize;
        }

        private void UpdateFoldersCount()
        {
            UsertempFilesCount = GetFoldersCount(FolderPaths.usertempPatch);
            tempFilesCount = GetFoldersCount(FolderPaths.tempPatch);
            prefetchFilesCount = GetFoldersCount(FolderPaths.prefecthPatch);
            memoryDumpCount = GetFoldersCount(FolderPaths.memoryDumpsPath);

            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            int totalBrowsersCount = 0;

            // 1. Chrome
            string chromeDefaultPath = Path.Combine(localAppData, @"Google\Chrome\User Data\Default");
            string[] chromeFolders = { "Cache", "Code Cache", "GPUCache", @"Service Worker\CacheStorage" };
            foreach (string folder in chromeFolders) totalBrowsersCount += GetFoldersCount(Path.Combine(chromeDefaultPath, folder));

            // 2. Edge
            string edgeDefaultPath = Path.Combine(localAppData, @"Microsoft\Edge\User Data\Default");
            string[] edgeFolders = { "Cache", "Code Cache", "GPUCache", @"Service Worker\CacheStorage" };
            foreach (string folder in edgeFolders) totalBrowsersCount += GetFoldersCount(Path.Combine(edgeDefaultPath, folder));

            // 3. Brave
            string braveDefaultPath = Path.Combine(localAppData, @"BraveSoftware\Brave-Browser\User Data\Default");
            string[] braveFolders = { "Cache", "Code Cache", "GPUCache", @"Service Worker\CacheStorage" };
            foreach (string folder in braveFolders) totalBrowsersCount += GetFoldersCount(Path.Combine(braveDefaultPath, folder));

            // 4. Opera
            string operaDefaultPath = Path.Combine(localAppData, @"Opera Software\Opera Stable");
            string[] operaFolders = { "Cache", "System Cache", "Code Cache", "GPUCache", @"Service Worker\CacheStorage" };
            foreach (string folder in operaFolders) totalBrowsersCount += GetFoldersCount(Path.Combine(operaDefaultPath, folder));

            // 5. Firefox
            string firefoxProfilesPath = Path.Combine(localAppData, @"Mozilla\Firefox\Profiles");
            if (Directory.Exists(firefoxProfilesPath))
            {
                try
                {
                    foreach (string profileDir in Directory.GetDirectories(firefoxProfilesPath))
                    {
                        string[] fxFolders = { "cache2", "startupCache", "OfflineCache" };
                        foreach (string folder in fxFolders) totalBrowsersCount += GetFoldersCount(Path.Combine(profileDir, folder));
                    }
                }
                catch { }
            }

            browsersCachCount = totalBrowsersCount;
        }

        private long GetFolderSize(string path)
        {
            long totalSize = 0;
            try
            {
                if (!Directory.Exists(path)) return 0;

                string[] allFiles = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

                foreach (string file in allFiles)
                {
                    try
                    {
                        FileInfo fi = new FileInfo(file);
                        totalSize += fi.Length;
                    }
                    catch (Exception ex)
                    {
                        Logger.Log(ex.Message, Logger.LogType.Error);
                        continue;
                    }
                }

            }
            catch { return 0; }
            return totalSize;
        }

        private int GetFoldersCount(string path)
        {
            if (!Directory.Exists(path)) return 0;

            try
            {
                string[] allFiles = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
                return allFiles.Length;
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message, Logger.LogType.Error);
            }
            return 0;
        }
    }
}
