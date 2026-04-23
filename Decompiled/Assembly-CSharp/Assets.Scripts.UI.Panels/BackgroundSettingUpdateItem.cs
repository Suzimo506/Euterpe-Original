using System;
using Assets.Scripts.PeroTools.Nice.Events;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008D3")]
public class BackgroundSettingUpdateItem : OnFancyScrollViewCellUpdate
{
	[SerializeField]
	[Token(Token = "0x4002E1F")]
	[FieldOffset(Offset = "0xA0")]
	private Image m_ImgBG;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4002E20")]
	[SerializeField]
	private Image m_ImgDarkMask;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4002E21")]
	[SerializeField]
	private Image m_ImgNote;

	[Token(Token = "0x4002E22")]
	[FieldOffset(Offset = "0xB8")]
	private Func<int, SceneSpriteInfo> m_GetSceneSpriteInfoFunc;

	[Token(Token = "0x6004F8F")]
	[Address(RVA = "0x6C0BB0", Offset = "0x6BF3B0", Length = "0x7D")]
	public void Init(Func<int, SceneSpriteInfo> func)
	{
	}

	[Token(Token = "0x6004F90")]
	[Address(RVA = "0x6C0C30", Offset = "0x6BF430", Length = "0x1A6")]
	private void OnDataIndexChange(int dataIndex)
	{
	}

	[Token(Token = "0x6004F91")]
	[Address(RVA = "0x6C0DE0", Offset = "0x6BF5E0", Length = "0x68")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004F92")]
	[Address(RVA = "0x6C0E50", Offset = "0x6BF650", Length = "0x14C")]
	public void RefreshItem(SceneSpriteInfo sceneSpriteInfo)
	{
	}

	[Address(RVA = "0x6C0FA0", Offset = "0x6BF7A0", Length = "0x21")]
	[Token(Token = "0x6004F93")]
	public void UpdateBrightness(float value)
	{
	}

	[Token(Token = "0x6004F94")]
	[Address(RVA = "0x6C0FD0", Offset = "0x6BF7D0", Length = "0x7")]
	public BackgroundSettingUpdateItem()
	{
	}
}
