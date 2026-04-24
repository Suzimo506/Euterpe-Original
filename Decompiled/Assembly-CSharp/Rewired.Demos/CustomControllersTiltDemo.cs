using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[Attribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
[Token(Token = "0x2000213")]
public class CustomControllersTiltDemo : MonoBehaviour
{
	[Token(Token = "0x4000F15")]
	[FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x4000F16")]
	[FieldOffset(Offset = "0x20")]
	public float speed;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F17")]
	private CustomController controller;

	[Token(Token = "0x4000F18")]
	[FieldOffset(Offset = "0x30")]
	private Player player;

	[Token(Token = "0x60013DD")]
	[Address(RVA = "0xF90770", Offset = "0xF8EF70", Length = "0x11C")]
	private void Awake()
	{
	}

	[Address(RVA = "0xF90920", Offset = "0xF8F120", Length = "0x1ED")]
	[Token(Token = "0x60013DE")]
	private void Update()
	{
	}

	[Address(RVA = "0xF90890", Offset = "0xF8F090", Length = "0x82")]
	[Token(Token = "0x60013DF")]
	private void OnInputUpdate()
	{
	}

	[Token(Token = "0x60013E0")]
	[Address(RVA = "0xF90B10", Offset = "0xF8F310", Length = "0xE")]
	public CustomControllersTiltDemo()
	{
	}
}
