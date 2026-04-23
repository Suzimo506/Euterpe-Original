using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using FormulaBase;

namespace GameLogic;

[Token(Token = "0x20004A9")]
public class GameTouchPlay
{
	[Token(Token = "0x4001933")]
	public static bool isTouchLeftRight;

	[Token(Token = "0x4001934")]
	public static bool isReverse;

	[Token(Token = "0x4001935")]
	public static bool isTouchReverse;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001936")]
	public bool isPunchBegan;

	[Token(Token = "0x4001937")]
	[FieldOffset(Offset = "0x11")]
	public bool isJumpBegan;

	[Token(Token = "0x4001938")]
	[FieldOffset(Offset = "0x12")]
	public bool isPunchStay;

	[Token(Token = "0x4001939")]
	[FieldOffset(Offset = "0x13")]
	public bool isJumpStay;

	[Token(Token = "0x400193A")]
	[FieldOffset(Offset = "0x14")]
	public bool isPunchEnded;

	[FieldOffset(Offset = "0x15")]
	[Token(Token = "0x400193B")]
	public bool isJumpEnded;

	[Token(Token = "0x400193C")]
	[FieldOffset(Offset = "0x16")]
	public bool isPunch;

	[Token(Token = "0x400193D")]
	[FieldOffset(Offset = "0x18")]
	private List<int> m_AirPressIndex;

	[Token(Token = "0x400193E")]
	[FieldOffset(Offset = "0x20")]
	private List<int> m_RoadPressIndex;

	[Token(Token = "0x400193F")]
	[FieldOffset(Offset = "0x28")]
	private List<int> m_AirKeyIndex;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001940")]
	private List<int> m_RoadKeyIndex;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001941")]
	private List<int> m_AllKeyPressedList;

	[Token(Token = "0x4001942")]
	[FieldOffset(Offset = "0x40")]
	public int widthMid;

	[Token(Token = "0x4001943")]
	[FieldOffset(Offset = "0x44")]
	public int heightMid;

	[Token(Token = "0x4001944")]
	[FieldOffset(Offset = "0x48")]
	private readonly decimal m_PressHardTime;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001945")]
	private decimal m_PunchHardTime;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001946")]
	private decimal m_JumpHardTime;

	[Token(Token = "0x4001949")]
	[FieldOffset(Offset = "0x80")]
	private Dictionary<int, int> m_CurFingerIds;

	[Token(Token = "0x170004CD")]
	public bool isReactAir
	{
		[Address(RVA = "0x8A0EA0", Offset = "0x89F6A0", Length = "0x5")]
		[Token(Token = "0x600351B")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x600351A")]
		[Address(RVA = "0x90A300", Offset = "0x908B00", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x170004CE")]
	public bool isReactGround
	{
		[Address(RVA = "0x8A0EB0", Offset = "0x89F6B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600351D")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x600351C")]
		[Address(RVA = "0x90A310", Offset = "0x908B10", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x6003500")]
	[Address(RVA = "0x9051B0", Offset = "0x9039B0", Length = "0x7D")]
	public void AddPressKey(bool isAir, int keyIndex)
	{
	}

	[Token(Token = "0x6003501")]
	[Address(RVA = "0x904D70", Offset = "0x903570", Length = "0x431")]
	public void AddPressKeyRange(List<int> keys, bool isAir, ref float pressTick)
	{
	}

	[Token(Token = "0x6003502")]
	[Address(RVA = "0x907590", Offset = "0x905D90", Length = "0x69")]
	public void RemovePressKey(bool isAir, int keyIndex)
	{
	}

	[Token(Token = "0x6003503")]
	[Address(RVA = "0x905570", Offset = "0x903D70", Length = "0x69")]
	public bool ContainsPressKey(bool isAir, int keyIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6003504")]
	[Address(RVA = "0x9055E0", Offset = "0x903DE0", Length = "0x78")]
	public bool ContainsPressKey(int keyIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6003505")]
	[Address(RVA = "0x907530", Offset = "0x905D30", Length = "0x52")]
	public int PressKeyCount(bool isAir)
	{
		return default(int);
	}

	[Token(Token = "0x6003506")]
	[Address(RVA = "0x9059D0", Offset = "0x9041D0", Length = "0x7B")]
	public int GetLastPressKey(bool isAir)
	{
		return default(int);
	}

	[Token(Token = "0x6003507")]
	[Address(RVA = "0x9057E0", Offset = "0x903FE0", Length = "0x1ED")]
	public int GetLastPressKeyExceptList(bool isAir, Dictionary<int, int> excepts)
	{
		return default(int);
	}

	[Token(Token = "0x6003508")]
	[Address(RVA = "0x905510", Offset = "0x903D10", Length = "0x5A")]
	public void ClearPressKey(bool isAir)
	{
	}

	[Address(RVA = "0x905410", Offset = "0x903C10", Length = "0xF7")]
	[Token(Token = "0x6003509")]
	public void ClearPressKey(int idx)
	{
	}

	[Token(Token = "0x600350A")]
	[Address(RVA = "0x905F50", Offset = "0x904750", Length = "0x22B")]
	public bool LongNoteCheck(bool isAir, int headIdx)
	{
		return default(bool);
	}

	[Token(Token = "0x600350B")]
	[Address(RVA = "0x905230", Offset = "0x903A30", Length = "0x82")]
	public void AddPress(bool isAir, int pressHeadIdx)
	{
	}

	[Address(RVA = "0x907600", Offset = "0x905E00", Length = "0x1C9")]
	[Token(Token = "0x600350C")]
	public void RemovePress(bool isAir, int pressHeadIdx)
	{
	}

	[Address(RVA = "0x9074D0", Offset = "0x905CD0", Length = "0x52")]
	[Token(Token = "0x600350D")]
	public int PressCount(bool isAir)
	{
		return default(int);
	}

	[Token(Token = "0x600350E")]
	[Address(RVA = "0x905760", Offset = "0x903F60", Length = "0xE")]
	public List<int> GetCurLpsIndexs(bool isAir)
	{
		return null;
	}

	[Address(RVA = "0x905770", Offset = "0x903F70", Length = "0x6D")]
	[Token(Token = "0x600350F")]
	public int GetFirstPress(bool isAir)
	{
		return default(int);
	}

	[Address(RVA = "0x905A50", Offset = "0x904250", Length = "0x7B")]
	[Token(Token = "0x6003510")]
	public int GetLastPress(bool isAir)
	{
		return default(int);
	}

	[Token(Token = "0x6003511")]
	[Address(RVA = "0x905AD0", Offset = "0x9042D0", Length = "0x416")]
	public void Init()
	{
	}

	[Token(Token = "0x6003512")]
	[Address(RVA = "0x907CC0", Offset = "0x9064C0", Length = "0x1E9")]
	public void TimeStep()
	{
	}

	[Address(RVA = "0x907EB0", Offset = "0x9066B0", Length = "0x1BE")]
	[Token(Token = "0x6003513")]
	public void TimeUpdateStep()
	{
	}

	[Address(RVA = "0x9077D0", Offset = "0x905FD0", Length = "0xE")]
	[Token(Token = "0x6003514")]
	public void Reset()
	{
	}

	[Address(RVA = "0x909F90", Offset = "0x908790", Length = "0x224")]
	[Token(Token = "0x6003515")]
	public void TouchTrigger(uint touchId)
	{
	}

	[Token(Token = "0x6003516")]
	[Address(RVA = "0x906180", Offset = "0x904980", Length = "0x1D")]
	public void MissHardTime()
	{
	}

	[Token(Token = "0x6003517")]
	[Address(RVA = "0x905660", Offset = "0x903E60", Length = "0xFD")]
	public void DisMissHardTime()
	{
	}

	[Address(RVA = "0x9052C0", Offset = "0x903AC0", Length = "0x148")]
	[Token(Token = "0x6003518")]
	public void BeginTouchPhaser()
	{
	}

	[Token(Token = "0x6003519")]
	[Address(RVA = "0x9061A0", Offset = "0x9049A0", Length = "0x9A9")]
	public void MoveTouchPhaser()
	{
	}

	[Address(RVA = "0x908070", Offset = "0x906870", Length = "0xB4B")]
	[Token(Token = "0x600351E")]
	public void TouchActionResult(uint actionType)
	{
	}

	[Token(Token = "0x600351F")]
	[Address(RVA = "0x908BC0", Offset = "0x9073C0", Length = "0x13C1")]
	public void TouchResult(int idx, byte resultCode, uint actionType, TimeNodeOrder tno = null, bool isSkill = false, bool isElfinSkill = false)
	{
	}

	[Token(Token = "0x6003520")]
	[Address(RVA = "0x905EF0", Offset = "0x9046F0", Length = "0x5B")]
	public bool IsPlayEmpty(int idx)
	{
		return default(bool);
	}

	[Address(RVA = "0x907AD0", Offset = "0x9062D0", Length = "0x1E0")]
	[Token(Token = "0x6003521")]
	private void ShowPlayResult(int idx, uint actionType, uint resultCode)
	{
	}

	[Token(Token = "0x6003522")]
	[Address(RVA = "0x906F60", Offset = "0x905760", Length = "0x56B")]
	private void PlayComboPhaser(MusicData md, uint resultCode, bool isDouble = false, bool isSkill = false)
	{
	}

	[Token(Token = "0x6003523")]
	[Address(RVA = "0x9077E0", Offset = "0x905FE0", Length = "0x2EB")]
	public void RhythmDoctorSkill(int addCombo, MusicData md)
	{
	}

	[Token(Token = "0x6003524")]
	[Address(RVA = "0x906B50", Offset = "0x905350", Length = "0x400")]
	public void OnRhythmDoctorSkill(MusicData md)
	{
	}

	[Token(Token = "0x6003525")]
	[Address(RVA = "0x90A200", Offset = "0x908A00", Length = "0xF2")]
	public GameTouchPlay()
	{
	}
}
