using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Common;

[Token(Token = "0x2000980")]
public class PeroServerTime : Singleton<PeroServerTime>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4003404")]
	private DateTime m_ServerUtcTime;

	[Token(Token = "0x4003405")]
	[FieldOffset(Offset = "0x18")]
	private DateTime m_ServerUtcTimeNotForced;

	[Token(Token = "0x4003406")]
	[FieldOffset(Offset = "0x20")]
	private Stopwatch m_Stopwatch;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4003407")]
	private Stopwatch m_StopwatchNotForced;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4003408")]
	private bool m_RequireDownCool;

	[Token(Token = "0x4003409")]
	private const float down_cool_time = 60f;

	[Token(Token = "0x400340A")]
	[FieldOffset(Offset = "0x38")]
	private Coroutine m_LimitCoroutine;

	[Token(Token = "0x400340B")]
	[FieldOffset(Offset = "0x40")]
	private bool m_AcquiredServerTime;

	[Token(Token = "0x400340C")]
	[FieldOffset(Offset = "0x41")]
	private bool m_AcquiredServerTimeForNotForced;

	[Token(Token = "0x400340E")]
	[FieldOffset(Offset = "0x50")]
	private bool m_Requireing;

	[Token(Token = "0x17000907")]
	public bool requireDownCool
	{
		[Token(Token = "0x6005678")]
		[Address(RVA = "0x702490", Offset = "0x700C90", Length = "0x5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000908")]
	public bool acquiredServerTime
	{
		[Address(RVA = "0x47F9B0", Offset = "0x47E1B0", Length = "0x5")]
		[Token(Token = "0x6005679")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000909")]
	public bool acquiredServerTimeForNotForced
	{
		[Address(RVA = "0x5F9A70", Offset = "0x5F8270", Length = "0x5")]
		[Token(Token = "0x600567A")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700090A")]
	public DateTime serverUtcTime
	{
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[Token(Token = "0x600567B")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x1700090B")]
	public DateTime serverUtcTimeNotForced
	{
		[Token(Token = "0x600567C")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x1700090C")]
	public DateTime chinaServerTime
	{
		[Token(Token = "0x600567D")]
		[Address(RVA = "0x7021E0", Offset = "0x7009E0", Length = "0x6C")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x1700090D")]
	public DateTime nowLocalServerTime
	{
		[Address(RVA = "0x702410", Offset = "0x700C10", Length = "0x7A")]
		[Token(Token = "0x600567E")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x1700090E")]
	public DateTime nowLocalServerTimeNotForced
	{
		[Address(RVA = "0x702390", Offset = "0x700B90", Length = "0x7A")]
		[Token(Token = "0x600567F")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x1700090F")]
	public DateTime nowChinaServerTime
	{
		[Address(RVA = "0x7022F0", Offset = "0x700AF0", Length = "0x9C")]
		[Token(Token = "0x6005680")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x17000910")]
	public DateTime nowChinaServerTimeNotForced
	{
		[Token(Token = "0x6005681")]
		[Address(RVA = "0x702250", Offset = "0x700A50", Length = "0x9C")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x1400009F")]
	public event Action<DateTime> onGetServerTime
	{
		[Address(RVA = "0x702140", Offset = "0x700940", Length = "0x9E")]
		[Token(Token = "0x6005682")]
		[CompilerGenerated]
		add
		{
		}
		[Address(RVA = "0x7024A0", Offset = "0x700CA0", Length = "0x9E")]
		[Token(Token = "0x6005683")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6005684")]
	[Address(RVA = "0x701BD0", Offset = "0x7003D0", Length = "0x5D")]
	private void Init()
	{
	}

	[Token(Token = "0x6005685")]
	[Address(RVA = "0x701BB0", Offset = "0x7003B0", Length = "0x11")]
	public void GetServerTime(Action<DateTime> callback, Action<long, string> failCallback, bool force = false)
	{
	}

	[Token(Token = "0x6005686")]
	[Address(RVA = "0x701FB0", Offset = "0x7007B0", Length = "0x30")]
	public void ResetToLocal()
	{
	}

	[Token(Token = "0x6005687")]
	[Address(RVA = "0x701C30", Offset = "0x700430", Length = "0x37A")]
	private void RequireTime(Action<DateTime> complete = null, Action<long, string> failCallback = null)
	{
	}

	[Token(Token = "0x6005688")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void AddConsoleTest()
	{
	}

	[Address(RVA = "0x701FE0", Offset = "0x7007E0", Length = "0x155")]
	[Token(Token = "0x6005689")]
	public PeroServerTime()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
