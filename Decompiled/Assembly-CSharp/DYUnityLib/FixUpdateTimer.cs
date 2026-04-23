using System.Collections.Generic;
using Cpp2ILInjected;

namespace DYUnityLib;

[Token(Token = "0x20004E7")]
public class FixUpdateTimer
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001A72")]
	private int m_Index;

	[Token(Token = "0x4001A73")]
	private static bool _isPausing;

	[Token(Token = "0x4001A74")]
	public static List<FixUpdateTimer> timers;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001A75")]
	private uint[][] m_OldIdx;

	[Token(Token = "0x4001A76")]
	[FieldOffset(Offset = "0x20")]
	private int[] m_Ticks;

	[Token(Token = "0x4001A77")]
	public const int TIMER_TYPE_EVENT_ARRAY = 0;

	[Token(Token = "0x4001A78")]
	public const int TIMER_TYPE_STEP_ARRAY = 1;

	[Token(Token = "0x4001A79")]
	[FieldOffset(Offset = "0x28")]
	private int iType;

	[Token(Token = "0x4001A7A")]
	private const int precision = 100;

	[Token(Token = "0x4001A7B")]
	[Attribute(Name = "DecimalConstantAttribute", RVA = "0x64300", Offset = "0x63700")]
	public static readonly decimal dInterval;

	[Token(Token = "0x4001A7C")]
	public const float fInterval = 0.01f;

	[Token(Token = "0x4001A7D")]
	[FieldOffset(Offset = "0x2C")]
	private int passedTick;

	[Token(Token = "0x4001A7E")]
	[FieldOffset(Offset = "0x30")]
	private int prePassedTick;

	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001A7F")]
	private int passedCount;

	[Token(Token = "0x4001A80")]
	[FieldOffset(Offset = "0x38")]
	private int totalTick;

	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001A81")]
	private uint defaultEvent;

	[Token(Token = "0x4001A82")]
	[FieldOffset(Offset = "0x40")]
	private bool isPause;

	[Token(Token = "0x4001A83")]
	[FieldOffset(Offset = "0x44")]
	private int m_curPassedTick;

	[Token(Token = "0x4001A84")]
	[FieldOffset(Offset = "0x48")]
	private uint[][] events;

	[Address(RVA = "0x4714C0", Offset = "0x46FCC0", Length = "0xCD")]
	[Token(Token = "0x6003644")]
	public static void RollTimer()
	{
	}

	[Token(Token = "0x6003645")]
	[Address(RVA = "0x4712A0", Offset = "0x46FAA0", Length = "0xF6")]
	public static void PauseTimer()
	{
	}

	[Token(Token = "0x6003646")]
	[Address(RVA = "0x4713B0", Offset = "0x46FBB0", Length = "0xF6")]
	public static void ResumeTimer()
	{
	}

	[Address(RVA = "0x470FF0", Offset = "0x46F7F0", Length = "0x56")]
	[Token(Token = "0x6003647")]
	public static bool IsPausing()
	{
		return default(bool);
	}

	[Address(RVA = "0x470E60", Offset = "0x46F660", Length = "0x181")]
	[Token(Token = "0x6003648")]
	public void Init(decimal _totalTick, int index, int timerType = 0)
	{
	}

	[Token(Token = "0x6003649")]
	[Address(RVA = "0x471590", Offset = "0x46FD90", Length = "0x11")]
	public void Run()
	{
	}

	[Token(Token = "0x600364A")]
	[Address(RVA = "0x471050", Offset = "0x46F850", Length = "0x8")]
	public bool IsRunning()
	{
		return default(bool);
	}

	[Token(Token = "0x600364B")]
	[Address(RVA = "0x470C40", Offset = "0x46F440", Length = "0xD4")]
	public void Cancel()
	{
	}

	[Token(Token = "0x600364C")]
	[Address(RVA = "0x4713A0", Offset = "0x46FBA0", Length = "0x5")]
	public void Pause()
	{
	}

	[Token(Token = "0x600364D")]
	[Address(RVA = "0x4714B0", Offset = "0x46FCB0", Length = "0x5")]
	public void Resume()
	{
	}

	[Token(Token = "0x600364E")]
	[Address(RVA = "0x4709B0", Offset = "0x46F1B0", Length = "0x28F")]
	public void AddTickEvent(decimal tick, uint eventIndex)
	{
	}

	[Token(Token = "0x600364F")]
	[Address(RVA = "0x470D20", Offset = "0x46F520", Length = "0x4D")]
	public void ClearTickEvent()
	{
	}

	[Address(RVA = "0x470D70", Offset = "0x46F570", Length = "0xE2")]
	[Token(Token = "0x6003650")]
	public decimal GetPassTick()
	{
		return default(decimal);
	}

	[Address(RVA = "0x4715C0", Offset = "0x46FDC0", Length = "0x303")]
	[Token(Token = "0x6003651")]
	private void __OnTickEventArray()
	{
	}

	[Address(RVA = "0x4718D0", Offset = "0x4700D0", Length = "0x166")]
	[Token(Token = "0x6003652")]
	private void __OnTickStepArray()
	{
	}

	[Token(Token = "0x6003653")]
	[Address(RVA = "0x471060", Offset = "0x46F860", Length = "0x230")]
	private void OnTick()
	{
	}

	[Address(RVA = "0x4715B0", Offset = "0x46FDB0", Length = "0xA")]
	[Token(Token = "0x6003654")]
	private void SetPassTick(int tick)
	{
	}

	[Address(RVA = "0x471B00", Offset = "0x470300", Length = "0x7A")]
	[Token(Token = "0x6003655")]
	public FixUpdateTimer()
	{
	}
}
