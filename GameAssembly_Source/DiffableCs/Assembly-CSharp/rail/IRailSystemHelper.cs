namespace rail;

public interface IRailSystemHelper
{

	public RailSystemState GetPlatformSystemState() { }

	public RailResult SetTerminationTimeoutOwnershipExpired(int timeout_seconds) { }

}

