// Made by x2Beef Coding Productions
// https://www.github.com/x2beef/drive-master

using System;
using System.IO;
using System.Threading;

class Program
{
    static void Main()
    {
        // Get the status and info of drives connected
        DriveInfo[] drives = DriveInfo.GetDrives();

        foreach (DriveInfo drive in drives)
        {
            // Only show drives that are ready to be used eg: C:\
            if (drive.IsReady)
            {
                Console.WriteLine("Made by x2Beef Coding Productions");
                Thread.Sleep(4000);
                Console.WriteLine("Introducing Drive-Master 1.0.1");
                Thread.Sleep(2000);

                // Uses WriteLine to display drive info
                Console.Clear();
                Console.WriteLine($"Drive {drive.Name}");
                Console.WriteLine($"Drive Letter: {drive.Name[0]}:");
                Console.WriteLine($"Total Space: {drive.TotalSize / (1024 * 1024 * 1024)} GB");
                Console.WriteLine($"Available Space: {drive.AvailableFreeSpace / (1024 * 1024 * 1024)} GB");
                Console.WriteLine(new string('-', 40));
                Console.ReadKey();
            }
        }
    }
}
