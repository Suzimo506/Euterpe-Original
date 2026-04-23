using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[Token(Token = "0x2000221")]
[Attribute(Name = "AddComponentMenu", RVA = "0x12030", Offset = "0x11430")]
[Attribute(Name = "RequireComponent", RVA = "0x12030", Offset = "0x11430")]
public class PressStartToJoinExample_GamePlayer : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F6D")]
	public int gamePlayerId;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000F6E")]
	public float moveSpeed;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F6F")]
	public float bulletSpeed;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F70")]
	public GameObject bulletPrefab;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000F71")]
	private CharacterController cc;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000F72")]
	private Vector3 moveVector;

	[Token(Token = "0x4000F73")]
	[FieldOffset(Offset = "0x44")]
	private bool fire;

	[Token(Token = "0x17000410")]
	private Player player
	{
		[Address(RVA = "0xF9EBC0", Offset = "0xF9D3C0", Length = "0xA")]
		[Token(Token = "0x600144B")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0xF9E730", Offset = "0xF9CF30", Length = "0x47")]
	[Token(Token = "0x600144C")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0xF9EA60", Offset = "0xF9D260", Length = "0x158")]
	[Token(Token = "0x600144D")]
	private void Update()
	{
	}

	[Address(RVA = "0xF9E690", Offset = "0xF9CE90", Length = "0x9F")]
	[Token(Token = "0x600144E")]
	private void GetInput()
	{
	}

	[Token(Token = "0x600144F")]
	[Address(RVA = "0xF9E780", Offset = "0xF9CF80", Length = "0x2D5")]
	private void ProcessInput()
	{
	}

	[Address(RVA = "0xF93DE0", Offset = "0xF925E0", Length = "0x15")]
	[Token(Token = "0x6001450")]
	public PressStartToJoinExample_GamePlayer()
	{
	}
}
