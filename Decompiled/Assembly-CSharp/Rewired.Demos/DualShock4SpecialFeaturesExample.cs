using System.Collections.Generic;
using Cpp2ILInjected;
using Rewired.ControllerExtensions;
using UnityEngine;

namespace Rewired.Demos;

[Attribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
[Token(Token = "0x2000218")]
public class DualShock4SpecialFeaturesExample : MonoBehaviour
{
	[Token(Token = "0x2000AB7")]
	private class Touch
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003849")]
		public GameObject go;

		[Token(Token = "0x400384A")]
		[FieldOffset(Offset = "0x18")]
		public int touchId;

		[Address(RVA = "0xFA6670", Offset = "0xFA4E70", Length = "0xE")]
		[Token(Token = "0x6005BE6")]
		public Touch()
		{
		}
	}

	[Token(Token = "0x4000F35")]
	private const int maxTouches = 2;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F36")]
	public int playerId;

	[Token(Token = "0x4000F37")]
	[FieldOffset(Offset = "0x20")]
	public Transform touchpadTransform;

	[Token(Token = "0x4000F38")]
	[FieldOffset(Offset = "0x28")]
	public GameObject lightObject;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000F39")]
	public Transform accelerometerTransform;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000F3A")]
	private List<Touch> touches;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000F3B")]
	private Queue<Touch> unusedTouches;

	[Token(Token = "0x4000F3C")]
	[FieldOffset(Offset = "0x48")]
	private bool isFlashing;

	[Token(Token = "0x4000F3D")]
	[FieldOffset(Offset = "0x50")]
	private GUIStyle textStyle;

	[Token(Token = "0x1700040D")]
	private Player player
	{
		[Token(Token = "0x6001404")]
		[Address(RVA = "0xF93790", Offset = "0xF91F90", Length = "0x66")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0xF91B70", Offset = "0xF90370", Length = "0x7")]
	[Token(Token = "0x6001405")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001406")]
	[Address(RVA = "0xF92F90", Offset = "0xF91790", Length = "0x7FE")]
	private void Update()
	{
	}

	[Token(Token = "0x6001407")]
	[Address(RVA = "0xF924B0", Offset = "0xF90CB0", Length = "0x68A")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6001408")]
	[Address(RVA = "0xF92B40", Offset = "0xF91340", Length = "0xAE")]
	private void ResetOrientation()
	{
	}

	[Address(RVA = "0xF92BF0", Offset = "0xF913F0", Length = "0x209")]
	[Token(Token = "0x6001409")]
	private void SetRandomLightColor()
	{
	}

	[Address(RVA = "0xF92E00", Offset = "0xF91600", Length = "0xC2")]
	[Token(Token = "0x600140A")]
	private void StartLightFlash()
	{
	}

	[Address(RVA = "0xF92ED0", Offset = "0xF916D0", Length = "0xB6")]
	[Token(Token = "0x600140B")]
	private void StopLightFlash()
	{
	}

	[Address(RVA = "0xF91B80", Offset = "0xF90380", Length = "0x1DF")]
	[Token(Token = "0x600140C")]
	private IDualShock4Extension GetFirstDS4(Player player)
	{
		return null;
	}

	[Address(RVA = "0xF92240", Offset = "0xF90A40", Length = "0x264")]
	[Token(Token = "0x600140D")]
	private void InitializeTouchObjects()
	{
	}

	[Token(Token = "0x600140E")]
	[Address(RVA = "0xF91D60", Offset = "0xF90560", Length = "0x4D0")]
	private void HandleTouchpad(IDualShock4Extension ds4)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600140F")]
	public DualShock4SpecialFeaturesExample()
	{
	}
}
