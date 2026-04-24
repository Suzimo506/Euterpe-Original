namespace rail;

public class IRailZoneServerHelperImpl : RailObject, IRailZoneServerHelper
{

	internal IRailZoneServerHelperImpl(IntPtr cPtr) { }

	public override RailResult AsyncSwitchPlayerSelectedZone(RailZoneID zone_id) { }

	protected virtual void Finalize() { }

	public override RailZoneID GetPlayerSelectedZoneID() { }

	public override RailZoneID GetRootZoneID() { }

	public override IRailZoneServer OpenZoneServer(RailZoneID zone_id, out RailResult result) { }

}

