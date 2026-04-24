using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[Attribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
[Token(Token = "0x2000226")]
public class TouchControls1_ManipulateCube : MonoBehaviour
{
	[Token(Token = "0x4000F93")]
	[FieldOffset(Offset = "0x18")]
	public float rotateSpeed;

	[Token(Token = "0x4000F94")]
	[FieldOffset(Offset = "0x1C")]
	public float moveSpeed;

	[Token(Token = "0x4000F95")]
	[FieldOffset(Offset = "0x20")]
	private int currentColorIndex;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F96")]
	private Color[] colors;

	[Token(Token = "0x6001478")]
	[Address(RVA = "0xFA56E0", Offset = "0xFA3EE0", Length = "0x3F3")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0xFA54A0", Offset = "0xFA3CA0", Length = "0x23D")]
	[Token(Token = "0x6001479")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600147A")]
	[Address(RVA = "0xFA5AE0", Offset = "0xFA42E0", Length = "0x46")]
	private void OnMoveReceivedX(InputActionEventData data)
	{
	}

	[Token(Token = "0x600147B")]
	[Address(RVA = "0xFA5B30", Offset = "0xFA4330", Length = "0x46")]
	private void OnMoveReceivedY(InputActionEventData data)
	{
	}

	[Token(Token = "0x600147C")]
	[Address(RVA = "0xFA5CC0", Offset = "0xFA44C0", Length = "0x46")]
	private void OnRotationReceivedX(InputActionEventData data)
	{
	}

	[Address(RVA = "0xFA5D10", Offset = "0xFA4510", Length = "0x46")]
	[Token(Token = "0x600147D")]
	private void OnRotationReceivedY(InputActionEventData data)
	{
	}

	[Token(Token = "0x600147E")]
	[Address(RVA = "0xFA53E0", Offset = "0xFA3BE0", Length = "0xBB")]
	private void OnCycleColor(InputActionEventData data)
	{
	}

	[Token(Token = "0x600147F")]
	[Address(RVA = "0xFA5320", Offset = "0xFA3B20", Length = "0xB5")]
	private void OnCycleColorReverse(InputActionEventData data)
	{
	}

	[Address(RVA = "0xFA5B80", Offset = "0xFA4380", Length = "0x137")]
	[Token(Token = "0x6001480")]
	private void OnMoveReceived(Vector2 move)
	{
	}

	[Address(RVA = "0xFA5D60", Offset = "0xFA4560", Length = "0x15A")]
	[Token(Token = "0x6001481")]
	private void OnRotationReceived(Vector2 rotate)
	{
	}

	[Token(Token = "0x6001482")]
	[Address(RVA = "0xFA53E0", Offset = "0xFA3BE0", Length = "0xBB")]
	private void OnCycleColor()
	{
	}

	[Token(Token = "0x6001483")]
	[Address(RVA = "0xFA5320", Offset = "0xFA3B20", Length = "0xB5")]
	private void OnCycleColorReverse()
	{
	}

	[Token(Token = "0x6001484")]
	[Address(RVA = "0xFA5EC0", Offset = "0xFA46C0", Length = "0x11B")]
	public TouchControls1_ManipulateCube()
	{
	}
}
