using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.Bulletin;

[Serializable]
[Token(Token = "0x2000952")]
public class PnlStageBulletinView
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40032CD")]
	[SerializeField]
	private ToggleGroup m_ToggleGroup;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40032CE")]
	[SerializeField]
	private PnlStageBulletinProperty m_CommonProperty;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40032CF")]
	public Transform content;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40032D0")]
	[SerializeField]
	private bool m_ShowFlag;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40032D1")]
	private IStorage m_ImageLoader;

	[Token(Token = "0x40032D2")]
	[FieldOffset(Offset = "0x38")]
	public readonly List<Toggle> toggles;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40032D3")]
	public bool languageChangDirty;

	[Token(Token = "0x60054A3")]
	[Address(RVA = "0x4713A0", Offset = "0x46FBA0", Length = "0x5")]
	public void Init()
	{
	}

	[Address(RVA = "0x6D0490", Offset = "0x6CEC90", Length = "0x5B")]
	[Token(Token = "0x60054A4")]
	public void ResetToggleOn()
	{
	}

	[Token(Token = "0x60054A5")]
	[Address(RVA = "0x6D00A0", Offset = "0x6CE8A0", Length = "0x3E6")]
	public void RefreshUI(Dictionary<string, List<PnlStageBulletinDataModel>> cellBulletin)
	{
	}

	[Token(Token = "0x60054A6")]
	[Address(RVA = "0x6D0080", Offset = "0x6CE880", Length = "0x17")]
	private YlyRichText GetRichText(BulletinCell container)
	{
		return null;
	}

	[Token(Token = "0x60054A7")]
	[Address(RVA = "0x6D04F0", Offset = "0x6CECF0", Length = "0x184")]
	private void ToggleInit(BulletinCell container, PnlStageBulletinDataModel bulletin, Image newTipsImage)
	{
	}

	[Address(RVA = "0x6D0680", Offset = "0x6CEE80", Length = "0x91")]
	[Token(Token = "0x60054A8")]
	public PnlStageBulletinView()
	{
	}
}
