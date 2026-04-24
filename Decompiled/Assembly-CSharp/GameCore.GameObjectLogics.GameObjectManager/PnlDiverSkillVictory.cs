using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;

namespace GameCore.GameObjectLogics.GameObjectManager;

[Token(Token = "0x200047A")]
public class PnlDiverSkillVictory : SingletonMonoBehaviour<PnlDiverSkillVictory>
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001839")]
	public List<PnlDaveFishInfo> pnlDaveFishInfos;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400183A")]
	public float daveFishInfoShowAndSaveDelay;

	[Token(Token = "0x6003375")]
	[Address(RVA = "0x90B150", Offset = "0x909950", Length = "0xFE")]
	public void SetDaveFishInfo(DaveFishData daveFishData)
	{
	}

	[Address(RVA = "0x90B0E0", Offset = "0x9098E0", Length = "0x6F")]
	[Token(Token = "0x6003376")]
	public void SetDaveFishInfoShowAndSave()
	{
	}

	[Address(RVA = "0x90B070", Offset = "0x909870", Length = "0x65")]
	[Token(Token = "0x6003377")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x416A0", Offset = "0x40AA0")]
	private IEnumerator SetDaveFishInfoShowAndSaveWithDelay()
	{
		return null;
	}

	[Address(RVA = "0x90B250", Offset = "0x909A50", Length = "0x3F")]
	[Token(Token = "0x6003378")]
	public PnlDiverSkillVictory()
	{
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
	}
}
