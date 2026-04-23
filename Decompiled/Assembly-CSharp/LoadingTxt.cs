using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000186")]
public class LoadingTxt : MonoBehaviour
{
	[Token(Token = "0x400098B")]
	[FieldOffset(Offset = "0x18")]
	private Text m_Txt;

	[Token(Token = "0x6000B0F")]
	[Address(RVA = "0x8BA650", Offset = "0x8B8E50", Length = "0x11B")]
	private void Start()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000B10")]
	public LoadingTxt()
	{
	}
}
