namespace rail;

public interface IRailStorageHelper
{

	public RailResult AsyncDeleteStreamFile(string filename, string user_data) { }

	public RailResult AsyncListStreamFiles(string contents, RailListStreamFileOption option, string user_data) { }

	public RailResult AsyncPublishFileToUserSpace(RailPublishFileToUserSpaceOption option, string user_data) { }

	public RailResult AsyncQueryQuota() { }

	public RailResult AsyncRenameStreamFile(string old_filename, string new_filename, string user_data) { }

	public IRailFile CreateFile(string filename, out RailResult result) { }

	public IRailFile CreateFile(string filename) { }

	public uint GetFileCount() { }

	public RailResult GetFileNameAndSize(uint file_index, out string filename, out ulong file_size) { }

	public RailResult GetFileTimestamp(string filename, out ulong time_stamp) { }

	public uint GetRailFileEnabledOS(string filename) { }

	public bool IsCloudStorageEnabledForApp() { }

	public bool IsCloudStorageEnabledForPlayer() { }

	public bool IsFileExist(string filename) { }

	public bool IsFileSyncedToCloud(string filename) { }

	public bool ListFiles(List<String> filelist) { }

	public IRailFile OpenFile(string filename, out RailResult result) { }

	public IRailFile OpenFile(string filename) { }

	public IRailStreamFile OpenStreamFile(string filename, RailStreamFileOption option) { }

	public IRailStreamFile OpenStreamFile(string filename, RailStreamFileOption option, out RailResult result) { }

	public RailResult RemoveFile(string filename) { }

	public RailResult SetRailFileEnabledOS(string filename, EnumRailStorageFileEnabledOS sync_os) { }

	public RailResult SetSyncFileOption(string filename, RailSyncFileOption option) { }

}

