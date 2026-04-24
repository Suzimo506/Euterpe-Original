using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000165")]
public class MatchContentSizeFitter : MonoBehaviour
{
	[Token(Token = "0x40008CB")]
	[FieldOffset(Offset = "0x18")]
	private ContentSizeFitter m_ContensizeFitter;

	[Token(Token = "0x6000A31")]
	[Address(RVA = "0x8C15C0", Offset = "0x8BFDC0", Length = "0x95")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000A32")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public MatchContentSizeFitter()
	{
	}
}
