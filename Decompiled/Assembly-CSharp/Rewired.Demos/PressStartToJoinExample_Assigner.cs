using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[Token(Token = "0x2000220")]
[Attribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
public class PressStartToJoinExample_Assigner : MonoBehaviour
{
	[Token(Token = "0x2000AB9")]
	private class PlayerMap
	{
		[Token(Token = "0x400384C")]
		[FieldOffset(Offset = "0x10")]
		public int rewiredPlayerId;

		[Token(Token = "0x400384D")]
		[FieldOffset(Offset = "0x14")]
		public int gamePlayerId;

		[Token(Token = "0x6005BE9")]
		[Address(RVA = "0xA6E490", Offset = "0xA6CC90", Length = "0x34")]
		public PlayerMap(int rewiredPlayerId, int gamePlayerId)
		{
		}
	}

	[Token(Token = "0x4000F69")]
	private static PressStartToJoinExample_Assigner instance;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F6A")]
	public int maxPlayers;

	[Token(Token = "0x4000F6B")]
	[FieldOffset(Offset = "0x20")]
	private List<PlayerMap> playerMap;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F6C")]
	private int gamePlayerIdCounter;

	[Token(Token = "0x6001445")]
	[Address(RVA = "0xF9E340", Offset = "0xF9CB40", Length = "0x255")]
	public static Player GetRewiredPlayer(int gamePlayerId)
	{
		return null;
	}

	[Address(RVA = "0xF9E2B0", Offset = "0xF9CAB0", Length = "0x78")]
	[Token(Token = "0x6001446")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001447")]
	[Address(RVA = "0xF9E5A0", Offset = "0xF9CDA0", Length = "0xDE")]
	private void Update()
	{
	}

	[Token(Token = "0x6001448")]
	[Address(RVA = "0xF9DF50", Offset = "0xF9C750", Length = "0x35E")]
	private void AssignNextPlayer(int rewiredPlayerId)
	{
	}

	[Address(RVA = "0xF9E330", Offset = "0xF9CB30", Length = "0xA")]
	[Token(Token = "0x6001449")]
	private int GetNextGamePlayerId()
	{
		return default(int);
	}

	[Address(RVA = "0xF9E680", Offset = "0xF9CE80", Length = "0xE")]
	[Token(Token = "0x600144A")]
	public PressStartToJoinExample_Assigner()
	{
	}
}
