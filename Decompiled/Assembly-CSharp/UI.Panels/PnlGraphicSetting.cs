using Assets.Scripts.PeroTools.Nice.Interface;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.Panels;

[Token(Token = "0x20001C3")]
public class PnlGraphicSetting : MonoBehaviour
{
	[Token(Token = "0x4000B17")]
	[FieldOffset(Offset = "0x18")]
	public ToggleSettingGroup quality;

	[Token(Token = "0x4000B18")]
	[FieldOffset(Offset = "0x20")]
	public ToggleSettingGroup effect;

	[Token(Token = "0x4000B19")]
	[FieldOffset(Offset = "0x28")]
	public ToggleSettingGroup fps;

	[Token(Token = "0x4000B1A")]
	[FieldOffset(Offset = "0x30")]
	public ToggleSettingGroup vSync;

	[Token(Token = "0x4000B1B")]
	[FieldOffset(Offset = "0x38")]
	public GameObject hightImgSuggest;

	[Token(Token = "0x4000B1C")]
	[FieldOffset(Offset = "0x40")]
	public GameObject lowImgSuggest;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B1D")]
	private IVariable m_QualityData;

	[Token(Token = "0x4000B1E")]
	[FieldOffset(Offset = "0x50")]
	private IVariable m_EffectData;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B1F")]
	private IVariable m_Advanced;

	[Token(Token = "0x4000B20")]
	[FieldOffset(Offset = "0x60")]
	private IVariable m_Ap;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000B21")]
	private IVariable m_Fps;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000B22")]
	private int[] m_FpsArray;

	[Address(RVA = "0x50C040", Offset = "0x50A840", Length = "0x312")]
	[Token(Token = "0x6000CB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000CB1")]
	[Address(RVA = "0x50C360", Offset = "0x50AB60", Length = "0x6B")]
	private int GetFpsIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6000CB2")]
	[Address(RVA = "0x50CAB0", Offset = "0x50B2B0", Length = "0x135")]
	private void OnVSyncSettingChanged(int index, bool enable)
	{
	}

	[Address(RVA = "0x50C650", Offset = "0x50AE50", Length = "0xB1")]
	[Token(Token = "0x6000CB3")]
	private void OnApChanged(int index, bool enable)
	{
	}

	[Address(RVA = "0x50C8F0", Offset = "0x50B0F0", Length = "0x108")]
	[Token(Token = "0x6000CB4")]
	private void OnFpsChanged(int index, bool enable)
	{
	}

	[Address(RVA = "0x50C590", Offset = "0x50AD90", Length = "0xB1")]
	[Token(Token = "0x6000CB5")]
	private void OnAdvancedChanged(int index, bool enable)
	{
	}

	[Token(Token = "0x6000CB6")]
	[Address(RVA = "0x50C840", Offset = "0x50B040", Length = "0xAE")]
	private void OnEffectChanged(int index, bool enable)
	{
	}

	[Token(Token = "0x6000CB7")]
	[Address(RVA = "0x50CA00", Offset = "0x50B200", Length = "0xAE")]
	private void OnQualityChanged(int index, bool enable)
	{
	}

	[Token(Token = "0x6000CB8")]
	[Address(RVA = "0x50CBF0", Offset = "0x50B3F0", Length = "0x48")]
	private void PlaySfx()
	{
	}

	[Address(RVA = "0x50C710", Offset = "0x50AF10", Length = "0xD9")]
	[Token(Token = "0x6000CB9")]
	private void OnApTipButtonClicked()
	{
	}

	[Address(RVA = "0x50C3D0", Offset = "0x50ABD0", Length = "0x1B7")]
	[Token(Token = "0x6000CBA")]
	private void InitVariable()
	{
	}

	[Token(Token = "0x6000CBB")]
	[Address(RVA = "0x50C7F0", Offset = "0x50AFF0", Length = "0x43")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000CBC")]
	[Address(RVA = "0x50CC40", Offset = "0x50B440", Length = "0x71")]
	public PnlGraphicSetting()
	{
	}
}
