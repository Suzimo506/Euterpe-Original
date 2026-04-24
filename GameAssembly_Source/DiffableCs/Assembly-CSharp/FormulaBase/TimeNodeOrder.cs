namespace FormulaBase;

public class TimeNodeOrder : IComparable<TimeNodeOrder>
{
	internal enum MusicDataType
	{
		Pressing = 0,
		Double = 1,
		Mul = 2,
		Normal = 3,
	}

	public short idx; //Field offset: 0x10
	public byte result; //Field offset: 0x12
	public bool enableJump; //Field offset: 0x13
	public bool isPerfectNode; //Field offset: 0x14
	public bool isLongPressStart; //Field offset: 0x15
	public bool isLongPressEnd; //Field offset: 0x16
	public bool isLongPressing; //Field offset: 0x17
	public bool isMulStart; //Field offset: 0x18
	public bool isMuling; //Field offset: 0x19
	public bool isAir; //Field offset: 0x1A
	public bool isFucked; //Field offset: 0x1B
	public bool isLast; //Field offset: 0x1C
	public bool isFirst; //Field offset: 0x1D
	public bool isRight; //Field offset: 0x1E
	public MusicData md; //Field offset: 0x20

	public bool isLongPressType
	{
		 get { } //Length: 20
	}

	public bool isMulType
	{
		 get { } //Length: 13
	}

	public TimeNodeOrder() { }

	public TimeNodeOrder(TimeNodeOrder tno) { }

	public override int CompareTo(TimeNodeOrder other) { }

	public static void CopyTimeNodeOrder(TimeNodeOrder tno, MusicData md, MusicDataType type, int curValue, int maxRange, bool isLeft) { }

	public virtual bool Equals(object obj) { }

	public bool get_isLongPressType() { }

	public bool get_isMulType() { }

	public virtual string ToString() { }

}

