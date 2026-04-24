namespace rail;

public interface IRailApps
{

	public RailResult AsyncQuerySubscribeWishPlayState(RailGameID game_id, string user_data) { }

	public bool IsGameInstalled(RailGameID game_id) { }

}

