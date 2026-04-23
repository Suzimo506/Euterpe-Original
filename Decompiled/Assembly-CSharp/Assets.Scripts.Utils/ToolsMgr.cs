using System;
using System.Collections.Generic;
using Assets.Scripts.Database;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Utils;

[Token(Token = "0x20005A9")]
public static class ToolsMgr
{
	[Token(Token = "0x4002107")]
	public static readonly Vector2Int standardResolution;

	[Token(Token = "0x4002108")]
	private static string m_CurSelectedLevelUid;

	[Token(Token = "0x17000537")]
	public static string curSelectedLevelUid
	{
		[Address(RVA = "0x606720", Offset = "0x604F20", Length = "0x271")]
		[Token(Token = "0x60038F7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60038F8")]
	[Address(RVA = "0x6055B0", Offset = "0x603DB0", Length = "0x19C")]
	public static bool IsCurLevelBarrageModeInovke()
	{
		return default(bool);
	}

	[Token(Token = "0x60038F9")]
	[Address(RVA = "0x604B90", Offset = "0x603390", Length = "0x44C")]
	public static void GetMostCommonElement(List<string> listTemp, int count = 3)
	{
	}

	[Address(RVA = "0x604740", Offset = "0x602F40", Length = "0xDC")]
	[Token(Token = "0x60038FA")]
	public static float GetCurAspectRatioFactor()
	{
		return default(float);
	}

	[Token(Token = "0x60038FB")]
	[Address(RVA = "0x605470", Offset = "0x603C70", Length = "0x13E")]
	public static bool IsColorMatch(Color color1, Color color2, float colorThreshold = 0.005f)
	{
		return default(bool);
	}

	[Address(RVA = "0x604A10", Offset = "0x603210", Length = "0xD0")]
	[Token(Token = "0x60038FC")]
	public static Sprite GetCurSelectedHeadImg()
	{
		return null;
	}

	[Address(RVA = "0x604AF0", Offset = "0x6032F0", Length = "0x95")]
	[Token(Token = "0x60038FD")]
	public static int GetFirstLayerActiveChildCount(GameObject parent)
	{
		return default(int);
	}

	[Address(RVA = "0x604820", Offset = "0x603020", Length = "0x5A")]
	[Token(Token = "0x60038FE")]
	public static string GetCurLanguage()
	{
		return null;
	}

	[Token(Token = "0x60038FF")]
	[Address(RVA = "0x605B20", Offset = "0x604320", Length = "0x22D")]
	public static bool IsCurSelectMusiclevelHasBestRecord()
	{
		return default(bool);
	}

	[Token(Token = "0x6003900")]
	[Address(RVA = "0x6052B0", Offset = "0x603AB0", Length = "0x74")]
	public static int GetTargetIndexByWeights(int[] listWeights)
	{
		return default(int);
	}

	[Address(RVA = "0xF414D0", Offset = "0xF3FCD0", Length = "0x61")]
	[Token(Token = "0x6003901")]
	public static int GetRandomIndex<T>(List<T> list)
	{
		return default(int);
	}

	[Address(RVA = "0x6065D0", Offset = "0x604DD0", Length = "0xBC")]
	[Token(Token = "0x6003902")]
	public static void SetUpDownNavigation(Selectable orgin, Selectable prev, Selectable next)
	{
	}

	[Address(RVA = "0x605110", Offset = "0x603910", Length = "0x197")]
	[Token(Token = "0x6003903")]
	public static string GetPlayerName()
	{
		return null;
	}

	[Token(Token = "0x6003904")]
	[Address(RVA = "0x605330", Offset = "0x603B30", Length = "0xD3")]
	public static string GetTruncatedString(string inputString, int targetLength, string suffix)
	{
		return null;
	}

	[Address(RVA = "0x6046B0", Offset = "0x602EB0", Length = "0x89")]
	[Token(Token = "0x6003905")]
	public static bool FloatEquals(float val1, float val2, float delta = 1E-06f)
	{
		return default(bool);
	}

	[Address(RVA = "0x604880", Offset = "0x603080", Length = "0x18A")]
	[Token(Token = "0x6003906")]
	public static string GetCurMusicDiffUid()
	{
		return null;
	}

	[Token(Token = "0x6003907")]
	[Address(RVA = "0x605410", Offset = "0x603C10", Length = "0x5D")]
	public static bool Is4x3()
	{
		return default(bool);
	}

	[Address(RVA = "0x606190", Offset = "0x604990", Length = "0x43D")]
	[Token(Token = "0x6003908")]
	public static void RefreshTimeRemainText(TimeSpan timeSpan, Text targetText)
	{
	}

	[Token(Token = "0x6003909")]
	[Address(RVA = "0x605D50", Offset = "0x604550", Length = "0x43D")]
	public static void RefreshTimeRemainText(TimeSpan timeSpan, TMP_Text targetText)
	{
	}

	[Token(Token = "0x600390A")]
	[Address(RVA = "0x604FE0", Offset = "0x6037E0", Length = "0x124")]
	public static DBConfigAlbums.AlbumsInfo GetNotFreeElfinAlbumInfo(int elfinIndex)
	{
		return null;
	}

	[Address(RVA = "0x604670", Offset = "0x602E70", Length = "0x3D")]
	[Token(Token = "0x600390B")]
	public static string DataTimeToString(DateTime dateTime)
	{
		return null;
	}

	[Address(RVA = "0x605750", Offset = "0x603F50", Length = "0x3CC")]
	[Token(Token = "0x600390C")]
	public static bool IsCurLevelHasLevelConfigData()
	{
		return default(bool);
	}
}
