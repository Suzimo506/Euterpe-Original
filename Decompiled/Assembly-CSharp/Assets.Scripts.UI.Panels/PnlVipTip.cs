using System.Collections.Generic;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008F5")]
public class PnlVipTip : BaseMessageBox
{
	[Attribute(Name = "HeaderAttribute", RVA = "0x5FBC0", Offset = "0x5EFC0")]
	[Token(Token = "0x4002FEE")]
	[FieldOffset(Offset = "0xF0")]
	public List<Toggle> vipToggles;

	[Token(Token = "0x4002FEF")]
	[FieldOffset(Offset = "0xF8")]
	public MusicPackageScrollRect musicPackageScrollRect;

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4002FF0")]
	private VipToggleType m_SelectToggleType;

	[Token(Token = "0x4002FF1")]
	[FieldOffset(Offset = "0x104")]
	public Color colorToggleOn;

	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x4002FF2")]
	public Color colorToggleOff;

	[FieldOffset(Offset = "0x124")]
	[Token(Token = "0x4002FF3")]
	public Color colorToggleTextOn;

	[FieldOffset(Offset = "0x134")]
	[Token(Token = "0x4002FF4")]
	public Color colorToggleTextOff;

	[Token(Token = "0x4002FF5")]
	[FieldOffset(Offset = "0x148")]
	public string toggleOnImage;

	[Token(Token = "0x4002FF6")]
	[FieldOffset(Offset = "0x150")]
	public string toggleOffImg;

	[Token(Token = "0x4002FF7")]
	private static Dictionary<string, Sprite> m_SpriteCache;

	[Address(RVA = "0x4CD210", Offset = "0x4CBA10", Length = "0x18C")]
	[Token(Token = "0x6005157")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x6005158")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void GenerateAllVipDatas()
	{
	}

	[Token(Token = "0x6005159")]
	[Address(RVA = "0x4CD3D0", Offset = "0x4CBBD0", Length = "0x50")]
	private void CloseSelfByJumpToTargetAlbum()
	{
	}

	[Address(RVA = "0x4CD880", Offset = "0x4CC080", Length = "0x34")]
	[Token(Token = "0x600515A")]
	protected override void OnShutClicked()
	{
	}

	[Address(RVA = "0x4CD3A0", Offset = "0x4CBBA0", Length = "0x29")]
	[Token(Token = "0x600515B")]
	public void ChangeOutScheme(float outTime, Ease outEase)
	{
	}

	[Token(Token = "0x600515C")]
	[Address(RVA = "0x4CDC90", Offset = "0x4CC490", Length = "0x85")]
	public override void Show()
	{
	}

	[Address(RVA = "0x4CDBA0", Offset = "0x4CC3A0", Length = "0xEB")]
	[Token(Token = "0x600515D")]
	public void Refresh()
	{
	}

	[Address(RVA = "0x4CD560", Offset = "0x4CBD60", Length = "0xFF")]
	[Token(Token = "0x600515E")]
	private void InitLoveElfinToggle()
	{
	}

	[Address(RVA = "0x4CD8C0", Offset = "0x4CC0C0", Length = "0x2D2")]
	[Token(Token = "0x600515F")]
	private void OnToggleValueChange(bool isOn)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6005160")]
	private void OnClickToggle()
	{
	}

	[Token(Token = "0x6005161")]
	[Address(RVA = "0x4CD430", Offset = "0x4CBC30", Length = "0x123")]
	public static Sprite GetSprite(string key)
	{
		return null;
	}

	[Token(Token = "0x6005162")]
	[Address(RVA = "0x4CD660", Offset = "0x4CBE60", Length = "0x21C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005163")]
	[Address(RVA = "0x4CDD80", Offset = "0x4CC580", Length = "0x6C")]
	public PnlVipTip()
	{
	}
}
