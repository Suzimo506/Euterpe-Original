namespace Rewired.Platforms.XboxOne;

[CustomClassObfuscation]
[CustomObfuscation]
internal sealed class XboxOneInputSource : CustomInputSource, IXboxOneInputSource
{
	[CustomObfuscation]
	private enum BadConnectionReason
	{
		None = 0,
		GamepadNotActive = 1,
		InvalidName = 2,
	}

	private struct PaUiPEicjhnbyHRsGvzGcwhwNDfLb
	{
		public uint WpDtmIlFUJGeTeojvAjlhksCIaHQb; //Field offset: 0x0
		public uint tusfJndSMQlzrlBanmCucAEcofBs; //Field offset: 0x4

		public PaUiPEicjhnbyHRsGvzGcwhwNDfLb(uint unnamed_param_0, uint unnamed_param_1) { }

	}

	private class vvTTgsGLvmutttEwBcGCwnLUajjC : Joystick
	{
		private const int bMWUdVcbaRUQKxqfXXruqPutnJrS = 6; //Field offset: 0x0
		private const int MctvACwZpXupPTRzPrTqbmgqdHBs = 9; //Field offset: 0x0
		private const int hcaIOHauqaszdTUEHVvVhFOjIlJVA = 8; //Field offset: 0x0
		private const int AIIDCKEJkFanPxafspfNRkPsyXOZ = 4; //Field offset: 0x0
		private const int LpFhdsbBGCyYbFSzpLnPySiouTUO = 3; //Field offset: 0x0
		private const int QwNJnDrqgCnxyazwUMGCdffeUiRe = 1; //Field offset: 0x0
		private const int nHVqPLPOCmUblQmUOFgycFpiHBNE = 0; //Field offset: 0x0
		private const int hFzWcZzkfbJyzfsCebaOYTyuhmbi = 15; //Field offset: 0x0
		private const int lQKjMdOWWwuKZEUGrhuFxHpvaPwZ = 14; //Field offset: 0x0
		private const int XzBZpZGgGVyifCIjnFnKERXOQHqQ = 13; //Field offset: 0x0
		private const int nPybkUtnweaDzgxiDDsKuCIAlRJzA = 9; //Field offset: 0x0
		private const int ACBIHuqdgfKxoWdPXmjvhXWEHDHH = 12; //Field offset: 0x0
		private const int dfZPzoRHjNwddwSeriLCzvyySrsb = 7; //Field offset: 0x0
		private const int EaoYOdjCrHYxiGiePuRjtfBEBMsBA = 6; //Field offset: 0x0
		private const int oGRXFYjeMJHvxCTgjdlZkNZiXIOy = 5; //Field offset: 0x0
		private const int NrppfcHiyfEOQbbWOwtEhfPpxztPA = 4; //Field offset: 0x0
		private const int SIdzbwSyDyVsRYbcOidtAZWtcuRi = 3; //Field offset: 0x0
		private const int bjLSRLmiZxdGBBUWXedIIHAfrBZeA = 2; //Field offset: 0x0
		private const int SQLEaCIDWwgnnEBwVNzupivDVcQS = 1; //Field offset: 0x0
		private const int rNoKCcrkcUHEzoRodHqTJarEjxdR = 0; //Field offset: 0x0
		private const string KQgzZGMOKyGXNgfZTUTvdhsgaLGT = "Xbox One Controller"; //Field offset: 0x0
		private const int TshEvKgeTSbAhQpxLCDjEaXdzmKT = 14; //Field offset: 0x0
		private const int ZRRGdBAGExaDfwqqlQHWTfukWnlpA = 8; //Field offset: 0x0
		private readonly IXboxOneInputSource cfzcHryyyqeSjrzQGsKAQMVeyMcl; //Field offset: 0x70
		private int dSWVOsdMDiyIHpIsJgFRkiYJuwmPA; //Field offset: 0x78
		private ulong qWofDEufenOovXbVGsOuvlhWVjSs; //Field offset: 0x80
		private String[] BacnzlwjZreBrMUfsceyETyFgRKw; //Field offset: 0x88

		public ulong tVMKArJiSsRDnZzQnFtUFPnQbstm
		{
			 get { } //Length: 8
		}

		public vvTTgsGLvmutttEwBcGCwnLUajjC(IXboxOneInputSource unnamed_param_0, ulong unnamed_param_1, int unnamed_param_2, bool unnamed_param_3) { }

		private void BoHFKVRtnGumQFSPzPskcxfsZFvb() { }

		public void cnKeHmkQcxuiGFzzSHmDurQFUSeaA(ulong unnamed_param_0) { }

		public virtual void gxgPRcKwociRNokZjvlZCFLqmmSU() { }

		private bool LfKvzuAGAWhjlkOqsVnRekbXSJdQ(int unnamed_param_0) { }

		private void mLdByTQAIObTQjIGGursEelXadkiA() { }

		public ulong oMCcrNcWDOYaeGMAXDdNmCFOFpkRA() { }

	}

	private const int mgGuhfpsnVkivBQezhRleqtyZLnRA = 8; //Field offset: 0x0
	private readonly bool ktHyYOotuGgbxPLLXVwLTXVPmjyu; //Field offset: 0x48
	private bool FsvBcYiROGDJzGRQDOvhIiFtNegSb; //Field offset: 0x49
	private Queue<PaUiPEicjhnbyHRsGvzGcwhwNDfLb> wntpacdrKIdpPfoRXlDOhlJhqkQCb; //Field offset: 0x50
	private bool HJIqUdpanNSGICxZbMmGqcqhazEs; //Field offset: 0x58

	public virtual bool isReady
	{
		 get { } //Length: 5
	}

	public XboxOneInputSource() { }

	private void bHdiVrAjxgZosiTtqombkKueeJuP() { }

	public virtual void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	private bool EaJBPtyHGIoyZnhMXLnOSlINwvbe(uint unnamed_param_0, bool unnamed_param_1, out BadConnectionReason unnamed_param_2) { }

	protected virtual void Finalize() { }

	public virtual bool get_isReady() { }

	public override int GetXboxOneUserIdFromUnityJoystick(int unityJoystickId) { }

	private void iHSkhjpBfbbCEIdvUdXEcJCrRkau(uint unnamed_param_0, bool unnamed_param_1) { }

	private void OsGMbGfsOkqmRTMByGLHmrAiSmOW() { }

	public override void PulseVibrateMotor(ulong xboxOneJoystickId, XboxOneGamepadMotorType motor, float startLevel, float endLevel, float duration) { }

	private void QiYKgeGvuKsPcBEoIvqtfVazkXTO(uint unnamed_param_0, bool unnamed_param_1) { }

	public override bool SetXboxOneVibration(ulong xboxOneJoystickId, RxhTXRdmHUscXChCXFKlTcNXwkox vibration) { }

	public virtual void Update() { }

}

