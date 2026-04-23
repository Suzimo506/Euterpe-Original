using Assets.Scripts.PeroTools.UI;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

[Token(Token = "0x200019F")]
public class WelcomeSpecialBtn : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Token(Token = "0x4000A41")]
	[FieldOffset(Offset = "0x18")]
	public InputKeyBinding m_BtnLogin;

	[Token(Token = "0x6000BCD")]
	[Address(RVA = "0xD32770", Offset = "0xD30F70", Length = "0x5E")]
	private void Start()
	{
	}

	[Token(Token = "0x6000BCE")]
	[Address(RVA = "0x5B0A40", Offset = "0x5AF240", Length = "0x20")]
	public void OnPointerDown(PointerEventData data)
	{
	}

	[Token(Token = "0x6000BCF")]
	[Address(RVA = "0x5B0A70", Offset = "0x5AF270", Length = "0x20")]
	public void OnOut12()
	{
	}

	[Token(Token = "0x6000BD0")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public WelcomeSpecialBtn()
	{
	}
}
