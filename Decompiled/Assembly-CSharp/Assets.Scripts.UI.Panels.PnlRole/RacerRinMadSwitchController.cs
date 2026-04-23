using System;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlRole;

[Token(Token = "0x200096E")]
public class RacerRinMadSwitchController : MonoBehaviour
{
	[Token(Token = "0x40033C6")]
	private const string switch_sfx_normal = "sfx_common_button";

	[Token(Token = "0x40033C7")]
	private const string switch_sfx_mad = "VoiceRacerHurt05_berserk";

	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40033C8")]
	private PnlRole m_RootPanel;

	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40033C9")]
	private Image m_ImgMadSign;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40033CA")]
	[SerializeField]
	private Image m_ImgNormalSign;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40033CB")]
	[SerializeField]
	private Button m_BtnSwitch;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40033CC")]
	private DOTweenAnimation m_ImgMadSignTween;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40033CD")]
	private DOTweenAnimation m_ImgNormalSignTween;

	[Address(RVA = "0x652380", Offset = "0x650B80", Length = "0x1C5")]
	[Token(Token = "0x6005616")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005617")]
	[Address(RVA = "0x652A60", Offset = "0x651260", Length = "0x179")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x652840", Offset = "0x651040", Length = "0xC0")]
	[Token(Token = "0x6005618")]
	private void OnApplyRoleAndUpdateInfo(int selectRoleIdx, int prevRoleIdx)
	{
	}

	[Token(Token = "0x6005619")]
	[Address(RVA = "0x652C90", Offset = "0x651490", Length = "0xA8")]
	private void ResetState()
	{
	}

	[Address(RVA = "0x652910", Offset = "0x651110", Length = "0x147")]
	[Token(Token = "0x600561A")]
	private void OnClickToSwitchState()
	{
	}

	[Token(Token = "0x600561B")]
	[Address(RVA = "0x6522B0", Offset = "0x650AB0", Length = "0xCE")]
	private void ActsAfterSwitchState()
	{
	}

	[Token(Token = "0x600561C")]
	[Address(RVA = "0x652BE0", Offset = "0x6513E0", Length = "0xAE")]
	private void OnScrollToRacerRinToShowSwitch()
	{
	}

	[Obsolete]
	[Token(Token = "0x600561D")]
	[Address(RVA = "0x652550", Offset = "0x650D50", Length = "0x124")]
	private string GetHpDes()
	{
		return null;
	}

	[Obsolete]
	[Token(Token = "0x600561E")]
	[Address(RVA = "0x652680", Offset = "0x650E80", Length = "0x1B7")]
	private string GetSkillDes()
	{
		return null;
	}

	[Token(Token = "0x600561F")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public RacerRinMadSwitchController()
	{
	}
}
