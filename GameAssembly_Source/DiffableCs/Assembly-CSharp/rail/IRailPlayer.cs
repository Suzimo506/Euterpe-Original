namespace rail;

public interface IRailPlayer
{

	public void AbandonSessionTicket(RailSessionTicket session_ticket) { }

	public bool AlreadyLoggedIn() { }

	public RailResult AsyncAcquireSessionTicket(string user_data) { }

	public RailResult AsyncGetAuthenticateURL(RailGetAuthenticateURLOptions options, string user_data) { }

	public RailResult AsyncGetEncryptedGameTicket(string set_metadata, string user_data) { }

	public RailResult AsyncGetGamePurchaseKey(string user_data) { }

	public RailResult AsyncGetPlayerMetadata(List<String> keys, string user_data) { }

	public RailResult AsyncQueryPlayerBannedStatus(string user_data) { }

	public RailResult AsyncStartSessionWithPlayer(RailSessionTicket player_ticket, RailID player_rail_id, string user_data) { }

	public RailResult GetPlayerDataPath(out string path) { }

	public RailResult GetPlayerName(out string name) { }

	public EnumRailPlayerOwnershipType GetPlayerOwnershipType() { }

	public RailID GetRailID() { }

	public float GetRateOfGameRevenue() { }

	public bool IsGameRevenueLimited() { }

	public void TerminateSessionOfPlayer(RailID player_rail_id) { }

}

