using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008CF")]
public class PnlBattleComps : IPause
{
	[Token(Token = "0x4002DEE")]
	[FieldOffset(Offset = "0x10")]
	public GameObject others;

	[Token(Token = "0x4002DEF")]
	[FieldOffset(Offset = "0x18")]
	public Slider sldProgress;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002DF0")]
	public Toggle tglAutoPlay;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002DF1")]
	public Animator feverAnimator;

	[Token(Token = "0x4002DF2")]
	[FieldOffset(Offset = "0x30")]
	public Animator pnlBattleAnim;

	[Token(Token = "0x4002DF3")]
	[FieldOffset(Offset = "0x38")]
	public ChangeScoreValue scoreValue;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002DF4")]
	public ButtonDisplay BtnPauseActivity;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002DF5")]
	public ButtonDisplay BtnTutorialSkipActivity;

	[Token(Token = "0x4002DF6")]
	[FieldOffset(Offset = "0x60")]
	private Image m_ImgFoolRoleBar;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002DF7")]
	public GameObject feverValue;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002DF8")]
	[SerializeField]
	private DOTweenAnimation[] m_Animations;

	[Token(Token = "0x4002DF9")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private ParticleSystem[] m_ParticleSystems;

	[Token(Token = "0x17000896")]
	public bool IsGlobal
	{
		[Token(Token = "0x6004F5B")]
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004F59")]
	[Address(RVA = "0x4311C0", Offset = "0x42F9C0", Length = "0x1AA")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Address(RVA = "0x431370", Offset = "0x42FB70", Length = "0x1AA")]
	[Token(Token = "0x6004F5A")]
	public void Resume()
	{
	}

	[Token(Token = "0x6004F5C")]
	[Address(RVA = "0x430E40", Offset = "0x42F640", Length = "0x2C3")]
	public void ActiveNekoSkillUI(bool isTouhouBlack)
	{
	}

	[Token(Token = "0x6004F5D")]
	[Address(RVA = "0x431110", Offset = "0x42F910", Length = "0xAE")]
	public void HideHpAndFeverStateUI()
	{
	}

	[Address(RVA = "0x431520", Offset = "0x42FD20", Length = "0x14F")]
	[Token(Token = "0x6004F5E")]
	public void SetFoolActivityBarTexture(Sprite foolSprite)
	{
	}

	[Token(Token = "0x6004F5F")]
	[Address(RVA = "0x431670", Offset = "0x42FE70", Length = "0x9C")]
	public void ShowFoolActivityBarRoleImg(bool isShow)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6004F60")]
	public PnlBattleComps()
	{
	}
}
