using System;
using System.Collections.Generic;
using Assets.Scripts.PeroTools.UI;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Structs;

[Serializable]
[Token(Token = "0x200058F")]
public class UISetColor
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40020BB")]
	public List<GameObject> m_GameObjects;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40020BC")]
	public List<Graphic> m_Graphics;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40020BD")]
	public List<InputKeyBinding> m_InputBinding;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40020BE")]
	public List<Animator> m_Animator;

	[Token(Token = "0x40020BF")]
	private static int s_OnHash;

	[Token(Token = "0x40020C0")]
	private static int s_OffHash;

	[Token(Token = "0x40020C1")]
	[FieldOffset(Offset = "0x30")]
	private List<Tweener> m_DoColorCache;

	[Address(RVA = "0x5BBCF0", Offset = "0x5BA4F0", Length = "0x230")]
	[Token(Token = "0x600389A")]
	public void SetEnable(bool enable)
	{
	}

	[Address(RVA = "0x5BBA00", Offset = "0x5BA200", Length = "0xB1")]
	[Token(Token = "0x600389B")]
	private void KillAllDoColor()
	{
	}

	[Address(RVA = "0x5BBAC0", Offset = "0x5BA2C0", Length = "0x229")]
	[Token(Token = "0x600389C")]
	public void SetColor(Color c, float fadeTime = 0.1f)
	{
	}

	[Address(RVA = "0x5BB9A0", Offset = "0x5BA1A0", Length = "0x52")]
	[Token(Token = "0x600389D")]
	public bool Contains(GameObject go)
	{
		return default(bool);
	}

	[Address(RVA = "0x5BBFA0", Offset = "0x5BA7A0", Length = "0x11D")]
	[Token(Token = "0x600389E")]
	public UISetColor()
	{
	}
}
