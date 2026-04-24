using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Components.UguiScrollViewExtend;

[Token(Token = "0x20001D9")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x61670", Offset = "0x60A70")]
public abstract class ScrollViewEx<T, TContext> : MonoBehaviour where T : class, IScrollItemData where TContext : BaseScrollViewContext<T>, new()
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BB2")]
	[SerializeField]
	protected GameObject m_ItemPrefab;

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BB3")]
	[SerializeField]
	protected RectTransform m_Content;

	[Token(Token = "0x4000BB4")]
	[FieldOffset(Offset = "0x0")]
	protected ScrollRect m_ScrollRect;

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BB5")]
	protected List<T> m_ItemDataList;

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BB6")]
	protected List<BaseScrollItem<T, TContext>> m_ItemList;

	[Token(Token = "0x4000BB7")]
	[FieldOffset(Offset = "0x0")]
	private GameObject m_ItemRoot;

	[Token(Token = "0x170000FB")]
	public TContext Context
	{
		[CompilerGenerated]
		[Token(Token = "0x6000D50")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
		[Token(Token = "0x6000D51")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event Action<T> onItemSelected
	{
		[Token(Token = "0x6000D52")]
		[Address(RVA = "0x14939D0", Offset = "0x14921D0", Length = "0xBC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000D53")]
		[Address(RVA = "0x1493B50", Offset = "0x1492350", Length = "0xBC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000C")]
	public event Action<T> onItemBeforeRemoved
	{
		[CompilerGenerated]
		[Address(RVA = "0x16F1190", Offset = "0x16EF990", Length = "0xBC")]
		[Token(Token = "0x6000D54")]
		add
		{
		}
		[Token(Token = "0x6000D55")]
		[Address(RVA = "0x16F13D0", Offset = "0x16EFBD0", Length = "0xBC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event Action<T> onItemRemoved
	{
		[Address(RVA = "0x16F1250", Offset = "0x16EFA50", Length = "0xBC")]
		[Token(Token = "0x6000D56")]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6000D57")]
		[Address(RVA = "0x16F1490", Offset = "0x16EFC90", Length = "0xBC")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public event Action<T> onItemAdded
	{
		[Address(RVA = "0x16F10D0", Offset = "0x16EF8D0", Length = "0xBC")]
		[CompilerGenerated]
		[Token(Token = "0x6000D58")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6000D59")]
		[Address(RVA = "0x16F1310", Offset = "0x16EFB10", Length = "0xBC")]
		remove
		{
		}
	}

	[Address(RVA = "0x16EFF10", Offset = "0x16EE710", Length = "0x16E")]
	[Token(Token = "0x6000D5A")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x6000D5B")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void Release()
	{
	}

	[Token(Token = "0x6000D5C")]
	[Address(RVA = "0x16F0080", Offset = "0x16EE880", Length = "0xEB")]
	public virtual void RefreshData(List<T> itemDataList)
	{
	}

	[Token(Token = "0x6000D5D")]
	[Address(RVA = "0x16F09A0", Offset = "0x16EF1A0", Length = "0x129")]
	public virtual void SelectItem(T item)
	{
	}

	[Token(Token = "0x6000D5E")]
	[Address(RVA = "0x16F0870", Offset = "0x16EF070", Length = "0x123")]
	public virtual void ScrollToItem(T item)
	{
	}

	[Address(RVA = "0x16F0820", Offset = "0x16EF020", Length = "0x4A")]
	[Token(Token = "0x6000D5F")]
	public virtual void ScrollToIndex(int index)
	{
	}

	[Address(RVA = "0x16EFAB0", Offset = "0x16EE2B0", Length = "0xEA")]
	[Token(Token = "0x6000D60")]
	public void ChangeItemData(T originalItemData, T changedItemData)
	{
	}

	[Address(RVA = "0x16EFBA0", Offset = "0x16EE3A0", Length = "0xD6")]
	[Token(Token = "0x6000D61")]
	public void ChangeItemData(int originalItemIdx, T changedItemData)
	{
	}

	[Address(RVA = "0x16EF820", Offset = "0x16EE020", Length = "0x281")]
	[Token(Token = "0x6000D62")]
	public virtual void AddItem(T addItem, int addIndex = -1)
	{
	}

	[Token(Token = "0x6000D63")]
	[Address(RVA = "0x16F0510", Offset = "0x16EED10", Length = "0x30F")]
	public virtual void RemoveItem(T removeItem)
	{
	}

	[Address(RVA = "0x16EFC80", Offset = "0x16EE480", Length = "0x286")]
	[Token(Token = "0x6000D64")]
	public virtual void ClearSelect()
	{
	}

	[Address(RVA = "0x16F0BC0", Offset = "0x16EF3C0", Length = "0x50F")]
	[Token(Token = "0x6000D65")]
	protected virtual void UpdateContent()
	{
	}

	[Address(RVA = "0x16F0170", Offset = "0x16EE970", Length = "0x39F")]
	[Token(Token = "0x6000D66")]
	protected virtual void RegisterActions()
	{
	}

	[Token(Token = "0x6000D67")]
	[Address(RVA = "0x1361E30", Offset = "0x1360630", Length = "0x19")]
	protected ScrollViewEx()
	{
	}
}
