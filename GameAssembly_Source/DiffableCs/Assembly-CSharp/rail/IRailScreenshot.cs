namespace rail;

public interface IRailScreenshot : IRailComponent
{

	public bool AssociatePublishedFiles(List<SpaceWorkID> work_files) { }

	public RailResult AsyncPublishScreenshot(string work_name, string user_data) { }

	public bool SetLocation(string location) { }

	public bool SetUsers(List<RailID> users) { }

}

