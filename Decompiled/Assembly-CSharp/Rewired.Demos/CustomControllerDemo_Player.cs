using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[Token(Token = "0x2000215")]
[Attribute(Name = "RequireComponent", RVA = "0xD3C0", Offset = "0xC7C0")]
[Attribute(Name = "AddComponentMenu", RVA = "0xD3C0", Offset = "0xC7C0")]
public class CustomControllerDemo_Player : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F24")]
	public int playerId;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000F25")]
	public float speed;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F26")]
	public float bulletSpeed;

	[Token(Token = "0x4000F27")]
	[FieldOffset(Offset = "0x28")]
	public GameObject bulletPrefab;

	[Token(Token = "0x4000F28")]
	[FieldOffset(Offset = "0x30")]
	private Player _player;

	[Token(Token = "0x4000F29")]
	[FieldOffset(Offset = "0x38")]
	private CharacterController cc;

	[Token(Token = "0x1700040A")]
	private Player player
	{
		[Token(Token = "0x60013EC")]
		[Address(RVA = "0xF90510", Offset = "0xF8ED10", Length = "0x8B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60013ED")]
	[Address(RVA = "0xF8FF80", Offset = "0xF8E780", Length = "0x47")]
	private void Awake()
	{
	}

	[Token(Token = "0x60013EE")]
	[Address(RVA = "0xF8FFD0", Offset = "0xF8E7D0", Length = "0x515")]
	private void Update()
	{
	}

	[Token(Token = "0x60013EF")]
	[Address(RVA = "0xF904F0", Offset = "0xF8ECF0", Length = "0x15")]
	public CustomControllerDemo_Player()
	{
	}
}
