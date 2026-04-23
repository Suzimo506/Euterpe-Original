using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xE950", Offset = "0xDD50")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xE950", Offset = "0xDD50")]
[Token(Token = "0x2000219")]
public class EightPlayersExample_Player : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F3E")]
	public int playerId;

	[Token(Token = "0x4000F3F")]
	[FieldOffset(Offset = "0x1C")]
	public float moveSpeed;

	[Token(Token = "0x4000F40")]
	[FieldOffset(Offset = "0x20")]
	public float bulletSpeed;

	[Token(Token = "0x4000F41")]
	[FieldOffset(Offset = "0x28")]
	public GameObject bulletPrefab;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000F42")]
	private Player player;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000F43")]
	private CharacterController cc;

	[Token(Token = "0x4000F44")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 moveVector;

	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000F45")]
	private bool fire;

	[NonSerialized]
	[Token(Token = "0x4000F46")]
	[FieldOffset(Offset = "0x4D")]
	private bool initialized;

	[Token(Token = "0x6001410")]
	[Address(RVA = "0xF93800", Offset = "0xF92000", Length = "0x47")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001411")]
	[Address(RVA = "0xF938E0", Offset = "0xF920E0", Length = "0x7A")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6001412")]
	[Address(RVA = "0xF93C40", Offset = "0xF92440", Length = "0x19F")]
	private void Update()
	{
	}

	[Address(RVA = "0xF93850", Offset = "0xF92050", Length = "0x84")]
	[Token(Token = "0x6001413")]
	private void GetInput()
	{
	}

	[Address(RVA = "0xF93960", Offset = "0xF92160", Length = "0x2D5")]
	[Token(Token = "0x6001414")]
	private void ProcessInput()
	{
	}

	[Address(RVA = "0xF93DE0", Offset = "0xF925E0", Length = "0x15")]
	[Token(Token = "0x6001415")]
	public EightPlayersExample_Player()
	{
	}
}
