using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace PeroPeroGames.DataStatistics.Utils;

[Token(Token = "0x20004FA")]
public class ThinkingDataTimeCount : MonoBehaviour
{
	[Token(Token = "0x4001B26")]
	public static float timeCounter;

	[Token(Token = "0x4001B27")]
	public static float endCount;

	[Token(Token = "0x4001B28")]
	private static string s_Message;

	[Token(Token = "0x4001B29")]
	private static string s_EvenName;

	[Token(Token = "0x4001B2A")]
	private static string s_PropertyName;

	[Token(Token = "0x4001B2B")]
	private static Dictionary<string, object> s_PlayerData;

	[Token(Token = "0x4001B2C")]
	private static bool m_IsCount;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001B2D")]
	public bool isTimerRunning;

	[Token(Token = "0x6003709")]
	[Address(RVA = "0x507A30", Offset = "0x506230", Length = "0x60")]
	public static void Init()
	{
	}

	[Token(Token = "0x600370A")]
	[Address(RVA = "0x5078B0", Offset = "0x5060B0", Length = "0x5E")]
	private void Awake()
	{
	}

	[Address(RVA = "0x507D40", Offset = "0x506540", Length = "0xA6")]
	[Token(Token = "0x600370B")]
	private void Update()
	{
	}

	[Token(Token = "0x600370C")]
	[Address(RVA = "0x507910", Offset = "0x506110", Length = "0x114")]
	public static void GetMessage(string evenName, string propertyName, string message)
	{
	}

	[Address(RVA = "0x507C30", Offset = "0x506430", Length = "0x108")]
	[Token(Token = "0x600370D")]
	private void TrackToThinkingData()
	{
	}

	[Address(RVA = "0x507B00", Offset = "0x506300", Length = "0x57")]
	[Token(Token = "0x600370E")]
	public static void Play()
	{
	}

	[Address(RVA = "0x507AA0", Offset = "0x5062A0", Length = "0x57")]
	[Token(Token = "0x600370F")]
	public static void Pause()
	{
	}

	[Token(Token = "0x6003710")]
	[Address(RVA = "0x507B60", Offset = "0x506360", Length = "0x59")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6003711")]
	[Address(RVA = "0x507BC0", Offset = "0x5063C0", Length = "0x6B")]
	public static void Resume()
	{
	}

	[Token(Token = "0x6003712")]
	[Address(RVA = "0x507DF0", Offset = "0x5065F0", Length = "0xB")]
	public ThinkingDataTimeCount()
	{
	}
}
