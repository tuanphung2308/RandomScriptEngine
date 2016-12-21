using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CheatEngine
{
	// Token: 0x02000009 RID: 9
	internal class CheatEngineLibrary
	{
		// Token: 0x06000001 RID: 1
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
		private static extern IntPtr LoadLibraryW(string strLib);

		// Token: 0x06000002 RID: 2
		[DllImport("kernel32.dll")]
		private static extern IntPtr LoadLibrary(string strLib);

		// Token: 0x06000003 RID: 3
		[DllImport("kernel32.dll")]
		private static extern int FreeLibrary(IntPtr iModule);

		// Token: 0x06000004 RID: 4
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
		private static extern IntPtr GetProcAddress(IntPtr iModule, string strProcName);

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		private void loadFunctions()
		{
			IntPtr procAddress = CheatEngineLibrary.GetProcAddress(this.libInst, "IGetProcessList");
			IntPtr procAddress2 = CheatEngineLibrary.GetProcAddress(this.libInst, "IOpenProcess");
			IntPtr procAddress3 = CheatEngineLibrary.GetProcAddress(this.libInst, "IResetTable");
			IntPtr procAddress4 = CheatEngineLibrary.GetProcAddress(this.libInst, "IAddScript");
			IntPtr procAddress5 = CheatEngineLibrary.GetProcAddress(this.libInst, "IRemoveRecord");
			IntPtr procAddress6 = CheatEngineLibrary.GetProcAddress(this.libInst, "IActivateRecord");
			IntPtr procAddress7 = CheatEngineLibrary.GetProcAddress(this.libInst, "IApplyFreeze");
			IntPtr procAddress8 = CheatEngineLibrary.GetProcAddress(this.libInst, "IAddAddressManually");
			IntPtr procAddress9 = CheatEngineLibrary.GetProcAddress(this.libInst, "IGetValue");
			IntPtr procAddress10 = CheatEngineLibrary.GetProcAddress(this.libInst, "ISetValue");
			IntPtr procAddress11 = CheatEngineLibrary.GetProcAddress(this.libInst, "IProcessAddress");
			IntPtr procAddress12 = CheatEngineLibrary.GetProcAddress(this.libInst, "IInitMemoryScanner");
			IntPtr procAddress13 = CheatEngineLibrary.GetProcAddress(this.libInst, "INewScan");
			IntPtr procAddress14 = CheatEngineLibrary.GetProcAddress(this.libInst, "IConfigScanner");
			IntPtr procAddress15 = CheatEngineLibrary.GetProcAddress(this.libInst, "IFirstScan");
			IntPtr procAddress16 = CheatEngineLibrary.GetProcAddress(this.libInst, "INextScan");
			IntPtr procAddress17 = CheatEngineLibrary.GetProcAddress(this.libInst, "ICountAddressesFound");
			IntPtr procAddress18 = CheatEngineLibrary.GetProcAddress(this.libInst, "IGetAddress");
			IntPtr procAddress19 = CheatEngineLibrary.GetProcAddress(this.libInst, "IInitFoundList");
			IntPtr procAddress20 = CheatEngineLibrary.GetProcAddress(this.libInst, "IResetValues");
			IntPtr procAddress21 = CheatEngineLibrary.GetProcAddress(this.libInst, "IGetBinarySize");
			this.iGetProcessList = (CheatEngineLibrary.IGetProcessList)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(CheatEngineLibrary.IGetProcessList));
			this.iOpenProcess = (CheatEngineLibrary.IOpenProcess)Marshal.GetDelegateForFunctionPointer(procAddress2, typeof(CheatEngineLibrary.IOpenProcess));
			this.iResetTable = (CheatEngineLibrary.IResetTable)Marshal.GetDelegateForFunctionPointer(procAddress3, typeof(CheatEngineLibrary.IResetTable));
			this.iAddScript = (CheatEngineLibrary.IAddScript)Marshal.GetDelegateForFunctionPointer(procAddress4, typeof(CheatEngineLibrary.IAddScript));
			this.iRemoveRecord = (CheatEngineLibrary.IRemoveRecord)Marshal.GetDelegateForFunctionPointer(procAddress5, typeof(CheatEngineLibrary.IRemoveRecord));
			this.iActivateRecord = (CheatEngineLibrary.IActivateRecord)Marshal.GetDelegateForFunctionPointer(procAddress6, typeof(CheatEngineLibrary.IActivateRecord));
			this.iApplyFreeze = (CheatEngineLibrary.IApplyFreeze)Marshal.GetDelegateForFunctionPointer(procAddress7, typeof(CheatEngineLibrary.IApplyFreeze));
			this.iAddAddressManually = (CheatEngineLibrary.IAddAddressManually)Marshal.GetDelegateForFunctionPointer(procAddress8, typeof(CheatEngineLibrary.IAddAddressManually));
			this.iGetValue = (CheatEngineLibrary.IGetValue)Marshal.GetDelegateForFunctionPointer(procAddress9, typeof(CheatEngineLibrary.IGetValue));
			this.iSetValue = (CheatEngineLibrary.ISetValue)Marshal.GetDelegateForFunctionPointer(procAddress10, typeof(CheatEngineLibrary.ISetValue));
			this.iProcessAddress = (CheatEngineLibrary.IProcessAddress)Marshal.GetDelegateForFunctionPointer(procAddress11, typeof(CheatEngineLibrary.IProcessAddress));
			this.iInitMemoryScanner = (CheatEngineLibrary.IInitMemoryScanner)Marshal.GetDelegateForFunctionPointer(procAddress12, typeof(CheatEngineLibrary.IInitMemoryScanner));
			this.iNewScan = (CheatEngineLibrary.INewScan)Marshal.GetDelegateForFunctionPointer(procAddress13, typeof(CheatEngineLibrary.INewScan));
			this.iConfigScanner = (CheatEngineLibrary.IConfigScanner)Marshal.GetDelegateForFunctionPointer(procAddress14, typeof(CheatEngineLibrary.IConfigScanner));
			this.iFirstScan = (CheatEngineLibrary.IFirstScan)Marshal.GetDelegateForFunctionPointer(procAddress15, typeof(CheatEngineLibrary.IFirstScan));
			this.iNextScan = (CheatEngineLibrary.INextScan)Marshal.GetDelegateForFunctionPointer(procAddress16, typeof(CheatEngineLibrary.INextScan));
			this.iCountAddressesFound = (CheatEngineLibrary.ICountAddressesFound)Marshal.GetDelegateForFunctionPointer(procAddress17, typeof(CheatEngineLibrary.ICountAddressesFound));
			this.iGetAddress = (CheatEngineLibrary.IGetAddress)Marshal.GetDelegateForFunctionPointer(procAddress18, typeof(CheatEngineLibrary.IGetAddress));
			this.iInitFoundList = (CheatEngineLibrary.IInitFoundList)Marshal.GetDelegateForFunctionPointer(procAddress19, typeof(CheatEngineLibrary.IInitFoundList));
			this.iResetValues = (CheatEngineLibrary.IResetValues)Marshal.GetDelegateForFunctionPointer(procAddress20, typeof(CheatEngineLibrary.IResetValues));
			this.iGetBinarySize = (CheatEngineLibrary.IGetBinarySize)Marshal.GetDelegateForFunctionPointer(procAddress21, typeof(CheatEngineLibrary.IGetBinarySize));
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000241C File Offset: 0x0000061C
		public void loadEngine()
		{
			this.libInst = CheatEngineLibrary.LoadLibrary("ce-lib32.dll");
			if (this.libInst != IntPtr.Zero)
			{
				this.loadFunctions();
			}
			else
			{
				MessageBox.Show("error, can't load the library");
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002467 File Offset: 0x00000667
		public void unloadEngine()
		{
			CheatEngineLibrary.FreeLibrary(this.libInst);
		}

		// Token: 0x04000034 RID: 52
		private IntPtr libInst;

		// Token: 0x04000035 RID: 53
		public CheatEngineLibrary.IGetProcessList iGetProcessList;

		// Token: 0x04000036 RID: 54
		public CheatEngineLibrary.IOpenProcess iOpenProcess;

		// Token: 0x04000037 RID: 55
		public CheatEngineLibrary.IResetTable iResetTable;

		// Token: 0x04000038 RID: 56
		public CheatEngineLibrary.IAddScript iAddScript;

		// Token: 0x04000039 RID: 57
		public CheatEngineLibrary.IRemoveRecord iRemoveRecord;

		// Token: 0x0400003A RID: 58
		public CheatEngineLibrary.IActivateRecord iActivateRecord;

		// Token: 0x0400003B RID: 59
		public CheatEngineLibrary.IApplyFreeze iApplyFreeze;

		// Token: 0x0400003C RID: 60
		public CheatEngineLibrary.IAddAddressManually iAddAddressManually;

		// Token: 0x0400003D RID: 61
		public CheatEngineLibrary.IGetValue iGetValue;

		// Token: 0x0400003E RID: 62
		public CheatEngineLibrary.ISetValue iSetValue;

		// Token: 0x0400003F RID: 63
		public CheatEngineLibrary.IProcessAddress iProcessAddress;

		// Token: 0x04000040 RID: 64
		public CheatEngineLibrary.IInitMemoryScanner iInitMemoryScanner;

		// Token: 0x04000041 RID: 65
		public CheatEngineLibrary.INewScan iNewScan;

		// Token: 0x04000042 RID: 66
		public CheatEngineLibrary.IConfigScanner iConfigScanner;

		// Token: 0x04000043 RID: 67
		public CheatEngineLibrary.IFirstScan iFirstScan;

		// Token: 0x04000044 RID: 68
		public CheatEngineLibrary.INextScan iNextScan;

		// Token: 0x04000045 RID: 69
		public CheatEngineLibrary.ICountAddressesFound iCountAddressesFound;

		// Token: 0x04000046 RID: 70
		public CheatEngineLibrary.IGetAddress iGetAddress;

		// Token: 0x04000047 RID: 71
		public CheatEngineLibrary.IInitFoundList iInitFoundList;

		// Token: 0x04000048 RID: 72
		public CheatEngineLibrary.IResetValues iResetValues;

		// Token: 0x04000049 RID: 73
		public CheatEngineLibrary.IGetBinarySize iGetBinarySize;

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x0600000A RID: 10
		public delegate void IGetProcessList([MarshalAs(UnmanagedType.BStr)] out string processes);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x0600000E RID: 14
		public delegate void IOpenProcess([MarshalAs(UnmanagedType.BStr)] string pid);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000012 RID: 18
		public delegate void IResetTable();

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000016 RID: 22
		public delegate void IAddScript([MarshalAs(UnmanagedType.BStr)] string name, [MarshalAs(UnmanagedType.BStr)] string script);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x0600001A RID: 26
		public delegate void IActivateRecord(int id, bool activate);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x0600001E RID: 30
		public delegate void IRemoveRecord(int id);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x06000022 RID: 34
		public delegate void IApplyFreeze();

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x06000026 RID: 38
		public delegate void IAddAddressManually([MarshalAs(UnmanagedType.BStr)] string initialaddress, TVariableType vartype);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x0600002A RID: 42
		public delegate void IGetValue(int id, [MarshalAs(UnmanagedType.BStr)] out string value);

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x0600002E RID: 46
		public delegate void ISetValue(int id, [MarshalAs(UnmanagedType.BStr)] string value, bool freezer);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000032 RID: 50
		public delegate void IProcessAddress([MarshalAs(UnmanagedType.BStr)] string address, TVariableType vartype, bool showashexadecimal, bool showAsSigned, int bytesize, [MarshalAs(UnmanagedType.BStr)] out string value);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x06000036 RID: 54
		public delegate void IInitMemoryScanner(int handle);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x0600003A RID: 58
		public delegate void INewScan();

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x0600003E RID: 62
		public delegate void IConfigScanner(Tscanregionpreference scanWritable, Tscanregionpreference scanExecutable, Tscanregionpreference scanCopyOnWrite);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x06000042 RID: 66
		public delegate void IFirstScan(TScanOption scanOption, TVariableType variableType, TRoundingType roundingtype, [MarshalAs(UnmanagedType.BStr)] string scanvalue1, [MarshalAs(UnmanagedType.BStr)] string scanvalue2, [MarshalAs(UnmanagedType.BStr)] string startaddress, [MarshalAs(UnmanagedType.BStr)] string stopaddress, bool hexadecimal, bool binaryStringAsDecimal, bool unicode, bool casesensitive, TFastScanMethod fastscanmethod, [MarshalAs(UnmanagedType.BStr)] string fastscanparameter);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x06000046 RID: 70
		public delegate void INextScan(TScanOption scanOption, TRoundingType roundingtype, [MarshalAs(UnmanagedType.BStr)] string scanvalue1, [MarshalAs(UnmanagedType.BStr)] string scanvalue2, bool hexadecimal, bool binaryStringAsDecimal, bool unicode, bool casesensitive, bool percentage, bool compareToSavedScan, [MarshalAs(UnmanagedType.BStr)] string savedscanname);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x0600004A RID: 74
		public delegate long ICountAddressesFound();

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x0600004E RID: 78
		public delegate void IGetAddress(long index, [MarshalAs(UnmanagedType.BStr)] out string address, [MarshalAs(UnmanagedType.BStr)] out string value);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x06000052 RID: 82
		public delegate void IInitFoundList(TVariableType vartype, int varlength, bool hexadecimal, bool signed, bool binaryasdecimal, bool unicode);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x06000056 RID: 86
		public delegate void IResetValues();

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x0600005A RID: 90
		public delegate int IGetBinarySize();
	}
}
