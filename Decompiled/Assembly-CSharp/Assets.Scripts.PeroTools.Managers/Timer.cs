using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Managers;

[Token(Token = "0x2000653")]
public class Timer
{
	[Token(Token = "0x4002391")]
	public const float infinite = float.MaxValue;

	[Token(Token = "0x4002392")]
	[FieldOffset(Offset = "0x10")]
	public UnityGameManager.LoopType type;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4002393")]
	public bool isPause;

	[Token(Token = "0x4002398")]
	[FieldOffset(Offset = "0x38")]
	private int m_PrePassTick;

	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4002399")]
	private readonly float m_Radio;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400239A")]
	private readonly Dictionary<int, Action<int>> m_Events;

	[Token(Token = "0x400239B")]
	[FieldOffset(Offset = "0x48")]
	private readonly List<Action<int>> m_Steps;

	[Token(Token = "0x170005B1")]
	public static float fixedInterval
	{
		[Token(Token = "0x6003CE9")]
		[Address(RVA = "0x764AE0", Offset = "0x7632E0", Length = "0x7")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005B2")]
	public static float updateInterval
	{
		[Token(Token = "0x6003CEA")]
		[Address(RVA = "0x764C70", Offset = "0x763470", Length = "0x7")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005B3")]
	public float interval
	{
		[CompilerGenerated]
		[Token(Token = "0x6003CEC")]
		[Address(RVA = "0x764AF0", Offset = "0x7632F0", Length = "0x6")]
		get
		{
			return default(float);
		}
		[Address(RVA = "0x764C80", Offset = "0x763480", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6003CEB")]
		private set
		{
		}
	}

	[Token(Token = "0x170005B4")]
	public static int length
	{
		[Token(Token = "0x6003CED")]
		[Address(RVA = "0x764B00", Offset = "0x763300", Length = "0xDD")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170005B5")]
	public string uid
	{
		[CompilerGenerated]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		[Token(Token = "0x6003CEF")]
		get
		{
			return null;
		}
		[Address(RVA = "0x483E40", Offset = "0x482640", Length = "0xC")]
		[Token(Token = "0x6003CEE")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170005B6")]
	public float totalTime
	{
		[Address(RVA = "0x73BB00", Offset = "0x73A300", Length = "0x6")]
		[Token(Token = "0x6003CF1")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Address(RVA = "0x764C90", Offset = "0x763490", Length = "0x6")]
		[Token(Token = "0x6003CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170005B7")]
	public float passedTime
	{
		[Address(RVA = "0x764C20", Offset = "0x763420", Length = "0x41")]
		[Token(Token = "0x6003CF2")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170005B8")]
	public int passedTick
	{
		[Address(RVA = "0x764BE0", Offset = "0x7633E0", Length = "0x35")]
		[Token(Token = "0x6003CF3")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170005B9")]
	public Stopwatch stopWatch
	{
		[Token(Token = "0x6003CF5")]
		[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6003CF4")]
		[CompilerGenerated]
		[Address(RVA = "0x45EF10", Offset = "0x45D710", Length = "0xC")]
		private set
		{
		}
	}

	[Token(Token = "0x6003CF6")]
	[Address(RVA = "0x764950", Offset = "0x763150", Length = "0x18A")]
	public Timer(string u, UnityGameManager.LoopType t = UnityGameManager.LoopType.FixedUpdate, float time = float.MaxValue)
	{
	}

	[Token(Token = "0x6003CF7")]
	[Address(RVA = "0x764280", Offset = "0x762A80", Length = "0x102")]
	public void AddTickEvent(Action<int> action, float time = -1f)
	{
	}

	[Token(Token = "0x6003CF8")]
	[Address(RVA = "0x7644B0", Offset = "0x762CB0", Length = "0x155")]
	public void RemoveTickEvent(Action<int> action)
	{
	}

	[Token(Token = "0x6003CF9")]
	[Address(RVA = "0x764470", Offset = "0x762C70", Length = "0x37")]
	public void Play()
	{
	}

	[Token(Token = "0x6003CFA")]
	[Address(RVA = "0x764440", Offset = "0x762C40", Length = "0x21")]
	public void Pause()
	{
	}

	[Address(RVA = "0x764610", Offset = "0x762E10", Length = "0x21")]
	[Token(Token = "0x6003CFB")]
	public void Resume()
	{
	}

	[Token(Token = "0x6003CFC")]
	[Address(RVA = "0x764390", Offset = "0x762B90", Length = "0xA6")]
	public void Kill()
	{
	}

	[Token(Token = "0x6003CFD")]
	[Address(RVA = "0x7647B0", Offset = "0x762FB0", Length = "0x19E")]
	public void Tick()
	{
	}

	[Token(Token = "0x6003CFE")]
	[Address(RVA = "0x764700", Offset = "0x762F00", Length = "0xA8")]
	private void TickStep(int curTick)
	{
	}

	[Token(Token = "0x6003CFF")]
	[Address(RVA = "0x764640", Offset = "0x762E40", Length = "0xB4")]
	private void TickEvent(int curTick)
	{
	}
}
