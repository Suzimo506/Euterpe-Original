namespace rail;

public interface IRailZoneServerHelper
{

	public RailResult AsyncSwitchPlayerSelectedZone(RailZoneID zone_id) { }

	public RailZoneID GetPlayerSelectedZoneID() { }

	public RailZoneID GetRootZoneID() { }

	public IRailZoneServer OpenZoneServer(RailZoneID zone_id, out RailResult result) { }

}

