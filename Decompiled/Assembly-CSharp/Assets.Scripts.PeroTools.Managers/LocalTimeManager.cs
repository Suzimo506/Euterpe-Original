using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Managers;

[Token(Token = "0x200064F")]
public class LocalTimeManager : Singleton<LocalTimeManager>
{
	[Token(Token = "0x4002383")]
	[FieldOffset(Offset = "0x10")]
	private bool m_UseTestTimePeriod;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002385")]
	private TimePeriod m_CurTimePeroid;

	[Token(Token = "0x170005A9")]
	public TimePeriod curTimePeriod
	{
		[Address(RVA = "0x42D1E0", Offset = "0x42B9E0", Length = "0x4")]
		[Token(Token = "0x6003CBD")]
		get
		{
			return default(TimePeriod);
		}
		[Token(Token = "0x6003CBE")]
		[Address(RVA = "0x42D200", Offset = "0x42BA00", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x1400005C")]
	public event Action<TimePeriod> onTimePeriodChange
	{
		[Address(RVA = "0x75F4B0", Offset = "0x75DCB0", Length = "0x9E")]
		[Token(Token = "0x6003CBB")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6003CBC")]
		[Address(RVA = "0x75F550", Offset = "0x75DD50", Length = "0x9E")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6003CBF")]
	[Address(RVA = "0x75F3E0", Offset = "0x75DBE0", Length = "0xC0")]
	public LocalTimeManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}

	[Token(Token = "0x6003CC0")]
	[Address(RVA = "0x75F320", Offset = "0x75DB20", Length = "0xBF")]
	private void RefreshCurTimePeriod(float runTime)
	{
	}
}
