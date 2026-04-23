using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Components;
using Assets.Scripts.PeroTools.Nice.Interface;
using Assets.Scripts.UI.Panels;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.PnlOptions;

[Token(Token = "0x2000858")]
[Attribute(Name = "RequireComponent", RVA = "0x251E0", Offset = "0x245E0")]
public class ModuleBackgroundSetting : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002B5E")]
	[SerializeField]
	private Button m_BackButton;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002B5F")]
	[SerializeField]
	private Animator m_Animator;

	[Token(Token = "0x4002B60")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Assets.Scripts.PeroTools.Nice.Components.FancyScrollView m_Fsv;

	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4002B61")]
	private Slider m_BrightnessSlider;

	[Token(Token = "0x4002B62")]
	[SerializeField]
	[FieldOffset(Offset = "0x38")]
	private Text m_BrightnessText;

	[SerializeField]
	[Token(Token = "0x4002B63")]
	[FieldOffset(Offset = "0x40")]
	private SceneSpriteInfo[] m_BgSpriteInfos;

	[Token(Token = "0x4002B64")]
	[FieldOffset(Offset = "0x48")]
	private UISelectManage m_UISelectManage;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002B65")]
	private PlaySettingModel m_SettingModel;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002B66")]
	private Dictionary<string, IData> m_BgSettingDic;

	[Token(Token = "0x4002B67")]
	[FieldOffset(Offset = "0x60")]
	private List<string> m_SceneNames;

	[Token(Token = "0x4002B68")]
	[FieldOffset(Offset = "0x68")]
	private BackgroundSettingUpdateItem m_CurrentItem;

	[Address(RVA = "0x4BFB50", Offset = "0x4BE350", Length = "0x1BF")]
	[Token(Token = "0x6004C60")]
	public void FirstInit()
	{
	}

	[Token(Token = "0x6004C61")]
	[Address(RVA = "0x4C01A0", Offset = "0x4BE9A0", Length = "0x3EF")]
	public void Open(DataModel dataModel)
	{
	}

	[Token(Token = "0x6004C62")]
	[Address(RVA = "0x4BFA70", Offset = "0x4BE270", Length = "0xD1")]
	private void Close()
	{
	}

	[Token(Token = "0x6004C63")]
	[Address(RVA = "0x4BFE50", Offset = "0x4BE650", Length = "0x96")]
	private void OnItemCreated(GameObject itemObj)
	{
	}

	[Token(Token = "0x6004C64")]
	[Address(RVA = "0x4BFD10", Offset = "0x4BE510", Length = "0x13D")]
	private SceneSpriteInfo GetSceneSpriteInfoByScrollIndex(int scrollIndex)
	{
		return null;
	}

	[Token(Token = "0x6004C65")]
	[Address(RVA = "0x4BFEF0", Offset = "0x4BE6F0", Length = "0x105")]
	private void OnSceneIndexChanged(int cellIndex)
	{
	}

	[Token(Token = "0x6004C66")]
	[Address(RVA = "0x4C0590", Offset = "0x4BED90", Length = "0x1DA")]
	private void ResetSliderState(float duration)
	{
	}

	[Token(Token = "0x6004C67")]
	[Address(RVA = "0x4C0000", Offset = "0x4BE800", Length = "0x191")]
	private void OnSliderValueChange(float duration)
	{
	}

	[Token(Token = "0x6004C68")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public ModuleBackgroundSetting()
	{
	}
}
