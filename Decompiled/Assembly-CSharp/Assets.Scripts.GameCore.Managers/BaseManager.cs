using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000736")]
public abstract class BaseManager
{
	[Token(Token = "0x6004318")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract void AwakeInit();

	[Token(Token = "0x6004319")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void StartInit()
	{
	}

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x600431A")]
	public abstract void Release();

	[Token(Token = "0x600431B")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	protected BaseManager()
	{
	}
}
