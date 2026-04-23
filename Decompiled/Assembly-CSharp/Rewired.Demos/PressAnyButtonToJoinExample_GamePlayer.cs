using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[Attribute(Name = "AddComponentMenu", RVA = "0x11AF0", Offset = "0x10EF0")]
[Token(Token = "0x200021F")]
[Attribute(Name = "RequireComponent", RVA = "0x11AF0", Offset = "0x10EF0")]
public class PressAnyButtonToJoinExample_GamePlayer : MonoBehaviour
{
	[Token(Token = "0x4000F62")]
	[FieldOffset(Offset = "0x18")]
	public int playerId;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000F63")]
	public float moveSpeed;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F64")]
	public float bulletSpeed;

	[Token(Token = "0x4000F65")]
	[FieldOffset(Offset = "0x28")]
	public GameObject bulletPrefab;

	[Token(Token = "0x4000F66")]
	[FieldOffset(Offset = "0x30")]
	private CharacterController cc;

	[Token(Token = "0x4000F67")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 moveVector;

	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000F68")]
	private bool fire;

	[Token(Token = "0x1700040F")]
	private Player player
	{
		[Token(Token = "0x600143F")]
		[Address(RVA = "0xF9DE70", Offset = "0xF9C670", Length = "0xD9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001440")]
	[Address(RVA = "0xF9D9E0", Offset = "0xF9C1E0", Length = "0x47")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001441")]
	[Address(RVA = "0xF9DD10", Offset = "0xF9C510", Length = "0x158")]
	private void Update()
	{
	}

	[Token(Token = "0x6001442")]
	[Address(RVA = "0xF9D940", Offset = "0xF9C140", Length = "0x9F")]
	private void GetInput()
	{
	}

	[Address(RVA = "0xF9DA30", Offset = "0xF9C230", Length = "0x2D5")]
	[Token(Token = "0x6001443")]
	private void ProcessInput()
	{
	}

	[Address(RVA = "0xF93DE0", Offset = "0xF925E0", Length = "0x15")]
	[Token(Token = "0x6001444")]
	public PressAnyButtonToJoinExample_GamePlayer()
	{
	}
}
