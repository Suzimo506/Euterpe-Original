using Cpp2ILInjected;

namespace Assets.Scripts.Managers;

[Token(Token = "0x200096F")]
public abstract class AbstractEventHandler
{
	[Token(Token = "0x2000DE0")]
	public delegate void TriggerHandler();

	[Token(Token = "0x2000DE1")]
	public delegate void TriggerHandler<in T>(T arg1);

	[Token(Token = "0x2000DE2")]
	public delegate void TriggerHandler<in T, in T2>(T arg1, T2 arg2);

	[Token(Token = "0x2000DE3")]
	public delegate void TriggerHandler<in T, in T2, in T3>(T arg1, T2 arg2, T3 arg3);

	[Token(Token = "0x40033CE")]
	[FieldOffset(Offset = "0x10")]
	public string uid;

	[Token(Token = "0x6005620")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract void ClearEvent();

	[Token(Token = "0x6005621")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	internal virtual void Play(object[] args = null)
	{
	}

	[Token(Token = "0x6005622")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	protected AbstractEventHandler()
	{
	}
}
