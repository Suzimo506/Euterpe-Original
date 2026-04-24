namespace Rewired.HID.Drivers;

[CustomClassObfuscation]
[CustomObfuscation]
internal class DualSenseDriver : HIDDeviceDriver, IDisposable, IControllerDriver, IDriver_DualSense
{
	internal enum jKNAYFmLAYihehPopXRctRNdZMVmA
	{
		High = 0,
		Medium = 1,
		Low = 2,
	}

	private enum kVhYffpxEwrCKICxnagoDLxYXwCIA
	{
		X = 0,
		Y = 1,
		Z = 2,
	}

	private enum ovOCmmOlOjHQxOgcBhhkZUyfqLdK
	{
		None = 0,
		XZ = 1,
		Y = 2,
	}

	private const float tCpKSeHWALlWtTpcEidTfVifnSdw = 4; //Field offset: 0x0
	private const int PWGSLpDpprCTBSGcBwwsGJvwrxXv = 16; //Field offset: 0x0
	private const int UTEoJxBDvMinHcBtleIbNxiruOOe = 33; //Field offset: 0x0
	private const int pKjYGZqEgSxuNcwqjfHDAFNJjLCW = 8; //Field offset: 0x0
	private const int WRlHAAeflSYXUbkBwGlAwnfnziuj = 9; //Field offset: 0x0
	private const int mVUnyrEczMTpjcgxYWEtYIggaeDe = 10; //Field offset: 0x0
	private const int EWxeZvFXOCnTIgJtRDSNSxzuYaXJ = 28; //Field offset: 0x0
	private const int IkdJpqVXZwvoHaRdfEZOTfRpbLfC = 54; //Field offset: 0x0
	private const int MeyjrFpSHJIZfyqRYezucORElzyGb = 55; //Field offset: 0x0
	private const int BpxKHiVmKhwLuLyiErfvLGDYIcWZ = 54; //Field offset: 0x0
	private const bool uCGJWTOueljviMjxhVWFvFQHpOww = True; //Field offset: 0x0
	private const int RufbfwsfTlbHlPBahhvUzhdpFKfK = 25; //Field offset: 0x0
	private const int vlDiIEDgEhZVbVYmgHjDOqPnQAvP = 3000000; //Field offset: 0x0
	private const float oZnbDHEkOuNywDitEAzvljBiqIsbA = 8192; //Field offset: 0x0
	private const int bCzDUlhKyUUKGAAuTyhLwjYUGeiQA = 22; //Field offset: 0x0
	private const float UAhostYsQbvgRrVrOaqCFPlDIzKD = 0.0010652969; //Field offset: 0x0
	private const bool DnChtAzSIpUSJTlbNhwmHAwpSqBNA = True; //Field offset: 0x0
	private const bool nczhuxACmiHZGoZQmLlMsyoTTFqf = True; //Field offset: 0x0
	private const bool TmmctXkhHOValqipictBpbBZIkER = True; //Field offset: 0x0
	private static UInt32[] nkZAfoGEzdqNLIYneMdaWRdTLpmzb; //Field offset: 0x0
	private const float ncWiYEavIUFwzELpaDXQQAfzUkNcb = 4096; //Field offset: 0x0
	private const float CnULDMZMiXheOgZedMgnLIgpkkXnA = 16384; //Field offset: 0x0
	private const float PqZDLMBYbJYajqgvvpVWlHUPObKcA = 16777216; //Field offset: 0x0
	private const float EdSIOcDiMbPAHDhRrvNwGpclpDui = 268435460; //Field offset: 0x0
	private const float wZmKilEbvptoVAWNGxcUYIHSfOlBA = 0.01999998; //Field offset: 0x0
	private const float nUcbloOHbvYheYIvvusJkwWIhVer = 8192; //Field offset: 0x0
	private const float oFPlaJlKnheBBIuOcNJXxOlNuFEIA = 0.98; //Field offset: 0x0
	private const float hzsHulOWFtpRieNJIPhzgByhvXai = 45; //Field offset: 0x0
	private const float QZWukHuAWZQFqEuSEmwuXgtbbpkr = 20; //Field offset: 0x0
	private const float WYZtJuLooWFaluOuohnsYOwJCiweA = 0.06103702; //Field offset: 0x0
	private const int psxRIndWtpXBabKUTOiXyqZrildA = 8; //Field offset: 0x0
	private const bool DXHPKhEFzgtvBpKxHoMzZqODDaCaA = True; //Field offset: 0x0
	private const int exNiXvTVEHMrxEiWocEyWgOHjuXA = 5; //Field offset: 0x0
	private const int dkAyNcILsvSZIsAKzSyaTaJpOMSe = 6; //Field offset: 0x0
	private const int SEIAKoQxKrDrpYGDkSFenQFvkamc = 15; //Field offset: 0x0
	private const int UCHqbWXrhfpzKgMATVGaEpqktqTJ = 2; //Field offset: 0x0
	private const int inMrjtNKjKupRVZJaiYcNdeAjPFS = 0; //Field offset: 0x0
	private const int OPBevsePXfgmvlKcdCppLbZYmKrcb = 1912; //Field offset: 0x0
	private const int esmiifXdSpsKpewgdIruPxVVCPjI = 0; //Field offset: 0x0
	private const int HBuNIlwXBbJtNNoxIQmjUfnyJcuJ = 941; //Field offset: 0x0
	private const bool jlkKoUviIrVXTGmvJWLQbrovmbhg = False; //Field offset: 0x0
	private const bool ltenJmYvlmgNZSCaOatQCoIiQNbfA = True; //Field offset: 0x0
	private const float VFOdzofCXkkPuvMcjOHAoqRNMnisA = 2.5; //Field offset: 0x0
	private const int rQDEaHsOKbOjEqCawVjzDkEOupxb = 0; //Field offset: 0x0
	private const int dVNbuKRKflUkxiPIzOKMVkWXpctU = 0; //Field offset: 0x0
	private const int MyliCEUUoXhAvcxFlMeAridJVFqx = 1; //Field offset: 0x0
	private const int lQUtcvkFSBGrplPzbrKnJhARQhAB = 0; //Field offset: 0x0
	private const uint aNmjnPirGtVPPOaqfmGBgfAIuFnJ = 3940166985; //Field offset: 0x0
	private const int nedmLBAQmYPTmQIyCdNkHQDVAucp = 0; //Field offset: 0x0
	private const int CgezjrZYILwyEgBEPRsRSDoeWyFq = 3; //Field offset: 0x0
	private const int NjMFfXnOmgOrSktqDuBqYpiVDJky = 2; //Field offset: 0x0
	private const int EXPQsQaljLHSWmtDebFidbEkfOfBA = 4; //Field offset: 0x0
	private const int hhQgpVFxnZObyTuggIvtOeEgPlcK = 547; //Field offset: 0x0
	private const int NZVlVbHplnInrNUtdjGtrLkBDKKl = 64; //Field offset: 0x0
	private const int mwiPcrLAnVyqhhjRagCkHzyfBrUq = 547; //Field offset: 0x0
	private const int odKNtDrKXlERwKeZSdwcFWshvoOJ = 1; //Field offset: 0x0
	private const int ZGEnUrGodOIzaWPzTRlPlcbDujhi = 64; //Field offset: 0x0
	private const int MkMFLyzqtvPtBlNYzgplminoQxpj = 1; //Field offset: 0x0
	private const int ALePSQBONOMxUFjbDfFrTlsfGqwr = 0; //Field offset: 0x0
	private const int gvnbGJofJyLSnymhjTpjxvpgtcnc = 49; //Field offset: 0x0
	private const int KrNeSYZXnkbFpewxyEtFOmNCHwLJ = 1; //Field offset: 0x0
	private const int gPNToLuvjFBhwfAuTJxZIMiUswOB = 48; //Field offset: 0x0
	private const int nNhokjFKGtnUODKnUFBBmVqfBetn = 0; //Field offset: 0x0
	private readonly bool omAcjoCyZpSOqErsJsxSlJqclkZhb; //Field offset: 0x58
	private readonly int zevQICKlqhMRFvOsvyZrrNfuHPlj; //Field offset: 0x5C
	private readonly int bDZxMLCdCwzvlBDVnIWFqwjrDOvI; //Field offset: 0x60
	private readonly bool vUHNwNKiGXVmlSdGZhFQFEvkzYIV; //Field offset: 0x64
	private readonly byte eYLcwpPVNwFonUWEiddsJIAuiUMyA; //Field offset: 0x65
	private readonly int uElMOTNiBrjGgfcecpRUlDBiPjAxA; //Field offset: 0x68
	private readonly int ADXFhOBqdZpiLFgoeTAAfYEYjQqlA; //Field offset: 0x6C
	private readonly int oacGboiAQxjdUqOceIXffFFtPTBGb; //Field offset: 0x70
	private readonly int uavVQslaNeeLYifGjaEttqUBgobzA; //Field offset: 0x74
	private readonly int xEVfqRzxIxZxpFNeMjCdemifUmMo; //Field offset: 0x78
	private readonly int LuKIjWiOdpjzcYQrMebEfOGQGQye; //Field offset: 0x7C
	private readonly NativeBuffer YegqbuohjBMnBznMUvkzRgRUkxSv; //Field offset: 0x80
	private readonly NativeBuffer BgFRlCwqFgbNrAAxWskfZxhHAzHl; //Field offset: 0x88
	private OutputReport COEmXZxJViBiiJdRkIPVyMppsFjx; //Field offset: 0x90
	private readonly Func<OutputReport, Boolean> odxcfhHmvSzrEFrzFZmaNlWxeXUR; //Field offset: 0xA8
	private readonly Action<OutputReport> LTltMluPjUFGkjNpYQJUBhrRtJKoA; //Field offset: 0xB0
	private bool TddNeJfCzUPSlkAamntpOCMaDVPR; //Field offset: 0xB8
	private bool TdRHNXyywQFInKIsBwpGCoZSEzvQ; //Field offset: 0xB9
	private double kmRPhvbZCzryEXaUOsgyHAplXeQQ; //Field offset: 0xC0
	private byte AkuOLJWhLinQsxLwucHABkIXofLDb; //Field offset: 0xC8
	private bool LchNAHWhcfjNbABzeeSCAeielDYJb; //Field offset: 0xC9
	private bool AJMWiNzguUesVqiNRXDoWECuVrmD; //Field offset: 0xCA
	private bool DDmMBIWzhKinPxmAaiCtfUDivuem; //Field offset: 0xCB
	private Quaternion baJufiCdNIgmojrhzEGiYskLUIXi; //Field offset: 0xCC
	private DualSenseMicrophoneLightMode ZfkRwswYwxlqZpDgSDVQXeiUBEJbA; //Field offset: 0xDC
	private jKNAYFmLAYihehPopXRctRNdZMVmA dBTGlPDASqVYdMjWejMtYiuHKiwUA; //Field offset: 0xDD
	private DualSensePlayerLightFlags sDUjJbVRlPEdusZdCEimuQpJrmPk; //Field offset: 0xDE
	private bool IunwvVcYiInmPRmGMVABkaxilvuK; //Field offset: 0xDF
	private bool XMljJhdSVaEgHUOTbUinvARkdhPfA; //Field offset: 0xE0
	private uint YOFrDZtvoLLOblWfrCwWCnLVpmuD; //Field offset: 0xE4
	private float xSqRBZHmDODwuHPHAXmyYpVdyldg; //Field offset: 0xE8
	private double tTarQORNfKhqBLbtjcgwGdFFqMwh; //Field offset: 0xF0
	private float SvOvRobqgPgEXBojyWOyVmzZxeZb; //Field offset: 0xF8
	private byte sveMPYSKDkEqLKKKdXMrtshhxMdpA; //Field offset: 0xFC
	private byte LJLdjDsHVAjKOCnchzxqusDbYXrl; //Field offset: 0xFD
	private Quaternion hSGUvhTgdVcMRqkkwCPUIcZiVVIt; //Field offset: 0x100
	private Quaternion kyuGxcIeEszLUlHTWjPpQPlwEsVU; //Field offset: 0x110
	private bool cqjhMinahPkPVfTnhRSjdGWfDoUn; //Field offset: 0x120
	private int fQxDrRLbjbEUECSWyyAiuEtcMQMSA; //Field offset: 0x124
	private Int32[] dHRJhujvFRlrHpjQcKokwtxFbmjb; //Field offset: 0x128
	private Int32[] GtsvMDXwxFrOZmmvThXRkpwxhtnS; //Field offset: 0x130

	public override Vector3 AccelerometerValue
	{
		 get { } //Length: 265
	}

	public override Vector3 AccelerometerValueRaw
	{
		 get { } //Length: 173
	}

	public override bool BatteryCharging
	{
		 get { } //Length: 8
	}

	public override float BatteryLevel
	{
		 get { } //Length: 54
	}

	public override Vector3 GyroscopeValue
	{
		 get { } //Length: 574
	}

	public override Vector3 GyroscopeValueRaw
	{
		 get { } //Length: 363
	}

	private bool isVibrating
	{
		private get { } //Length: 103
	}

	public override Vector3 LastGyroscopeValue
	{
		 get { } //Length: 456
	}

	public override Vector3 LastGyroscopeValueRaw
	{
		 get { } //Length: 173
	}

	public override float LeftMotor
	{
		 get { } //Length: 92
		 set { } //Length: 112
	}

	public override float LightColorB
	{
		 get { } //Length: 73
		 set { } //Length: 109
	}

	public override float LightColorG
	{
		 get { } //Length: 73
		 set { } //Length: 109
	}

	public override float LightColorR
	{
		 get { } //Length: 73
		 set { } //Length: 109
	}

	public override float LightFlashOffDuration
	{
		 get { } //Length: 15
		 set { } //Length: 101
	}

	public override float LightFlashOnDuration
	{
		 get { } //Length: 15
		 set { } //Length: 100
	}

	public override int MaxTouches
	{
		 get { } //Length: 6
	}

	public override DualSenseMicrophoneLightMode microphoneLightMode
	{
		 get { } //Length: 8
		 set { } //Length: 14
	}

	public override Quaternion Orientation
	{
		 get { } //Length: 14
	}

	public override DualSenseOtherLightBrightness otherLightBrightness
	{
		 get { } //Length: 180
		 set { } //Length: 191
	}

	public override DualSensePlayerLightFlags playerLights
	{
		 get { } //Length: 8
		 set { } //Length: 14
	}

	public override float RightMotor
	{
		 get { } //Length: 92
		 set { } //Length: 112
	}

	private static DualSenseDriver() { }

	public DualSenseDriver(InitArgs unnamed_param_0) { }

	private static jKNAYFmLAYihehPopXRctRNdZMVmA ajClzkfZQWqjuCnAIJPHxdixCCTc(DualSenseOtherLightBrightness unnamed_param_0) { }

	private Vector3 AmfMzHfLxsbbxDGKVEXLytoUSVFn(Vector3 unnamed_param_0, float unnamed_param_1 = 0) { }

	private float azHZzFhnMYXsQSmimKyPeiRyUzsF() { }

	private bool caIfqbbSizuctqhILBMyiDoswaxBb(eRzvhpApSEEezSKSJQauNUYBfjtD unnamed_param_0) { }

	private bool CcuyqhoQfRUCBtxTZRhjykLDICKs() { }

	private bool cpoetyIqYieATUMDgMgViIEajMneb(eRzvhpApSEEezSKSJQauNUYBfjtD unnamed_param_0) { }

	public virtual Extension CreateControllerExtension() { }

	protected virtual void Dispose(bool disposing) { }

	private void EIeCjUdXIWiKABNoTODlaphqNJAY(NativeBuffer unnamed_param_0) { }

	private void EitCLWHdHlgCPNCosCrclhERoTtC() { }

	protected virtual void Finalize() { }

	private void fuRVKZlvrTtZzNTbeGhrnDvpekze(NativeBuffer unnamed_param_0, TouchData[] unnamed_param_1) { }

	public override Vector3 get_AccelerometerValue() { }

	public override Vector3 get_AccelerometerValueRaw() { }

	public override bool get_BatteryCharging() { }

	public override float get_BatteryLevel() { }

	public override Vector3 get_GyroscopeValue() { }

	public override Vector3 get_GyroscopeValueRaw() { }

	public override Vector3 get_LastGyroscopeValue() { }

	public override Vector3 get_LastGyroscopeValueRaw() { }

	public override float get_LeftMotor() { }

	public override float get_LightColorB() { }

	public override float get_LightColorG() { }

	public override float get_LightColorR() { }

	public override float get_LightFlashOffDuration() { }

	public override float get_LightFlashOnDuration() { }

	public override int get_MaxTouches() { }

	public override DualSenseMicrophoneLightMode get_microphoneLightMode() { }

	public override Quaternion get_Orientation() { }

	public override DualSenseOtherLightBrightness get_otherLightBrightness() { }

	public override DualSensePlayerLightFlags get_playerLights() { }

	public override float get_RightMotor() { }

	public override int GetTouchCount() { }

	public override int GetTouchIdAtIndex(int index) { }

	public override bool GetTouchPositionAbsoluteByIndex(int index, out int positionX, out int positionY) { }

	public override bool GetTouchPositionAbsoluteByTouchId(int touchId, out int positionX, out int positionY) { }

	public override bool GetTouchPositionByIndex(int index, out Vector2 position) { }

	public override bool GetTouchPositionByTouchId(int touchId, out Vector2 position) { }

	private static Vector3 IcquWhqkPJUJxsocvBvQhMnUCHJLA(Vector3 unnamed_param_0, Vector3 unnamed_param_1) { }

	public static Quaternion Inverse(Quaternion quaternion) { }

	public override bool IsTouchingAtIndex(int index) { }

	public override bool IsTouchingAtTouchId(int touchId) { }

	private bool KJlsfrmKFjjESpTlWGZYLwiIGYLv(Vector3 unnamed_param_0) { }

	private Quaternion kwAqZXwBcCXeyhhGKBHDcxeiVEGgA(Quaternion unnamed_param_0, kVhYffpxEwrCKICxnagoDLxYXwCIA unnamed_param_1) { }

	private void LmCFTgwZzsddCagmPTXfsLBWecrF(NativeBuffer unnamed_param_0, double unnamed_param_1) { }

	public static bool Matches(int vid, int pid) { }

	private void mCBABaUryhlavFpljImjwqWKpTWE(Byte[] unnamed_param_0, Single[] unnamed_param_1) { }

	private bool mwmyMaCwIPdjPwgPhRGlTseTNFXF(Vector3 unnamed_param_0, out ovOCmmOlOjHQxOgcBhhkZUyfqLdK unnamed_param_1) { }

	private bool ndKIZrXoDnhZLkTFGzVPzHNAAObcA(float unnamed_param_0) { }

	private static uint NRYFlGgEyajFFoaIgtePEHVcqvyQ(NativeBuffer unnamed_param_0, int unnamed_param_1) { }

	private int oVlgSNdbBlNpZvMLbQiCDQdVohOx(int unnamed_param_0) { }

	public virtual bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, double timestamp) { }

	private static Quaternion qJsYGFiXHAQkvnGdfMJntYFxlNZj(Quaternion unnamed_param_0, Vector3 unnamed_param_1) { }

	public override void ResetOrientation() { }

	public override void set_LeftMotor(float value) { }

	public override void set_LightColorB(float value) { }

	public override void set_LightColorG(float value) { }

	public override void set_LightColorR(float value) { }

	public override void set_LightFlashOffDuration(float value) { }

	public override void set_LightFlashOnDuration(float value) { }

	public override void set_microphoneLightMode(DualSenseMicrophoneLightMode value) { }

	public override void set_otherLightBrightness(DualSenseOtherLightBrightness value) { }

	public override void set_playerLights(DualSensePlayerLightFlags value) { }

	public override void set_RightMotor(float value) { }

	public override void StopLightFlash() { }

	public override void StopVibration() { }

	private int tauisfhHZGacDFhnZJqGSmqcoMDD(int unnamed_param_0, bool unnamed_param_1, int unnamed_param_2) { }

	private bool tBVSQyUedYWZVHNdDQfqQQAjGuZh(Vector3 unnamed_param_0) { }

	private static DualSenseOtherLightBrightness tGYxRzwRGLEsdXRzxrqYwDGiGVQu(jKNAYFmLAYihehPopXRctRNdZMVmA unnamed_param_0) { }

	private Quaternion UKrVJYCjjhaSFBqcKsyrAViwzBmgA(Vector3 unnamed_param_0, float unnamed_param_1 = 0) { }

	private Vector3 UNwIcYbmOJJSmgZPUglDUAFMTyCn(Single[] unnamed_param_0) { }

	public virtual void Update(UpdateLoopType updateLoop) { }

	private static bool vOiNPblkLMXtFkUJCQvwuMhQdsKE(ref Vector3 unnamed_param_0) { }

	private void WCwRAscQenbgYhPBImEWXqewzhpg(eRzvhpApSEEezSKSJQauNUYBfjtD unnamed_param_0) { }

	private void wEgdqlIAISwqAGlQaQmWegUGFrxqb() { }

	private Vector3 WxsUQrmHKHEaeVEhhAcKPphSEtIx(ExpandableArray_DataContainer<kLuNdbrJGJiHJiTkrqQjaMlPqjVE> unnamed_param_0) { }

	private Vector3 WxsUQrmHKHEaeVEhhAcKPphSEtIx(Vector3 unnamed_param_0, float unnamed_param_1) { }

	private void xBYOnnjOZTAYPTitFDkwdMSecrjL(Byte[] unnamed_param_0, Single[] unnamed_param_1) { }

	private void xcQqWHlyuycjMVLSEucimdWLKkAM(HIDControllerElement[] unnamed_param_0, NativeBuffer unnamed_param_1, double unnamed_param_2) { }

	private void XfTOOcWjGZTnXUMzLNZjdmnBTFaJ(Vector3 unnamed_param_0, Vector3 unnamed_param_1) { }

	private float YlVcgffJiJdPobjllIwHdJBHaLxDb(float unnamed_param_0, float unnamed_param_1) { }

	private float yMnsCcxMoWDjrcfeRLdTmThIgvaP(Vector3 unnamed_param_0) { }

	private Quaternion ZDOEqqSNLSZUiVaQENfsZXxiFuhv(Vector3 unnamed_param_0, float unnamed_param_1 = 0) { }

	private void ZdpTRRndvanCsmpvGtfzHbrIVtSB() { }

	private void ZlAFnbrLifZoHvslbxKrQrTANMbf() { }

	private void ZlAFnbrLifZoHvslbxKrQrTANMbf(NativeBuffer unnamed_param_0, int unnamed_param_1) { }

}

