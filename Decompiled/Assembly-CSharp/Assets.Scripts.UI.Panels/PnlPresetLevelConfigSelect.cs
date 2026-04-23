using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008E9")]
public class PnlPresetLevelConfigSelect : UISelectManage
{
	[SerializeField]
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4002F5E")]
	private Button m_BtnBack;

	[SerializeField]
	[Token(Token = "0x4002F5F")]
	[FieldOffset(Offset = "0x120")]
	private GameObject m_AreaSelect;

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4002F60")]
	[SerializeField]
	private Button m_BtnPreSelect;

	[SerializeField]
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4002F61")]
	private Button m_BtnCustom;

	[SerializeField]
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4002F62")]
	private PopupPresetConfigSelect m_PopupPresetSelect;

	[Token(Token = "0x4002F63")]
	[FieldOffset(Offset = "0x140")]
	private Sequence m_PopAnimaComp;

	[Token(Token = "0x60050D2")]
	[Address(RVA = "0x685480", Offset = "0x683C80", Length = "0x149")]
	public override void OnAwake()
	{
	}

	[Token(Token = "0x60050D3")]
	[Address(RVA = "0x6857E0", Offset = "0x683FE0", Length = "0x109")]
	public override void OnEnablePnl()
	{
	}

	[Token(Token = "0x60050D4")]
	[Address(RVA = "0x685710", Offset = "0x683F10", Length = "0xC8")]
	public override void OnDisablePnl()
	{
	}

	[Token(Token = "0x60050D5")]
	[Address(RVA = "0x6858F0", Offset = "0x6840F0", Length = "0x11C")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Address(RVA = "0x6855D0", Offset = "0x683DD0", Length = "0x32")]
	[Token(Token = "0x60050D6")]
	private void OnBtnBack()
	{
	}

	[Token(Token = "0x60050D7")]
	[Address(RVA = "0x685610", Offset = "0x683E10", Length = "0xAE")]
	private void OnBtnCustom()
	{
	}

	[Address(RVA = "0x6856C0", Offset = "0x683EC0", Length = "0x2A")]
	[Token(Token = "0x60050D8")]
	private void OnBtnPreSelect()
	{
	}

	[Address(RVA = "0x685C00", Offset = "0x684400", Length = "0x23F")]
	[Token(Token = "0x60050D9")]
	private void TweenToShow()
	{
	}

	[Address(RVA = "0x685A10", Offset = "0x684210", Length = "0x1EF")]
	[Token(Token = "0x60050DA")]
	private void TweenToClose()
	{
	}

	[Token(Token = "0x60050DB")]
	[Address(RVA = "0x6856F0", Offset = "0x683EF0", Length = "0x11")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60050DC")]
	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	public PnlPresetLevelConfigSelect()
	{
	}
}
