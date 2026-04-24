using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
[Token(Token = "0x200021B")]
public class PlayerMouseSpriteExample : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F4E")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xEEE0", Offset = "0xE2E0")]
	public int playerId;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF080", Offset = "0xE480")]
	[Token(Token = "0x4000F4F")]
	[FieldOffset(Offset = "0x20")]
	public string horizontalAction;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF240", Offset = "0xE640")]
	public string verticalAction;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000F51")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF380", Offset = "0xE780")]
	public string wheelAction;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF500", Offset = "0xE900")]
	[Token(Token = "0x4000F52")]
	[FieldOffset(Offset = "0x38")]
	public string leftButtonAction;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000F53")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF620", Offset = "0xEA20")]
	public string rightButtonAction;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF6D0", Offset = "0xEAD0")]
	[Token(Token = "0x4000F54")]
	[FieldOffset(Offset = "0x48")]
	public string middleButtonAction;

	[Token(Token = "0x4000F55")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF830", Offset = "0xEC30")]
	public float distanceFromCamera;

	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000F56")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF980", Offset = "0xED80")]
	public float spriteScale;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xFAE0", Offset = "0xEEE0")]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000F57")]
	public GameObject pointerPrefab;

	[Token(Token = "0x4000F58")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xFC80", Offset = "0xF080")]
	public GameObject clickEffectPrefab;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000F59")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xFED0", Offset = "0xF2D0")]
	public bool hideHardwarePointer;

	[NonSerialized]
	[Token(Token = "0x4000F5A")]
	[FieldOffset(Offset = "0x70")]
	private GameObject pointer;

	[NonSerialized]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000F5B")]
	private PlayerMouse mouse;

	[Address(RVA = "0xF997F0", Offset = "0xF97FF0", Length = "0x438")]
	[Token(Token = "0x600141F")]
	private void Awake()
	{
	}

	[Address(RVA = "0xF99F20", Offset = "0xF98720", Length = "0x2C9")]
	[Token(Token = "0x6001420")]
	private void Update()
	{
	}

	[Token(Token = "0x6001421")]
	[Address(RVA = "0xF99C30", Offset = "0xF98430", Length = "0x20C")]
	private void CreateClickEffect(Color color)
	{
	}

	[Token(Token = "0x6001422")]
	[Address(RVA = "0xF99E40", Offset = "0xF98640", Length = "0xD1")]
	private void OnScreenPositionChanged(Vector2 position)
	{
	}

	[Token(Token = "0x6001423")]
	[Address(RVA = "0xF9A1F0", Offset = "0xF989F0", Length = "0xB7")]
	public PlayerMouseSpriteExample()
	{
	}
}
