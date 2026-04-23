using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
[Token(Token = "0x2000209")]
public class UIControl : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000EDC")]
	public Text title;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000EDD")]
	private int _id;

	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000EDE")]
	private bool _showTitle;

	[Token(Token = "0x4000EDF")]
	private static int _uidCounter;

	[Token(Token = "0x170003F8")]
	public int id
	{
		[Token(Token = "0x600134A")]
		[Address(RVA = "0x42D1E0", Offset = "0x42B9E0", Length = "0x4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003F9")]
	public bool showTitle
	{
		[Token(Token = "0x600134C")]
		[Address(RVA = "0x44A0C0", Offset = "0x4488C0", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0xDCCE10", Offset = "0xDCB610", Length = "0xA0")]
		[Token(Token = "0x600134D")]
		set
		{
		}
	}

	[Token(Token = "0x600134B")]
	[Address(RVA = "0xDCCD50", Offset = "0xDCB550", Length = "0x5E")]
	private void Awake()
	{
	}

	[Token(Token = "0x600134E")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void SetCancelCallback(Action cancelCallback)
	{
	}

	[Token(Token = "0x600134F")]
	[Address(RVA = "0xDCCDB0", Offset = "0xDCB5B0", Length = "0x55")]
	private static int GetNextUid()
	{
		return default(int);
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6001350")]
	public UIControl()
	{
	}
}
