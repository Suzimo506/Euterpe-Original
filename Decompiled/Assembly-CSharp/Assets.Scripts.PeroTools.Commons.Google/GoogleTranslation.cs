using System;
using System.Collections;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Commons.Google;

[Token(Token = "0x20006A9")]
public static class GoogleTranslation
{
	[Token(Token = "0x6003E9A")]
	[Address(RVA = "0x92BBB0", Offset = "0x92A3B0", Length = "0x9B")]
	public static void Translate(string text, string languageCodeTo, Action<string> onTranslationReady, string languageCodeFrom = "auto")
	{
	}

	[Token(Token = "0x6003E9B")]
	[Address(RVA = "0x92BC50", Offset = "0x92A450", Length = "0x19B")]
	public static void Translate(string[] texts, string languageCodeTo, Action<string>[] onTranslationReadys, string languageCodeFrom = "auto")
	{
	}

	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x44060", Offset = "0x43460")]
	[Address(RVA = "0x92BEF0", Offset = "0x92A6F0", Length = "0x9D")]
	[Token(Token = "0x6003E9C")]
	private static IEnumerator WaitForTranslation(WWW www, Action<string> onTranslationReady, string originalText)
	{
		return null;
	}

	[Token(Token = "0x6003E9D")]
	[Address(RVA = "0x92AFF0", Offset = "0x9297F0", Length = "0x213")]
	public static string ForceTranslate(string text, string languageCodeTo, string languageCodeFrom = "auto")
	{
		return null;
	}

	[Address(RVA = "0x92B340", Offset = "0x929B40", Length = "0x6BD")]
	[Token(Token = "0x6003E9E")]
	public static WWW GetTranslationWWW(string text, string languageCodeFrom, string languageCodeTo)
	{
		return null;
	}

	[Token(Token = "0x6003E9F")]
	[Address(RVA = "0x92BA00", Offset = "0x92A200", Length = "0xFC")]
	public static string ParseTranslationResult(string html, string originalText)
	{
		return null;
	}

	[Token(Token = "0x6003EA0")]
	[Address(RVA = "0x92B210", Offset = "0x929A10", Length = "0x126")]
	private static string GetMd5WithString(string input)
	{
		return null;
	}

	[Token(Token = "0x6003EA1")]
	[Address(RVA = "0x92BDF0", Offset = "0x92A5F0", Length = "0xFC")]
	public static string UppercaseFirst(string s)
	{
		return null;
	}

	[Address(RVA = "0x92BB00", Offset = "0x92A300", Length = "0xA4")]
	[Token(Token = "0x6003EA2")]
	public static string TitleCase(string s)
	{
		return null;
	}
}
