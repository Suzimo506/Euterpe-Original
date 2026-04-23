using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Common;

[Token(Token = "0x2000985")]
[Attribute(Name = "RequireComponent", RVA = "0x1CF90", Offset = "0x1C390")]
public class TextClickUrl : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4003415")]
	private YlyRichText m_Text;

	[Token(Token = "0x6005693")]
	[Address(RVA = "0x703320", Offset = "0x701B20", Length = "0xEB")]
	private void Awake()
	{
	}

	[Address(RVA = "0x703410", Offset = "0x701C10", Length = "0xBB")]
	[Token(Token = "0x6005694")]
	public void OnClickUrl(string url)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6005695")]
	public TextClickUrl()
	{
	}
}
