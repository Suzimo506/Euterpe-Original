using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200001B")]
public abstract class StaticSynhroObject : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000085")]
	protected GameObject singleSynchroObj;

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract void Init();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x60000AF")]
	public abstract void Release();

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	protected StaticSynhroObject()
	{
	}
}
