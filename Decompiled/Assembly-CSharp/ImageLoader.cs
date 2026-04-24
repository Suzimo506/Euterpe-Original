using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000D9")]
public class ImageLoader : IStorage
{
	[Token(Token = "0x400057B")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, Texture2D> m_MemoryCache;

	[Token(Token = "0x400057C")]
	[FieldOffset(Offset = "0x18")]
	private string m_DiskCachePath;

	[Token(Token = "0x400057D")]
	[FieldOffset(Offset = "0x20")]
	private readonly int m_MaxCacheCount;

	[Token(Token = "0x400057E")]
	[FieldOffset(Offset = "0x28")]
	private LinkedList<string> m_LruList;

	[Token(Token = "0x400057F")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<string, LinkedListNode<string>> m_LruDict;

	[Token(Token = "0x1700008C")]
	private string diskCachePath
	{
		[Address(RVA = "0x5C6B00", Offset = "0x5C5300", Length = "0x5E")]
		[Token(Token = "0x6000647")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000648")]
	[Address(RVA = "0x5C6560", Offset = "0x5C4D60", Length = "0xA3")]
	public void ImageLoad(string url, Action<Texture2D> callback)
	{
	}

	[Token(Token = "0x6000649")]
	[Address(RVA = "0x5C64A0", Offset = "0x5C4CA0", Length = "0xB2")]
	public void ImageLoad(string url, Action<Texture2D> callback, Action failCallback)
	{
	}

	[Token(Token = "0x600064A")]
	[Address(RVA = "0x5C6610", Offset = "0x5C4E10", Length = "0x13D")]
	private bool LoadTexture2DFromLocal(string url, Action<Texture2D> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x600064B")]
	[Address(RVA = "0x5C6280", Offset = "0x5C4A80", Length = "0xB1")]
	private string GetFilePath(string url)
	{
		return null;
	}

	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8850", Offset = "0x7C50")]
	[Token(Token = "0x600064C")]
	[Address(RVA = "0x5C61C0", Offset = "0x5C49C0", Length = "0xBB")]
	private IEnumerator Download(string url, Action<Texture2D> callback, Action failCallback)
	{
		return null;
	}

	[Token(Token = "0x600064D")]
	[Address(RVA = "0x5C6750", Offset = "0x5C4F50", Length = "0x109")]
	private void SavetoDick(string url, Texture2D texture2D)
	{
	}

	[Token(Token = "0x600064E")]
	[Address(RVA = "0x5C6340", Offset = "0x5C4B40", Length = "0x15B")]
	private string GetMD5(string str)
	{
		return null;
	}

	[Address(RVA = "0x5C6860", Offset = "0x5C5060", Length = "0x1CC")]
	[Token(Token = "0x600064F")]
	private void UpdateLRU(string url)
	{
	}

	[Token(Token = "0x6000650")]
	[Address(RVA = "0x5C60A0", Offset = "0x5C48A0", Length = "0x119")]
	public void ClearCache()
	{
	}

	[Address(RVA = "0x5C6A30", Offset = "0x5C5230", Length = "0xCA")]
	[Token(Token = "0x6000651")]
	public ImageLoader()
	{
	}
}
