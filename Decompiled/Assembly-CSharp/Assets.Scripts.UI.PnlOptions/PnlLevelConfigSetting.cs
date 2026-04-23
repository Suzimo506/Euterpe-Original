using System.Collections.Generic;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.PnlOptions;

[Token(Token = "0x200085A")]
public class PnlLevelConfigSetting : UISelectManage
{
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x4002B6B")]
	private BaseMessageBox m_MsgBoxTip;

	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x4002B6C")]
	private ToggleSettingGroup m_TglSetLevelConfigValidate;

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4002B6D")]
	[SerializeField]
	private Button m_BtnShowTip;

	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4002B6E")]
	private CompSavedLevelConfig m_CompLevelConfigs;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4002B6F")]
	private List<SavedLevelConfigItem> m_ItemList;

	[Address(RVA = "0x4C35B0", Offset = "0x4C1DB0", Length = "0x130")]
	[Token(Token = "0x6004C72")]
	public override void OnAwake()
	{
	}

	[Token(Token = "0x6004C73")]
	[Address(RVA = "0x4C38E0", Offset = "0x4C20E0", Length = "0x439")]
	public override void OnEnablePnl()
	{
	}

	[Token(Token = "0x6004C74")]
	[Address(RVA = "0x4C4160", Offset = "0x4C2960", Length = "0x298")]
	private void OnItemSelected(SavedLevelConfigData configData)
	{
	}

	[Token(Token = "0x6004C75")]
	[Address(RVA = "0x4C36F0", Offset = "0x4C1EF0", Length = "0x1EB")]
	public override void OnDisablePnl()
	{
	}

	[Token(Token = "0x6004C76")]
	[Address(RVA = "0x4C3D20", Offset = "0x4C2520", Length = "0xC2")]
	private void OnItemAdded(SavedLevelConfigData data)
	{
	}

	[Token(Token = "0x6004C77")]
	[Address(RVA = "0x4C3DF0", Offset = "0x4C25F0", Length = "0x1C5")]
	private void OnItemBeforeRemoved(SavedLevelConfigData data)
	{
	}

	[Token(Token = "0x6004C78")]
	[Address(RVA = "0x4C3FC0", Offset = "0x4C27C0", Length = "0x196")]
	private void OnItemRemoved(SavedLevelConfigData data)
	{
	}

	[Token(Token = "0x6004C79")]
	[Address(RVA = "0x4C4670", Offset = "0x4C2E70", Length = "0x64F")]
	private void RefreshSelectableObjsAndNavigation()
	{
	}

	[Address(RVA = "0x4C4CC0", Offset = "0x4C34C0", Length = "0x33")]
	[Token(Token = "0x6004C7A")]
	private void SetSelectableObjs(List<GameObject> selectableItems)
	{
	}

	[Token(Token = "0x6004C7B")]
	[Address(RVA = "0x4C4400", Offset = "0x4C2C00", Length = "0x268")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Token(Token = "0x6004C7C")]
	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	public PnlLevelConfigSetting()
	{
	}
}
