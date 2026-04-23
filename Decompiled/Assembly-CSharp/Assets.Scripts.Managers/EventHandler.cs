using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.Managers;

[Token(Token = "0x2000970")]
public class EventHandler : AbstractEventHandler
{
	[Token(Token = "0x1400009B")]
	public event TriggerHandler trigger
	{
		[Address(RVA = "0x924B50", Offset = "0x923350", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6005625")]
		add
		{
		}
		[Token(Token = "0x6005626")]
		[CompilerGenerated]
		[Address(RVA = "0x924BF0", Offset = "0x9233F0", Length = "0x9E")]
		remove
		{
		}
	}

	[Address(RVA = "0x494AC0", Offset = "0x4932C0", Length = "0x30")]
	[Token(Token = "0x6005623")]
	public EventHandler(string uid)
	{
	}

	[Address(RVA = "0x924A90", Offset = "0x923290", Length = "0x90")]
	[Token(Token = "0x6005624")]
	public void GetDelegate()
	{
	}

	[Address(RVA = "0x924A40", Offset = "0x923240", Length = "0x12")]
	[Token(Token = "0x6005627")]
	public override void ClearEvent()
	{
	}

	[Address(RVA = "0x924B30", Offset = "0x923330", Length = "0x11")]
	[Token(Token = "0x6005628")]
	internal void Play()
	{
	}

	[Token(Token = "0x6005629")]
	[Address(RVA = "0x924B30", Offset = "0x923330", Length = "0x11")]
	internal override void Play(object[] args = null)
	{
	}

	[Token(Token = "0x600562A")]
	[Address(RVA = "0x924A60", Offset = "0x923260", Length = "0x25")]
	internal EventHandler Clear()
	{
		return null;
	}
}
[Token(Token = "0x2000971")]
public class EventHandler<T> : AbstractEventHandler
{
	[Token(Token = "0x1400009C")]
	public event TriggerHandler<T> trigger
	{
		[CompilerGenerated]
		[Token(Token = "0x600562B")]
		[Address(RVA = "0x135C3C0", Offset = "0x135ABC0", Length = "0xBC")]
		add
		{
		}
		[Address(RVA = "0x135C480", Offset = "0x135AC80", Length = "0xBC")]
		[Token(Token = "0x600562C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600562D")]
	[Address(RVA = "0x135C380", Offset = "0x135AB80", Length = "0x3A")]
	public EventHandler(string uid)
	{
	}

	[Token(Token = "0x600562E")]
	[Address(RVA = "0x135C360", Offset = "0x135AB60", Length = "0x1F")]
	internal void Play(T arg1)
	{
	}

	[Token(Token = "0x600562F")]
	[Address(RVA = "0x924A40", Offset = "0x923240", Length = "0x12")]
	public override void ClearEvent()
	{
	}

	[Address(RVA = "0x135C180", Offset = "0x135A980", Length = "0x1DF")]
	[Token(Token = "0x6005630")]
	internal override void Play(object[] args = null)
	{
	}

	[Address(RVA = "0x924A60", Offset = "0x923260", Length = "0x25")]
	[Token(Token = "0x6005631")]
	internal EventHandler<T> Clear()
	{
		return null;
	}
}
[Token(Token = "0x2000972")]
public class EventHandler<T, T2> : AbstractEventHandler
{
	[Token(Token = "0x1400009D")]
	public event TriggerHandler<T, T2> trigger
	{
		[Token(Token = "0x6005634")]
		[CompilerGenerated]
		[Address(RVA = "0x135C3C0", Offset = "0x135ABC0", Length = "0xBC")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6005635")]
		[Address(RVA = "0x135C480", Offset = "0x135AC80", Length = "0xBC")]
		remove
		{
		}
	}

	[Address(RVA = "0x135C380", Offset = "0x135AB80", Length = "0x3A")]
	[Token(Token = "0x6005632")]
	public EventHandler(string uid)
	{
	}

	[Address(RVA = "0x924A40", Offset = "0x923240", Length = "0x12")]
	[Token(Token = "0x6005633")]
	public override void ClearEvent()
	{
	}

	[Address(RVA = "0x135C540", Offset = "0x135AD40", Length = "0x1F")]
	[Token(Token = "0x6005636")]
	internal void Play(T arg1, T2 arg2)
	{
	}

	[Token(Token = "0x6005637")]
	[Address(RVA = "0x135C560", Offset = "0x135AD60", Length = "0x2A9")]
	internal override void Play(object[] args = null)
	{
	}

	[Token(Token = "0x6005638")]
	[Address(RVA = "0x924A60", Offset = "0x923260", Length = "0x25")]
	internal EventHandler<T, T2> Clear()
	{
		return null;
	}
}
[Token(Token = "0x2000973")]
public class EventHandler<T, T2, T3> : AbstractEventHandler
{
	[Token(Token = "0x1400009E")]
	public event TriggerHandler<T, T2, T3> trigger
	{
		[CompilerGenerated]
		[Address(RVA = "0x135C3C0", Offset = "0x135ABC0", Length = "0xBC")]
		[Token(Token = "0x600563B")]
		add
		{
		}
		[Address(RVA = "0x135C480", Offset = "0x135AC80", Length = "0xBC")]
		[Token(Token = "0x600563C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6005639")]
	[Address(RVA = "0x135C380", Offset = "0x135AB80", Length = "0x3A")]
	public EventHandler(string uid)
	{
	}

	[Token(Token = "0x600563A")]
	[Address(RVA = "0x924A40", Offset = "0x923240", Length = "0x12")]
	public override void ClearEvent()
	{
	}

	[Address(RVA = "0x135C810", Offset = "0x135B010", Length = "0x26")]
	[Token(Token = "0x600563D")]
	internal void Play(T arg1, T2 arg2, T3 arg3)
	{
	}

	[Token(Token = "0x600563E")]
	[Address(RVA = "0x135C840", Offset = "0x135B040", Length = "0x372")]
	internal override void Play(object[] args = null)
	{
	}

	[Token(Token = "0x600563F")]
	[Address(RVA = "0x924A60", Offset = "0x923260", Length = "0x25")]
	internal EventHandler<T, T2, T3> Clear()
	{
		return null;
	}
}
