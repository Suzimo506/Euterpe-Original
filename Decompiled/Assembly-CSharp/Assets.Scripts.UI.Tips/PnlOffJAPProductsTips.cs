using System;
using Assets.Scripts.Database;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Tips;

[Token(Token = "0x2000884")]
public class PnlOffJAPProductsTips : BaseMessageBox
{
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4002C70")]
	[SerializeField]
	private Button m_BtnRestore;

	[Token(Token = "0x4002C71")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private Font[] m_LocalLanguageFont;

	[Token(Token = "0x4002C72")]
	[FieldOffset(Offset = "0x100")]
	private Action m_OnYes;

	[Token(Token = "0x4002C73")]
	[FieldOffset(Offset = "0x108")]
	private string m_AlbumName;

	[Address(RVA = "0x5FCFD0", Offset = "0x5FB7D0", Length = "0x143")]
	[Token(Token = "0x6004D93")]
	public override void AwakeInit()
	{
	}

	[Address(RVA = "0x5FD1A0", Offset = "0x5FB9A0", Length = "0xCD")]
	[Token(Token = "0x6004D94")]
	public void ShowWithProductName(DBConfigAlbums.AlbumsInfo albumName)
	{
	}

	[Address(RVA = "0x4E7B30", Offset = "0x4E6330", Length = "0xF")]
	[Token(Token = "0x6004D95")]
	public void SetButtonAction(Action onYes)
	{
	}

	[Address(RVA = "0x5FD120", Offset = "0x5FB920", Length = "0x80")]
	[Token(Token = "0x6004D96")]
	private void OnClickRestore()
	{
	}

	[Token(Token = "0x6004D97")]
	[Address(RVA = "0x5FD270", Offset = "0x5FBA70", Length = "0x21D")]
	private void SwitchLanguage()
	{
	}

	[Token(Token = "0x6004D98")]
	[Address(RVA = "0x5F96A0", Offset = "0x5F7EA0", Length = "0x51")]
	public PnlOffJAPProductsTips()
	{
	}
}
