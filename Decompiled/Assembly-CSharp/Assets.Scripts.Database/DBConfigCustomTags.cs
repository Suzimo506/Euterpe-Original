using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007B1")]
public class DBConfigCustomTags : BaseDBConfigObject
{
	[Token(Token = "0x2000D05")]
	public class CustomTagInfo : BaseDataObject
	{
		[Token(Token = "0x4003E90")]
		[FieldOffset(Offset = "0x20")]
		public string object_id;

		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4003E91")]
		public DateTime created_at;

		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003E92")]
		public DateTime updated_at;

		[Token(Token = "0x4003E93")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, string> tag_name;

		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4003E94")]
		public string tag_picture;

		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003E95")]
		public string icon_name;

		[Token(Token = "0x4003E96")]
		[FieldOffset(Offset = "0x50")]
		public List<string> music_list;

		[Token(Token = "0x4003E97")]
		[FieldOffset(Offset = "0x58")]
		public bool anchor_pattern;

		[Token(Token = "0x4003E98")]
		[FieldOffset(Offset = "0x5C")]
		public int sort_key;

		[Token(Token = "0x4003E99")]
		[FieldOffset(Offset = "0x60")]
		protected Texture2D m_Image;

		[Token(Token = "0x4003E9A")]
		[FieldOffset(Offset = "0x68")]
		private Coroutine m_ImgCoroutine;

		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4003E9B")]
		private Action<Texture2D> m_Callback;

		[Token(Token = "0x6006335")]
		[Address(RVA = "0x6F2FE0", Offset = "0x6F17E0", Length = "0x165")]
		public void GetIconAsync(Action<Texture2D> callback)
		{
		}

		[Token(Token = "0x6006336")]
		[Address(RVA = "0x6F3150", Offset = "0x6F1950", Length = "0xD3")]
		public void InitCustomTag()
		{
		}

		[Token(Token = "0x6006337")]
		[Address(RVA = "0x6F3230", Offset = "0x6F1A30", Length = "0x65")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x43B0", Offset = "0x37B0")]
		private IEnumerator LoadImg()
		{
			return null;
		}

		[Token(Token = "0x6006338")]
		[Address(RVA = "0x6EF370", Offset = "0x6EDB70", Length = "0x69")]
		public CustomTagInfo()
		{
		}
	}

	[Token(Token = "0x40028A3")]
	[FieldOffset(Offset = "0x38")]
	private List<CustomTagInfo> m_Items;

	[Token(Token = "0x170006CE")]
	protected List<CustomTagInfo> list
	{
		[Token(Token = "0x6004732")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004733")]
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		private set
		{
		}
	}

	[Token(Token = "0x6004734")]
	[Address(RVA = "0x6F81A0", Offset = "0x6F69A0", Length = "0x164")]
	public CustomTagInfo GetCustomTagInfoBySortKey(int sortIndex)
	{
		return null;
	}

	[Token(Token = "0x6004735")]
	[Address(RVA = "0x6F8140", Offset = "0x6F6940", Length = "0x5A")]
	public CustomTagInfo GetCustomTagInfoByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x6004736")]
	[Address(RVA = "0x6F8310", Offset = "0x6F6B10", Length = "0x8C")]
	public DBConfigCustomTags()
	{
	}

	[Address(RVA = "0x6F8030", Offset = "0x6F6830", Length = "0x100")]
	[Token(Token = "0x6004737")]
	public override void Deserialize(string str)
	{
	}
}
