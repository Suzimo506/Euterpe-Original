using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x200074B")]
public class ModuleGoods
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400268F")]
	public string name;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002690")]
	public string pic_url;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002691")]
	private Texture2D m_Image;

	[Token(Token = "0x4002692")]
	[FieldOffset(Offset = "0x28")]
	private bool m_IsLocal;

	[Token(Token = "0x4002693")]
	[FieldOffset(Offset = "0x30")]
	public List<ShopInfo> languages;

	[Token(Token = "0x1700066D")]
	public Texture2D image
	{
		[Token(Token = "0x6004448")]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700066E")]
	public string picFileName
	{
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6004449")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x600444A")]
		[Address(RVA = "0x45EEF0", Offset = "0x45D6F0", Length = "0xC")]
		private set
		{
		}
	}

	[Address(RVA = "0x6D9DE0", Offset = "0x6D85E0", Length = "0x21E")]
	[Token(Token = "0x600444B")]
	public ShopInfo GetShopImgInfoByLanguage(string language, bool failGetFirst = false)
	{
		return default(ShopInfo);
	}

	[Token(Token = "0x600444C")]
	[Address(RVA = "0x6DA000", Offset = "0x6D8800", Length = "0x6D")]
	public void Init()
	{
	}

	[Token(Token = "0x600444D")]
	[Address(RVA = "0x6D9CB0", Offset = "0x6D84B0", Length = "0x128")]
	public void AsyncGetImg(Action<Texture2D> callback = null)
	{
	}

	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x91790", Offset = "0x90B90")]
	[Address(RVA = "0x6DA070", Offset = "0x6D8870", Length = "0x81")]
	[Token(Token = "0x600444E")]
	private IEnumerator LoadImg(Action<Texture2D> callback = null)
	{
		return null;
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x600444F")]
	public ModuleGoods()
	{
	}
}
