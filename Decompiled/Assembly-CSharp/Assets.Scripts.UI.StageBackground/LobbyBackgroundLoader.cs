using System;
using System.Collections.Generic;
using Assets.Scripts.Database;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.UI.StageBackground;

[Token(Token = "0x200082E")]
public class LobbyBackgroundLoader : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002A98")]
	[SerializeField]
	private CanvasGroup m_CanvasGroup;

	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2170", Offset = "0x1570")]
	[SerializeField]
	[Token(Token = "0x4002A99")]
	[FieldOffset(Offset = "0x20")]
	private float m_Duration;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002A9A")]
	private GameObject m_ShowBg;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002A9B")]
	private List<GameObject> m_LoadedPrefs;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002A9C")]
	private Dictionary<int, StageBackgroundData> m_CachedBgs;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002A9D")]
	private Dictionary<int, GameObject> m_ActivedBgs;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002A9E")]
	private Tweener m_CurrentSwitchTweener;

	[Token(Token = "0x4002A9F")]
	[FieldOffset(Offset = "0x50")]
	private int m_CurrentActiveBgId;

	[Token(Token = "0x6004B49")]
	[Address(RVA = "0x610BB0", Offset = "0x60F3B0", Length = "0xDD")]
	public void SwitchAndLoadBackground(int bgId)
	{
	}

	[Token(Token = "0x6004B4A")]
	[Address(RVA = "0x610420", Offset = "0x60EC20", Length = "0xC0")]
	public void Init()
	{
	}

	[Address(RVA = "0x610860", Offset = "0x60F060", Length = "0x348")]
	[Token(Token = "0x6004B4B")]
	private void OnLoadBgCompleted()
	{
	}

	[Address(RVA = "0x610070", Offset = "0x60E870", Length = "0x12E")]
	[Token(Token = "0x6004B4C")]
	private void AdaptScreen()
	{
	}

	[Token(Token = "0x6004B4D")]
	[Address(RVA = "0x6104E0", Offset = "0x60ECE0", Length = "0x250")]
	private void LoadBackground(StageBackgroundData bg)
	{
	}

	[Token(Token = "0x6004B4E")]
	[Address(RVA = "0x6102C0", Offset = "0x60EAC0", Length = "0x155")]
	private void BgSwitchToDark(Action callback = null)
	{
	}

	[Token(Token = "0x6004B4F")]
	[Address(RVA = "0x6101A0", Offset = "0x60E9A0", Length = "0x113")]
	private void BgSwitchToBright(Action callback = null)
	{
	}

	[Token(Token = "0x6004B50")]
	[Address(RVA = "0x610740", Offset = "0x60EF40", Length = "0x11E")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004B51")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public LobbyBackgroundLoader()
	{
	}
}
