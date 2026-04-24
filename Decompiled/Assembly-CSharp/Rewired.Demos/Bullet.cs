using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[Token(Token = "0x2000222")]
[Attribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
public class Bullet : MonoBehaviour
{
	[Token(Token = "0x4000F74")]
	[FieldOffset(Offset = "0x18")]
	public float lifeTime;

	[Token(Token = "0x4000F75")]
	[FieldOffset(Offset = "0x1C")]
	private bool die;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F76")]
	private float deathTime;

	[Token(Token = "0x6001451")]
	[Address(RVA = "0x5576C0", Offset = "0x555EC0", Length = "0x31")]
	private void Start()
	{
	}

	[Token(Token = "0x6001452")]
	[Address(RVA = "0x557700", Offset = "0x555F00", Length = "0x77")]
	private void Update()
	{
	}

	[Address(RVA = "0x557780", Offset = "0x555F80", Length = "0xE")]
	[Token(Token = "0x6001453")]
	public Bullet()
	{
	}
}
