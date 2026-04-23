using Assets.Scripts.Database;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000A3")]
public class HomeElfinShowControl : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000460")]
	private int m_SelectElfinIndex;

	[Token(Token = "0x4000461")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_ElfinShowObj;

	[Token(Token = "0x4000462")]
	[FieldOffset(Offset = "0x28")]
	private DBConfigElfin m_ConfigElfin;

	[Token(Token = "0x6000501")]
	[Address(RVA = "0x5C4D40", Offset = "0x5C3540", Length = "0x62")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000502")]
	[Address(RVA = "0x5C4DB0", Offset = "0x5C35B0", Length = "0x1AD")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000503")]
	[Address(RVA = "0x5C4F60", Offset = "0x5C3760", Length = "0xE")]
	public HomeElfinShowControl()
	{
	}
}
