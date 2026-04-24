namespace rail;

public class IRailSystemHelperImpl : RailObject, IRailSystemHelper
{

	internal IRailSystemHelperImpl(IntPtr cPtr) { }

	protected virtual void Finalize() { }

	public override RailSystemState GetPlatformSystemState() { }

	public override RailResult SetTerminationTimeoutOwnershipExpired(int timeout_seconds) { }

}

