using Cpp2ILInjected;

namespace Assets.Scripts.UI.Abstracts;

[Token(Token = "0x20008C5")]
public interface IPopup<T1>
{
	[Token(Token = "0x17000889")]
	T1 Value1
	{
		[Token(Token = "0x6004F06")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
		[Token(Token = "0x6004F07")]
		[Address(RVA = "0x0", Length = "0x0")]
		set;
	}

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6004F08")]
	void SetAndRendDatas(T1 v1);
}
[Token(Token = "0x20008C7")]
public interface IPopup<T1, T2>
{
	[Token(Token = "0x1700088B")]
	T1 Value1
	{
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6004F0F")]
		get;
		[Address(RVA = "0x0", Length = "0x0")]
		[Token(Token = "0x6004F10")]
		set;
	}

	[Token(Token = "0x1700088C")]
	T2 Value2
	{
		[Token(Token = "0x6004F11")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
		[Token(Token = "0x6004F12")]
		[Address(RVA = "0x0", Length = "0x0")]
		set;
	}

	[Token(Token = "0x6004F13")]
	[Address(RVA = "0x0", Length = "0x0")]
	void SetAndRendDatas(T1 v1, T2 v2);
}
