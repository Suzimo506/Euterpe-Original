using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x200060D")]
public abstract class Action : IPlayable
{
	[Token(Token = "0x17000580")]
	public virtual float duration
	{
		[Token(Token = "0x6003B2F")]
		[Address(RVA = "0x73A090", Offset = "0x738890", Length = "0x4")]
		get
		{
			return default(float);
		}
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6003B30")]
	public virtual void Enter()
	{
	}

	[Token(Token = "0x6003B31")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void Execute()
	{
	}

	[Token(Token = "0x6003B32")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void Exit()
	{
	}

	[Token(Token = "0x6003B33")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void Pause()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6003B34")]
	public virtual void Resume()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6003B35")]
	public virtual void OnGUISelected()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003B36")]
	protected Action()
	{
	}
}
