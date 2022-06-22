using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Protection
{
	// Token: 0x02000005 RID: 5
	internal class ProcessCheck
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00003128 File Offset: 0x00001328
		public static void Initialize()
		{
			Thread thread = new Thread(new ThreadStart(ProcessCheck.check));
			thread.Start();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00003150 File Offset: 0x00001350
		public static void check()
		{
			bool flag = ProcessCheck.IsSandboxie();
			if (flag)
			{
				ProcessCheck.msg();
			}
			bool flag2 = ProcessCheck.IsDebugger();
			if (flag2)
			{
				ProcessCheck.msg();
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000317C File Offset: 0x0000137C
		internal static bool IsSandboxie()
		{
			return ProcessCheck.IsDetected();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00003194 File Offset: 0x00001394
		internal static bool IsDebugger()
		{
			return ProcessCheck.Run();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000031AC File Offset: 0x000013AC
		internal static void msg()
		{
			Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
			Process.Start(new ProcessStartInfo
			{
				Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Process.GetCurrentProcess().MainModule.FileName + "\"",
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "cmd.exe"
			});
			Application.Exit();
			Environment.Exit(1);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00003220 File Offset: 0x00001420
		private static IntPtr GetModuleHandle(string libName)
		{
			foreach (object obj in Process.GetCurrentProcess().Modules)
			{
				ProcessModule processModule = (ProcessModule)obj;
				bool flag = processModule.ModuleName.ToLower().Contains(libName.ToLower());
				if (flag)
				{
					return processModule.BaseAddress;
				}
			}
			return IntPtr.Zero;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000032A8 File Offset: 0x000014A8
		internal static bool IsDetected()
		{
			return ProcessCheck.GetModuleHandle("SbieDll.dll") != IntPtr.Zero;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000032D0 File Offset: 0x000014D0
		internal static bool Run()
		{
			bool result = false;
			bool flag = Debugger.IsAttached || Debugger.IsLogging();
			if (!flag)
			{
				string[] array = new string[]
				{
					"dnspy",
					"codecracker",
					"x32dbg",
					"x64dbg",
					"ollydbg",
					"ida",
					"charles",
					"simpleassembly",
					"peek",
					"httpanalyzer",
					"httpdebug",
					"fiddler",
					"wireshark",
					"dbx",
					"mdbg",
					"gdb",
					"windbg",
					"dbgclr",
					"kdb",
					"kgdb",
					"mdb",
					"processhacker",
					"scylla_x86",
					"scylla_x64",
					"scylla",
					"idau64",
					"idau",
					"idaq",
					"idaq64",
					"idaw",
					"idaw64",
					"idag",
					"idag64",
					"ida64",
					"ida",
					"ImportREC",
					"IMMUNITYDEBUGGER",
					"MegaDumper",
					"CodeBrowser",
					"reshacker",
					"cheat engine"
				};
				foreach (Process process in Process.GetProcesses())
				{
					bool flag2 = process != Process.GetCurrentProcess();
					if (flag2)
					{
						for (int j = 0; j < array.Length; j++)
						{
							bool flag3 = process.ProcessName.ToLower().Contains(array[j]);
							if (flag3)
							{
								result = true;
							}
							bool flag4 = process.MainWindowTitle.ToLower().Contains(array[j]);
							if (flag4)
							{
								result = true;
							}
						}
					}
				}
			}
			return result;
		}
	}
}