using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.GameObjectLogics.ExtraControl;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Structs;

[Token(Token = "0x2000589")]
public struct SyncObjectsBuffer
{
	[Token(Token = "0x40020A3")]
	[FieldOffset(Offset = "0x8")]
	private List<GameObject> m_SyncObjectsBuffer;

	[Token(Token = "0x40020A4")]
	[FieldOffset(Offset = "0x10")]
	private List<Animator> m_SyncAnimatorBuffers;

	[Token(Token = "0x40020A5")]
	[FieldOffset(Offset = "0x18")]
	private List<SpineActionController> m_SyncSpineActionControllerBuffers;

	[Token(Token = "0x40020A6")]
	[FieldOffset(Offset = "0x20")]
	private List<RoleBattleSubControl> m_SyncRoleBattleSubControlBuffers;

	[Token(Token = "0x17000524")]
	public bool isInit
	{
		[CompilerGenerated]
		[Token(Token = "0x6003886")]
		[Address(RVA = "0x65E760", Offset = "0x65CF60", Length = "0x4")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x65E780", Offset = "0x65CF80", Length = "0x3")]
		[Token(Token = "0x6003887")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000525")]
	public List<GameObject> syncObjects
	{
		[Address(RVA = "0x65E770", Offset = "0x65CF70", Length = "0x5")]
		[Token(Token = "0x6003888")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000526")]
	public List<SpineActionController> SyncSacs
	{
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		[Token(Token = "0x6003889")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x65E510", Offset = "0x65CD10", Length = "0xEA")]
	[Token(Token = "0x600388A")]
	public void Init()
	{
	}

	[Address(RVA = "0x65E450", Offset = "0x65CC50", Length = "0xB6")]
	[Token(Token = "0x600388B")]
	public void AddSyncObject(GameObject obj, Animator animator, SpineActionController sac, RoleBattleSubControl subControl)
	{
	}

	[Address(RVA = "0x65E600", Offset = "0x65CE00", Length = "0x15B")]
	[Token(Token = "0x600388C")]
	public void SyncPlay(string actionKey, float tick = 0f, bool isOverride = true)
	{
	}
}
