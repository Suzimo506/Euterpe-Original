using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008EA")]
public class PopupPresetConfigSelect : BaseMessageBox
{
	[SerializeField]
	[Token(Token = "0x4002F64")]
	[FieldOffset(Offset = "0xF0")]
	private CompSavedLevelConfig m_CompLevelConfigs;

	[SerializeField]
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4002F65")]
	private Button m_BtnCustomConfig;

	[SerializeField]
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4002F66")]
	private RectTransform m_RectBtnConfirmTxtArea;

	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4002F67")]
	[SerializeField]
	private RectTransform m_RectBtnCustomTxtArea;

	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4002F68")]
	private PopupPresetUISelectManage m_UISelectManage;

	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4002F69")]
	private SavedRoleElfinConfigModel m_DataModel;

	[Token(Token = "0x170008A6")]
	public CompSavedLevelConfig CompLevelConfigs
	{
		[Address(RVA = "0x4CFBF0", Offset = "0x4CE3F0", Length = "0x8")]
		[Token(Token = "0x60050E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60050E1")]
	[Address(RVA = "0x4CED20", Offset = "0x4CD520", Length = "0x1A1")]
	public void Init()
	{
	}

	[Token(Token = "0x60050E2")]
	[Address(RVA = "0x4CF870", Offset = "0x4CE070", Length = "0x2FF")]
	public override void Show()
	{
	}

	[Address(RVA = "0x4CF190", Offset = "0x4CD990", Length = "0xD4")]
	[Token(Token = "0x60050E3")]
	protected override void OnYesClicked()
	{
	}

	[Token(Token = "0x60050E4")]
	[Address(RVA = "0x4CEFC0", Offset = "0x4CD7C0", Length = "0x1C9")]
	private void OnSelectedItemDataAndConfirm(SavedLevelConfigData data)
	{
	}

	[Address(RVA = "0x4CEED0", Offset = "0x4CD6D0", Length = "0x4F")]
	[Token(Token = "0x60050E5")]
	private void OnBtnBack()
	{
	}

	[Address(RVA = "0x4CF6C0", Offset = "0x4CDEC0", Length = "0x1A4")]
	[Token(Token = "0x60050E6")]
	private void SetSelectableObj(List<Selectable> selectables)
	{
	}

	[Address(RVA = "0x4CF270", Offset = "0x4CDA70", Length = "0x445")]
	[Token(Token = "0x60050E7")]
	private void SetItemsNavigation()
	{
	}

	[Address(RVA = "0x4CEF20", Offset = "0x4CD720", Length = "0x9D")]
	[Token(Token = "0x60050E8")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	[Token(Token = "0x60050E9")]
	public PopupPresetConfigSelect()
	{
	}
}
