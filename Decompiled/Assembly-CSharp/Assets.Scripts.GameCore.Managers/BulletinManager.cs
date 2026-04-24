using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000738")]
public class BulletinManager : Singleton<BulletinManager>
{
	[Token(Token = "0x2000CA5")]
	public class Bulletin
	{
		[Token(Token = "0x4003DA1")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		[Token(Token = "0x4003DA2")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		[Token(Token = "0x4003DA3")]
		[FieldOffset(Offset = "0x20")]
		public string content;

		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4003DA4")]
		public string imageUrl;

		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003DA5")]
		public bool force;

		[Token(Token = "0x4003DA6")]
		[FieldOffset(Offset = "0x38")]
		public Texture2D texture;

		[Token(Token = "0x17000ADE")]
		public bool isNew
		{
			[Token(Token = "0x6006232")]
			[Address(RVA = "0x78D250", Offset = "0x78BA50", Length = "0x92")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006233")]
			[Address(RVA = "0x78D2F0", Offset = "0x78BAF0", Length = "0x114")]
			set
			{
			}
		}

		[Address(RVA = "0x78D0F0", Offset = "0x78B8F0", Length = "0xC9")]
		[Token(Token = "0x6006230")]
		public void GetTexture(Action<Texture2D> callback)
		{
		}

		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x82AC0", Offset = "0x81EC0")]
		[Token(Token = "0x6006231")]
		[Address(RVA = "0x78D1C0", Offset = "0x78B9C0", Length = "0x81")]
		private IEnumerator LoadTexture(Action<Texture2D> callback)
		{
			return null;
		}

		[Token(Token = "0x6006234")]
		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		public Bulletin()
		{
		}
	}

	[Token(Token = "0x17000646")]
	public Dictionary<string, List<Bulletin>> bulletins
	{
		[CompilerGenerated]
		[Token(Token = "0x600431F")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
		[Token(Token = "0x600431E")]
		private set
		{
		}
	}

	[Token(Token = "0x6004320")]
	[Address(RVA = "0x78CF60", Offset = "0x78B760", Length = "0x148")]
	public void RefreshBulletin(Action<Dictionary<string, List<Bulletin>>> callback = null)
	{
	}

	[Token(Token = "0x6004321")]
	[Address(RVA = "0x78CC10", Offset = "0x78B410", Length = "0x34B")]
	private void BulletinAdd(JToken announce, Dictionary<string, List<Bulletin>> dic)
	{
	}

	[Address(RVA = "0x78D0B0", Offset = "0x78B8B0", Length = "0x38")]
	[Token(Token = "0x6004322")]
	public BulletinManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
