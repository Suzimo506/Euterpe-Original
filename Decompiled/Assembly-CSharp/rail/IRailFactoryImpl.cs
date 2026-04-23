using System;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000234")]
public class IRailFactoryImpl : RailObject, IRailFactory
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x600278A")]
	internal IRailFactoryImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x600278B")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailFactoryImpl()
	{
	}

	[Token(Token = "0x600278C")]
	[Address(RVA = "0xD24DB0", Offset = "0xD235B0", Length = "0xA0")]
	public virtual IRailPlayer RailPlayer()
	{
		return null;
	}

	[Token(Token = "0x600278D")]
	[Address(RVA = "0xD25350", Offset = "0xD23B50", Length = "0xA0")]
	public virtual IRailUsersHelper RailUsersHelper()
	{
		return null;
	}

	[Token(Token = "0x600278E")]
	[Address(RVA = "0xD246D0", Offset = "0xD22ED0", Length = "0xA0")]
	public virtual IRailFriends RailFriends()
	{
		return null;
	}

	[Address(RVA = "0xD24630", Offset = "0xD22E30", Length = "0xA0")]
	[Token(Token = "0x600278F")]
	public virtual IRailFloatingWindow RailFloatingWindow()
	{
		return null;
	}

	[Address(RVA = "0xD244F0", Offset = "0xD22CF0", Length = "0xA0")]
	[Token(Token = "0x6002790")]
	public virtual IRailBrowserHelper RailBrowserHelper()
	{
		return null;
	}

	[Token(Token = "0x6002791")]
	[Address(RVA = "0xD24B30", Offset = "0xD23330", Length = "0xA0")]
	public virtual IRailInGamePurchase RailInGamePurchase()
	{
		return null;
	}

	[Token(Token = "0x6002792")]
	[Address(RVA = "0xD24A90", Offset = "0xD23290", Length = "0xA0")]
	public virtual IRailInGameCoin RailInGameCoin()
	{
		return null;
	}

	[Token(Token = "0x6002793")]
	[Address(RVA = "0xD24E50", Offset = "0xD23650", Length = "0xA0")]
	public virtual IRailRoomHelper RailRoomHelper()
	{
		return null;
	}

	[Address(RVA = "0xD24770", Offset = "0xD22F70", Length = "0xA0")]
	[Token(Token = "0x6002794")]
	public virtual IRailGameServerHelper RailGameServerHelper()
	{
		return null;
	}

	[Token(Token = "0x6002795")]
	[Address(RVA = "0xD250D0", Offset = "0xD238D0", Length = "0xA0")]
	public virtual IRailStorageHelper RailStorageHelper()
	{
		return null;
	}

	[Token(Token = "0x6002796")]
	[Address(RVA = "0xD252B0", Offset = "0xD23AB0", Length = "0xA0")]
	public virtual IRailUserSpaceHelper RailUserSpaceHelper()
	{
		return null;
	}

	[Token(Token = "0x6002797")]
	[Address(RVA = "0xD25030", Offset = "0xD23830", Length = "0xA0")]
	public virtual IRailStatisticHelper RailStatisticHelper()
	{
		return null;
	}

	[Token(Token = "0x6002798")]
	[Address(RVA = "0xD24C70", Offset = "0xD23470", Length = "0xA0")]
	public virtual IRailLeaderboardHelper RailLeaderboardHelper()
	{
		return null;
	}

	[Token(Token = "0x6002799")]
	[Address(RVA = "0xD24310", Offset = "0xD22B10", Length = "0xA0")]
	public virtual IRailAchievementHelper RailAchievementHelper()
	{
		return null;
	}

	[Address(RVA = "0xD24D10", Offset = "0xD23510", Length = "0xA0")]
	[Token(Token = "0x600279A")]
	public virtual IRailNetwork RailNetworkHelper()
	{
		return null;
	}

	[Token(Token = "0x600279B")]
	[Address(RVA = "0xD243B0", Offset = "0xD22BB0", Length = "0xA0")]
	public virtual IRailApps RailApps()
	{
		return null;
	}

	[Address(RVA = "0xD24810", Offset = "0xD23010", Length = "0xA0")]
	[Token(Token = "0x600279C")]
	public virtual IRailGame RailGame()
	{
		return null;
	}

	[Address(RVA = "0xD253F0", Offset = "0xD23BF0", Length = "0xA0")]
	[Token(Token = "0x600279D")]
	public virtual IRailUtils RailUtils()
	{
		return null;
	}

	[Address(RVA = "0xD24450", Offset = "0xD22C50", Length = "0xA0")]
	[Token(Token = "0x600279E")]
	public virtual IRailAssetsHelper RailAssetsHelper()
	{
		return null;
	}

	[Token(Token = "0x600279F")]
	[Address(RVA = "0xD24590", Offset = "0xD22D90", Length = "0xA0")]
	public virtual IRailDlcHelper RailDlcHelper()
	{
		return null;
	}

	[Token(Token = "0x60027A0")]
	[Address(RVA = "0xD24EF0", Offset = "0xD236F0", Length = "0xA0")]
	public virtual IRailScreenshotHelper RailScreenshotHelper()
	{
		return null;
	}

	[Token(Token = "0x60027A1")]
	[Address(RVA = "0xD25490", Offset = "0xD23C90", Length = "0xA0")]
	public virtual IRailVoiceHelper RailVoiceHelper()
	{
		return null;
	}

	[Token(Token = "0x60027A2")]
	[Address(RVA = "0xD25170", Offset = "0xD23970", Length = "0xA0")]
	public virtual IRailSystemHelper RailSystemHelper()
	{
		return null;
	}

	[Token(Token = "0x60027A3")]
	[Address(RVA = "0xD25210", Offset = "0xD23A10", Length = "0xA0")]
	public virtual IRailTextInputHelper RailTextInputHelper()
	{
		return null;
	}

	[Address(RVA = "0xD249F0", Offset = "0xD231F0", Length = "0xA0")]
	[Token(Token = "0x60027A4")]
	public virtual IRailIMEHelper RailIMETextInputHelper()
	{
		return null;
	}

	[Token(Token = "0x60027A5")]
	[Address(RVA = "0xD24950", Offset = "0xD23150", Length = "0xA0")]
	public virtual IRailHttpSessionHelper RailHttpSessionHelper()
	{
		return null;
	}

	[Token(Token = "0x60027A6")]
	[Address(RVA = "0xD24F90", Offset = "0xD23790", Length = "0xA0")]
	public virtual IRailSmallObjectServiceHelper RailSmallObjectServiceHelper()
	{
		return null;
	}

	[Token(Token = "0x60027A7")]
	[Address(RVA = "0xD25530", Offset = "0xD23D30", Length = "0xA0")]
	public virtual IRailZoneServerHelper RailZoneServerHelper()
	{
		return null;
	}

	[Address(RVA = "0xD248B0", Offset = "0xD230B0", Length = "0xA0")]
	[Token(Token = "0x60027A8")]
	public virtual IRailGroupChatHelper RailGroupChatHelper()
	{
		return null;
	}

	[Token(Token = "0x60027A9")]
	[Address(RVA = "0xD24BD0", Offset = "0xD233D0", Length = "0xA0")]
	public virtual IRailInGameStorePurchaseHelper RailInGameStorePurchaseHelper()
	{
		return null;
	}
}
