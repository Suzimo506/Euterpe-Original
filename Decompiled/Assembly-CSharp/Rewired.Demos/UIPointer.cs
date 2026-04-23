using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Demos;

[Token(Token = "0x200021D")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x100B0", Offset = "0xF4B0")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x100B0", Offset = "0xF4B0")]
public sealed class UIPointer : UIBehaviour
{
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x116A0", Offset = "0x10AA0")]
	[SerializeField]
	[Token(Token = "0x4000F5F")]
	[FieldOffset(Offset = "0x18")]
	private bool _hideHardwarePointer;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11910", Offset = "0x10D10")]
	[SerializeField]
	[Token(Token = "0x4000F60")]
	[FieldOffset(Offset = "0x19")]
	private bool _autoSort;

	[NonSerialized]
	[Token(Token = "0x4000F61")]
	[FieldOffset(Offset = "0x20")]
	private RectTransform _canvasRectTransform;

	[Token(Token = "0x1700040E")]
	public bool autoSort
	{
		[Address(RVA = "0x575490", Offset = "0x573C90", Length = "0x5")]
		[Token(Token = "0x6001431")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0xFA7330", Offset = "0xFA5B30", Length = "0x34")]
		[Token(Token = "0x6001432")]
		set
		{
		}
	}

	[Address(RVA = "0xFA6DD0", Offset = "0xFA55D0", Length = "0x196")]
	[Token(Token = "0x6001433")]
	protected override void Awake()
	{
	}

	[Address(RVA = "0xFA7290", Offset = "0xFA5A90", Length = "0x83")]
	[Token(Token = "0x6001434")]
	private void Update()
	{
	}

	[Token(Token = "0x6001435")]
	[Address(RVA = "0xFA7040", Offset = "0xFA5840", Length = "0x1F")]
	protected override void OnTransformParentChanged()
	{
	}

	[Token(Token = "0x6001436")]
	[Address(RVA = "0xFA7040", Offset = "0xFA5840", Length = "0x1F")]
	protected override void OnCanvasGroupChanged()
	{
	}

	[Token(Token = "0x6001437")]
	[Address(RVA = "0xFA7060", Offset = "0xFA5860", Length = "0x229")]
	public void OnScreenPositionChanged(Vector2 screenPosition)
	{
	}

	[Token(Token = "0x6001438")]
	[Address(RVA = "0xFA6F70", Offset = "0xFA5770", Length = "0xC7")]
	private void GetDependencies()
	{
	}

	[Token(Token = "0x6001439")]
	[Address(RVA = "0xFA7320", Offset = "0xFA5B20", Length = "0xD")]
	public UIPointer()
	{
	}
}
