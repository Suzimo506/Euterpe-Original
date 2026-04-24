using Cpp2ILInjected;
using DaveGameFramework.GameComponents.AnimaControl;
using PeroPeroGames.GlobalDefines;

namespace DaveGameFramework.GameActivedObjects.DaveGameNoteInstances;

[Token(Token = "0x20004DE")]
public class DaveGameNote_DishFinished : DaveGameBehaviourNote
{
	[Token(Token = "0x6003625")]
	[Address(RVA = "0x998960", Offset = "0x997160", Length = "0x6C1")]
	public override void ExcuteNoteAction()
	{
	}

	[Address(RVA = "0x999030", Offset = "0x997830", Length = "0x28")]
	[Token(Token = "0x6003626")]
	private DishType GetDishType(BmsNodeUid nodeUid)
	{
		return default(DishType);
	}

	[Address(RVA = "0x999060", Offset = "0x997860", Length = "0x7")]
	[Token(Token = "0x6003627")]
	public DaveGameNote_DishFinished()
	{
	}
}
