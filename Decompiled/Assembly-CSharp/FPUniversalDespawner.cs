using System.Collections;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000074")]
public class FPUniversalDespawner : MonoBehaviour, IFastPoolItem
{
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400031C")]
	private int targetPoolID;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400031D")]
	[SerializeField]
	private bool despawnDelayed;

	[Token(Token = "0x400031E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float delay;

	[SerializeField]
	[Token(Token = "0x400031F")]
	[FieldOffset(Offset = "0x24")]
	private bool despawnOnParticlesDead;

	[FieldOffset(Offset = "0x25")]
	[Token(Token = "0x4000320")]
	[SerializeField]
	private bool resetParticleSystem;

	[Token(Token = "0x4000321")]
	[SerializeField]
	[FieldOffset(Offset = "0x26")]
	private bool despawnOnAudioSourceStop;

	[Token(Token = "0x4000322")]
	[FieldOffset(Offset = "0x27")]
	private bool needCheck;

	[Token(Token = "0x4000323")]
	[FieldOffset(Offset = "0x28")]
	private AudioSource aSource;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000324")]
	private ParticleSystem pSystem;

	[Token(Token = "0x17000061")]
	public int TargetPoolID
	{
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x44A0E0", Offset = "0x4488E0", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x44A0F0", Offset = "0x4488F0", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x17000062")]
	public bool DespawnDelayed
	{
		[Address(RVA = "0x44A0A0", Offset = "0x4488A0", Length = "0x5")]
		[Token(Token = "0x6000377")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000063")]
	public float Delay
	{
		[Address(RVA = "0x44A090", Offset = "0x448890", Length = "0x6")]
		[Token(Token = "0x6000378")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000064")]
	public bool DespawnOnParticlesDead
	{
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x44A0C0", Offset = "0x4488C0", Length = "0x5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000065")]
	public bool ResetParticleSystem
	{
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x44A0D0", Offset = "0x4488D0", Length = "0x5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000066")]
	public bool DespawnOnAudioSourceStop
	{
		[Address(RVA = "0x44A0B0", Offset = "0x4488B0", Length = "0x5")]
		[Token(Token = "0x600037B")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x449F80", Offset = "0x448780", Length = "0x10E")]
	private void Start()
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x449E70", Offset = "0x448670", Length = "0x10D")]
	public void OnFastInstantiate()
	{
	}

	[Address(RVA = "0x449DD0", Offset = "0x4485D0", Length = "0x9A")]
	[Token(Token = "0x600037E")]
	public void OnFastDestroy()
	{
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x449D50", Offset = "0x448550", Length = "0x77")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x74110", Offset = "0x73510")]
	private IEnumerator Despawn(float despawn_delay)
	{
		return null;
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x74470", Offset = "0x73870")]
	[Address(RVA = "0x449CE0", Offset = "0x4484E0", Length = "0x65")]
	[Token(Token = "0x6000380")]
	private IEnumerator CheckAlive()
	{
		return null;
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000381")]
	public FPUniversalDespawner()
	{
	}
}
