using Cpp2ILInjected;
using DaveGameFramework.GameComponents;

namespace DaveGameFramework.GameActivedObjects.DaveGameNoteInstances;

[Token(Token = "0x20004DB")]
public class DaveGameNote_AfterCutFish : DaveGameBehaviourNote
{
	[Address(RVA = "0x46F1D0", Offset = "0x46D9D0", Length = "0x161")]
	[Token(Token = "0x6003618")]
	public override void ExcuteNoteAction()
	{
	}

	[Address(RVA = "0x46F340", Offset = "0x46DB40", Length = "0x91")]
	[Token(Token = "0x6003619")]
	private void ShowAnimation(DaveGameCharacter character, string resPrefix)
	{
	}

	[Address(RVA = "0x46DD90", Offset = "0x46C590", Length = "0xE")]
	[Token(Token = "0x600361A")]
	public DaveGameNote_AfterCutFish()
	{
	}
}
