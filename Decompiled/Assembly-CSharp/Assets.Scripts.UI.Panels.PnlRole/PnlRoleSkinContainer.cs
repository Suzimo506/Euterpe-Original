using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.PnlRole;

[Token(Token = "0x200096A")]
public class PnlRoleSkinContainer : PnlRoleSelectedItem
{
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x400339F")]
	private GameObject m_SkinItemPrefab;

	[SerializeField]
	[Token(Token = "0x40033A0")]
	[FieldOffset(Offset = "0x88")]
	private Transform m_Content;

	[Token(Token = "0x40033A1")]
	[SerializeField]
	[FieldOffset(Offset = "0x90")]
	private RectTransform m_ImgSelect;

	[SerializeField]
	[Token(Token = "0x40033A2")]
	[FieldOffset(Offset = "0x98")]
	private PeroScrollRect m_PeroScrollRect;

	[SerializeField]
	[Token(Token = "0x40033A3")]
	[FieldOffset(Offset = "0xA0")]
	private SelectableFancyPanel m_FancyPanel;

	[SerializeField]
	[Token(Token = "0x40033A4")]
	[FieldOffset(Offset = "0xA8")]
	private Vector2 m_SelectedInDressSizeDelta;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40033A5")]
	[SerializeField]
	private Vector2 m_SelectedUnInDressSizeDelta;

	[Token(Token = "0x40033A6")]
	[FieldOffset(Offset = "0xB8")]
	private List<PnlRoleSkinItem> m_SkinItems;

	[Token(Token = "0x40033A7")]
	[FieldOffset(Offset = "0xC0")]
	private List<RoleSkin> m_CurrentSkinList;

	[Token(Token = "0x40033A8")]
	[FieldOffset(Offset = "0xC8")]
	private int[] m_SelectedSkinIndexs;

	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40033A9")]
	public Action onSelectSkin;

	[Token(Token = "0x40033AA")]
	[FieldOffset(Offset = "0xD8")]
	private int m_CurrentCharacterIndex;

	[Token(Token = "0x40033AB")]
	[FieldOffset(Offset = "0xE0")]
	private Assets.Scripts.Database.CharacterInfo m_CharacterInfo;

	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40033AC")]
	private bool m_HasGotCharacter;

	[Token(Token = "0x170008FC")]
	public int currentSelectedIndex
	{
		[Address(RVA = "0x4A1330", Offset = "0x49FB30", Length = "0x7")]
		[Token(Token = "0x60055DE")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60055DF")]
		[CompilerGenerated]
		[Address(RVA = "0x6425A0", Offset = "0x640DA0", Length = "0x7")]
		private set
		{
		}
	}

	[Token(Token = "0x170008FD")]
	public int currentInDressIndex
	{
		[Token(Token = "0x60055E0")]
		[Address(RVA = "0x4A15E0", Offset = "0x49FDE0", Length = "0x7")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60055E1")]
		[Address(RVA = "0x642590", Offset = "0x640D90", Length = "0x7")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170008FE")]
	public RoleSkin currentRoleSkin
	{
		[Address(RVA = "0x642520", Offset = "0x640D20", Length = "0x60")]
		[Token(Token = "0x60055E2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60055E3")]
	[Address(RVA = "0x640DD0", Offset = "0x63F5D0", Length = "0x1DB")]
	private void Awake()
	{
	}

	[Address(RVA = "0x641960", Offset = "0x640160", Length = "0x33D")]
	[Token(Token = "0x60055E4")]
	public void RefreshSkinItems(Assets.Scripts.Database.CharacterInfo characterInfo, bool hasGotCharacter)
	{
	}

	[Address(RVA = "0x6412E0", Offset = "0x63FAE0", Length = "0x1F")]
	[Token(Token = "0x60055E5")]
	public void Init()
	{
	}

	[Token(Token = "0x60055E6")]
	[Address(RVA = "0x641230", Offset = "0x63FA30", Length = "0xA0")]
	private void InitSelectedSkinIndexs()
	{
	}

	[Token(Token = "0x60055E7")]
	[Address(RVA = "0x641490", Offset = "0x63FC90", Length = "0x7")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60055E8")]
	[Address(RVA = "0x641880", Offset = "0x640080", Length = "0xD7")]
	private void RefreshSelectedSkinIndexs()
	{
	}

	[Address(RVA = "0x6409C0", Offset = "0x63F1C0", Length = "0x407")]
	[Token(Token = "0x60055E9")]
	private void AdjustSkinItemsCount()
	{
	}

	[Token(Token = "0x60055EA")]
	[Address(RVA = "0x640810", Offset = "0x63F010", Length = "0x1A8")]
	private void AddSkinItem(int count)
	{
	}

	[Token(Token = "0x60055EB")]
	[Address(RVA = "0x6414E0", Offset = "0x63FCE0", Length = "0x269")]
	private void OnSkinItemClicked(GameObject itemObj, int index)
	{
	}

	[Token(Token = "0x60055EC")]
	[Address(RVA = "0x640FB0", Offset = "0x63F7B0", Length = "0x18A")]
	public void ChangeSelectedToInDressSkin()
	{
	}

	[Token(Token = "0x60055ED")]
	[Address(RVA = "0x641CA0", Offset = "0x6404A0", Length = "0x1A0")]
	private void SelectSkinItem(GameObject itemObj, int index)
	{
	}

	[Token(Token = "0x60055EE")]
	[Address(RVA = "0x641E50", Offset = "0x640650", Length = "0xE0")]
	private void ShowSelectedItem(Transform transform)
	{
	}

	[Address(RVA = "0x641140", Offset = "0x63F940", Length = "0xE9")]
	[Token(Token = "0x60055EF")]
	private void HideSkinItem(int count)
	{
	}

	[Address(RVA = "0x641390", Offset = "0x63FB90", Length = "0x89")]
	[Token(Token = "0x60055F0")]
	public bool IsSelectedSkinItemTryOut()
	{
		return default(bool);
	}

	[Address(RVA = "0x641300", Offset = "0x63FB00", Length = "0x89")]
	[Token(Token = "0x60055F1")]
	public bool IsSelectedSkinIsBuy()
	{
		return default(bool);
	}

	[Address(RVA = "0x641F40", Offset = "0x640740", Length = "0x1A7")]
	[Token(Token = "0x60055F2")]
	private void ShowSkinTipMessage()
	{
	}

	[Token(Token = "0x60055F3")]
	[Address(RVA = "0x6422C0", Offset = "0x640AC0", Length = "0xE4")]
	public void TurnLeft()
	{
	}

	[Address(RVA = "0x6423B0", Offset = "0x640BB0", Length = "0xFA")]
	[Token(Token = "0x60055F4")]
	public void TurnRight()
	{
	}

	[Address(RVA = "0x6420F0", Offset = "0x6408F0", Length = "0x1C5")]
	[Token(Token = "0x60055F5")]
	private void TurnByAxis(float value)
	{
	}

	[Address(RVA = "0x641750", Offset = "0x63FF50", Length = "0x12F")]
	[Token(Token = "0x60055F6")]
	private void OnSubmit()
	{
	}

	[Address(RVA = "0x6414A0", Offset = "0x63FCA0", Length = "0x32")]
	[Token(Token = "0x60055F7")]
	public override void OnSelected()
	{
	}

	[Token(Token = "0x60055F8")]
	[Address(RVA = "0x641450", Offset = "0x63FC50", Length = "0x32")]
	public override void OnDeselected()
	{
	}

	[Address(RVA = "0x641420", Offset = "0x63FC20", Length = "0x2F")]
	[Token(Token = "0x60055F9")]
	public override bool IsSelectedValid()
	{
		return default(bool);
	}

	[Address(RVA = "0x6424B0", Offset = "0x640CB0", Length = "0x6C")]
	[Token(Token = "0x60055FA")]
	public PnlRoleSkinContainer()
	{
	}
}
