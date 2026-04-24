using System.Collections.Generic;
using System.Reflection;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using NCalc;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Variables;

[Token(Token = "0x20005C4")]
public class Formula : IVariable, IValue
{
	[SerializeField]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400217E")]
	private string m_Expression;

	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400217F")]
	private List<IVariable> m_Params;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002180")]
	private IData m_Data;

	[Token(Token = "0x4002181")]
	[FieldOffset(Offset = "0x28")]
	private Expression m_NcalExpression;

	[Token(Token = "0x4002182")]
	private static MemberInfo m_SetDataMi;

	[Token(Token = "0x17000543")]
	public object result
	{
		[Address(RVA = "0x97C500", Offset = "0x97AD00", Length = "0x7")]
		[Token(Token = "0x6003995")]
		get
		{
			return null;
		}
		[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
		[Token(Token = "0x6003996")]
		set
		{
		}
	}

	[Address(RVA = "0x979F30", Offset = "0x978730", Length = "0x471")]
	[Token(Token = "0x6003997")]
	private object Evaluate()
	{
		return null;
	}

	[Address(RVA = "0x97A3B0", Offset = "0x978BB0", Length = "0x14E")]
	[Token(Token = "0x6003998")]
	private void FieldFunction(string name, FunctionArgs args)
	{
	}

	[Address(RVA = "0x97BDD0", Offset = "0x97A5D0", Length = "0x3FE")]
	[Token(Token = "0x6003999")]
	private void OtherFunction(string name, FunctionArgs args)
	{
	}

	[Token(Token = "0x600399A")]
	[Address(RVA = "0x97A5A0", Offset = "0x978DA0", Length = "0x1820")]
	private void ListFunction(string name, FunctionArgs args)
	{
	}

	[Address(RVA = "0x97A500", Offset = "0x978D00", Length = "0x9F")]
	[Token(Token = "0x600399B")]
	private static Dictionary<string, IVariable> GetIDataFields(object obj)
	{
		return null;
	}

	[Address(RVA = "0x97C1D0", Offset = "0x97A9D0", Length = "0x2B5")]
	[Token(Token = "0x600399C")]
	public static void SetFormulaData(object variable, IData data)
	{
	}

	[Address(RVA = "0x97C490", Offset = "0x97AC90", Length = "0x69")]
	[Token(Token = "0x600399D")]
	public Formula()
	{
	}
}
