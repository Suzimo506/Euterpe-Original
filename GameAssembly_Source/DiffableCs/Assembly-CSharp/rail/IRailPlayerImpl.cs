namespace rail;

public class IRailPlayerImpl : RailObject, IRailPlayer
{

	internal IRailPlayerImpl(IntPtr cPtr) { }

	public override void AbandonSessionTicket(RailSessionTicket session_ticket) { }

	public override bool AlreadyLoggedIn() { }

	public override RailResult AsyncAcquireSessionTicket(string user_data) { }

	public override RailResult AsyncGetAuthenticateURL(RailGetAuthenticateURLOptions options, string user_data) { }

	public override RailResult AsyncGetEncryptedGameTicket(string set_metadata, string user_data) { }

	public override RailResult AsyncGetGamePurchaseKey(string user_data) { }

	public override RailResult AsyncGetPlayerMetadata(List<String> keys, string user_data) { }

	public override RailResult AsyncQueryPlayerBannedStatus(string user_data) { }

	public override RailResult AsyncStartSessionWithPlayer(RailSessionTicket player_ticket, RailID player_rail_id, string user_data) { }

	protected virtual void Finalize() { }

	public override RailResult GetPlayerDataPath(out string path) { }

	public override RailResult GetPlayerName(out string name) { }

	public override EnumRailPlayerOwnershipType GetPlayerOwnershipType() { }

	public override RailID GetRailID() { }

	public override float GetRateOfGameRevenue() { }

	public override bool IsGameRevenueLimited() { }

	public override void TerminateSessionOfPlayer(RailID player_rail_id) { }

}

