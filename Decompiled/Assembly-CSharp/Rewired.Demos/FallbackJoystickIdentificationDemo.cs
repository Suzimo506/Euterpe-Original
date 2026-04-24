using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[Token(Token = "0x200021A")]
[Attribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
public class FallbackJoystickIdentificationDemo : MonoBehaviour
{
	[Token(Token = "0x4000F47")]
	private const float windowWidth = 250f;

	[Token(Token = "0x4000F48")]
	private const float windowHeight = 250f;

	[Token(Token = "0x4000F49")]
	private const float inputDelay = 1f;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F4A")]
	private bool identifyRequired;

	[Token(Token = "0x4000F4B")]
	[FieldOffset(Offset = "0x20")]
	private Queue<Joystick> joysticksToIdentify;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F4C")]
	private float nextInputAllowedTime;

	[Token(Token = "0x4000F4D")]
	[FieldOffset(Offset = "0x30")]
	private GUIStyle style;

	[Token(Token = "0x6001416")]
	[Address(RVA = "0xF93F20", Offset = "0xF92720", Length = "0xED")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001417")]
	[Address(RVA = "0xF94300", Offset = "0xF92B00", Length = "0x7")]
	private void JoystickConnected(ControllerStatusChangedEventArgs args)
	{
	}

	[Address(RVA = "0xF94300", Offset = "0xF92B00", Length = "0x7")]
	[Token(Token = "0x6001418")]
	private void JoystickDisconnected(ControllerStatusChangedEventArgs args)
	{
	}

	[Address(RVA = "0xF941D0", Offset = "0xF929D0", Length = "0x128")]
	[Token(Token = "0x6001419")]
	public void IdentifyAllJoysticks()
	{
	}

	[Address(RVA = "0xF945B0", Offset = "0xF92DB0", Length = "0x23")]
	[Token(Token = "0x600141A")]
	private void SetInputDelay()
	{
	}

	[Token(Token = "0x600141B")]
	[Address(RVA = "0xF94310", Offset = "0xF92B10", Length = "0x267")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600141C")]
	[Address(RVA = "0xF94010", Offset = "0xF92810", Length = "0x1B8")]
	private void DrawDialogWindow(int windowId)
	{
	}

	[Token(Token = "0x600141D")]
	[Address(RVA = "0xF94580", Offset = "0xF92D80", Length = "0x26")]
	private void Reset()
	{
	}

	[Token(Token = "0x600141E")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public FallbackJoystickIdentificationDemo()
	{
	}
}
