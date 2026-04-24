namespace rail;

public class IRailSpaceWorkImpl : RailObject, IRailSpaceWork, IRailComponent
{

	internal IRailSpaceWorkImpl(IntPtr cPtr) { }

	public override RailResult AddAssociatedGameIDs(List<RailGameID> game_ids) { }

	public override RailResult AsyncUpdateMetadata(string user_data) { }

	public override RailResult CancelSync() { }

	public override void Close() { }

	public override bool Editable() { }

	protected virtual void Finalize() { }

	public override RailResult GetAdditionalPreviewUrls(List<String> preview_urls) { }

	public override RailResult GetAllMetadata(List<RailKeyValue> metadata) { }

	public override RailResult GetAssociatedGameIDs(List<RailGameID> game_ids) { }

	public override RailResult GetAssociatedSpaceWorks(List<SpaceWorkID> ids) { }

	public override ulong GetComponentVersion() { }

	public override uint GetCreateTime() { }

	public override RailResult GetDescription(out string description) { }

	public override ulong GetDownloadCount() { }

	public override RailResult GetLanguages(List<String> languages) { }

	public override uint GetLastUpdateTime() { }

	public override RailResult GetLocalVersion(out string version) { }

	public override RailResult GetMetadata(string key, out string value) { }

	public override EnumRailSpaceWorkRateValue GetMyVote() { }

	public override RailResult GetName(out string name) { }

	public override RailResult GetPreviewImage(out string path) { }

	public override RailResult GetPreviewUrl(out string url, uint scaling) { }

	public override RailResult GetPreviewUrl(out string url) { }

	public override ulong GetScore() { }

	public override EnumRailSpaceWorkShareLevel GetShareLevel() { }

	public override SpaceWorkID GetSpaceWorkID() { }

	public override uint GetState() { }

	public override RailResult GetStatistic(EnumRailSpaceWorkStatistic stat_type, out ulong value) { }

	public override ulong GetSubscribedCount() { }

	public override RailResult GetSyncProgress(RailSpaceWorkSyncProgress progress) { }

	public override RailResult GetTags(List<String> tags) { }

	public override RailResult GetUploaderIDs(List<RailID> uploader_ids) { }

	public override RailResult GetUrl(out string url) { }

	public override RailResult GetVersion(out string version) { }

	public override RailResult GetVoteDetail(List<RailSpaceWorkVoteDetail> vote_details) { }

	public override ulong GetWorkFileSize() { }

	public override RailResult GetWorkLocalFolder(out string path) { }

	public override bool IsFavorite() { }

	public override bool IsSubscribed() { }

	public override void Release() { }

	public override RailResult RemoveAssociatedGameIDs(List<RailGameID> game_ids) { }

	public override RailResult RemoveMetadata(string key) { }

	public override RailResult RemovePreviewImage() { }

	public override RailResult SetAdditionalPreviews(List<String> local_paths) { }

	public override RailResult SetAssociatedSpaceWorks(List<SpaceWorkID> ids) { }

	public override RailResult SetContentFromFolder(string path) { }

	public override RailResult SetDescription(string description) { }

	public override RailResult SetLanguages(List<String> languages) { }

	public override RailResult SetMetadata(string key, string value) { }

	public override RailResult SetName(string name) { }

	public override RailResult SetPreviewImage(string path_filename) { }

	public override RailResult SetShareLevel() { }

	public override RailResult SetShareLevel(EnumRailSpaceWorkShareLevel level) { }

	public override RailResult SetTags(List<String> tags) { }

	public override RailResult SetUpdateOptions(RailSpaceWorkUpdateOptions options) { }

	public override RailResult SetVersion(string version) { }

	public override RailResult StartSync(string user_data) { }

}

