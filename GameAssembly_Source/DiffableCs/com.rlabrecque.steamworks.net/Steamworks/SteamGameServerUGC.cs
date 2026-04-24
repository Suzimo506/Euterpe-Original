namespace Steamworks;

public static class SteamGameServerUGC
{

	public static SteamAPICall_t AddAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID) { }

	public static SteamAPICall_t AddDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) { }

	public static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName) { }

	public static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue) { }

	public static bool AddItemPreviewFile(UGCUpdateHandle_t handle, string pszPreviewFile, EItemPreviewType type) { }

	public static bool AddItemPreviewVideo(UGCUpdateHandle_t handle, string pszVideoID) { }

	public static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID) { }

	public static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue) { }

	public static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName) { }

	public static bool AddRequiredTagGroup(UGCQueryHandle_t handle, IList<String> pTagGroups) { }

	public static bool BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, string pszFolder) { }

	public static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType) { }

	public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) { }

	public static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, string pchCursor = null) { }

	public static UGCQueryHandle_t CreateQueryUGCDetailsRequest(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	public static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) { }

	public static SteamAPICall_t DeleteItem(PublishedFileId_t nPublishedFileID) { }

	public static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority) { }

	public static SteamAPICall_t GetAppDependencies(PublishedFileId_t nPublishedFileID) { }

	public static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal) { }

	public static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp) { }

	public static uint GetItemState(PublishedFileId_t nPublishedFileID) { }

	public static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal) { }

	public static uint GetNumSubscribedItems() { }

	public static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out string pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType) { }

	public static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) { }

	public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, string pchKey, out string pchValue, uint cchValueSize) { }

	public static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize) { }

	public static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize) { }

	public static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index) { }

	public static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index) { }

	public static uint GetQueryUGCNumTags(UGCQueryHandle_t handle, uint index) { }

	public static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize) { }

	public static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails) { }

	public static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue) { }

	public static bool GetQueryUGCTag(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize) { }

	public static bool GetQueryUGCTagDisplayName(UGCQueryHandle_t handle, uint index, uint indexTag, out string pchValue, uint cchValueSize) { }

	public static uint GetSubscribedItems(PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) { }

	public static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID) { }

	public static SteamAPICall_t GetWorkshopEULAStatus() { }

	public static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle) { }

	public static bool RemoveAllItemKeyValueTags(UGCUpdateHandle_t handle) { }

	public static SteamAPICall_t RemoveAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID) { }

	public static SteamAPICall_t RemoveDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) { }

	public static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID) { }

	public static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey) { }

	public static bool RemoveItemPreview(UGCUpdateHandle_t handle, uint index) { }

	public static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds) { }

	public static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle) { }

	public static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds) { }

	public static bool SetAllowLegacyUpload(UGCUpdateHandle_t handle, bool bAllowLegacyUpload) { }

	public static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName) { }

	public static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder) { }

	public static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription) { }

	public static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData) { }

	public static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile) { }

	public static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<String> pTags) { }

	public static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle) { }

	public static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage) { }

	public static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility) { }

	public static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage) { }

	public static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag) { }

	public static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays) { }

	public static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews) { }

	public static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren) { }

	public static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags) { }

	public static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription) { }

	public static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata) { }

	public static bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs) { }

	public static bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays) { }

	public static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly) { }

	public static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText) { }

	public static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp) { }

	public static bool ShowWorkshopEULA() { }

	public static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID) { }

	public static SteamAPICall_t StartPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	public static SteamAPICall_t StopPlaytimeTracking(PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	public static SteamAPICall_t StopPlaytimeTrackingForAllItems() { }

	public static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote) { }

	public static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID) { }

	public static void SuspendDownloads(bool bSuspend) { }

	public static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID) { }

	public static bool UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, string pszPreviewFile) { }

	public static bool UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, string pszVideoID) { }

}

