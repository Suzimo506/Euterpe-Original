using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008D2")]
public class PnlBulletin : BaseMessageBox
{
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4002E17")]
	public YlyRichText txtContent;

	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4002E18")]
	public Image image;

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4002E19")]
	public GameObject tglBulletin;

	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4002E1A")]
	public Transform content;

	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4002E1B")]
	public ToggleGroup toggleGroup;

	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4002E1C")]
	private readonly List<Toggle> m_Tgls;

	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4002E1D")]
	private bool m_LanguageChangDirty;

	[Token(Token = "0x4002E1E")]
	private static bool m_ShowFlag;

	[Token(Token = "0x6004F84")]
	[Address(RVA = "0x434490", Offset = "0x432C90", Length = "0x7")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004F85")]
	[Address(RVA = "0x434440", Offset = "0x432C40", Length = "0x43")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004F86")]
	[Address(RVA = "0x4345B0", Offset = "0x432DB0", Length = "0x147")]
	public void Popup()
	{
	}

	[Address(RVA = "0x433F50", Offset = "0x432750", Length = "0x3C2")]
	[Token(Token = "0x6004F87")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x6004F88")]
	[Address(RVA = "0x434320", Offset = "0x432B20", Length = "0x115")]
	public override void Destroy()
	{
	}

	[Token(Token = "0x6004F89")]
	[Address(RVA = "0x434E20", Offset = "0x433620", Length = "0x8")]
	private void SetDirty(int index)
	{
	}

	[Token(Token = "0x6004F8A")]
	[Address(RVA = "0x4344A0", Offset = "0x432CA0", Length = "0x101")]
	private void OnShowPnlBulletin()
	{
	}

	[Token(Token = "0x6004F8B")]
	[Address(RVA = "0x434700", Offset = "0x432F00", Length = "0x71A")]
	public void RefreshUI()
	{
	}

	[Token(Token = "0x6004F8C")]
	[Address(RVA = "0x435190", Offset = "0x433990", Length = "0x6C")]
	public PnlBulletin()
	{
	}
}
