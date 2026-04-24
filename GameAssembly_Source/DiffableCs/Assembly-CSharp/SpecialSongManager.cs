//Type is in global namespace

public class SpecialSongManager : Singleton<SpecialSongManager>
{
	private class HideBmsInfo
	{
		private string musicUid; //Field offset: 0x10
		private int triggerDiff; //Field offset: 0x18
		private Func<Boolean> extraCondition; //Field offset: 0x20
		private string resultMapName; //Field offset: 0x28
		private int m_HideDiff; //Field offset: 0x30

		public string uid
		{
			 get { } //Length: 5
		}

		public HideBmsInfo(string musicUid, int triggerDiff, int hideDiff, string resultMap, Func<Boolean> extraCondition = null) { }

		public string get_uid() { }

		public string isMatch(ref int diff) { }

	}

	private const int width_size = 18; //Field offset: 0x0
	private const int height_size = 10; //Field offset: 0x0
	public static Action onTriggerHideBmsEvent; //Field offset: 0x0
	private Vector2[] m_PosPoints; //Field offset: 0x10
	private String[] m_OperationInfos; //Field offset: 0x18
	private String[] m_OperationInfosTouchTwo; //Field offset: 0x20
	private Dictionary<String, HideBmsInfo> m_HideBmsInfos; //Field offset: 0x28
	private String[] m_CircleData; //Field offset: 0x30
	private string m_RecordChangedValue; //Field offset: 0x38
	private readonly Dictionary<String, Boolean> m_IsInvokeHideDic; //Field offset: 0x40
	private string m_PrevMusicUid; //Field offset: 0x48
	private String[] m_LongPressHideUids; //Field offset: 0x50
	private String[] m_ToggleChangedHideUids; //Field offset: 0x58
	private String[] m_ClickHideUids; //Field offset: 0x60
	private int m_ClickTglIndex; //Field offset: 0x68
	private int m_DiffTglClickCount; //Field offset: 0x6C
	private DateTime m_GameInTime; //Field offset: 0x70
	private byte m_XInputBuffer; //Field offset: 0x78
	private int m_PrevIndex; //Field offset: 0x7C

	private static SpecialSongManager() { }

	public SpecialSongManager() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_0() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_1() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_10() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_11() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_12() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_13() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_14() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_15() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_16() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_17() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_18() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_19() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_2() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_20() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_21() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_22() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_23() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_24() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_25() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_26() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_27() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_28() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_29() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_3() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_30() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_31() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_32() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_33() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_34() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_35() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_36() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_37() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_38() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_39() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_4() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_40() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_41() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_5() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_6() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_7() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_8() { }

	[CompilerGenerated]
	private bool <InitHideBmsInfoDic>b__34_9() { }

	private int GetScreenQuadrant(ref Vector2 pos) { }

	public string HideBmsCheck(MusicInfo selectedMusic, ref int selectedDifficulty) { }

	private void InitHideBmsInfoDic() { }

	private void InitHideBmsInfoField() { }

	private void InitHideInvoke() { }

	public void InitManager() { }

	private void InitRhythmSpecialStage() { }

	public void InputListener() { }

	public void InvokeHideBms(MusicInfo musicInfo, bool forceSet = false) { }

	public bool IsBarrageBms(string uid) { }

	private bool IsCircleData() { }

	public bool IsInvokeHideBms(string musicUid) { }

	public bool IsSpecialMusic() { }

	private void OnDiffClicked(MusicInfo musicInfo, int tglIndex, bool isOn) { }

	private void OnDifficultyChanged(object sender, object rev, Object[] args) { }

	public void OnDiffToggleClicked(int tglIndex, bool isOn) { }

	public void OnGameEnd(string jsonName) { }

	private void RecordFDInput(Vector2 end, bool isTouchTwo = false) { }

	public void RefreshHideDataTime() { }

	public void ResetHideBmsInputRecord() { }

	private void ResetUserInputInfo() { }

	private void ResetXInput() { }

	public void SetBarrageMode(bool isOn) { }

	private string SetFDOperationInfo(char str, string inputInfos) { }

	private char SetPosTag(int index, Vector2 end) { }

	private void UpdateFDInput() { }

	private void UpdateXInput() { }

	private void XInputCalc(Vector2 pos, bool isPress) { }

}

