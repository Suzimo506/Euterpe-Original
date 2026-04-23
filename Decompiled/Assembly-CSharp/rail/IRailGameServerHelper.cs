using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002E0")]
public interface IRailGameServerHelper
{
	[Token(Token = "0x6002DAD")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncGetGameServerPlayerList(RailID gameserver_rail_id, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002DAE")]
	RailResult AsyncGetGameServerList(uint start_index, uint end_index, List<GameServerListFilter> alternative_filters, List<GameServerListSorter> sorter, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002DAF")]
	IRailGameServer AsyncCreateGameServer(CreateGameServerOptions options, string game_server_name, string user_data);

	[Token(Token = "0x6002DB0")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailGameServer AsyncCreateGameServer(CreateGameServerOptions options, string game_server_name);

	[Token(Token = "0x6002DB1")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailGameServer AsyncCreateGameServer(CreateGameServerOptions options);

	[Token(Token = "0x6002DB2")]
	[Address(RVA = "0x0", Length = "0x0")]
	IRailGameServer AsyncCreateGameServer();

	[Token(Token = "0x6002DB3")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncGetFavoriteGameServers(string user_data);

	[Token(Token = "0x6002DB4")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncGetFavoriteGameServers();

	[Token(Token = "0x6002DB5")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncAddFavoriteGameServer(RailID game_server_id, string user_data);

	[Token(Token = "0x6002DB6")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncAddFavoriteGameServer(RailID game_server_id);

	[Token(Token = "0x6002DB7")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncRemoveFavoriteGameServer(RailID game_server_id, string user_Data);

	[Token(Token = "0x6002DB8")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncRemoveFavoriteGameServer(RailID game_server_id);
}
