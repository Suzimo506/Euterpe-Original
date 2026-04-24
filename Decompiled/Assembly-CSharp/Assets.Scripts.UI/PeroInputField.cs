using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Rewired;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts.UI;

[Token(Token = "0x2000820")]
public class PeroInputField : InputField
{
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4002A67")]
	private bool m_PrevFocus;

	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4002A69")]
	private IGamepadTemplate m_Gamepad;

	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4002A6A")]
	private bool m_ClickOnce;

	[Token(Token = "0x17000838")]
	public bool prevFocus
	{
		[Address(RVA = "0x4C2C20", Offset = "0x4C1420", Length = "0x8")]
		[Token(Token = "0x6004AF9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000089")]
	public event Action<bool> onFocusChanged
	{
		[CompilerGenerated]
		[Address(RVA = "0x4C2B80", Offset = "0x4C1380", Length = "0x9E")]
		[Token(Token = "0x6004AF7")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6004AF8")]
		[Address(RVA = "0x4C2C30", Offset = "0x4C1430", Length = "0x9E")]
		remove
		{
		}
	}

	[Address(RVA = "0x4C25B0", Offset = "0x4C0DB0", Length = "0xAE")]
	[Token(Token = "0x6004AFA")]
	protected override void Awake()
	{
	}

	[Address(RVA = "0x4C2830", Offset = "0x4C1030", Length = "0x119")]
	[Token(Token = "0x6004AFB")]
	protected override void LateUpdate()
	{
	}

	[Address(RVA = "0x4C26A0", Offset = "0x4C0EA0", Length = "0x183")]
	[Token(Token = "0x6004AFC")]
	private bool IsAPressed()
	{
		return default(bool);
	}

	[Address(RVA = "0x4C2A30", Offset = "0x4C1230", Length = "0x1E")]
	[Token(Token = "0x6004AFD")]
	public override void OnSelect(BaseEventData eventData)
	{
	}

	[Token(Token = "0x6004AFE")]
	[Address(RVA = "0x4C2950", Offset = "0x4C1150", Length = "0x1E")]
	public override void OnDeselect(BaseEventData eventData)
	{
	}

	[Token(Token = "0x6004AFF")]
	[Address(RVA = "0x4C2660", Offset = "0x4C0E60", Length = "0x34")]
	public void Deselect()
	{
	}

	[Address(RVA = "0x4C2970", Offset = "0x4C1170", Length = "0xB9")]
	[Token(Token = "0x6004B00")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6004B01")]
	[Address(RVA = "0x4C2A50", Offset = "0x4C1250", Length = "0x121")]
	public PeroInputField()
	{
	}
}
