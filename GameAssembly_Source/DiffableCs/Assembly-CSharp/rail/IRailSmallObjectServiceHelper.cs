namespace rail;

public interface IRailSmallObjectServiceHelper
{

	public RailResult AsyncDownloadObjects(List<UInt32> indexes, string user_data) { }

	public RailResult AsyncQueryObjectState(string user_data) { }

	public RailResult GetObjectContent(uint index, out string content) { }

}

