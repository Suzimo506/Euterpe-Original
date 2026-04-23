using Cpp2ILInjected;
using DaveGameFramework.GameComponents;

namespace DaveGameFramework.GameActivedObjects.DaveGameNoteInstances;

[Token(Token = "0x20004DD")]
public class DaveGameNote_CutFishLight : DaveGameJudgedNote
{
	[Token(Token = "0x6003621")]
	[Address(RVA = "0x998070", Offset = "0x996870", Length = "0x223")]
	public override void ExcuteNoteAction()
	{
	}

	[Token(Token = "0x6003622")]
	[Address(RVA = "0x9982A0", Offset = "0x996AA0", Length = "0x517")]
	public override void JudgeNote()
	{
	}

	[Token(Token = "0x6003623")]
	[Address(RVA = "0x9987C0", Offset = "0x996FC0", Length = "0x19B")]
	private void OnCharacterHitOn(DaveGameCharacter character, int hitType)
	{
	}

	[Token(Token = "0x6003624")]
	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	public DaveGameNote_CutFishLight()
	{
	}
}
