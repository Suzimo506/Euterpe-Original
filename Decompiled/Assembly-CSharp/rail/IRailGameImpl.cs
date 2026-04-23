using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000238")]
public class IRailGameImpl : RailObject, IRailGame
{
	[Token(Token = "0x60027D0")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailGameImpl(IntPtr cPtr)
	{
	}

	[Token(Token = "0x60027D1")]
	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	~IRailGameImpl()
	{
	}

	[Token(Token = "0x60027D2")]
	[Address(RVA = "0xD272D0", Offset = "0xD25AD0", Length = "0x8C")]
	public virtual RailGameID GetGameID()
	{
		return null;
	}

	[Token(Token = "0x60027D3")]
	[Address(RVA = "0xD27AB0", Offset = "0xD262B0", Length = "0x63")]
	public virtual RailResult ReportGameContentDamaged(EnumRailGameContentDamageFlag flag)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60027D4")]
	[Address(RVA = "0xD27360", Offset = "0xD25B60", Length = "0x131")]
	public virtual RailResult GetGameInstallPath(out string app_path)
	{
		app_path = null;
		return default(RailResult);
	}

	[Address(RVA = "0xD26EB0", Offset = "0xD256B0", Length = "0x65")]
	[Token(Token = "0x60027D5")]
	public virtual RailResult AsyncQuerySubscribeWishPlayState(string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60027D6")]
	[Address(RVA = "0xD27780", Offset = "0xD25F80", Length = "0x131")]
	public virtual RailResult GetPlayerSelectedLanguageCode(out string language_code)
	{
		language_code = null;
		return default(RailResult);
	}

	[Address(RVA = "0xD27650", Offset = "0xD25E50", Length = "0x12E")]
	[Token(Token = "0x60027D7")]
	public virtual RailResult GetGameSupportedLanguageCodes(List<string> language_codes)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD27B90", Offset = "0xD26390", Length = "0x63")]
	[Token(Token = "0x60027D8")]
	public virtual RailResult SetGameState(EnumRailGamePlayingState game_state)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD27530", Offset = "0xD25D30", Length = "0x11C")]
	[Token(Token = "0x60027D9")]
	public virtual RailResult GetGameState(out EnumRailGamePlayingState game_state)
	{
		System.Runtime.CompilerServices.Unsafe.As<EnumRailGamePlayingState, @null>(ref game_state) = null;
		return default(RailResult);
	}

	[Address(RVA = "0xD27980", Offset = "0xD26180", Length = "0x124")]
	[Token(Token = "0x60027DA")]
	public virtual RailResult RegisterGameDefineGamePlayingState(List<RailGameDefineGamePlayingState> game_playing_states)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60027DB")]
	[Address(RVA = "0xD27B20", Offset = "0xD26320", Length = "0x63")]
	public virtual RailResult SetGameDefineGamePlayingState(uint game_playing_state)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD27200", Offset = "0xD25A00", Length = "0x65")]
	[Token(Token = "0x60027DC")]
	public virtual RailResult GetGameDefineGamePlayingState(out uint game_playing_state)
	{
		System.Runtime.CompilerServices.Unsafe.As<uint, @null>(ref game_playing_state) = null;
		return default(RailResult);
	}

	[Token(Token = "0x60027DD")]
	[Address(RVA = "0xD26F90", Offset = "0xD25790", Length = "0x131")]
	public virtual RailResult GetBranchBuildNumber(out string build_number)
	{
		build_number = null;
		return default(RailResult);
	}

	[Address(RVA = "0xD270D0", Offset = "0xD258D0", Length = "0x12E")]
	[Token(Token = "0x60027DE")]
	public virtual RailResult GetCurrentBranchInfo(RailBranchInfo branch_info)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD27C00", Offset = "0xD26400", Length = "0x65")]
	[Token(Token = "0x60027DF")]
	public virtual RailResult StartGameTimeCounting(string counting_key)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60027E0")]
	[Address(RVA = "0xD26F20", Offset = "0xD25720", Length = "0x65")]
	public virtual RailResult EndGameTimeCounting(string counting_key)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60027E1")]
	[Address(RVA = "0xD274A0", Offset = "0xD25CA0", Length = "0x8C")]
	public virtual RailID GetGamePurchasePlayerRailID()
	{
		return null;
	}

	[Token(Token = "0x60027E2")]
	[Address(RVA = "0xD27270", Offset = "0xD25A70", Length = "0x55")]
	public virtual uint GetGameEarliestPurchaseTime()
	{
		return default(uint);
	}

	[Token(Token = "0x60027E3")]
	[Address(RVA = "0xD278C0", Offset = "0xD260C0", Length = "0x55")]
	public virtual uint GetTimeCountSinceGameActivated()
	{
		return default(uint);
	}

	[Token(Token = "0x60027E4")]
	[Address(RVA = "0xD27920", Offset = "0xD26120", Length = "0x55")]
	public virtual uint GetTimeCountSinceLastMouseMoved()
	{
		return default(uint);
	}
}
