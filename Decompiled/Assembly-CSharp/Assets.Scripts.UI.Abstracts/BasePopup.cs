using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using PeroTools2.UI;

namespace Assets.Scripts.UI.Abstracts;

[Token(Token = "0x20008C6")]
public abstract class BasePopup<T1> : Popup, IPopup<T1>
{
	[Token(Token = "0x1700088A")]
	public T1 Value1
	{
		[Token(Token = "0x6004F09")]
		[Address(RVA = "0x4E8C20", Offset = "0x4E7420", Length = "0x8")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6004F0A")]
		[Address(RVA = "0x4E7B30", Offset = "0x4E6330", Length = "0xF")]
		set
		{
		}
	}

	[Token(Token = "0x6004F0B")]
	[Address(RVA = "0x135BBD0", Offset = "0x135A3D0", Length = "0x52")]
	public virtual void SetAndRendDatas(T1 v1)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6004F0C")]
	protected virtual void RegistClickEvts()
	{
	}

	[Token(Token = "0x6004F0D")]
	[Address(RVA = "0x0", Length = "0x0")]
	protected abstract void RendDatasToUI();

	[Token(Token = "0x6004F0E")]
	[Address(RVA = "0x135BC30", Offset = "0x135A430", Length = "0x5B")]
	protected BasePopup()
	{
	}
}
[Token(Token = "0x20008C8")]
public abstract class BasePopup<T1, T2> : Popup, IPopup<T1, T2>
{
	[Token(Token = "0x1700088D")]
	public T1 Value1
	{
		[Address(RVA = "0x4E8C20", Offset = "0x4E7420", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6004F14")]
		get
		{
			return (T1)null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6004F15")]
		[Address(RVA = "0x4E7B30", Offset = "0x4E6330", Length = "0xF")]
		set
		{
		}
	}

	[Token(Token = "0x1700088E")]
	public T2 Value2
	{
		[Address(RVA = "0x135BEF0", Offset = "0x135A6F0", Length = "0x26")]
		[CompilerGenerated]
		[Token(Token = "0x6004F16")]
		get
		{
			return (T2)null;
		}
		[CompilerGenerated]
		[Address(RVA = "0x135BF30", Offset = "0x135A730", Length = "0x26")]
		[Token(Token = "0x6004F17")]
		set
		{
		}
	}

	[Token(Token = "0x6004F18")]
	[Address(RVA = "0x135BC90", Offset = "0x135A490", Length = "0xA7")]
	public virtual void SetAndRendDatas(T1 v1, T2 v2)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6004F19")]
	protected virtual void RegistClickEvts()
	{
	}

	[Token(Token = "0x6004F1A")]
	[Address(RVA = "0x0", Length = "0x0")]
	protected abstract void RendDatasToUI();

	[Token(Token = "0x6004F1B")]
	[Address(RVA = "0x135BDD0", Offset = "0x135A5D0", Length = "0x5B")]
	protected BasePopup()
	{
	}
}
