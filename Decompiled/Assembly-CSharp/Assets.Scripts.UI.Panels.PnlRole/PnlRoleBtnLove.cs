using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlRole;

[Token(Token = "0x200095F")]
public class PnlRoleBtnLove : MonoBehaviour
{
	[Token(Token = "0x4003343")]
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	private Button m_BtnLove;

	[SerializeField]
	[Token(Token = "0x4003344")]
	[FieldOffset(Offset = "0x20")]
	private Image m_ImgLike;

	[Token(Token = "0x4003345")]
	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	private Image m_ImageRandom;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4003346")]
	[SerializeField]
	private Sprite m_LikeSprite;

	[SerializeField]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4003347")]
	private Sprite m_DisLikeSprite;

	[Token(Token = "0x4003348")]
	[FieldOffset(Offset = "0x40")]
	private List<bool> m_Loves;

	[Token(Token = "0x4003349")]
	[FieldOffset(Offset = "0x48")]
	private List<string> m_LoveStrs;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400334A")]
	private int m_CurCharacterIndex;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400334B")]
	public Action onChangeLove;

	[Token(Token = "0x400334C")]
	[FieldOffset(Offset = "0x60")]
	private GlobalScriptableObjectData m_GlobalData;

	[Token(Token = "0x170008F8")]
	public GlobalScriptableObjectData globalData
	{
		[Address(RVA = "0x6390E0", Offset = "0x6378E0", Length = "0xBF")]
		[Token(Token = "0x600556D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600556E")]
	[Address(RVA = "0x638B40", Offset = "0x637340", Length = "0x20D")]
	public void Init()
	{
	}

	[Token(Token = "0x600556F")]
	[Address(RVA = "0x638F80", Offset = "0x637780", Length = "0x152")]
	public void ShowLikeDisplay(int characterIndex)
	{
	}

	[Token(Token = "0x6005570")]
	[Address(RVA = "0x638860", Offset = "0x637060", Length = "0x5C")]
	public void ChangeCurIndex(int characterIndex)
	{
	}

	[Address(RVA = "0x6388C0", Offset = "0x6370C0", Length = "0x208")]
	[Token(Token = "0x6005571")]
	public void ChangeCurRoleLove()
	{
	}

	[Token(Token = "0x6005572")]
	[Address(RVA = "0x638E40", Offset = "0x637640", Length = "0x132")]
	private void SendRoleLove()
	{
	}

	[Address(RVA = "0x638AD0", Offset = "0x6372D0", Length = "0x6C")]
	[Token(Token = "0x6005573")]
	public bool GetLoveByCharacterIndex(int characterIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6005574")]
	[Address(RVA = "0x638DE0", Offset = "0x6375E0", Length = "0x5C")]
	public void SaveLove()
	{
	}

	[Token(Token = "0x6005575")]
	[Address(RVA = "0x60BE40", Offset = "0x60A640", Length = "0x2F")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6005576")]
	[Address(RVA = "0x442320", Offset = "0x440B20", Length = "0x2F")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6005577")]
	[Address(RVA = "0x638D50", Offset = "0x637550", Length = "0x89")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6005578")]
	public PnlRoleBtnLove()
	{
	}
}
