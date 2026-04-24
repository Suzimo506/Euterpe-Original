namespace rail;

public class IRailScreenshotImpl : RailObject, IRailScreenshot, IRailComponent
{

	internal IRailScreenshotImpl(IntPtr cPtr) { }

	public override bool AssociatePublishedFiles(List<SpaceWorkID> work_files) { }

	public override RailResult AsyncPublishScreenshot(string work_name, string user_data) { }

	protected virtual void Finalize() { }

	public override ulong GetComponentVersion() { }

	public override void Release() { }

	public override bool SetLocation(string location) { }

	public override bool SetUsers(List<RailID> users) { }

}

