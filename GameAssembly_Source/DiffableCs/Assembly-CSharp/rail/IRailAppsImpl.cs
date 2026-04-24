namespace rail;

public class IRailAppsImpl : RailObject, IRailApps
{

	internal IRailAppsImpl(IntPtr cPtr) { }

	public override RailResult AsyncQuerySubscribeWishPlayState(RailGameID game_id, string user_data) { }

	protected virtual void Finalize() { }

	public override bool IsGameInstalled(RailGameID game_id) { }

}

