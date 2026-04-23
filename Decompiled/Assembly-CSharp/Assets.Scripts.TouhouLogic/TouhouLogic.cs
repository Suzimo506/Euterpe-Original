using Cpp2ILInjected;
using GameLogic;
using UnityEngine;

namespace Assets.Scripts.TouhouLogic;

[Token(Token = "0x200056B")]
public static class TouhouLogic
{
	[Address(RVA = "0x5B9090", Offset = "0x5B7890", Length = "0x5A7")]
	[Token(Token = "0x6003835")]
	public static void ReplaceMarisaJumpActionWithSilencer(SpineActionController marisaCtrl)
	{
	}

	[Token(Token = "0x6003836")]
	[Address(RVA = "0x5B8CA0", Offset = "0x5B74A0", Length = "0x80")]
	public static void ReplaceBadAppleLongPress(ref MusicData md)
	{
	}

	[Token(Token = "0x6003837")]
	[Address(RVA = "0x5B9640", Offset = "0x5B7E40", Length = "0x51")]
	public static void SetLongCatchColor(ref Color air1, ref Color air2, ref Color road1, ref Color road2)
	{
	}

	[Token(Token = "0x6003838")]
	[Address(RVA = "0x5B8D70", Offset = "0x5B7570", Length = "0x25D")]
	public static string ReplaceBadAppleString(string str)
	{
		return null;
	}

	[Token(Token = "0x6003839")]
	[Address(RVA = "0x5B8D20", Offset = "0x5B7520", Length = "0x4C")]
	public static string ReplaceBadAppleScene(string scene)
	{
		return null;
	}

	[Address(RVA = "0x5B8FD0", Offset = "0x5B77D0", Length = "0xBD")]
	[Token(Token = "0x600383A")]
	public static void ReplaceBadApple(GameObject go)
	{
	}

	[Token(Token = "0x600383B")]
	[Address(RVA = "0x5B8C30", Offset = "0x5B7430", Length = "0x68")]
	public static string ReplaceBadAppleFever(string str)
	{
		return null;
	}

	[Token(Token = "0x600383C")]
	[Address(RVA = "0x5B8980", Offset = "0x5B7180", Length = "0x2A2")]
	public static void ReplaceBadAppleCatch(GameObject go)
	{
	}
}
