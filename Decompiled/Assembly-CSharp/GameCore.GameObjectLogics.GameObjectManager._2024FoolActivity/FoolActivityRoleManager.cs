using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace GameCore.GameObjectLogics.GameObjectManager._2024FoolActivity;

[Token(Token = "0x2000488")]
public class FoolActivityRoleManager
{
	[Token(Token = "0x4001885")]
	public const string char_series_rin = "rin";

	[Token(Token = "0x4001886")]
	public const string char_series_marija = "marija";

	[Token(Token = "0x4001887")]
	public const string char_series_buro_or_ola = "buro_or_ola";

	[Token(Token = "0x4001888")]
	private static readonly Dictionary<string, List<string>> s_CharacterTypeDic;

	[Token(Token = "0x170004B5")]
	public FoolAcitivityRoleAssetConfig AssetConfig
	{
		[CompilerGenerated]
		[Token(Token = "0x60033DC")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x8F5FD0", Offset = "0x8F47D0", Length = "0xF9")]
	[Token(Token = "0x60033DD")]
	public static string GetCurrentStageSelectCharacterType()
	{
		return null;
	}

	[Token(Token = "0x60033DE")]
	[Address(RVA = "0x8F7010", Offset = "0x8F5810", Length = "0x2B")]
	public FoolActivityRoleManager()
	{
	}

	[Token(Token = "0x60033DF")]
	[Address(RVA = "0x8F60D0", Offset = "0x8F48D0", Length = "0x32B")]
	public List<string> GetGirlNameAccordingToSelectRole()
	{
		return null;
	}

	[Address(RVA = "0x8F6730", Offset = "0x8F4F30", Length = "0x14F")]
	[Token(Token = "0x60033E0")]
	public bool IsShowMuscleShow()
	{
		return default(bool);
	}

	[Address(RVA = "0x8F6880", Offset = "0x8F5080", Length = "0x51D")]
	[Token(Token = "0x60033E1")]
	[Obsolete]
	public void ShowBattlePerformance(Transform showParentPoint)
	{
	}

	[Token(Token = "0x60033E2")]
	[Address(RVA = "0x8F6400", Offset = "0x8F4C00", Length = "0x32B")]
	public List<string> GetShowGirlAssetNameAccordingToSelectRole()
	{
		return null;
	}
}
