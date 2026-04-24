using System.Collections.Generic;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;

namespace GameCore.GameObjectLogics.GameObjectManager._2024FoolActivity;

[CreateAssetMenu]
[Token(Token = "0x2000486")]
public class FoolAcitivityRoleAssetConfig : SerializedScriptableObject
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400187B")]
	public Dictionary<string, List<string>> assetDic;

	[Token(Token = "0x400187C")]
	[FieldOffset(Offset = "0x60")]
	public Dictionary<string, List<string>> showSpineAssetDic;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400187D")]
	public Dictionary<string, List<string>> normalRoleDic;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400187E")]
	public Dictionary<string, string> noteTypeActionDic;

	[Token(Token = "0x400187F")]
	[FieldOffset(Offset = "0x78")]
	public Dictionary<int, string> comboFaceAction;

	[Token(Token = "0x4001880")]
	[FieldOffset(Offset = "0x80")]
	public string touhouReadyAsset;

	[Token(Token = "0x4001881")]
	private static FoolAcitivityRoleAssetConfig s_Instance;

	[Token(Token = "0x170004B4")]
	public static FoolAcitivityRoleAssetConfig Instance
	{
		[Address(RVA = "0x8F5690", Offset = "0x8F3E90", Length = "0xD6")]
		[Token(Token = "0x60033D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60033D1")]
	[Address(RVA = "0x8F55B0", Offset = "0x8F3DB0", Length = "0xD0")]
	public static void ReleaseInstance()
	{
	}

	[Address(RVA = "0x4A38A0", Offset = "0x4A20A0", Length = "0x7")]
	[Token(Token = "0x60033D2")]
	public FoolAcitivityRoleAssetConfig()
	{
	}
}
