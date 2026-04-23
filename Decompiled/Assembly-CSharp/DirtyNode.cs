using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200016A")]
public class DirtyNode : MonoBehaviour
{
	[Token(Token = "0x40008E1")]
	[FieldOffset(Offset = "0x18")]
	protected bool mDirty;

	[Token(Token = "0x6000A42")]
	[Address(RVA = "0x99FB70", Offset = "0x99E370", Length = "0x2B")]
	public virtual void Dirty(bool isRightNow)
	{
	}

	[Token(Token = "0x6000A43")]
	[Address(RVA = "0x99FBA0", Offset = "0x99E3A0", Length = "0x41")]
	public virtual void Show(params object[] param)
	{
	}

	[Token(Token = "0x6000A44")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	protected virtual void OnReset()
	{
	}

	[Token(Token = "0x6000A45")]
	[Address(RVA = "0x507DF0", Offset = "0x5065F0", Length = "0xB")]
	public DirtyNode()
	{
	}
}
