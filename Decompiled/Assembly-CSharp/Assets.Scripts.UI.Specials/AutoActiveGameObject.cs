using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Specials;

[Token(Token = "0x2000868")]
public class AutoActiveGameObject : MonoBehaviour
{
	[Token(Token = "0x4002BF5")]
	[FieldOffset(Offset = "0x18")]
	public GameObject obj;

	[Token(Token = "0x6004CE7")]
	[Address(RVA = "0x6092E0", Offset = "0x607AE0", Length = "0x7E")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004CE8")]
	[Address(RVA = "0x609260", Offset = "0x607A60", Length = "0x7E")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004CE9")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public AutoActiveGameObject()
	{
	}
}
