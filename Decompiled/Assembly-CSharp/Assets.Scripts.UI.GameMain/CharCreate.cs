using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.GameMain;

[Token(Token = "0x200088F")]
public class CharCreate : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002C85")]
	public Transform parent;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002C86")]
	public CharCreateType createType;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002C87")]
	private GameObject m_CharGo;

	[Token(Token = "0x6004DC5")]
	[Address(RVA = "0x5A7CE0", Offset = "0x5A64E0", Length = "0x607")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004DC6")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public CharCreate()
	{
	}
}
