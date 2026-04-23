using Cpp2ILInjected;
using DaveGameFramework.GameComponents;
using DaveGameFramework.GameComponents.AnimaControl;
using PeroPeroGames.GlobalDefines;

namespace DaveGameFramework.GameActivedObjects.DaveGameNoteInstances;

[Token(Token = "0x20004DF")]
public class DaveGameNote_DishedFishShow : DaveGameBehaviourNote
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001A68")]
	private DaveGameFishHandleState m_FishHandleState;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001A69")]
	private DaveGameCharacter m_OperatingRole;

	[Token(Token = "0x6003628")]
	[Address(RVA = "0x999070", Offset = "0x997870", Length = "0x83")]
	public override void ExcuteNoteAction()
	{
	}

	[Address(RVA = "0x999210", Offset = "0x997A10", Length = "0x3F4")]
	[Token(Token = "0x6003629")]
	private void RefreshGameSceneNoteJudgeData()
	{
	}

	[Address(RVA = "0x999100", Offset = "0x997900", Length = "0xD8")]
	[Token(Token = "0x600362A")]
	private (FishType, DishType) GetFishHandleDefines(BmsNodeUid bmsNodeUid)
	{
		return default((FishType, DishType));
	}

	[Token(Token = "0x600362B")]
	[Address(RVA = "0x999060", Offset = "0x997860", Length = "0x7")]
	public DaveGameNote_DishedFishShow()
	{
	}
}
