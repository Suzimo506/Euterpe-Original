using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.UI.ControlMapper;

[AttributeAttribute(Name = "RequireComponent", RVA = "0x75A00", Offset = "0x74E00")]
[Token(Token = "0x20001F9")]
public class CanvasScalerFitter : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000A7B")]
	private class BreakPoint
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003721")]
		[SerializeField]
		public string name;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003722")]
		[SerializeField]
		public float screenAspectRatio;

		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4003723")]
		[SerializeField]
		public Vector2 referenceResolution;

		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		[Token(Token = "0x60059FC")]
		public BreakPoint()
		{
		}
	}

	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000DE9")]
	private BreakPoint[] breakPoints;

	[Token(Token = "0x4000DEA")]
	[FieldOffset(Offset = "0x20")]
	private CanvasScalerExt canvasScaler;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000DEB")]
	private int screenWidth;

	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000DEC")]
	private int screenHeight;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000DED")]
	private Action ScreenSizeChanged;

	[Token(Token = "0x60010F4")]
	[Address(RVA = "0x884DC0", Offset = "0x8835C0", Length = "0xA6")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60010F5")]
	[Address(RVA = "0x8850C0", Offset = "0x8838C0", Length = "0x4E")]
	private void Update()
	{
	}

	[Token(Token = "0x60010F6")]
	[Address(RVA = "0x884E70", Offset = "0x883670", Length = "0x24E")]
	private void UpdateSize()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60010F7")]
	public CanvasScalerFitter()
	{
	}
}
