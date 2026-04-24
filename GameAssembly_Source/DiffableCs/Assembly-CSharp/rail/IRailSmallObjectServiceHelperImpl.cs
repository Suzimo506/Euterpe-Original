namespace rail;

public class IRailSmallObjectServiceHelperImpl : RailObject, IRailSmallObjectServiceHelper
{

	internal IRailSmallObjectServiceHelperImpl(IntPtr cPtr) { }

	public override RailResult AsyncDownloadObjects(List<UInt32> indexes, string user_data) { }

	public override RailResult AsyncQueryObjectState(string user_data) { }

	protected virtual void Finalize() { }

	public override RailResult GetObjectContent(uint index, out string content) { }

}

