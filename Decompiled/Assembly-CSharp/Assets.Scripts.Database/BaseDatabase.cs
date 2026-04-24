using Cpp2ILInjected;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000781")]
public abstract class BaseDatabase
{
	[Token(Token = "0x40027AB")]
	protected static readonly bool m_SafeMode;

	[Token(Token = "0x600463A")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract void AwakeInit();

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x600463B")]
	public virtual void StartInit()
	{
	}

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x600463C")]
	public abstract void Release();

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x600463D")]
	public virtual void SceneChangedRelease(Scene preScene, Scene curScene)
	{
	}

	[Token(Token = "0x600463E")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void Flush()
	{
	}

	[Token(Token = "0x600463F")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	protected BaseDatabase()
	{
	}
}
