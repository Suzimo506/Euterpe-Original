using System.Collections.Generic;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Common.SceneEgg;

[Token(Token = "0x200098E")]
public abstract class SceneEggAbstractController : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4003444")]
	[FieldOffset(Offset = "0x18")]
	protected List<GameSceneEgg> m_SceneEggs;

	[SerializeField]
	[Token(Token = "0x4003445")]
	[FieldOffset(Offset = "0x20")]
	protected List<MergeGameSceneEgg> m_MergeSceneEggs;

	[Token(Token = "0x60056DD")]
	[Address(RVA = "0x7029C0", Offset = "0x7011C0", Length = "0x284")]
	public void Init()
	{
	}

	[Token(Token = "0x60056DE")]
	[Address(RVA = "0x702DA0", Offset = "0x7015A0", Length = "0x1BC")]
	protected virtual void SceneEggHandle(List<int> sceneEggIdsBuffer)
	{
	}

	[Token(Token = "0x60056DF")]
	[Address(RVA = "0x702C50", Offset = "0x701450", Length = "0x149")]
	protected virtual void NormalSceneEggHandler(List<int> sceneEggIdsBuffer)
	{
	}

	[Token(Token = "0x60056E0")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	protected SceneEggAbstractController()
	{
	}
}
