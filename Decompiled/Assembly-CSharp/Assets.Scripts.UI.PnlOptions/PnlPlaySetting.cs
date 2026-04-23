using System.Collections.Generic;
using Assets.Scripts.Structs;
using Assets.Scripts.UI.Panels;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.PnlOptions;

[Token(Token = "0x200085B")]
public class PnlPlaySetting : UISelectManage
{
	[Token(Token = "0x4002B70")]
	[SerializeField]
	[FieldOffset(Offset = "0x118")]
	private Slider m_HitSfxVolumeSlider;

	[SerializeField]
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4002B71")]
	private Button m_BtnVolumePrevious;

	[SerializeField]
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4002B72")]
	private Button m_BtnVolumeNext;

	[SerializeField]
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4002B73")]
	private Button m_BtnBattleSfx;

	[SerializeField]
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4002B74")]
	private GameObject m_PnlBattleSfxSelect;

	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x4002B75")]
	private Text m_TxtBattleSfx;

	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4002B76")]
	[SerializeField]
	private Button m_BtnShowSfxTip;

	[SerializeField]
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4002B77")]
	private Button m_BtnBgLightSetting;

	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	[Token(Token = "0x4002B78")]
	private Button m_BtnFeverBgSetting;

	[SerializeField]
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4002B79")]
	private ToggleSettingGroup m_TglGroupAp;

	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4002B7A")]
	[SerializeField]
	private ToggleSettingGroup m_TglGroupAdvancedJudge;

	[SerializeField]
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4002B7B")]
	private Button m_BtnAPIndicator;

	[FieldOffset(Offset = "0x178")]
	[SerializeField]
	[Token(Token = "0x4002B7C")]
	private Button m_BtnInputSetting;

	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4002B7D")]
	[SerializeField]
	private Button m_BtnLevelConfigSetting;

	[Token(Token = "0x4002B7E")]
	[FieldOffset(Offset = "0x188")]
	[SerializeField]
	private ModuleBackgroundSetting m_ModuleBackgroundSetting;

	[Token(Token = "0x4002B7F")]
	[SerializeField]
	[FieldOffset(Offset = "0x190")]
	private PnlFeverSetting m_PnlFeverBgSetting;

	[Token(Token = "0x4002B80")]
	[SerializeField]
	[FieldOffset(Offset = "0x198")]
	private PnlLevelConfigSetting m_PnlLevelConfigSetting;

	[FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	[Token(Token = "0x4002B81")]
	private GameObject m_PnlInputSettingStandlone;

	[Token(Token = "0x4002B82")]
	[FieldOffset(Offset = "0x1A8")]
	[SerializeField]
	private GameObject m_PnlInputSettingMobile;

	[SerializeField]
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4002B83")]
	private GameObject m_PnlInputSettingSwitch;

	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4002B84")]
	private List<Selectable> m_SelectableList;

	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4002B85")]
	private PlaySettingModel m_SettingModel;

	[Token(Token = "0x6004C81")]
	[Address(RVA = "0x6144A0", Offset = "0x612CA0", Length = "0x549")]
	public override void OnAwake()
	{
	}

	[Address(RVA = "0x614A50", Offset = "0x613250", Length = "0x23")]
	[Token(Token = "0x6004C82")]
	private void OnClickToSelectBattleSfx()
	{
	}

	[Address(RVA = "0x6149F0", Offset = "0x6131F0", Length = "0x57")]
	[Token(Token = "0x6004C83")]
	private void OnClickAdjustVolume(float volumeDuration)
	{
	}

	[Address(RVA = "0x614BA0", Offset = "0x6133A0", Length = "0x247")]
	[Token(Token = "0x6004C84")]
	public override void OnEnablePnl()
	{
	}

	[Address(RVA = "0x614A80", Offset = "0x613280", Length = "0x111")]
	[Token(Token = "0x6004C85")]
	public override void OnDisablePnl()
	{
	}

	[Address(RVA = "0x614DF0", Offset = "0x6135F0", Length = "0x10F")]
	[Token(Token = "0x6004C86")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Token(Token = "0x6004C87")]
	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	public PnlPlaySetting()
	{
	}
}
