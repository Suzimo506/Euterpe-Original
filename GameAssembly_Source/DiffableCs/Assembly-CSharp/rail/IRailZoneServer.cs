namespace rail;

public interface IRailZoneServer : IRailComponent
{

	public RailResult GetChildrenZoneIDs(List<RailZoneID> zone_ids) { }

	public RailResult GetGameServerAddresses(List<String> server_addresses) { }

	public RailResult GetZoneDescription(string language_filter, out string zone_description) { }

	public RailResult GetZoneDescriptionLanguages(List<String> languages) { }

	public uint GetZoneEnableEndTime() { }

	public uint GetZoneEnableStartTime() { }

	public RailZoneID GetZoneID() { }

	public RailResult GetZoneMetadatas(List<RailKeyValue> key_values) { }

	public RailResult GetZoneName(string language_filter, out string zone_name) { }

	public RailResult GetZoneNameLanguages(List<String> languages) { }

	public bool IsZoneJoinable() { }

	public bool IsZoneVisiable() { }

}

