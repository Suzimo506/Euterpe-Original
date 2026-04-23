using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.GameCore.HostComponent;

[Token(Token = "0x200072B")]
public class BattleEnemyManager : Singleton<BattleEnemyManager>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400258A")]
	private int m_CurrentGenIdx;

	[Token(Token = "0x400258B")]
	[FieldOffset(Offset = "0x18")]
	private int[] m_Hp;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400258C")]
	private byte[] m_Evaluates;

	[Token(Token = "0x400258D")]
	[FieldOffset(Offset = "0x28")]
	private bool[] m_LeftRight;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400258E")]
	public bool isAirPressing;

	[Token(Token = "0x400258F")]
	[FieldOffset(Offset = "0x31")]
	public bool isGroundPressing;

	[Token(Token = "0x4002590")]
	[FieldOffset(Offset = "0x32")]
	public bool isCharacterGroundHitting;

	[Token(Token = "0x4002591")]
	[FieldOffset(Offset = "0x33")]
	public bool isCharacterAirHitting;

	[Token(Token = "0x4002592")]
	[FieldOffset(Offset = "0x34")]
	public bool isGhostHitting;

	[Token(Token = "0x4002593")]
	[FieldOffset(Offset = "0x35")]
	public bool isGhostOnAir;

	[FieldOffset(Offset = "0x36")]
	[Token(Token = "0x4002594")]
	public bool isMulHitting;

	[Token(Token = "0x4002595")]
	[FieldOffset(Offset = "0x38")]
	public float damageRatio;

	[Address(RVA = "0x789750", Offset = "0x787F50", Length = "0x19")]
	[Token(Token = "0x6004244")]
	public void Init()
	{
	}

	[Token(Token = "0x6004245")]
	[Address(RVA = "0x789CC0", Offset = "0x7884C0", Length = "0xA4")]
	public static void ReleaseReferences()
	{
	}

	[Address(RVA = "0x789700", Offset = "0x787F00", Length = "0x41")]
	[Token(Token = "0x6004246")]
	public byte GetPlayResult(int idx)
	{
		return default(byte);
	}

	[Address(RVA = "0x7897B0", Offset = "0x787FB0", Length = "0x44")]
	[Token(Token = "0x6004247")]
	public bool IsPlayLeft(int idx)
	{
		return default(bool);
	}

	[Address(RVA = "0x789770", Offset = "0x787F70", Length = "0x39")]
	[Token(Token = "0x6004248")]
	public bool IsDead(int idx)
	{
		return default(bool);
	}

	[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
	[Token(Token = "0x6004249")]
	public int GetCurrentGenIdx()
	{
		return default(int);
	}

	[Address(RVA = "0x789170", Offset = "0x787970", Length = "0x1DF")]
	[Token(Token = "0x600424A")]
	public int GetDamageValueByIndex(int idx)
	{
		return default(int);
	}

	[Token(Token = "0x600424B")]
	[Address(RVA = "0x789500", Offset = "0x787D00", Length = "0xF7")]
	public string GetNodeAudioByIdx(int idx)
	{
		return null;
	}

	[Token(Token = "0x600424C")]
	[Address(RVA = "0x789600", Offset = "0x787E00", Length = "0xF7")]
	public string GetNodeUidByIdx(int idx)
	{
		return null;
	}

	[Token(Token = "0x600424D")]
	[Address(RVA = "0x789350", Offset = "0x787B50", Length = "0x1A2")]
	public string GetHitEffectByIdx(int idx)
	{
		return null;
	}

	[Token(Token = "0x600424E")]
	[Address(RVA = "0x789E70", Offset = "0x788670", Length = "0xF9")]
	public void SetPlayResult(int idx, byte result, bool isMulStart = false, bool isMulEnd = false, bool isLeft = false)
	{
	}

	[Token(Token = "0x600424F")]
	[Address(RVA = "0x789D70", Offset = "0x788570", Length = "0xFA")]
	public void SetLongPressEffect(bool isTo, bool isAir = false, bool isForce = false)
	{
	}

	[Address(RVA = "0x788CA0", Offset = "0x7874A0", Length = "0x35")]
	[Token(Token = "0x6004250")]
	public void AddHp(int idx, int value)
	{
	}

	[Token(Token = "0x6004251")]
	[Address(RVA = "0x788CE0", Offset = "0x7874E0", Length = "0x29B")]
	public void CreateBattleEnemy(int idx)
	{
	}

	[Token(Token = "0x6004252")]
	[Address(RVA = "0x789970", Offset = "0x788170", Length = "0x34F")]
	public void PreloadCreateBattleEnemy()
	{
	}

	[Token(Token = "0x6004253")]
	[Address(RVA = "0x788F80", Offset = "0x787780", Length = "0x1EC")]
	private void CreateObj(int idx, bool isVisible = true)
	{
	}

	[Address(RVA = "0x789800", Offset = "0x788000", Length = "0x16B")]
	[Token(Token = "0x6004254")]
	private void ObjInit(GameObject obj, int idx, bool isVisible)
	{
	}

	[Address(RVA = "0x789F70", Offset = "0x788770", Length = "0x3F")]
	[Token(Token = "0x6004255")]
	public BattleEnemyManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
