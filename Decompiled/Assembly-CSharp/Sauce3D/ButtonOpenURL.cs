using Cpp2ILInjected;
using UnityEngine;

namespace Sauce3D;

[Token(Token = "0x200045F")]
public class ButtonOpenURL : MonoBehaviour
{
	[Token(Token = "0x40017C8")]
	[FieldOffset(Offset = "0x18")]
	public string url;

	[Address(RVA = "0x61ED70", Offset = "0x61D570", Length = "0xB")]
	[Token(Token = "0x6003297")]
	private void OpenUrl()
	{
	}

	[Token(Token = "0x6003298")]
	[Address(RVA = "0x61ED80", Offset = "0x61D580", Length = "0x46")]
	public ButtonOpenURL()
	{
	}
}
