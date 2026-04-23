using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000945")]
public class PnlDlcTagControl : MonoBehaviour
{
	[Token(Token = "0x400324C")]
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	private ToggleGroup m_ToggleGroup;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x99E50", Offset = "0x99250")]
	[SerializeField]
	[Token(Token = "0x400324E")]
	[FieldOffset(Offset = "0x28")]
	private Toggle m_TglVip;

	[SerializeField]
	[Token(Token = "0x400324F")]
	[FieldOffset(Offset = "0x30")]
	private Toggle m_TglPack;

	[SerializeField]
	[Token(Token = "0x4003250")]
	[FieldOffset(Offset = "0x38")]
	private Toggle m_TglDlc;

	[Token(Token = "0x4003251")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9A130", Offset = "0x99530")]
	public Text TxtVipToggleName;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4003252")]
	public Text TxtPackToggleName;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4003253")]
	public Text TxtDlcToggleName;

	[Token(Token = "0x4003254")]
	[FieldOffset(Offset = "0x58")]
	public Text TxtVipToggleCheckMarkName;

	[Token(Token = "0x4003255")]
	[FieldOffset(Offset = "0x60")]
	public Text TxtPackToggleCheckMarkName;

	[Token(Token = "0x4003256")]
	[FieldOffset(Offset = "0x68")]
	public Text TxtDlcToggleCheckMarkName;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4003257")]
	[SerializeField]
	private ToggleAnimation tglVipAnimator;

	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4003258")]
	private ToggleAnimation tglPackAnimator;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4003259")]
	[SerializeField]
	private ToggleAnimation tglDLCAnimator;

	[Token(Token = "0x400325A")]
	private const string tgl_recommanded_name_key = "recommended";

	[Token(Token = "0x400325B")]
	private const string tgl_vip_name_key = "pnl_dlc_tgl_vip_name";

	[Token(Token = "0x400325C")]
	private const string tgl_vip_mp_name_key = "pnl_dlc_tgl_vip_name_mp";

	[Token(Token = "0x400325D")]
	private const string tgl_pack_name_key = "pnl_dlc_tgl_pack_name";

	[Token(Token = "0x400325E")]
	private const string tgl_dlc_name_key = "pnl_dlc_tgl_dlc_name";

	[Token(Token = "0x400325F")]
	[FieldOffset(Offset = "0x88")]
	private PnlDlc m_Parent;

	[Token(Token = "0x14000098")]
	internal event Action<PnlDlcToggleType> OnTagToggleChange
	{
		[CompilerGenerated]
		[Token(Token = "0x6005436")]
		[Address(RVA = "0x82C8D0", Offset = "0x82B0D0", Length = "0x9E")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6005437")]
		[Address(RVA = "0x82C970", Offset = "0x82B170", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x6005438")]
	[Address(RVA = "0x82C000", Offset = "0x82A800", Length = "0x1B6")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005439")]
	[Address(RVA = "0x82C300", Offset = "0x82AB00", Length = "0x16D")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x82C1C0", Offset = "0x82A9C0", Length = "0x13B")]
	[Token(Token = "0x600543A")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600543B")]
	[Address(RVA = "0x5C14D0", Offset = "0x5BFCD0", Length = "0xF")]
	internal void Init(PnlDlc parent)
	{
	}

	[Address(RVA = "0x82C1C0", Offset = "0x82A9C0", Length = "0x13B")]
	[Token(Token = "0x600543C")]
	private void Release()
	{
	}

	[Address(RVA = "0x82C800", Offset = "0x82B000", Length = "0x47")]
	[Token(Token = "0x600543D")]
	private void OnTglVipClick(bool isOn)
	{
	}

	[Address(RVA = "0x82C7B0", Offset = "0x82AFB0", Length = "0x47")]
	[Token(Token = "0x600543E")]
	private void OnTglPackClick(bool isOn)
	{
	}

	[Address(RVA = "0x82C760", Offset = "0x82AF60", Length = "0x47")]
	[Token(Token = "0x600543F")]
	private void OnTglDlcClick(bool isOn)
	{
	}

	[Token(Token = "0x6005440")]
	[Address(RVA = "0x82C850", Offset = "0x82B050", Length = "0x37")]
	public void SetDLCTglActive(int validDLCCount)
	{
	}

	[Address(RVA = "0x82C890", Offset = "0x82B090", Length = "0x3F")]
	[Token(Token = "0x6005441")]
	private void SetTglInteractable(PnlDlcToggleType toggleType, bool isActive)
	{
	}

	[Token(Token = "0x6005442")]
	[Address(RVA = "0x82C470", Offset = "0x82AC70", Length = "0x1B3")]
	public void OnSwitchTgl(PnlDlcToggleType toggleType)
	{
	}

	[Token(Token = "0x6005443")]
	[Address(RVA = "0x82C630", Offset = "0x82AE30", Length = "0xD9")]
	private void OnSwitchToggleAnimation(PnlDlcToggleType toggleType)
	{
	}

	[Token(Token = "0x6005444")]
	[Address(RVA = "0x82C710", Offset = "0x82AF10", Length = "0x4C")]
	private void OnTglChange(PnlDlcToggleType toggleType)
	{
	}

	[Token(Token = "0x6005445")]
	[Address(RVA = "0x82C300", Offset = "0x82AB00", Length = "0x16D")]
	private void RefreshTglName()
	{
	}

	[Token(Token = "0x6005446")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlDlcTagControl()
	{
	}
}
