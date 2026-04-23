using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200023A")]
public class IRailGameServerHelperImpl : RailObject, IRailGameServerHelper
{
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	[Token(Token = "0x600281A")]
	internal IRailGameServerHelperImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x600281B")]
	~IRailGameServerHelperImpl()
	{
	}

	[Address(RVA = "0xD286E0", Offset = "0xD26EE0", Length = "0x17B")]
	[Token(Token = "0x600281C")]
	public virtual RailResult AsyncGetGameServerPlayerList(RailID gameserver_rail_id, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD28530", Offset = "0xD26D30", Length = "0x1A5")]
	[Token(Token = "0x600281D")]
	public virtual RailResult AsyncGetGameServerList(uint start_index, uint end_index, List<GameServerListFilter> alternative_filters, List<GameServerListSorter> sorter, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x600281E")]
	[Address(RVA = "0xD282E0", Offset = "0xD26AE0", Length = "0x172")]
	public virtual IRailGameServer AsyncCreateGameServer(CreateGameServerOptions options, string game_server_name, string user_data)
	{
		return null;
	}

	[Address(RVA = "0xD27F70", Offset = "0xD26770", Length = "0x160")]
	[Token(Token = "0x600281F")]
	public virtual IRailGameServer AsyncCreateGameServer(CreateGameServerOptions options, string game_server_name)
	{
		return null;
	}

	[Address(RVA = "0xD28180", Offset = "0xD26980", Length = "0x15C")]
	[Token(Token = "0x6002820")]
	public virtual IRailGameServer AsyncCreateGameServer(CreateGameServerOptions options)
	{
		return null;
	}

	[Token(Token = "0x6002821")]
	[Address(RVA = "0xD280E0", Offset = "0xD268E0", Length = "0xA0")]
	public virtual IRailGameServer AsyncCreateGameServer()
	{
		return null;
	}

	[Token(Token = "0x6002822")]
	[Address(RVA = "0xD284C0", Offset = "0xD26CC0", Length = "0x65")]
	public virtual RailResult AsyncGetFavoriteGameServers(string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002823")]
	[Address(RVA = "0xD28460", Offset = "0xD26C60", Length = "0x55")]
	public virtual RailResult AsyncGetFavoriteGameServers()
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002824")]
	[Address(RVA = "0xD27DF0", Offset = "0xD265F0", Length = "0x17B")]
	public virtual RailResult AsyncAddFavoriteGameServer(RailID game_server_id, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002825")]
	[Address(RVA = "0xD27C70", Offset = "0xD26470", Length = "0x177")]
	public virtual RailResult AsyncAddFavoriteGameServer(RailID game_server_id)
	{
		return default(RailResult);
	}

	[Token(Token = "0x6002826")]
	[Address(RVA = "0xD28860", Offset = "0xD27060", Length = "0x17B")]
	public virtual RailResult AsyncRemoveFavoriteGameServer(RailID game_server_id, string user_Data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD289E0", Offset = "0xD271E0", Length = "0x177")]
	[Token(Token = "0x6002827")]
	public virtual RailResult AsyncRemoveFavoriteGameServer(RailID game_server_id)
	{
		return default(RailResult);
	}
}
