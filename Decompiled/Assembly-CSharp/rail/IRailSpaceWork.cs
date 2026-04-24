using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000396")]
public interface IRailSpaceWork : IRailComponent
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F01")]
	void Close();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F02")]
	SpaceWorkID GetSpaceWorkID();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F03")]
	bool Editable();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F04")]
	RailResult StartSync(string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F05")]
	RailResult GetSyncProgress(RailSpaceWorkSyncProgress progress);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F06")]
	RailResult CancelSync();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F07")]
	RailResult GetWorkLocalFolder(out string path);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F08")]
	RailResult AsyncUpdateMetadata(string user_data);

	[Token(Token = "0x6002F09")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetName(out string name);

	[Token(Token = "0x6002F0A")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetDescription(out string description);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F0B")]
	RailResult GetUrl(out string url);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F0C")]
	uint GetCreateTime();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F0D")]
	uint GetLastUpdateTime();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F0E")]
	ulong GetWorkFileSize();

	[Token(Token = "0x6002F0F")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetTags(List<string> tags);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F10")]
	RailResult GetPreviewImage(out string path);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F11")]
	RailResult GetVersion(out string version);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F12")]
	ulong GetDownloadCount();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F13")]
	ulong GetSubscribedCount();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F14")]
	EnumRailSpaceWorkShareLevel GetShareLevel();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F15")]
	ulong GetScore();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F16")]
	RailResult GetMetadata(string key, out string value);

	[Token(Token = "0x6002F17")]
	[Address(RVA = "0x0", Length = "0x0")]
	EnumRailSpaceWorkRateValue GetMyVote();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F18")]
	bool IsFavorite();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F19")]
	bool IsSubscribed();

	[Token(Token = "0x6002F1A")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult SetName(string name);

	[Token(Token = "0x6002F1B")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult SetDescription(string description);

	[Token(Token = "0x6002F1C")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult SetTags(List<string> tags);

	[Token(Token = "0x6002F1D")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult SetPreviewImage(string path_filename);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F1E")]
	RailResult SetVersion(string version);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F1F")]
	RailResult SetShareLevel(EnumRailSpaceWorkShareLevel level);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F20")]
	RailResult SetShareLevel();

	[Token(Token = "0x6002F21")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult SetMetadata(string key, string value);

	[Token(Token = "0x6002F22")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult SetContentFromFolder(string path);

	[Token(Token = "0x6002F23")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetAllMetadata(List<RailKeyValue> metadata);

	[Token(Token = "0x6002F24")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetAdditionalPreviewUrls(List<string> preview_urls);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F25")]
	RailResult GetAssociatedSpaceWorks(List<SpaceWorkID> ids);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F26")]
	RailResult GetLanguages(List<string> languages);

	[Token(Token = "0x6002F27")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult RemoveMetadata(string key);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F28")]
	RailResult SetAdditionalPreviews(List<string> local_paths);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F29")]
	RailResult SetAssociatedSpaceWorks(List<SpaceWorkID> ids);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F2A")]
	RailResult SetLanguages(List<string> languages);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F2B")]
	RailResult GetPreviewUrl(out string url, uint scaling);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F2C")]
	RailResult GetPreviewUrl(out string url);

	[Token(Token = "0x6002F2D")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetVoteDetail(List<RailSpaceWorkVoteDetail> vote_details);

	[Token(Token = "0x6002F2E")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult GetUploaderIDs(List<RailID> uploader_ids);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F2F")]
	RailResult SetUpdateOptions(RailSpaceWorkUpdateOptions options);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F30")]
	RailResult GetStatistic(EnumRailSpaceWorkStatistic stat_type, out ulong value);

	[Token(Token = "0x6002F31")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult RemovePreviewImage();

	[Token(Token = "0x6002F32")]
	[Address(RVA = "0x0", Length = "0x0")]
	uint GetState();

	[Token(Token = "0x6002F33")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AddAssociatedGameIDs(List<RailGameID> game_ids);

	[Token(Token = "0x6002F34")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult RemoveAssociatedGameIDs(List<RailGameID> game_ids);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F35")]
	RailResult GetAssociatedGameIDs(List<RailGameID> game_ids);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002F36")]
	RailResult GetLocalVersion(out string version);
}
