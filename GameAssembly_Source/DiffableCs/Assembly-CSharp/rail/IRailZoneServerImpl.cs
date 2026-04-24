namespace rail;

public class IRailZoneServerImpl : RailObject, IRailZoneServer, IRailComponent
{

	internal IRailZoneServerImpl(IntPtr cPtr) { }

	protected virtual void Finalize() { }

	public override RailResult GetChildrenZoneIDs(List<RailZoneID> zone_ids) { }

	public override ulong GetComponentVersion() { }

	public override RailResult GetGameServerAddresses(List<String> server_addresses) { }

	public override RailResult GetZoneDescription(string language_filter, out string zone_description) { }

	public override RailResult GetZoneDescriptionLanguages(List<String> languages) { }

	public override uint GetZoneEnableEndTime() { }

	public override uint GetZoneEnableStartTime() { }

	public override RailZoneID GetZoneID() { }

	public override RailResult GetZoneMetadatas(List<RailKeyValue> key_values) { }

	public override RailResult GetZoneName(string language_filter, out string zone_name) { }

	public override RailResult GetZoneNameLanguages(List<String> languages) { }

	public override bool IsZoneJoinable() { }

	public override bool IsZoneVisiable() { }

	public override void Release() { }

}

