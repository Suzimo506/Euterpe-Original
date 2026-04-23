using Assets.Scripts.PeroTools.UI;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000A6")]
public class DisableTargetInputKeybinding : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400046C")]
	public string targetControllerName;

	[Token(Token = "0x400046D")]
	[FieldOffset(Offset = "0x20")]
	public InputKeyBinding targetDisableInputKeyBinding;

	[Address(RVA = "0x99FC60", Offset = "0x99E460", Length = "0x7A")]
	[Token(Token = "0x600050F")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000510")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public DisableTargetInputKeybinding()
	{
	}
}
