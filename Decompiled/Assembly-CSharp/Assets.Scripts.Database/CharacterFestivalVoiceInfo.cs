using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007A4")]
public class CharacterFestivalVoiceInfo : BaseDataObject
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002887")]
	public int index;

	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4002888")]
	public float weight;

	[Token(Token = "0x4002889")]
	[FieldOffset(Offset = "0x28")]
	public List<FestivalExpression> expressions;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400288A")]
	public List<FestivalExpression> reviewExpressions;

	[Address(RVA = "0x6F2170", Offset = "0x6F0970", Length = "0xD1")]
	[Token(Token = "0x6004703")]
	private void SetExpression(List<FestivalExpression> expr, List<List<string>> localExpressions)
	{
	}

	[Token(Token = "0x6004704")]
	[Address(RVA = "0x6F1EA0", Offset = "0x6F06A0", Length = "0x2CA")]
	public List<FestivalExpression> GetFestivalExpression()
	{
		return null;
	}

	[Token(Token = "0x6004705")]
	[Address(RVA = "0x6EF370", Offset = "0x6EDB70", Length = "0x69")]
	public CharacterFestivalVoiceInfo()
	{
	}
}
