using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[Token(Token = "0x200021E")]
[Attribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
public class PressAnyButtonToJoinExample_Assigner : MonoBehaviour
{
	[Token(Token = "0x600143A")]
	[Address(RVA = "0xF9D880", Offset = "0xF9C080", Length = "0xB1")]
	private void Update()
	{
	}

	[Token(Token = "0x600143B")]
	[Address(RVA = "0xF9D580", Offset = "0xF9BD80", Length = "0x1C5")]
	private void AssignJoysticksToPlayers()
	{
	}

	[Token(Token = "0x600143C")]
	[Address(RVA = "0xF9D770", Offset = "0xF9BF70", Length = "0x10A")]
	private Player FindPlayerWithoutJoystick()
	{
		return null;
	}

	[Address(RVA = "0xF9D750", Offset = "0xF9BF50", Length = "0x16")]
	[Token(Token = "0x600143D")]
	private bool DoAllPlayersHaveJoysticks()
	{
		return default(bool);
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600143E")]
	public PressAnyButtonToJoinExample_Assigner()
	{
	}
}
