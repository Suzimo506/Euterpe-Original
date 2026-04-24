using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001AD")]
public class WelcomeLogic : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A7C")]
	[SerializeField]
	private string[] m_SoundName;

	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A7D")]
	private float m_FadeInTime;

	[Token(Token = "0x6000C13")]
	[Address(RVA = "0xD32490", Offset = "0xD30C90", Length = "0x1FC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000C14")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public WelcomeLogic()
	{
	}
}
