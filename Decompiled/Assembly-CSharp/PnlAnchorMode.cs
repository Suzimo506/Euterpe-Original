using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000F7")]
public class PnlAnchorMode : UISelectManage
{
	[Token(Token = "0x400061A")]
	[FieldOffset(Offset = "0x118")]
	public Toggle openBtn;

	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400061B")]
	public Toggle closeBtn;

	[Token(Token = "0x400061C")]
	[FieldOffset(Offset = "0x128")]
	public Color highlightColor;

	[Token(Token = "0x400061D")]
	[FieldOffset(Offset = "0x138")]
	public Color normalColor;

	[Token(Token = "0x400061E")]
	[FieldOffset(Offset = "0x148")]
	public AudioClip optionBgmClip;

	[Token(Token = "0x600073B")]
	[Address(RVA = "0x4FAE20", Offset = "0x4F9620", Length = "0xEA")]
	public override void OnInit()
	{
	}

	[Address(RVA = "0x4FAC60", Offset = "0x4F9460", Length = "0xF4")]
	[Token(Token = "0x600073C")]
	public override void OnDisablePnl()
	{
	}

	[Address(RVA = "0x4FAD60", Offset = "0x4F9560", Length = "0xB8")]
	[Token(Token = "0x600073D")]
	public override void OnEnablePnl()
	{
	}

	[Token(Token = "0x600073E")]
	[Address(RVA = "0x4FB340", Offset = "0x4F9B40", Length = "0xA8")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Token(Token = "0x600073F")]
	[Address(RVA = "0x4FAF10", Offset = "0x4F9710", Length = "0x2E2")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Token(Token = "0x6000740")]
	[Address(RVA = "0x4FB200", Offset = "0x4F9A00", Length = "0x13F")]
	private void SetHighlight(Toggle tgl, bool enable)
	{
	}

	[Token(Token = "0x6000741")]
	[Address(RVA = "0x4FA990", Offset = "0x4F9190", Length = "0x2C8")]
	public void OnClickOpen(bool isOn)
	{
	}

	[Token(Token = "0x6000742")]
	[Address(RVA = "0x4FA6A0", Offset = "0x4F8EA0", Length = "0x2E9")]
	public void OnClickClose(bool isOn)
	{
	}

	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	[Token(Token = "0x6000743")]
	public PnlAnchorMode()
	{
	}
}
