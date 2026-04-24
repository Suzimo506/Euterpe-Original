using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Demos;

[AttributeAttribute(Name = "RequireComponent", RVA = "0xDF00", Offset = "0xD300")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xDF00", Offset = "0xD300")]
[Token(Token = "0x2000217")]
public class TouchJoystickExample : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F2C")]
	public bool allowMouseControl;

	[Token(Token = "0x4000F2D")]
	[FieldOffset(Offset = "0x1C")]
	public int radius;

	[Token(Token = "0x4000F2E")]
	[FieldOffset(Offset = "0x20")]
	private Vector2 origAnchoredPosition;

	[Token(Token = "0x4000F2F")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 origWorldPosition;

	[Token(Token = "0x4000F30")]
	[FieldOffset(Offset = "0x34")]
	private Vector2 origScreenResolution;

	[Token(Token = "0x4000F31")]
	[FieldOffset(Offset = "0x3C")]
	private ScreenOrientation origScreenOrientation;

	[NonSerialized]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000F32")]
	private bool hasFinger;

	[NonSerialized]
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000F33")]
	private int lastFingerId;

	[Token(Token = "0x1700040C")]
	public Vector2 position
	{
		[Address(RVA = "0xE69490", Offset = "0xE67C90", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60013F8")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x60013F9")]
		[Address(RVA = "0xD8DD70", Offset = "0xD8C570", Length = "0x5")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60013FA")]
	[Address(RVA = "0xFA60A0", Offset = "0xFA48A0", Length = "0x28")]
	private void Start()
	{
	}

	[Token(Token = "0x60013FB")]
	[Address(RVA = "0xFA65F0", Offset = "0xFA4DF0", Length = "0x60")]
	private void Update()
	{
	}

	[Token(Token = "0x60013FC")]
	[Address(RVA = "0xFA5FE0", Offset = "0xFA47E0", Length = "0xB1")]
	private void Restart()
	{
	}

	[Address(RVA = "0xFA60D0", Offset = "0xFA48D0", Length = "0xFC")]
	[Token(Token = "0x60013FD")]
	private void StoreOrigValues()
	{
	}

	[Address(RVA = "0xFA64C0", Offset = "0xFA4CC0", Length = "0x125")]
	[Token(Token = "0x60013FE")]
	private void UpdateValue(Vector3 value)
	{
	}

	[Token(Token = "0x60013FF")]
	[Address(RVA = "0xFA6430", Offset = "0xFA4C30", Length = "0x47")]
	private void UnityEngine_002EEventSystems_002EIPointerDownHandler_002EOnPointerDown(PointerEventData eventData)
	{
	}

	[Address(RVA = "0xFA6480", Offset = "0xFA4C80", Length = "0x3C")]
	[Token(Token = "0x6001400")]
	private void UnityEngine_002EEventSystems_002EIPointerUpHandler_002EOnPointerUp(PointerEventData eventData)
	{
	}

	[Address(RVA = "0xFA61D0", Offset = "0xFA49D0", Length = "0x25B")]
	[Token(Token = "0x6001401")]
	private void UnityEngine_002EEventSystems_002EIDragHandler_002EOnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6001402")]
	[Address(RVA = "0xFA5280", Offset = "0xFA3A80", Length = "0x12")]
	private static bool IsMousePointerId(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x6001403")]
	[Address(RVA = "0xFA6650", Offset = "0xFA4E50", Length = "0x12")]
	public TouchJoystickExample()
	{
	}
}
