using System.Collections.Generic;
using Assets.Scripts.Database;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.Redot.RoleSelectRedot;

[Token(Token = "0x2000852")]
public static class RolePreviewCacheDataManager
{
	[Token(Token = "0x4002B51")]
	public const string role_preview_cached_data_key = "rolePreviewedList";

	[Token(Token = "0x4002B52")]
	public const int role_preview_must_show = 28;

	[Token(Token = "0x4002B53")]
	public static readonly List<int> rolePreviewReplicaShow;

	[Token(Token = "0x4002B54")]
	private static HashSet<int> s_PreviewRoles;

	[Token(Token = "0x17000861")]
	public static HashSet<int> RolePreviewHashSet
	{
		[Address(RVA = "0x61A260", Offset = "0x618A60", Length = "0x2DD")]
		[Token(Token = "0x6004C50")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x61A010", Offset = "0x618810", Length = "0xC1")]
	[Token(Token = "0x6004C51")]
	public static bool IsRoleUnFocused(int roleIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6004C52")]
	[Address(RVA = "0x61A0E0", Offset = "0x6188E0", Length = "0xFA")]
	public static void SetRoleFocused(int roleIndex)
	{
	}

	[Token(Token = "0x6004C53")]
	[Address(RVA = "0x619E10", Offset = "0x618610", Length = "0x1F7")]
	public static bool HasNewUnfocusedRole()
	{
		return default(bool);
	}

	[Address(RVA = "0x619AB0", Offset = "0x6182B0", Length = "0x81")]
	[Token(Token = "0x6004C54")]
	public static CharacterInfo GetNewestRoleInCurrentVersion()
	{
		return null;
	}

	[Address(RVA = "0x619C10", Offset = "0x618410", Length = "0x1FD")]
	[Token(Token = "0x6004C55")]
	public static List<CharacterInfo> GetRecommendedRolesInCurrentVersion()
	{
		return null;
	}

	[Token(Token = "0x6004C56")]
	[Address(RVA = "0x619B40", Offset = "0x618340", Length = "0xC2")]
	private static List<int> GetPreviewedRoleList()
	{
		return null;
	}
}
