using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Structs;

[Serializable]
[Token(Token = "0x2000574")]
public class MergeGameSceneEgg : GameSceneEgg
{
	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002030")]
	private int[] m_PrerequisiteEggIndexs;

	[Token(Token = "0x600385A")]
	[Address(RVA = "0x656E90", Offset = "0x655690", Length = "0xAC")]
	public bool CheckPrerequisite(List<int> eggIndexs)
	{
		return default(bool);
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x600385B")]
	public MergeGameSceneEgg()
	{
	}
}
