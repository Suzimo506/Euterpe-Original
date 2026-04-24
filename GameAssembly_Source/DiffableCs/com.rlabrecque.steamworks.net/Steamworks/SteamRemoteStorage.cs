namespace Steamworks;

public static class SteamRemoteStorage
{

	public static bool BeginFileWriteBatch() { }

	public static SteamAPICall_t CommitPublishedFileUpdate(PublishedFileUpdateHandle_t updateHandle) { }

	public static PublishedFileUpdateHandle_t CreatePublishedFileUpdateRequest(PublishedFileId_t unPublishedFileId) { }

	public static SteamAPICall_t DeletePublishedFile(PublishedFileId_t unPublishedFileId) { }

	public static bool EndFileWriteBatch() { }

	public static SteamAPICall_t EnumeratePublishedFilesByUserAction(EWorkshopFileAction eAction, uint unStartIndex) { }

	public static SteamAPICall_t EnumeratePublishedWorkshopFiles(EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IList<String> pTags, IList<String> pUserTags) { }

	public static SteamAPICall_t EnumerateUserPublishedFiles(uint unStartIndex) { }

	public static SteamAPICall_t EnumerateUserSharedWorkshopFiles(CSteamID steamId, uint unStartIndex, IList<String> pRequiredTags, IList<String> pExcludedTags) { }

	public static SteamAPICall_t EnumerateUserSubscribedFiles(uint unStartIndex) { }

	public static bool FileDelete(string pchFile) { }

	public static bool FileExists(string pchFile) { }

	public static bool FileForget(string pchFile) { }

	public static bool FilePersisted(string pchFile) { }

	public static int FileRead(string pchFile, Byte[] pvData, int cubDataToRead) { }

	public static SteamAPICall_t FileReadAsync(string pchFile, uint nOffset, uint cubToRead) { }

	public static bool FileReadAsyncComplete(SteamAPICall_t hReadCall, Byte[] pvBuffer, uint cubToRead) { }

	public static SteamAPICall_t FileShare(string pchFile) { }

	public static bool FileWrite(string pchFile, Byte[] pvData, int cubData) { }

	public static SteamAPICall_t FileWriteAsync(string pchFile, Byte[] pvData, uint cubData) { }

	public static bool FileWriteStreamCancel(UGCFileWriteStreamHandle_t writeHandle) { }

	public static bool FileWriteStreamClose(UGCFileWriteStreamHandle_t writeHandle) { }

	public static UGCFileWriteStreamHandle_t FileWriteStreamOpen(string pchFile) { }

	public static bool FileWriteStreamWriteChunk(UGCFileWriteStreamHandle_t writeHandle, Byte[] pvData, int cubData) { }

	public static int GetCachedUGCCount() { }

	public static UGCHandle_t GetCachedUGCHandle(int iCachedContent) { }

	public static int GetFileCount() { }

	public static string GetFileNameAndSize(int iFile, out int pnFileSizeInBytes) { }

	public static int GetFileSize(string pchFile) { }

	public static long GetFileTimestamp(string pchFile) { }

	public static string GetLocalFileChange(int iFile, out ERemoteStorageLocalFileChange pEChangeType, out ERemoteStorageFilePathType pEFilePathType) { }

	public static int GetLocalFileChangeCount() { }

	public static SteamAPICall_t GetPublishedFileDetails(PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld) { }

	public static SteamAPICall_t GetPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId) { }

	public static bool GetQuota(out ulong pnTotalBytes, out ulong puAvailableBytes) { }

	public static ERemoteStoragePlatform GetSyncPlatforms(string pchFile) { }

	public static bool GetUGCDetails(UGCHandle_t hContent, out AppId_t pnAppID, out string ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner) { }

	public static bool GetUGCDownloadProgress(UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected) { }

	public static SteamAPICall_t GetUserPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId) { }

	public static bool IsCloudEnabledForAccount() { }

	public static bool IsCloudEnabledForApp() { }

	public static SteamAPICall_t PublishVideo(EWorkshopVideoProvider eVideoProvider, string pchVideoAccount, string pchVideoIdentifier, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<String> pTags) { }

	public static SteamAPICall_t PublishWorkshopFile(string pchFile, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<String> pTags, EWorkshopFileType eWorkshopFileType) { }

	public static void SetCloudEnabledForApp(bool bEnabled) { }

	public static bool SetSyncPlatforms(string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform) { }

	public static SteamAPICall_t SetUserPublishedFileAction(PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction) { }

	public static SteamAPICall_t SubscribePublishedFile(PublishedFileId_t unPublishedFileId) { }

	public static SteamAPICall_t UGCDownload(UGCHandle_t hContent, uint unPriority) { }

	public static SteamAPICall_t UGCDownloadToLocation(UGCHandle_t hContent, string pchLocation, uint unPriority) { }

	public static int UGCRead(UGCHandle_t hContent, Byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction) { }

	public static SteamAPICall_t UnsubscribePublishedFile(PublishedFileId_t unPublishedFileId) { }

	public static bool UpdatePublishedFileDescription(PublishedFileUpdateHandle_t updateHandle, string pchDescription) { }

	public static bool UpdatePublishedFileFile(PublishedFileUpdateHandle_t updateHandle, string pchFile) { }

	public static bool UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle_t updateHandle, string pchPreviewFile) { }

	public static bool UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle_t updateHandle, string pchChangeDescription) { }

	public static bool UpdatePublishedFileTags(PublishedFileUpdateHandle_t updateHandle, IList<String> pTags) { }

	public static bool UpdatePublishedFileTitle(PublishedFileUpdateHandle_t updateHandle, string pchTitle) { }

	public static bool UpdatePublishedFileVisibility(PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility) { }

	public static SteamAPICall_t UpdateUserPublishedItemVote(PublishedFileId_t unPublishedFileId, bool bVoteUp) { }

}

