namespace rail;

public class RailUsersGetUserLimitsResult : EventBase
{
	public RailID user_id; //Field offset: 0x30
	public List<EnumRailUsersLimits> user_limits; //Field offset: 0x38

	public RailUsersGetUserLimitsResult() { }

}

