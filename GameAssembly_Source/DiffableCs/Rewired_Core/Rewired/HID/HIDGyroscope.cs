namespace Rewired.HID;

[CustomClassObfuscation]
[CustomObfuscation]
internal class HIDGyroscope : HIDControllerElementWithDataSet
{
	internal class kLuNdbrJGJiHJiTkrqQjaMlPqjVE : xgFqVIxaaiIBjgSrkHEHRPGSWguHA<kLuNdbrJGJiHJiTkrqQjaMlPqjVE>, IComparable<kLuNdbrJGJiHJiTkrqQjaMlPqjVE>
	{
		public Vector3 GVTZjOXhNnTDtBoajrSfTRRYVRht; //Field offset: 0x10
		public float bpSjHOBzzIbTMmVIHLHbQnlqyhMp; //Field offset: 0x1C

		public kLuNdbrJGJiHJiTkrqQjaMlPqjVE() { }

		public kLuNdbrJGJiHJiTkrqQjaMlPqjVE(Single[] unnamed_param_0, float unnamed_param_1) { }

		public override void Clear() { }

		public override int CompareTo(kLuNdbrJGJiHJiTkrqQjaMlPqjVE other) { }

		public override bool Equals(kLuNdbrJGJiHJiTkrqQjaMlPqjVE unnamed_param_0) { }

		public void LhOHkUrFtwRUrsbQgaaTfeNGmmPB(Single[] unnamed_param_0, float unnamed_param_1) { }

		public override void Set(kLuNdbrJGJiHJiTkrqQjaMlPqjVE unnamed_param_0) { }

	}

	public class skHhVEMYFJqgfXRoZIxVuTZhcgIkA : VQmZsUnYOiCXmuqeGEbJbfDljouK
	{
		private Single[] xzzBnrTnKGTNuosATnqrWqnwMJGA; //Field offset: 0x18
		public Single[] GVTZjOXhNnTDtBoajrSfTRRYVRht; //Field offset: 0x20
		public ExpandableArray_DataContainer<kLuNdbrJGJiHJiTkrqQjaMlPqjVE> agRUmHdujesYsULKASJZatwoxtUK; //Field offset: 0x28
		private ExpandableArray_DataContainer<kLuNdbrJGJiHJiTkrqQjaMlPqjVE> QVZZAgpTNvCCLtoxUfHYeTizhatH; //Field offset: 0x30

		public skHhVEMYFJqgfXRoZIxVuTZhcgIkA(UpdateLoopType unnamed_param_0, int unnamed_param_1, int unnamed_param_2) { }

		public void bijFHgeaiQdFtgQVnUMYcISUCaTMA(Single[] unnamed_param_0, float unnamed_param_1) { }

		public void gxgPRcKwociRNokZjvlZCFLqmmSU() { }

		public virtual void ygcSCNhNqkuVcVXohlrHkrtkJylB() { }

	}

	public class ZzuAwAiMTfsHytmnoYwEqWXoqsOK : fbeaCWhUIHCBlCdpdfeDmgxluOync
	{
		private int WNFFpCQSlzjnyeXojaanUQIZjDueb; //Field offset: 0x40
		private int IBgkpaEPDcsMtjLJPrnkWWWlUPvV; //Field offset: 0x44

		public ExpandableArray_DataContainer<kLuNdbrJGJiHJiTkrqQjaMlPqjVE> agRUmHdujesYsULKASJZatwoxtUK
		{
			 get { } //Length: 176
		}

		public Single[] GVTZjOXhNnTDtBoajrSfTRRYVRht
		{
			 get { } //Length: 176
		}

		public ZzuAwAiMTfsHytmnoYwEqWXoqsOK(UpdateLoopSetting unnamed_param_0, int unnamed_param_1, int unnamed_param_2) { }

		public void esHXhgfkcTNACqBADjBWnSLykbgo(Single[] unnamed_param_0, float unnamed_param_1) { }

		public virtual void gxgPRcKwociRNokZjvlZCFLqmmSU(UpdateLoopType unnamed_param_0) { }

		private VQmZsUnYOiCXmuqeGEbJbfDljouK JSNjDGILyFUaCIUzONLqiaXxIlUs(UpdateLoopType unnamed_param_0) { }

		public ExpandableArray_DataContainer<kLuNdbrJGJiHJiTkrqQjaMlPqjVE> OPXPKtzIRKomJeKumltAbxxiRoXQ() { }

		public Single[] XIMwCIzLvoqgMGJGLoAuhVVGIFYj() { }

	}

	public double timestamp; //Field offset: 0x28
	public readonly Single[] lastRawValue; //Field offset: 0x30
	public readonly int valueLength; //Field offset: 0x38
	private readonly Byte[] QjmNKTFvVcQlySuPNgFvOlbXFJbZ; //Field offset: 0x40
	private readonly Single[] iFZFavkouWWTcEdJlAEmjRagwOZF; //Field offset: 0x48
	private readonly int LOAmVmAFVGItLtoHRLJaGjmyKFRE; //Field offset: 0x50
	private readonly int VFktbYKqgoHohQxHPtuhtHWVDSCz; //Field offset: 0x54
	private readonly Action<Byte[], Single[]> bTckYQTvShOcvHUBpOnekntDHyFd; //Field offset: 0x58
	private readonly Func<Single> wXBobBuNMWsHFkXCFeVQelQhIMgF; //Field offset: 0x60

	public ExpandableArray_DataContainer<kLuNdbrJGJiHJiTkrqQjaMlPqjVE> events
	{
		 get { } //Length: 322
	}

	public Single[] rawValue
	{
		 get { } //Length: 322
	}

	public HIDGyroscope(UpdateLoopSetting unnamed_param_0, byte unnamed_param_1, HIDInfo unnamed_param_2, int unnamed_param_3, int unnamed_param_4, Action<Byte[], Single[]> unnamed_param_5, Func<Single> unnamed_param_6) { }

	public ExpandableArray_DataContainer<kLuNdbrJGJiHJiTkrqQjaMlPqjVE> get_events() { }

	public Single[] get_rawValue() { }

	public virtual void UpdateValue(NativeBuffer inputReport, double timestamp) { }

	public void UpdateValueManual(Single[] value, double timestamp) { }

}

