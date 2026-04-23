using Assets.Scripts.UI.Controls;
using Cpp2ILInjected;

[Token(Token = "0x20000A4")]
public class PirateCharacterApply : CharacterApply
{
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000463")]
	private bool m_IsCrying;

	[Token(Token = "0x6000504")]
	[Address(RVA = "0x4F9410", Offset = "0x4F7C10", Length = "0x13A")]
	protected override void PreCharacterApply(string animName)
	{
	}

	[Address(RVA = "0x4F9550", Offset = "0x4F7D50", Length = "0x11A")]
	[Token(Token = "0x6000505")]
	protected override void ResetCharaterApply()
	{
	}

	[Token(Token = "0x6000506")]
	[Address(RVA = "0x4F9310", Offset = "0x4F7B10", Length = "0xFF")]
	private float CaculateFadeTime(float time)
	{
		return default(float);
	}

	[Token(Token = "0x6000507")]
	[Address(RVA = "0x4F9670", Offset = "0x4F7E70", Length = "0x7")]
	public PirateCharacterApply()
	{
	}
}
