using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Graphics;

[Token(Token = "0x20006EC")]
[Attribute(Name = "RequireComponent", RVA = "0x6F780", Offset = "0x6EB80")]
public class ChangeMaterialColor : MonoBehaviour
{
	[Token(Token = "0x400252D")]
	[FieldOffset(Offset = "0x18")]
	public string propertyName;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400252E")]
	private Material m_Mtr;

	[Token(Token = "0x17000602")]
	public Color color
	{
		[Address(RVA = "0xC6EFC0", Offset = "0xC6D7C0", Length = "0x3A")]
		[Token(Token = "0x6004169")]
		get
		{
			return default(Color);
		}
		[Address(RVA = "0xC6F000", Offset = "0xC6D800", Length = "0x33")]
		[Token(Token = "0x600416A")]
		set
		{
		}
	}

	[Token(Token = "0x6004168")]
	[Address(RVA = "0xC6EF60", Offset = "0xC6D760", Length = "0x5B")]
	private void Awake()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600416B")]
	public ChangeMaterialColor()
	{
	}
}
