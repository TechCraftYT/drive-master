// Made by x2Beef Coding Productions
// https://www.github.com/x2beef/drive-master


using System;
using System.IO;

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
                // Uses WriteLine to display X amount of space and names
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
