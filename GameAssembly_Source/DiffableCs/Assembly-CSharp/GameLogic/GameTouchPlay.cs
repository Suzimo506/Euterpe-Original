namespace GameLogic;

public class GameTouchPlay
{
	public static bool isTouchLeftRight; //Field offset: 0x0
	public static bool isReverse; //Field offset: 0x1
	public static bool isTouchReverse; //Field offset: 0x2
	public bool isPunchBegan; //Field offset: 0x10
	public bool isJumpBegan; //Field offset: 0x11
	public bool isPunchStay; //Field offset: 0x12
	public bool isJumpStay; //Field offset: 0x13
	public bool isPunchEnded; //Field offset: 0x14
	public bool isJumpEnded; //Field offset: 0x15
	public bool isPunch; //Field offset: 0x16
	private List<Int32> m_AirPressIndex; //Field offset: 0x18
	private List<Int32> m_RoadPressIndex; //Field offset: 0x20
	private List<Int32> m_AirKeyIndex; //Field offset: 0x28
	private List<Int32> m_RoadKeyIndex; //Field offset: 0x30
	public int widthMid; //Field offset: 0x38
	public int heightMid; //Field offset: 0x3C
	private readonly decimal m_PressHardTime; //Field offset: 0x40
	private decimal m_PunchHardTime; //Field offset: 0x50
	private decimal m_JumpHardTime; //Field offset: 0x60
	[CompilerGenerated]
	private bool <isReactAir>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private bool <isReactGround>k__BackingField; //Field offset: 0x71

	public private bool isReactAir
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool isReactGround
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private static GameTouchPlay() { }

	public GameTouchPlay() { }

	public void AddPress(bool isAir, int pressHeadIdx) { }

	public void AddPressKey(bool isAir, int keyIndex) { }

	public void AddPressKeyRange(List<Int32> keys, bool isAir, ref float pressTick) { }

	public void BeginTouchPhaser() { }

	public void ClearPressKey(bool isAir) { }

	public bool ContainsPressKey(bool isAir, int keyIndex) { }

	public void DisMissHardTime() { }

	[CompilerGenerated]
	public bool get_isReactAir() { }

	[CompilerGenerated]
	public bool get_isReactGround() { }

	public List<Int32> GetCurLpsIndexs(bool isAir) { }

	public int GetFirstPress(bool isAir) { }

	public int GetLastPress(bool isAir) { }

	public int GetLastPressKey(bool isAir) { }

	public void Init() { }

	public bool IsPlayEmpty(int idx) { }

	public bool LongNoteCheck(bool isAir, int headIdx) { }

	public void MissHardTime() { }

	public void MoveTouchPhaser() { }

	public void OnRhythmDoctorSkill(MusicData md) { }

	private void PlayComboPhaser(MusicData md, uint resultCode, bool isDouble = false) { }

	public int PressCount(bool isAir) { }

	public int PressKeyCount(bool isAir) { }

	public void RemovePress(bool isAir, int pressHeadIdx) { }

	public void RemovePressKey(bool isAir, int keyIndex) { }

	public void RemovePressKeyLast(bool isAir) { }

	public void Reset() { }

	public void RhythmDoctorSkill(int addCombo, MusicData md) { }

	[CompilerGenerated]
	private void set_isReactAir(bool value) { }

	[CompilerGenerated]
	private void set_isReactGround(bool value) { }

	private void ShowPlayResult(int idx, uint actionType, uint resultCode) { }

	public void TimeStep() { }

	public void TimeUpdateStep() { }

	public void TouchActionResult(uint actionType) { }

	public void TouchResult(int idx, byte resultCode, uint actionType, TimeNodeOrder tno = null, bool isSkill = false) { }

	public void TouchTrigger(uint touchId) { }

}

