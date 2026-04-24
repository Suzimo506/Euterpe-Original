using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Components;
using Assets.Scripts.PeroTools.Nice.Interface;
using Assets.Scripts.PeroTools.PreWarm;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008CD")]
public class PnlBackgroundSetting : MonoBehaviour, IPreWarm
{
	[Token(Token = "0x4002DDE")]
	[FieldOffset(Offset = "0x18")]
	public Slider slider;

	[Token(Token = "0x4002DDF")]
	[FieldOffset(Offset = "0x20")]
	public Text text;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002DE0")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView fancyScrollView;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002DE1")]
	public AudioClip optionBgmClip;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002DE2")]
	private List<string> s_SceneNames;

	[Token(Token = "0x4002DE3")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Button m_BackButton;

	[SerializeField]
	[Token(Token = "0x4002DE4")]
	[FieldOffset(Offset = "0x48")]
	private Animator m_Animator;

	[Token(Token = "0x4002DE5")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<string, IData> m_BrightnessDic;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002DE6")]
	[SerializeField]
	private List<SceneSpriteInfo> m_SceneSpriteInfos;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002DE7")]
	private List<SceneSpriteInfo> m_TempSpriteInfos;

	[Token(Token = "0x4002DE8")]
	[FieldOffset(Offset = "0x68")]
	private BackgroundSettingUpdateItem m_CurrentItem;

	[Address(RVA = "0x42FED0", Offset = "0x42E6D0", Length = "0x89")]
	[Token(Token = "0x6004F4C")]
	public void Awake()
	{
	}

	[Address(RVA = "0x430500", Offset = "0x42ED00", Length = "0xCE")]
	[Token(Token = "0x6004F4D")]
	private void OnBackClicked()
	{
	}

	[Address(RVA = "0x430800", Offset = "0x42F000", Length = "0xF8")]
	[Token(Token = "0x6004F4E")]
	private void OnSceneIndexChanged(int index)
	{
	}

	[Address(RVA = "0x430A80", Offset = "0x42F280", Length = "0x1BD")]
	[Token(Token = "0x6004F4F")]
	private void OnSliderValueChanged(float value, bool reset)
	{
	}

	[Address(RVA = "0x430900", Offset = "0x42F100", Length = "0x17F")]
	[Token(Token = "0x6004F50")]
	private void OnSliderValueChanged(float value)
	{
	}

	[Address(RVA = "0x430670", Offset = "0x42EE70", Length = "0x177")]
	[Token(Token = "0x6004F51")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004F52")]
	[Address(RVA = "0x430C40", Offset = "0x42F440", Length = "0x12B")]
	public void PreWarm(int slice)
	{
	}

	[Token(Token = "0x6004F53")]
	[Address(RVA = "0x4307F0", Offset = "0x42EFF0", Length = "0x7")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004F54")]
	[Address(RVA = "0x42FF60", Offset = "0x42E760", Length = "0x536")]
	private void CheckAndRebuildFsv()
	{
	}

	[Token(Token = "0x6004F55")]
	[Address(RVA = "0x4305D0", Offset = "0x42EDD0", Length = "0x96")]
	private void OnCreateItem(GameObject gameObject)
	{
	}

	[Token(Token = "0x6004F56")]
	[Address(RVA = "0x4304A0", Offset = "0x42ECA0", Length = "0x59")]
	private SceneSpriteInfo GetSceneSpriteInfoByScrollIndex(int scrollIndex)
	{
		return null;
	}

	[Token(Token = "0x6004F57")]
	[Address(RVA = "0x430D70", Offset = "0x42F570", Length = "0xC3")]
	public PnlBackgroundSetting()
	{
	}
}
