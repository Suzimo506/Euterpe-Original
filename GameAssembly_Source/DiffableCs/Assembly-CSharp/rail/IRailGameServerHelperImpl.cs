namespace rail;

public class IRailGameServerHelperImpl : RailObject, IRailGameServerHelper
{

	internal IRailGameServerHelperImpl(IntPtr cPtr) { }

	public override RailResult AsyncAddFavoriteGameServer(RailID game_server_id, string user_data) { }

	public override RailResult AsyncAddFavoriteGameServer(RailID game_server_id) { }

	public override IRailGameServer AsyncCreateGameServer(CreateGameServerOptions options, string game_server_name, string user_data) { }

	public override IRailGameServer AsyncCreateGameServer(CreateGameServerOptions options, string game_server_name) { }

	public override IRailGameServer AsyncCreateGameServer(CreateGameServerOptions options) { }

	public override IRailGameServer AsyncCreateGameServer() { }

	public override RailResult AsyncGetFavoriteGameServers(string user_data) { }

	public override RailResult AsyncGetFavoriteGameServers() { }

	public override RailResult AsyncGetGameServerList(uint start_index, uint end_index, List<GameServerListFilter> alternative_filters, List<GameServerListSorter> sorter, string user_data) { }

	public override RailResult AsyncGetGameServerPlayerList(RailID gameserver_rail_id, string user_data) { }

	public override RailResult AsyncRemoveFavoriteGameServer(RailID game_server_id, string user_Data) { }

	public override RailResult AsyncRemoveFavoriteGameServer(RailID game_server_id) { }

	protected virtual void Finalize() { }

}

