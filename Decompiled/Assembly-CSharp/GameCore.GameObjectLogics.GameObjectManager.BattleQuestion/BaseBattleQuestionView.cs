using Cpp2ILInjected;
using UnityEngine;

namespace GameCore.GameObjectLogics.GameObjectManager.BattleQuestion;

[Token(Token = "0x200047B")]
public abstract class BaseBattleQuestionView : MonoBehaviour
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6003379")]
	public abstract void RefreshUI();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x600337A")]
	public abstract void SetAnswerState(bool isRight, bool charaIsAir);

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x600337B")]
	public virtual void SetVisible(bool isVisible)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600337C")]
	protected BaseBattleQuestionView()
	{
	}
}
