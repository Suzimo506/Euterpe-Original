using System;
using System.Collections.Generic;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Managers;

[Token(Token = "0x2000652")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x2060", Offset = "0x1460")]
public class TimerManager : Singleton<TimerManager>
{
	[Token(Token = "0x400238F")]
	[FieldOffset(Offset = "0x10")]
	private readonly List<Timer> m_FixedTimers;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002390")]
	private readonly List<Timer> m_UpdateTimers;

	[Token(Token = "0x170005B0")]
	public Timer Item
	{
		[Address(RVA = "0x764180", Offset = "0x762980", Length = "0xF6")]
		[Token(Token = "0x6003CDE")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003CDF")]
	[Address(RVA = "0x763A80", Offset = "0x762280", Length = "0x11E")]
	private void Init()
	{
	}

	[Address(RVA = "0x763810", Offset = "0x762010", Length = "0x26B")]
	[Token(Token = "0x6003CE0")]
	public Timer Delay(Action callFunc, float dt)
	{
		return null;
	}

	[Token(Token = "0x6003CE1")]
	[Address(RVA = "0x763CB0", Offset = "0x7624B0", Length = "0x129")]
	public void Pause()
	{
	}

	[Address(RVA = "0x763E50", Offset = "0x762650", Length = "0x129")]
	[Token(Token = "0x6003CE2")]
	public void Resume()
	{
	}

	[Address(RVA = "0x763BA0", Offset = "0x7623A0", Length = "0x10C")]
	[Token(Token = "0x6003CE3")]
	public void Kill()
	{
	}

	[Address(RVA = "0x7637A0", Offset = "0x761FA0", Length = "0x6A")]
	[Token(Token = "0x6003CE4")]
	public void AddTimer(Timer timer)
	{
	}

	[Address(RVA = "0x763DE0", Offset = "0x7625E0", Length = "0x6A")]
	[Token(Token = "0x6003CE5")]
	public void RemoveTimer(Timer timer)
	{
	}

	[Token(Token = "0x6003CE6")]
	[Address(RVA = "0x7640E0", Offset = "0x7628E0", Length = "0x9B")]
	public TimerManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
