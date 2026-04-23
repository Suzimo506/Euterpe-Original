using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000134")]
public class PnlUnlockStage : MonoBehaviour
{
	[Token(Token = "0x400078C")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip unlockClip;

	[Token(Token = "0x400078D")]
	[FieldOffset(Offset = "0x20")]
	public Button btnMask;

	[Token(Token = "0x400078E")]
	[FieldOffset(Offset = "0x28")]
	public Animator unlockAnimator;

	[Token(Token = "0x400078F")]
	[FieldOffset(Offset = "0x30")]
	public Image unlockCover;

	[Token(Token = "0x4000790")]
	[FieldOffset(Offset = "0x38")]
	public Text unlockText;

	[Token(Token = "0x4000791")]
	[FieldOffset(Offset = "0x40")]
	public Text musicTitle;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000792")]
	public Text authorTitle;

	[Token(Token = "0x4000794")]
	[FieldOffset(Offset = "0x58")]
	private IData m_CurNewSong;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000795")]
	private bool m_IsShowSpecialSong;

	[Token(Token = "0x4000796")]
	[FieldOffset(Offset = "0x68")]
	private string m_CurSpecialSongUid;

	[Token(Token = "0x4000797")]
	[FieldOffset(Offset = "0x70")]
	private Image m_ImgLockedBg;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000798")]
	private Sprite m_SprLockedDefault;

	[Token(Token = "0x170000AA")]
	public string newSongUid
	{
		[Address(RVA = "0x565940", Offset = "0x564140", Length = "0x9B")]
		[Token(Token = "0x60008AF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000003")]
	public event Action onDisable
	{
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x5658A0", Offset = "0x5640A0", Length = "0x9E")]
		[CompilerGenerated]
		add
		{
		}
		[Address(RVA = "0x5659E0", Offset = "0x5641E0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60008B1")]
		remove
		{
		}
	}

	[Address(RVA = "0x5648F0", Offset = "0x5630F0", Length = "0x89")]
	[Token(Token = "0x60008B2")]
	private void Awake()
	{
	}

	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x20730", Offset = "0x1FB30")]
	[Token(Token = "0x60008B3")]
	[Address(RVA = "0x564DB0", Offset = "0x5635B0", Length = "0x65")]
	private IEnumerator OnMaskBtnClicked()
	{
		return null;
	}

	[Address(RVA = "0x564DA0", Offset = "0x5635A0", Length = "0x7")]
	[Token(Token = "0x60008B4")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x564B60", Offset = "0x563360", Length = "0x16D")]
	[Token(Token = "0x60008B5")]
	private void OnClose()
	{
	}

	[Address(RVA = "0x564CD0", Offset = "0x5634D0", Length = "0xCA")]
	[Token(Token = "0x60008B6")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x564AA0", Offset = "0x5632A0", Length = "0xB7")]
	[Token(Token = "0x60008B7")]
	private void OnCloseAfterShowSpecialSong()
	{
	}

	[Token(Token = "0x60008B8")]
	[Address(RVA = "0x565380", Offset = "0x563B80", Length = "0x51B")]
	public void UnlockSpecialSong(string songUid, bool jumpToNewSong = true)
	{
	}

	[Token(Token = "0x60008B9")]
	[Address(RVA = "0x564ED0", Offset = "0x5636D0", Length = "0x4A6")]
	public void UnlockNewSong(IData newSong)
	{
	}

	[Address(RVA = "0x564980", Offset = "0x563180", Length = "0x119")]
	[Token(Token = "0x60008BA")]
	private void InitImgLockedBgComp()
	{
	}

	[Token(Token = "0x60008BB")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlUnlockStage()
	{
	}
}
