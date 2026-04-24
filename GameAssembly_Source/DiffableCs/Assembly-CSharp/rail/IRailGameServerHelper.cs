namespace rail;

public interface IRailGameServerHelper
{

	public RailResult AsyncAddFavoriteGameServer(RailID game_server_id, string user_data) { }

	public RailResult AsyncAddFavoriteGameServer(RailID game_server_id) { }

	public IRailGameServer AsyncCreateGameServer(CreateGameServerOptions options, string game_server_name, string user_data) { }

	public IRailGameServer AsyncCreateGameServer(CreateGameServerOptions options, string game_server_name) { }

	public IRailGameServer AsyncCreateGameServer(CreateGameServerOptions options) { }

	public IRailGameServer AsyncCreateGameServer() { }

	public RailResult AsyncGetFavoriteGameServers(string user_data) { }

	public RailResult AsyncGetFavoriteGameServers() { }

	public RailResult AsyncGetGameServerList(uint start_index, uint end_index, List<GameServerListFilter> alternative_filters, List<GameServerListSorter> sorter, string user_data) { }

	public RailResult AsyncGetGameServerPlayerList(RailID gameserver_rail_id, string user_data) { }

	public RailResult AsyncRemoveFavoriteGameServer(RailID game_server_id, string user_Data) { }

	public RailResult AsyncRemoveFavoriteGameServer(RailID game_server_id) { }

}

