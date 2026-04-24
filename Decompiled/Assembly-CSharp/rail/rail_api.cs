using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200026A")]
public class rail_api
{
	[Token(Token = "0x4000FD3")]
	public static readonly int USE_MANUAL_ALLOC;

	[Token(Token = "0x4000FD4")]
	public static readonly int RAIL_SDK_PACKING;

	[Token(Token = "0x17000417")]
	public static uint kRailMaxQueryPlayedWithFriendsTimeLimit
	{
		[Address(RVA = "0x2723140", Offset = "0x2721940", Length = "0x48")]
		[Token(Token = "0x6002C8C")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17000418")]
	public static uint kRailRoomDefaultMaxMemberNumber
	{
		[Token(Token = "0x6002C8D")]
		[Address(RVA = "0x27231E0", Offset = "0x27219E0", Length = "0x48")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17000419")]
	public static uint kRailRoomDataKeyValuePairsLimit
	{
		[Token(Token = "0x6002C8E")]
		[Address(RVA = "0x2723190", Offset = "0x2721990", Length = "0x48")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x1700041A")]
	public static uint kRailMaxGameDefinePlayingStateValue
	{
		[Token(Token = "0x6002C8F")]
		[Address(RVA = "0x27230F0", Offset = "0x27218F0", Length = "0x48")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x6002C90")]
	[Address(RVA = "0x2722EF0", Offset = "0x27216F0", Length = "0x17C")]
	public static bool RailNeedRestartAppForCheckingEnvironment(RailGameID game_id, int argc, string[] argv)
	{
		return default(bool);
	}

	[Address(RVA = "0x2722EA0", Offset = "0x27216A0", Length = "0x48")]
	[Token(Token = "0x6002C91")]
	public static bool RailInitialize()
	{
		return default(bool);
	}

	[Token(Token = "0x6002C92")]
	[Address(RVA = "0x2722C90", Offset = "0x2721490", Length = "0x48")]
	public static void RailFinalize()
	{
	}

	[Token(Token = "0x6002C93")]
	[Address(RVA = "0x2722CE0", Offset = "0x27214E0", Length = "0x48")]
	public static void RailFireEvents()
	{
	}

	[Address(RVA = "0x2722BF0", Offset = "0x27213F0", Length = "0x92")]
	[Token(Token = "0x6002C94")]
	public static IRailFactory RailFactory()
	{
		return null;
	}

	[Token(Token = "0x6002C95")]
	[Address(RVA = "0x2722D30", Offset = "0x2721530", Length = "0x169")]
	public static void RailGetSdkVersion(out string version, out string description)
	{
		version = null;
		description = null;
	}

	[Token(Token = "0x6002C96")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public rail_api()
	{
	}
}
