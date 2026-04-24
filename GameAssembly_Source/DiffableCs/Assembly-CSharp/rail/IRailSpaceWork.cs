namespace rail;

public interface IRailSpaceWork : IRailComponent
{

	public RailResult AddAssociatedGameIDs(List<RailGameID> game_ids) { }

	public RailResult AsyncUpdateMetadata(string user_data) { }

	public RailResult CancelSync() { }

	public void Close() { }

	public bool Editable() { }

	public RailResult GetAdditionalPreviewUrls(List<String> preview_urls) { }

	public RailResult GetAllMetadata(List<RailKeyValue> metadata) { }

	public RailResult GetAssociatedGameIDs(List<RailGameID> game_ids) { }

	public RailResult GetAssociatedSpaceWorks(List<SpaceWorkID> ids) { }

	public uint GetCreateTime() { }

	public RailResult GetDescription(out string description) { }

	public ulong GetDownloadCount() { }

	public RailResult GetLanguages(List<String> languages) { }

	public uint GetLastUpdateTime() { }

	public RailResult GetLocalVersion(out string version) { }

	public RailResult GetMetadata(string key, out string value) { }

	public EnumRailSpaceWorkRateValue GetMyVote() { }

	public RailResult GetName(out string name) { }

	public RailResult GetPreviewImage(out string path) { }

	public RailResult GetPreviewUrl(out string url) { }

	public RailResult GetPreviewUrl(out string url, uint scaling) { }

	public ulong GetScore() { }

	public EnumRailSpaceWorkShareLevel GetShareLevel() { }

	public SpaceWorkID GetSpaceWorkID() { }

	public uint GetState() { }

	public RailResult GetStatistic(EnumRailSpaceWorkStatistic stat_type, out ulong value) { }

	public ulong GetSubscribedCount() { }

	public RailResult GetSyncProgress(RailSpaceWorkSyncProgress progress) { }

	public RailResult GetTags(List<String> tags) { }

	public RailResult GetUploaderIDs(List<RailID> uploader_ids) { }

	public RailResult GetUrl(out string url) { }

	public RailResult GetVersion(out string version) { }

	public RailResult GetVoteDetail(List<RailSpaceWorkVoteDetail> vote_details) { }

	public ulong GetWorkFileSize() { }

	public RailResult GetWorkLocalFolder(out string path) { }

	public bool IsFavorite() { }

	public bool IsSubscribed() { }

	public RailResult RemoveAssociatedGameIDs(List<RailGameID> game_ids) { }

	public RailResult RemoveMetadata(string key) { }

	public RailResult RemovePreviewImage() { }

	public RailResult SetAdditionalPreviews(List<String> local_paths) { }

	public RailResult SetAssociatedSpaceWorks(List<SpaceWorkID> ids) { }

	public RailResult SetContentFromFolder(string path) { }

	public RailResult SetDescription(string description) { }

	public RailResult SetLanguages(List<String> languages) { }

	public RailResult SetMetadata(string key, string value) { }

	public RailResult SetName(string name) { }

	public RailResult SetPreviewImage(string path_filename) { }

	public RailResult SetShareLevel() { }

	public RailResult SetShareLevel(EnumRailSpaceWorkShareLevel level) { }

	public RailResult SetTags(List<String> tags) { }

	public RailResult SetUpdateOptions(RailSpaceWorkUpdateOptions options) { }

	public RailResult SetVersion(string version) { }

	public RailResult StartSync(string user_data) { }

}

