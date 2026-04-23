using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Variables;

[Token(Token = "0x20005C7")]
public class Text : IVariable, IValue
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002188")]
	[Attribute(Name = "VariableAttribute", RVA = "0x9A600", Offset = "0x99A00")]
	[SerializeField]
	private IVariable m_Name;

	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "VariableAttribute", RVA = "0x9A890", Offset = "0x99C90")]
	[SerializeField]
	[Token(Token = "0x4002189")]
	private IVariable m_Key;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400218A")]
	[Attribute(Name = "VariableAttribute", RVA = "0x9AAB0", Offset = "0x99EB0")]
	[SerializeField]
	private IVariable m_Index;

	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400218B")]
	private bool m_IsPro;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400218C")]
	[SerializeField]
	[Attribute(Name = "VariableAttribute", RVA = "0x9AF70", Offset = "0x9A370")]
	private IVariable m_CompareKey;

	[SerializeField]
	[Attribute(Name = "VariableAttribute", RVA = "0x9B190", Offset = "0x9A590")]
	[Token(Token = "0x400218D")]
	[FieldOffset(Offset = "0x38")]
	private IVariable m_CompareValue;

	[Token(Token = "0x17000545")]
	public string name
	{
		[Address(RVA = "0x9854F0", Offset = "0x983CF0", Length = "0x39")]
		[Token(Token = "0x60039A9")]
		get
		{
			return null;
		}
		[Token(Token = "0x60039AA")]
		[Address(RVA = "0x985A10", Offset = "0x984210", Length = "0x57")]
		set
		{
		}
	}

	[Token(Token = "0x17000546")]
	public string key
	{
		[Address(RVA = "0x9854B0", Offset = "0x983CB0", Length = "0x39")]
		[Token(Token = "0x60039AB")]
		get
		{
			return null;
		}
		[Token(Token = "0x60039AC")]
		[Address(RVA = "0x9859B0", Offset = "0x9841B0", Length = "0x57")]
		set
		{
		}
	}

	[Token(Token = "0x17000547")]
	public int index
	{
		[Address(RVA = "0x985470", Offset = "0x983C70", Length = "0x39")]
		[Token(Token = "0x60039AD")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x985940", Offset = "0x984140", Length = "0x6F")]
		[Token(Token = "0x60039AE")]
		set
		{
		}
	}

	[Token(Token = "0x17000548")]
	public object result
	{
		[Address(RVA = "0x985530", Offset = "0x983D30", Length = "0x405")]
		[Token(Token = "0x60039AF")]
		get
		{
			return null;
		}
		[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
		[Token(Token = "0x60039B0")]
		set
		{
		}
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60039B1")]
	public Text()
	{
	}
}
