namespace rail;

public class IRailStorageHelperImpl : RailObject, IRailStorageHelper
{

	internal IRailStorageHelperImpl(IntPtr cPtr) { }

	public override RailResult AsyncDeleteStreamFile(string filename, string user_data) { }

	public override RailResult AsyncListStreamFiles(string contents, RailListStreamFileOption option, string user_data) { }

	public override RailResult AsyncPublishFileToUserSpace(RailPublishFileToUserSpaceOption option, string user_data) { }

	public override RailResult AsyncQueryQuota() { }

	public override RailResult AsyncRenameStreamFile(string old_filename, string new_filename, string user_data) { }

	public override IRailFile CreateFile(string filename, out RailResult result) { }

	public override IRailFile CreateFile(string filename) { }

	protected virtual void Finalize() { }

	public override uint GetFileCount() { }

	public override RailResult GetFileNameAndSize(uint file_index, out string filename, out ulong file_size) { }

	public override RailResult GetFileTimestamp(string filename, out ulong time_stamp) { }

	public override uint GetRailFileEnabledOS(string filename) { }

	public override bool IsCloudStorageEnabledForApp() { }

	public override bool IsCloudStorageEnabledForPlayer() { }

	public override bool IsFileExist(string filename) { }

	public override bool IsFileSyncedToCloud(string filename) { }

	public override bool ListFiles(List<String> filelist) { }

	public override IRailFile OpenFile(string filename) { }

	public override IRailFile OpenFile(string filename, out RailResult result) { }

	public override IRailStreamFile OpenStreamFile(string filename, RailStreamFileOption option, out RailResult result) { }

	public override IRailStreamFile OpenStreamFile(string filename, RailStreamFileOption option) { }

	public override RailResult RemoveFile(string filename) { }

	public override RailResult SetRailFileEnabledOS(string filename, EnumRailStorageFileEnabledOS sync_os) { }

	public override RailResult SetSyncFileOption(string filename, RailSyncFileOption option) { }

}

