namespace Rewired.HID.Drivers;

[CustomClassObfuscation]
[CustomObfuscation]
internal class DualShock4Driver : HIDDeviceDriver, IDisposable, IControllerDriver, IDriver_DualShock4
{
	private enum eMIrdxNwWVntcoSjPZgbPxMHEOp
	{
		X = 0,
		Y = 1,
		Z = 2,
	}

	private enum ymvUVNVuYZGogMZODYICiCEuDqTs
	{
		None = 0,
		XZ = 1,
		Y = 2,
	}

	private const float tCpKSeHWALlWtTpcEidTfVifnSdw = 4; //Field offset: 0x0
	private const int WRlHAAeflSYXUbkBwGlAwnfnziuj = 6; //Field offset: 0x0
	private const int mVUnyrEczMTpjcgxYWEtYIggaeDe = 7; //Field offset: 0x0
	private const int EWxeZvFXOCnTIgJtRDSNSxzuYaXJ = 10; //Field offset: 0x0
	private const int AmAYNvqeEgBHEDkiUvQzsstJkzPD = 30; //Field offset: 0x0
	private const int nDkggtSGMTGoYdfqKrHcaqKVnvNu = 27; //Field offset: 0x0
	private const byte QXoHdSIHDoSURdrSQOOYpHzUhnuv = 200; //Field offset: 0x0
	private const byte eMndIpcmvLEpqWTZFERfxzOPZMcg = 53; //Field offset: 0x0
	private const byte ZZtVmtBRqCQVyxgAtVlhSNmRetFL = 255; //Field offset: 0x0
	private const byte EQxBEZzfcXZHhwZtqEosXLBVJUJe = 0; //Field offset: 0x0
	private const bool uCGJWTOueljviMjxhVWFvFQHpOww = True; //Field offset: 0x0
	private const int RufbfwsfTlbHlPBahhvUzhdpFKfK = 25; //Field offset: 0x0
	private const int vlDiIEDgEhZVbVYmgHjDOqPnQAvP = 187500; //Field offset: 0x0
	private const float oZnbDHEkOuNywDitEAzvljBiqIsbA = 8192; //Field offset: 0x0
	private const float UAhostYsQbvgRrVrOaqCFPlDIzKD = 0.0010652969; //Field offset: 0x0
	private const bool DnChtAzSIpUSJTlbNhwmHAwpSqBNA = True; //Field offset: 0x0
	private const bool nczhuxACmiHZGoZQmLlMsyoTTFqf = True; //Field offset: 0x0
	private const bool TmmctXkhHOValqipictBpbBZIkER = True; //Field offset: 0x0
	private const bool DXHPKhEFzgtvBpKxHoMzZqODDaCaA = True; //Field offset: 0x0
	private const float ncWiYEavIUFwzELpaDXQQAfzUkNcb = 4096; //Field offset: 0x0
	private const float CnULDMZMiXheOgZedMgnLIgpkkXnA = 16384; //Field offset: 0x0
	private const float PqZDLMBYbJYajqgvvpVWlHUPObKcA = 16777216; //Field offset: 0x0
	private const float EdSIOcDiMbPAHDhRrvNwGpclpDui = 268435460; //Field offset: 0x0
	private const float wZmKilEbvptoVAWNGxcUYIHSfOlBA = 0.01999998; //Field offset: 0x0
	private const float nUcbloOHbvYheYIvvusJkwWIhVer = 8192; //Field offset: 0x0
	private const float oFPlaJlKnheBBIuOcNJXxOlNuFEIA = 0.98; //Field offset: 0x0
	private const float hzsHulOWFtpRieNJIPhzgByhvXai = 45; //Field offset: 0x0
	private const float QZWukHuAWZQFqEuSEmwuXgtbbpkr = 20; //Field offset: 0x0
	private const int pKjYGZqEgSxuNcwqjfHDAFNJjLCW = 5; //Field offset: 0x0
	private const int UTEoJxBDvMinHcBtleIbNxiruOOe = 35; //Field offset: 0x0
	private const float WYZtJuLooWFaluOuohnsYOwJCiweA = 0.06103702; //Field offset: 0x0
	private const int bCzDUlhKyUUKGAAuTyhLwjYUGeiQA = 19; //Field offset: 0x0
	private const int SEIAKoQxKrDrpYGDkSFenQFvkamc = 14; //Field offset: 0x0
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
	private const int PWGSLpDpprCTBSGcBwwsGJvwrxXv = 13; //Field offset: 0x0
	private const int nNhokjFKGtnUODKnUFBBmVqfBetn = 0; //Field offset: 0x0
	private const int nedmLBAQmYPTmQIyCdNkHQDVAucp = 0; //Field offset: 0x0
	private const int KrNeSYZXnkbFpewxyEtFOmNCHwLJ = 1; //Field offset: 0x0
	private const int iKNvbJMoDxlEzGFCwLUuxNuIHRWT = 17; //Field offset: 0x0
	private const int ALePSQBONOMxUFjbDfFrTlsfGqwr = 0; //Field offset: 0x0
	private const int vBQizgDUWFtDhHywbVfLwHakcHan = 2; //Field offset: 0x0
	private const int ZGEnUrGodOIzaWPzTRlPlcbDujhi = 64; //Field offset: 0x0
	private const int DljgGDZaELRJLUynFaGKLVTtUkDD = 78; //Field offset: 0x0
	private const int odKNtDrKXlERwKeZSdwcFWshvoOJ = 1; //Field offset: 0x0
	private const int NjMFfXnOmgOrSktqDuBqYpiVDJky = 2; //Field offset: 0x0
	private const int CgezjrZYILwyEgBEPRsRSDoeWyFq = 3; //Field offset: 0x0
	private const int EXPQsQaljLHSWmtDebFidbEkfOfBA = 4; //Field offset: 0x0
	private const int exNiXvTVEHMrxEiWocEyWgOHjuXA = 8; //Field offset: 0x0
	private const int dkAyNcILsvSZIsAKzSyaTaJpOMSe = 9; //Field offset: 0x0
	private const int psxRIndWtpXBabKUTOiXyqZrildA = 5; //Field offset: 0x0
	private readonly bool omAcjoCyZpSOqErsJsxSlJqclkZhb; //Field offset: 0x58
	private readonly DeviceConnectionType wxbWzfSoKSvZziqelWdwcEIpOSOQ; //Field offset: 0x5C
	private readonly int zevQICKlqhMRFvOsvyZrrNfuHPlj; //Field offset: 0x60
	private readonly int bDZxMLCdCwzvlBDVnIWFqwjrDOvI; //Field offset: 0x64
	private readonly bool vUHNwNKiGXVmlSdGZhFQFEvkzYIV; //Field offset: 0x68
	private readonly byte eYLcwpPVNwFonUWEiddsJIAuiUMyA; //Field offset: 0x69
	private readonly int uElMOTNiBrjGgfcecpRUlDBiPjAxA; //Field offset: 0x6C
	private readonly int ADXFhOBqdZpiLFgoeTAAfYEYjQqlA; //Field offset: 0x70
	private readonly int oacGboiAQxjdUqOceIXffFFtPTBGb; //Field offset: 0x74
	private readonly int uavVQslaNeeLYifGjaEttqUBgobzA; //Field offset: 0x78
	private readonly int xEVfqRzxIxZxpFNeMjCdemifUmMo; //Field offset: 0x7C
	private readonly int LuKIjWiOdpjzcYQrMebEfOGQGQye; //Field offset: 0x80
	private readonly NativeBuffer YegqbuohjBMnBznMUvkzRgRUkxSv; //Field offset: 0x88
	private readonly NativeBuffer BgFRlCwqFgbNrAAxWskfZxhHAzHl; //Field offset: 0x90
	private readonly OutputReport COEmXZxJViBiiJdRkIPVyMppsFjx; //Field offset: 0x98
	private readonly Func<OutputReport, Boolean> odxcfhHmvSzrEFrzFZmaNlWxeXUR; //Field offset: 0xB0
	private readonly Action<OutputReport> LTltMluPjUFGkjNpYQJUBhrRtJKoA; //Field offset: 0xB8
	private readonly GetHidFeatureData wusrMNpUyaGcxiMmbEZQHZcYpiJL; //Field offset: 0xC0
	private bool TddNeJfCzUPSlkAamntpOCMaDVPR; //Field offset: 0xC8
	private bool TdRHNXyywQFInKIsBwpGCoZSEzvQ; //Field offset: 0xC9
	private double kmRPhvbZCzryEXaUOsgyHAplXeQQ; //Field offset: 0xD0
	private byte AkuOLJWhLinQsxLwucHABkIXofLDb; //Field offset: 0xD8
	private Quaternion baJufiCdNIgmojrhzEGiYskLUIXi; //Field offset: 0xDC
	private ushort YOFrDZtvoLLOblWfrCwWCnLVpmuD; //Field offset: 0xEC
	private float xSqRBZHmDODwuHPHAXmyYpVdyldg; //Field offset: 0xF0
	private double tTarQORNfKhqBLbtjcgwGdFFqMwh; //Field offset: 0xF8
	private float SvOvRobqgPgEXBojyWOyVmzZxeZb; //Field offset: 0x100
	private byte sveMPYSKDkEqLKKKdXMrtshhxMdpA; //Field offset: 0x104
	private byte LJLdjDsHVAjKOCnchzxqusDbYXrl; //Field offset: 0x105
	private Quaternion hSGUvhTgdVcMRqkkwCPUIcZiVVIt; //Field offset: 0x108
	private Quaternion kyuGxcIeEszLUlHTWjPpQPlwEsVU; //Field offset: 0x118
	private bool cqjhMinahPkPVfTnhRSjdGWfDoUn; //Field offset: 0x128
	private int fQxDrRLbjbEUECSWyyAiuEtcMQMSA; //Field offset: 0x12C
	private Int32[] dHRJhujvFRlrHpjQcKokwtxFbmjb; //Field offset: 0x130
	private Int32[] GtsvMDXwxFrOZmmvThXRkpwxhtnS; //Field offset: 0x138

	public override Vector3 AccelerometerValue
	{
		 get { } //Length: 265
	}

	public override Vector3 AccelerometerValueRaw
	{
		 get { } //Length: 173
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

	public override Quaternion Orientation
	{
		 get { } //Length: 14
	}

	public override float RightMotor
	{
		 get { } //Length: 92
		 set { } //Length: 112
	}

	public DualShock4Driver(InitArgs unnamed_param_0) { }

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

	public override Quaternion get_Orientation() { }

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

	private Quaternion kwAqZXwBcCXeyhhGKBHDcxeiVEGgA(Quaternion unnamed_param_0, eMIrdxNwWVntcoSjPZgbPxMHEOp unnamed_param_1) { }

	private void LmCFTgwZzsddCagmPTXfsLBWecrF(NativeBuffer unnamed_param_0, double unnamed_param_1) { }

	public static bool Matches(int vid, int pid) { }

	private void mCBABaUryhlavFpljImjwqWKpTWE(Byte[] unnamed_param_0, Single[] unnamed_param_1) { }

	private bool mwmyMaCwIPdjPwgPhRGlTseTNFXF(Vector3 unnamed_param_0, out ymvUVNVuYZGogMZODYICiCEuDqTs unnamed_param_1) { }

	private bool ndKIZrXoDnhZLkTFGzVPzHNAAObcA(float unnamed_param_0) { }

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

	public override void set_RightMotor(float value) { }

	public override void StopLightFlash() { }

	public override void StopVibration() { }

	private int tauisfhHZGacDFhnZJqGSmqcoMDD(int unnamed_param_0, bool unnamed_param_1, int unnamed_param_2) { }

	private bool tBVSQyUedYWZVHNdDQfqQQAjGuZh(Vector3 unnamed_param_0) { }

	private Quaternion UKrVJYCjjhaSFBqcKsyrAViwzBmgA(Vector3 unnamed_param_0, float unnamed_param_1 = 0) { }

	private Vector3 UNwIcYbmOJJSmgZPUglDUAFMTyCn(Single[] unnamed_param_0) { }

	public virtual void Update(UpdateLoopType updateLoop) { }

	private static bool vOiNPblkLMXtFkUJCQvwuMhQdsKE(ref Vector3 unnamed_param_0) { }

	private void WCwRAscQenbgYhPBImEWXqewzhpg(eRzvhpApSEEezSKSJQauNUYBfjtD unnamed_param_0) { }

	private void wEgdqlIAISwqAGlQaQmWegUGFrxqb() { }

	private Vector3 WxsUQrmHKHEaeVEhhAcKPphSEtIx(Vector3 unnamed_param_0, float unnamed_param_1) { }

	private Vector3 WxsUQrmHKHEaeVEhhAcKPphSEtIx(ExpandableArray_DataContainer<kLuNdbrJGJiHJiTkrqQjaMlPqjVE> unnamed_param_0) { }

	private void xBYOnnjOZTAYPTitFDkwdMSecrjL(Byte[] unnamed_param_0, Single[] unnamed_param_1) { }

	private void xcQqWHlyuycjMVLSEucimdWLKkAM(HIDControllerElement[] unnamed_param_0, NativeBuffer unnamed_param_1, double unnamed_param_2) { }

	private void XfTOOcWjGZTnXUMzLNZjdmnBTFaJ(Vector3 unnamed_param_0, Vector3 unnamed_param_1) { }

	private float YlVcgffJiJdPobjllIwHdJBHaLxDb(float unnamed_param_0, float unnamed_param_1) { }

	private float yMnsCcxMoWDjrcfeRLdTmThIgvaP(Vector3 unnamed_param_0) { }

	private Quaternion ZDOEqqSNLSZUiVaQENfsZXxiFuhv(Vector3 unnamed_param_0, float unnamed_param_1 = 0) { }

	private void ZdpTRRndvanCsmpvGtfzHbrIVtSB() { }

	private void ZlAFnbrLifZoHvslbxKrQrTANMbf() { }

}

