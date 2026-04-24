using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200003B")]
public class DebugInfoController : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000186")]
	private GameObject parentObject;

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x600018C")]
	private void Start()
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x99DD20", Offset = "0x99C520", Length = "0x122")]
	private void InitParentObject()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public DebugInfoController()
	{
	}
}
