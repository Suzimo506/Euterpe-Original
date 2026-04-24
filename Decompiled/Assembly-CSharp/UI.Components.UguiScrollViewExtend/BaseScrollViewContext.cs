using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace UI.Components.UguiScrollViewExtend;

[Token(Token = "0x20001D7")]
public class BaseScrollViewContext<T> where T : class, IScrollItemData
{
	[Token(Token = "0x170000F3")]
	public List<T> ItemDataList
	{
		[CompilerGenerated]
		[Token(Token = "0x6000D3C")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
		[Token(Token = "0x6000D3D")]
		private set
		{
		}
	}

	[Token(Token = "0x170000F4")]
	public T CurSelectItemData
	{
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000D3E")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6000D3F")]
		[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
		private set
		{
		}
	}

	[Token(Token = "0x170000F5")]
	public Action<int> ScrollToIndex
	{
		[Token(Token = "0x6000D40")]
		[CompilerGenerated]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x483E40", Offset = "0x482640", Length = "0xC")]
		[CompilerGenerated]
		[Token(Token = "0x6000D41")]
		set
		{
		}
	}

	[Token(Token = "0x170000F6")]
	public Action<T> ScrollToItem
	{
		[Token(Token = "0x6000D42")]
		[CompilerGenerated]
		[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x48F110", Offset = "0x48D910", Length = "0xC")]
		[Token(Token = "0x6000D43")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170000F7")]
	public Action<T> SelectItem
	{
		[CompilerGenerated]
		[Token(Token = "0x6000D44")]
		[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D45")]
		[Address(RVA = "0x45EF10", Offset = "0x45D710", Length = "0xC")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170000F8")]
	public Action<T> RemoveItem
	{
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		[Token(Token = "0x6000D46")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Address(RVA = "0x45EEF0", Offset = "0x45D6F0", Length = "0xC")]
		[Token(Token = "0x6000D47")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170000F9")]
	public Action<T, int> AddItem
	{
		[CompilerGenerated]
		[Token(Token = "0x6000D48")]
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D49")]
		[Address(RVA = "0x4434D0", Offset = "0x441CD0", Length = "0xC")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170000FA")]
	public Action<T, T> ChangeItemData
	{
		[Token(Token = "0x6000D4A")]
		[CompilerGenerated]
		[Address(RVA = "0x46EF30", Offset = "0x46D730", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6000D4B")]
		[Address(RVA = "0x637D40", Offset = "0x636540", Length = "0xC")]
		set
		{
		}
	}

	[Address(RVA = "0x1441E00", Offset = "0x1440600", Length = "0x26")]
	[Token(Token = "0x6000D4C")]
	public void SetSelectItem(T item)
	{
	}

	[Token(Token = "0x6000D4D")]
	[Address(RVA = "0x135EED0", Offset = "0x135D6D0", Length = "0x27")]
	public void RefreshItemDatas(List<T> newItemDataList)
	{
	}

	[Token(Token = "0x6000D4E")]
	[Address(RVA = "0x16EBEF0", Offset = "0x16EA6F0", Length = "0x6E")]
	public void ClearData()
	{
	}

	[Token(Token = "0x6000D4F")]
	[Address(RVA = "0xC25360", Offset = "0xC23B60", Length = "0x19")]
	public BaseScrollViewContext()
	{
	}
}
