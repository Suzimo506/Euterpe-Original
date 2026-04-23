using Assets.Scripts.Database;
using Assets.Scripts.UI.Controls;
using Cpp2ILInjected;
using MEC;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Specials;

[Token(Token = "0x200086C")]
public class BloodheirTransformBtn : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4002C01")]
	[FieldOffset(Offset = "0x18")]
	private SkeletonAnimation m_BtnAnimator;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002C02")]
	[SerializeField]
	private Button m_BtnTransform;

	[SerializeField]
	[Token(Token = "0x4002C03")]
	[FieldOffset(Offset = "0x28")]
	private BloodheirTransformHoldBtn m_BtnHold;

	[SerializeField]
	[Token(Token = "0x4002C04")]
	[FieldOffset(Offset = "0x30")]
	private GameObject m_Mask;

	[Token(Token = "0x4002C05")]
	[FieldOffset(Offset = "0x38")]
	private Assets.Scripts.Database.CharacterInfo m_CharacterInfo;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002C06")]
	private Animator m_BuroAnimator;

	[Token(Token = "0x4002C07")]
	[FieldOffset(Offset = "0x48")]
	private CharacterApply m_CharacterApply;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002C08")]
	private bool m_IsBig;

	[Token(Token = "0x4002C09")]
	[FieldOffset(Offset = "0x54")]
	private int m_Level;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002C0A")]
	private bool m_Interactable;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002C0B")]
	private CharacterFestivalVoiceInfo m_FestivalVoiceInfo;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002C0C")]
	private CoroutineHandle m_TipsCoroutine;

	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4002C0D")]
	private CoroutineHandle m_S2BCoroutine;

	[Address(RVA = "0x60A820", Offset = "0x609020", Length = "0x219")]
	[Token(Token = "0x6004CFB")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004CFC")]
	[Address(RVA = "0x60BC10", Offset = "0x60A410", Length = "0x7")]
	private void Start()
	{
	}

	[Token(Token = "0x6004CFD")]
	[Address(RVA = "0x60B4A0", Offset = "0x609CA0", Length = "0xFC")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x60B450", Offset = "0x609C50", Length = "0x48")]
	[Token(Token = "0x6004CFE")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004CFF")]
	[Address(RVA = "0x60B340", Offset = "0x609B40", Length = "0x36")]
	public void Init(Animator buroAnimator, CharacterApply characterApply)
	{
	}

	[Token(Token = "0x6004D00")]
	[Address(RVA = "0x60BA30", Offset = "0x60A230", Length = "0xF1")]
	private void StartAnimationSet()
	{
	}

	[Token(Token = "0x6004D01")]
	[Address(RVA = "0x60B380", Offset = "0x609B80", Length = "0xC8")]
	private void OnClick()
	{
	}

	[Address(RVA = "0x60AA40", Offset = "0x609240", Length = "0x6E")]
	[Token(Token = "0x6004D02")]
	private void Big2Small()
	{
	}

	[Address(RVA = "0x60B810", Offset = "0x60A010", Length = "0x21C")]
	[Token(Token = "0x6004D03")]
	private void SmallLevelUp()
	{
	}

	[Address(RVA = "0x60B5F0", Offset = "0x609DF0", Length = "0x93")]
	[Token(Token = "0x6004D04")]
	private void Small2Level1()
	{
	}

	[Address(RVA = "0x60B690", Offset = "0x609E90", Length = "0x172")]
	[Token(Token = "0x6004D05")]
	private void Small2Level2()
	{
	}

	[Token(Token = "0x6004D06")]
	[Address(RVA = "0x60BB30", Offset = "0x60A330", Length = "0xD5")]
	private void StartHold()
	{
	}

	[Token(Token = "0x6004D07")]
	[Address(RVA = "0x60B0D0", Offset = "0x6098D0", Length = "0x187")]
	private void HoldFail(bool isHolding)
	{
	}

	[Address(RVA = "0x60B260", Offset = "0x609A60", Length = "0xD2")]
	[Token(Token = "0x6004D08")]
	private void HoldSuccess()
	{
	}

	[Token(Token = "0x6004D09")]
	[Address(RVA = "0x60AF10", Offset = "0x609710", Length = "0x1B1")]
	public void Change()
	{
	}

	[Token(Token = "0x6004D0A")]
	[Address(RVA = "0x60AAB0", Offset = "0x6092B0", Length = "0x454")]
	private void ChangeExpression()
	{
	}

	[Token(Token = "0x6004D0B")]
	[Address(RVA = "0x60B5A0", Offset = "0x609DA0", Length = "0x4E")]
	private void ReturnToStandby()
	{
	}

	[Token(Token = "0x6004D0C")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public BloodheirTransformBtn()
	{
	}
}
