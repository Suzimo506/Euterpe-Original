namespace GameLogic;

public struct MusicData
{
	public short objId; //Field offset: 0x0
	public decimal tick; //Field offset: 0x4
	public MusicConfigData configData; //Field offset: 0x18
	public NoteConfigData noteData; //Field offset: 0x50
	public bool isLongPressing; //Field offset: 0x110
	public int doubleIdx; //Field offset: 0x114
	public bool isDouble; //Field offset: 0x118
	public bool isLongPressEnd; //Field offset: 0x119
	public decimal longPressPTick; //Field offset: 0x11C
	public int endIndex; //Field offset: 0x12C
	public decimal dt; //Field offset: 0x130
	public int longPressNum; //Field offset: 0x140
	public decimal showTick; //Field offset: 0x144

	public bool isAir
	{
		 get { } //Length: 11
	}

	public bool IsBossNearAttack
	{
		 get { } //Length: 51
	}

	public bool isBossNote
	{
		 get { } //Length: 28
	}

	public bool IsDouble
	{
		 get { } //Length: 23
	}

	public bool isLongPressStart
	{
		 get { } //Length: 161
	}

	public bool isLongPressType
	{
		 get { } //Length: 49
	}

	public bool isMul
	{
		 get { } //Length: 161
	}

	public int longPressCount
	{
		 get { } //Length: 248
	}

	public decimal missTick
	{
		 get { } //Length: 372
	}

	public bool get_isAir() { }

	public bool get_IsBossNearAttack() { }

	public bool get_isBossNote() { }

	public bool get_IsDouble() { }

	public bool get_isLongPressStart() { }

	public bool get_isLongPressType() { }

	public bool get_isMul() { }

	public int get_longPressCount() { }

	public decimal get_missTick() { }

	public int GetMulHitHighThreshold() { }

	public int GetMulHitLowThreshold() { }

	public int GetMulHitMidThreshold() { }

	public virtual string ToString() { }

}

