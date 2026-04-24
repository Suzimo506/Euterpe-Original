using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Specials;

[Token(Token = "0x2000871")]
public class DisableMultiTouch : MonoBehaviour
{
	[Token(Token = "0x6004D22")]
	[Address(RVA = "0x469BC0", Offset = "0x4683C0", Length = "0x9")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004D23")]
	[Address(RVA = "0x60E650", Offset = "0x60CE50", Length = "0x9")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6004D24")]
	public DisableMultiTouch()
	{
	}
}
