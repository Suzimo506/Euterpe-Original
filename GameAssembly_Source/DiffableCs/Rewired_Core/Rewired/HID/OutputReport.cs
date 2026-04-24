namespace Rewired.HID;

[CustomClassObfuscation]
[CustomObfuscation]
internal struct OutputReport
{
	public IntPtr buffer; //Field offset: 0x0
	public int bufferLength; //Field offset: 0x8
	public int reportLength; //Field offset: 0xC
	public OutputReportOptions options; //Field offset: 0x10

	public bool IsValid
	{
		 get { } //Length: 80
	}

	public OutputReport(IntPtr unnamed_param_0, int unnamed_param_1, int unnamed_param_2) { }

	public void Clear() { }

	public bool get_IsValid() { }

	public virtual string ToString() { }

}

