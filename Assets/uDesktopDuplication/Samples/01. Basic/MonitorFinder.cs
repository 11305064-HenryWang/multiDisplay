// using System;
// using System.Diagnostics;
// using System.Drawing;
// using System.Linq;
// using System.Runtime.InteropServices;
// // #if UNITY_STANDALONE_WIN
// // using System.Windows.Forms;
// // #endif
// public class MonitorFinder
// {
// 	[DllImport("user32.dll")]
// 	private static extern bool GetWindowRect(IntPtr hWnd, out Rectangle lpRect);

// 	public static int GetMonitorIdForProcess(string processName)
// 	{
// 		// Find the process
// 		var process = Process.GetProcessesByName(processName).FirstOrDefault();
// 		if (process == null)
// 		{
// 			Console.WriteLine("Process not found.");
// 			return -1; // Process not found
// 		}

// 		// Get the main window handle
// 		IntPtr mainWindowHandle = process.MainWindowHandle;
// 		if (mainWindowHandle == IntPtr.Zero)
// 		{
// 			Console.WriteLine("Main window handle not found.");
// 			return -1; // Main window handle not found
// 		}

// 		// Get the window rectangle
// 		GetWindowRect(mainWindowHandle, out Rectangle windowRect);

// 		// Determine which screen the window is on
// 		Screen screen = Screen.AllScreens.FirstOrDefault(s => s.Bounds.IntersectsWith(windowRect));
// 		if (screen == null)
// 		{
// 			Console.WriteLine("Screen not found.");
// 			return -1; // Screen not found
// 		}

// 		// Return the monitor ID, which we'll define as the index in Screen.AllScreens
// 		int monitorId = Array.IndexOf(Screen.AllScreens, screen);
// 		return monitorId;
// 	}
// }