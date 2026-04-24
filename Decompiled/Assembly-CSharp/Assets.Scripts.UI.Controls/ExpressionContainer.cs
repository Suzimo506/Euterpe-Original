using System.Collections.Generic;
using Assets.Scripts.Database;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.Controls;

[Token(Token = "0x20008A7")]
public class ExpressionContainer
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002D18")]
	private byte[] m_MasterRandom;

	[Token(Token = "0x4002D19")]
	[FieldOffset(Offset = "0x18")]
	private byte[] m_ExpressionRandom;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002D1A")]
	private List<Expression> m_Expressions;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002D1B")]
	private List<Expression> m_AutoExpressions;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002D1C")]
	private List<FestivalExpression> m_FestivalExpressions;

	[Token(Token = "0x4002D1D")]
	private const int base_random = 1000;

	[Token(Token = "0x4002D1E")]
	private const byte base_exp = 0;

	[Token(Token = "0x4002D1F")]
	private const byte festival_exp = 1;

	[Token(Token = "0x6004E57")]
	[Address(RVA = "0x5AF0A0", Offset = "0x5AD8A0", Length = "0xA3")]
	public Expression RandomExpression()
	{
		return null;
	}

	[Address(RVA = "0x5AF8C0", Offset = "0x5AE0C0", Length = "0x120")]
	[Token(Token = "0x6004E58")]
	private void SetRandom(byte[] random, List<float> weightBuffer)
	{
	}

	[Address(RVA = "0x5AF370", Offset = "0x5ADB70", Length = "0x1D6")]
	[Token(Token = "0x6004E59")]
	private void RefreshRandom(List<float> typeWeightBuffer)
	{
	}

	[Token(Token = "0x6004E5A")]
	[Address(RVA = "0x5AF150", Offset = "0x5AD950", Length = "0x212")]
	private void RefreshRandom()
	{
	}

	[Token(Token = "0x6004E5B")]
	[Address(RVA = "0x5AF5C0", Offset = "0x5ADDC0", Length = "0x2F1")]
	public void SetExpression(CharacterInfo characterInfo, CharacterFestivalVoiceInfo festivalVoiceInfo = null)
	{
	}

	[Token(Token = "0x6004E5C")]
	[Address(RVA = "0x5AF550", Offset = "0x5ADD50", Length = "0x64")]
	public void SetExpression(List<Expression> expression)
	{
	}

	[Address(RVA = "0x5AF000", Offset = "0x5AD800", Length = "0x9C")]
	[Token(Token = "0x6004E5D")]
	public Expression GetExpression(int index)
	{
		return null;
	}

	[Token(Token = "0x6004E5E")]
	[Address(RVA = "0x5AEF40", Offset = "0x5AD740", Length = "0xB9")]
	public List<Expression> GetAutoExpressions()
	{
		return null;
	}

	[Token(Token = "0x6004E5F")]
	[Address(RVA = "0x5AF9F0", Offset = "0x5AE1F0", Length = "0xA9")]
	public ExpressionContainer()
	{
	}
}
