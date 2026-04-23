using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.Components.UguiScrollViewExtend;

[Token(Token = "0x20001D6")]
public abstract class BaseScrollItem<T, TContext> : MonoBehaviour where T : class, IScrollItemData where TContext : BaseScrollViewContext<T>, new()
{
	[Token(Token = "0x170000F1")]
	public T Data
	{
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		[Token(Token = "0x6000D32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
		[Token(Token = "0x6000D33")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x170000F2")]
	public TContext Context
	{
		[CompilerGenerated]
		[Token(Token = "0x6000D34")]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
		[Address(RVA = "0x483E40", Offset = "0x482640", Length = "0xC")]
		[CompilerGenerated]
		[Token(Token = "0x6000D35")]
		private set
		{
		}
	}

	[Address(RVA = "0x1441E00", Offset = "0x1440600", Length = "0x26")]
	[Token(Token = "0x6000D36")]
	public virtual void Init(TContext context = null)
	{
	}

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6000D37")]
	public abstract void UpdateData(T data);

	[Token(Token = "0x6000D38")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void Release()
	{
	}

	[Token(Token = "0x6000D39")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void Select()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6000D3A")]
	public virtual void UnSelect()
	{
	}

	[Address(RVA = "0x1361E30", Offset = "0x1360630", Length = "0x19")]
	[Token(Token = "0x6000D3B")]
	protected BaseScrollItem()
	{
	}
}
