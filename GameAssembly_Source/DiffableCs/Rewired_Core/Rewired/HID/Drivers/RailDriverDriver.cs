namespace Rewired.HID.Drivers;

[CustomClassObfuscation]
[CustomObfuscation]
internal class RailDriverDriver : HIDDeviceDriver, IDisposable, IControllerDriver, IDriver_RailDriver
{
	private enum kAMdWLAIUUPIEAafiYusMoDcVyVmb
	{
		Speaker = 0,
		LED = 1,
	}

	private const int iCjUOVKPMliuKOGIwEVNyYuAroJT = 1523; //Field offset: 0x0
	private const int oLHorKJereHrZaEPGbYRFRDDpwCLA = 7; //Field offset: 0x0
	private const int lInKiQsMWplSQjJmWcaeitDzeIeF = 3; //Field offset: 0x0
	private const int jPWBBxzYXLghgUlHsRlNLLixFfIX = 14; //Field offset: 0x0
	private const int tlEJzMsSewifSDmEMAmgbkgdFmfpA = 8; //Field offset: 0x0
	private const int PWLncpoyjRaCAkWDYnbyHIRaYfbN = 7; //Field offset: 0x0
	private const int uJRuBmVBgXsCTFqqSuLuXsrXCFQJ = 6; //Field offset: 0x0
	private const int AyunUWYpsxshlahHYIzWRWVNfJQF = 5; //Field offset: 0x0
	private const int perjphulWMDeFTZnmGKDzryxNWGf = 4; //Field offset: 0x0
	private const int ApBgVVUFGQqiiDNagkoTmEPUDaDJ = 3; //Field offset: 0x0
	private const int lSexkegIaZliomIQgAqYzerIkluP = 1; //Field offset: 0x0
	private const int ekiXFnxRdQMtChhVCjjhTVcHjAgx = 9; //Field offset: 0x0
	private const int aAruZbRIdXJeYOJygAtrhlylwcCx = 2; //Field offset: 0x0
	private const int okWMohAPtZcjkYTOySlNShEDZnAr = 0; //Field offset: 0x0
	private const int cOgwVzmIENuNBszYnEczxnuHDDLJ = 210; //Field offset: 0x0
	private const int SEIAKoQxKrDrpYGDkSFenQFvkamc = 50; //Field offset: 0x0
	private const int dVJGyVbycZcaMNkWshKfNIkXXxlBA = 15; //Field offset: 0x0
	private const int OSdEeaSexiSXJcZXuuuCPgxDySj = 6; //Field offset: 0x0
	private const int wgdllTMznGeXzDhAXiTolgKhgnzjA = 44; //Field offset: 0x0
	private const int KVsMjrEOiWqvmRMInfKIzsJTDLfD = 44; //Field offset: 0x0
	private const int askAyRAcSxpfsrsXgavtxJUEptVwA = 46; //Field offset: 0x0
	private const int jXOjlhNqsHKhopTObWYThTQBcgyX = 47; //Field offset: 0x0
	private const int CrDKbbVCljnDKtAXKaeoobRuDDrIA = 48; //Field offset: 0x0
	private const int xUNrXppNXMIZmfXpLKvoXHuvGHAT = 49; //Field offset: 0x0
	private const int vrIFtCFfCrpPJgBjFwEOIkUaJnOFb = 45; //Field offset: 0x0
	private readonly NativeBuffer YegqbuohjBMnBznMUvkzRgRUkxSv; //Field offset: 0x58
	private readonly NativeBuffer BgFRlCwqFgbNrAAxWskfZxhHAzHl; //Field offset: 0x60
	private bool nJUdNvcjZIbXiBWqULurfbpqiXLhA; //Field offset: 0x68
	private Byte[] MDRCgLMMNphmAvEbSeEHDhDowENM; //Field offset: 0x70
	private readonly OutputReport COEmXZxJViBiiJdRkIPVyMppsFjx; //Field offset: 0x78
	private readonly Func<OutputReport, Boolean> odxcfhHmvSzrEFrzFZmaNlWxeXUR; //Field offset: 0x90
	private readonly Action<OutputReport> LTltMluPjUFGkjNpYQJUBhrRtJKoA; //Field offset: 0x98

	public override bool SpeakerEnabled
	{
		 get { } //Length: 5
		 set { } //Length: 206
	}

	public RailDriverDriver(InitArgs unnamed_param_0) { }

	private bool caIfqbbSizuctqhILBMyiDoswaxBb(kAMdWLAIUUPIEAafiYusMoDcVyVmb unnamed_param_0, eRzvhpApSEEezSKSJQauNUYBfjtD unnamed_param_1) { }

	private bool cpoetyIqYieATUMDgMgViIEajMneb(eRzvhpApSEEezSKSJQauNUYBfjtD unnamed_param_0) { }

	public virtual Extension CreateControllerExtension() { }

	protected virtual void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public override bool get_SpeakerEnabled() { }

	private void LmCFTgwZzsddCagmPTXfsLBWecrF(NativeBuffer unnamed_param_0, double unnamed_param_1) { }

	public static bool Matches(int vid, int pid) { }

	public virtual bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, double timestamp) { }

	public override void set_SpeakerEnabled(bool value) { }

	public override void SetLEDDisplay(int digitIndex, byte digitBitValues) { }

	public override void SetLEDDisplay(byte digit1BitValues, byte digit2BitValues, byte digit3BitValues) { }

	public virtual void Update(UpdateLoopType updateLoop) { }

	private void xcQqWHlyuycjMVLSEucimdWLKkAM(HIDControllerElement[] unnamed_param_0, NativeBuffer unnamed_param_1, double unnamed_param_2) { }

	private void ZlAFnbrLifZoHvslbxKrQrTANMbf(kAMdWLAIUUPIEAafiYusMoDcVyVmb unnamed_param_0) { }

}

