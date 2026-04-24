namespace Steamworks;

[SuppressUnmanagedCodeSecurity]
internal static class NativeMethods
{
	internal const string NativeLibraryName = "steam_api64"; //Field offset: 0x0
	internal const string NativeLibrary_SDKEncryptedAppTicket = "sdkencryptedappticket64"; //Field offset: 0x0

	public static int ISteamAppList_GetAppBuildId(IntPtr instancePtr, AppId_t nAppID) { }

	public static int ISteamAppList_GetAppInstallDir(IntPtr instancePtr, AppId_t nAppID, IntPtr pchDirectory, int cchNameMax) { }

	public static int ISteamAppList_GetAppName(IntPtr instancePtr, AppId_t nAppID, IntPtr pchName, int cchNameMax) { }

	public static uint ISteamAppList_GetInstalledApps(IntPtr instancePtr, out AppId_t[] pvecAppID, uint unMaxAppIDs) { }

	public static uint ISteamAppList_GetNumInstalledApps(IntPtr instancePtr) { }

	public static bool ISteamApps_BGetDLCDataByIndex(IntPtr instancePtr, int iDLC, out AppId_t pAppID, out bool pbAvailable, IntPtr pchName, int cchNameBufferSize) { }

	public static bool ISteamApps_BIsAppInstalled(IntPtr instancePtr, AppId_t appID) { }

	public static bool ISteamApps_BIsCybercafe(IntPtr instancePtr) { }

	public static bool ISteamApps_BIsDlcInstalled(IntPtr instancePtr, AppId_t appID) { }

	public static bool ISteamApps_BIsLowViolence(IntPtr instancePtr) { }

	public static bool ISteamApps_BIsSubscribed(IntPtr instancePtr) { }

	public static bool ISteamApps_BIsSubscribedApp(IntPtr instancePtr, AppId_t appID) { }

	public static bool ISteamApps_BIsSubscribedFromFamilySharing(IntPtr instancePtr) { }

	public static bool ISteamApps_BIsSubscribedFromFreeWeekend(IntPtr instancePtr) { }

	public static bool ISteamApps_BIsTimedTrial(IntPtr instancePtr, out uint punSecondsAllowed, out uint punSecondsPlayed) { }

	public static bool ISteamApps_BIsVACBanned(IntPtr instancePtr) { }

	public static int ISteamApps_GetAppBuildId(IntPtr instancePtr) { }

	public static uint ISteamApps_GetAppInstallDir(IntPtr instancePtr, AppId_t appID, IntPtr pchFolder, uint cchFolderBufferSize) { }

	public static ulong ISteamApps_GetAppOwner(IntPtr instancePtr) { }

	public static IntPtr ISteamApps_GetAvailableGameLanguages(IntPtr instancePtr) { }

	public static bool ISteamApps_GetCurrentBetaName(IntPtr instancePtr, IntPtr pchName, int cchNameBufferSize) { }

	public static IntPtr ISteamApps_GetCurrentGameLanguage(IntPtr instancePtr) { }

	public static int ISteamApps_GetDLCCount(IntPtr instancePtr) { }

	public static bool ISteamApps_GetDlcDownloadProgress(IntPtr instancePtr, AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal) { }

	public static uint ISteamApps_GetEarliestPurchaseUnixTime(IntPtr instancePtr, AppId_t nAppID) { }

	public static ulong ISteamApps_GetFileDetails(IntPtr instancePtr, UTF8StringHandle pszFileName) { }

	public static uint ISteamApps_GetInstalledDepots(IntPtr instancePtr, AppId_t appID, out DepotId_t[] pvecDepots, uint cMaxDepots) { }

	public static int ISteamApps_GetLaunchCommandLine(IntPtr instancePtr, IntPtr pszCommandLine, int cubCommandLine) { }

	public static IntPtr ISteamApps_GetLaunchQueryParam(IntPtr instancePtr, UTF8StringHandle pchKey) { }

	public static void ISteamApps_InstallDLC(IntPtr instancePtr, AppId_t nAppID) { }

	public static bool ISteamApps_MarkContentCorrupt(IntPtr instancePtr, bool bMissingFilesOnly) { }

	public static void ISteamApps_RequestAllProofOfPurchaseKeys(IntPtr instancePtr) { }

	public static void ISteamApps_RequestAppProofOfPurchaseKey(IntPtr instancePtr, AppId_t nAppID) { }

	public static void ISteamApps_UninstallDLC(IntPtr instancePtr, AppId_t nAppID) { }

	public static bool ISteamClient_BReleaseSteamPipe(IntPtr instancePtr, HSteamPipe hSteamPipe) { }

	public static bool ISteamClient_BShutdownIfAllPipesClosed(IntPtr instancePtr) { }

	public static int ISteamClient_ConnectToGlobalUser(IntPtr instancePtr, HSteamPipe hSteamPipe) { }

	public static int ISteamClient_CreateLocalUser(IntPtr instancePtr, out HSteamPipe phSteamPipe, EAccountType eAccountType) { }

	public static int ISteamClient_CreateSteamPipe(IntPtr instancePtr) { }

	public static uint ISteamClient_GetIPCCallCount(IntPtr instancePtr) { }

	public static IntPtr ISteamClient_GetISteamAppList(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamApps(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamController(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamFriends(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamGameSearch(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamGameServer(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamGameServerStats(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamGenericInterface(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamHTMLSurface(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamHTTP(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamInput(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamInventory(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamMatchmaking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamMatchmakingServers(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamMusic(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamMusicRemote(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamNetworking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamParentalSettings(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamParties(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamRemotePlay(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamRemoteStorage(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamScreenshots(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamUGC(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamUser(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamUserStats(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamUtils(IntPtr instancePtr, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static IntPtr ISteamClient_GetISteamVideo(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, UTF8StringHandle pchVersion) { }

	public static void ISteamClient_ReleaseUser(IntPtr instancePtr, HSteamPipe hSteamPipe, HSteamUser hUser) { }

	public static void ISteamClient_SetLocalIPBinding(IntPtr instancePtr, ref SteamIPAddress_t unIP, ushort usPort) { }

	public static void ISteamClient_SetWarningMessageHook(IntPtr instancePtr, SteamAPIWarningMessageHook_t pFunction) { }

	public static void ISteamFriends_ActivateGameOverlay(IntPtr instancePtr, UTF8StringHandle pchDialog) { }

	public static void ISteamFriends_ActivateGameOverlayInviteDialog(IntPtr instancePtr, CSteamID steamIDLobby) { }

	public static void ISteamFriends_ActivateGameOverlayInviteDialogConnectString(IntPtr instancePtr, UTF8StringHandle pchConnectString) { }

	public static void ISteamFriends_ActivateGameOverlayRemotePlayTogetherInviteDialog(IntPtr instancePtr, CSteamID steamIDLobby) { }

	public static void ISteamFriends_ActivateGameOverlayToStore(IntPtr instancePtr, AppId_t nAppID, EOverlayToStoreFlag eFlag) { }

	public static void ISteamFriends_ActivateGameOverlayToUser(IntPtr instancePtr, UTF8StringHandle pchDialog, CSteamID steamID) { }

	public static void ISteamFriends_ActivateGameOverlayToWebPage(IntPtr instancePtr, UTF8StringHandle pchURL, EActivateGameOverlayToWebPageMode eMode) { }

	public static void ISteamFriends_ClearRichPresence(IntPtr instancePtr) { }

	public static bool ISteamFriends_CloseClanChatWindowInSteam(IntPtr instancePtr, CSteamID steamIDClanChat) { }

	public static ulong ISteamFriends_DownloadClanActivityCounts(IntPtr instancePtr, out CSteamID[] psteamIDClans, int cClansToRequest) { }

	public static ulong ISteamFriends_EnumerateFollowingList(IntPtr instancePtr, uint unStartIndex) { }

	public static ulong ISteamFriends_GetChatMemberByIndex(IntPtr instancePtr, CSteamID steamIDClan, int iUser) { }

	public static bool ISteamFriends_GetClanActivityCounts(IntPtr instancePtr, CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting) { }

	public static ulong ISteamFriends_GetClanByIndex(IntPtr instancePtr, int iClan) { }

	public static int ISteamFriends_GetClanChatMemberCount(IntPtr instancePtr, CSteamID steamIDClan) { }

	public static int ISteamFriends_GetClanChatMessage(IntPtr instancePtr, CSteamID steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter) { }

	public static int ISteamFriends_GetClanCount(IntPtr instancePtr) { }

	public static IntPtr ISteamFriends_GetClanName(IntPtr instancePtr, CSteamID steamIDClan) { }

	public static ulong ISteamFriends_GetClanOfficerByIndex(IntPtr instancePtr, CSteamID steamIDClan, int iOfficer) { }

	public static int ISteamFriends_GetClanOfficerCount(IntPtr instancePtr, CSteamID steamIDClan) { }

	public static ulong ISteamFriends_GetClanOwner(IntPtr instancePtr, CSteamID steamIDClan) { }

	public static IntPtr ISteamFriends_GetClanTag(IntPtr instancePtr, CSteamID steamIDClan) { }

	public static ulong ISteamFriends_GetCoplayFriend(IntPtr instancePtr, int iCoplayFriend) { }

	public static int ISteamFriends_GetCoplayFriendCount(IntPtr instancePtr) { }

	public static ulong ISteamFriends_GetFollowerCount(IntPtr instancePtr, CSteamID steamID) { }

	public static ulong ISteamFriends_GetFriendByIndex(IntPtr instancePtr, int iFriend, EFriendFlags iFriendFlags) { }

	public static uint ISteamFriends_GetFriendCoplayGame(IntPtr instancePtr, CSteamID steamIDFriend) { }

	public static int ISteamFriends_GetFriendCoplayTime(IntPtr instancePtr, CSteamID steamIDFriend) { }

	public static int ISteamFriends_GetFriendCount(IntPtr instancePtr, EFriendFlags iFriendFlags) { }

	public static int ISteamFriends_GetFriendCountFromSource(IntPtr instancePtr, CSteamID steamIDSource) { }

	public static ulong ISteamFriends_GetFriendFromSourceByIndex(IntPtr instancePtr, CSteamID steamIDSource, int iFriend) { }

	public static bool ISteamFriends_GetFriendGamePlayed(IntPtr instancePtr, CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo) { }

	public static int ISteamFriends_GetFriendMessage(IntPtr instancePtr, CSteamID steamIDFriend, int iMessageID, IntPtr pvData, int cubData, out EChatEntryType peChatEntryType) { }

	public static IntPtr ISteamFriends_GetFriendPersonaName(IntPtr instancePtr, CSteamID steamIDFriend) { }

	public static IntPtr ISteamFriends_GetFriendPersonaNameHistory(IntPtr instancePtr, CSteamID steamIDFriend, int iPersonaName) { }

	public static EPersonaState ISteamFriends_GetFriendPersonaState(IntPtr instancePtr, CSteamID steamIDFriend) { }

	public static EFriendRelationship ISteamFriends_GetFriendRelationship(IntPtr instancePtr, CSteamID steamIDFriend) { }

	public static IntPtr ISteamFriends_GetFriendRichPresence(IntPtr instancePtr, CSteamID steamIDFriend, UTF8StringHandle pchKey) { }

	public static IntPtr ISteamFriends_GetFriendRichPresenceKeyByIndex(IntPtr instancePtr, CSteamID steamIDFriend, int iKey) { }

	public static int ISteamFriends_GetFriendRichPresenceKeyCount(IntPtr instancePtr, CSteamID steamIDFriend) { }

	public static int ISteamFriends_GetFriendsGroupCount(IntPtr instancePtr) { }

	public static short ISteamFriends_GetFriendsGroupIDByIndex(IntPtr instancePtr, int iFG) { }

	public static int ISteamFriends_GetFriendsGroupMembersCount(IntPtr instancePtr, FriendsGroupID_t friendsGroupID) { }

	public static void ISteamFriends_GetFriendsGroupMembersList(IntPtr instancePtr, FriendsGroupID_t friendsGroupID, out CSteamID[] pOutSteamIDMembers, int nMembersCount) { }

	public static IntPtr ISteamFriends_GetFriendsGroupName(IntPtr instancePtr, FriendsGroupID_t friendsGroupID) { }

	public static int ISteamFriends_GetFriendSteamLevel(IntPtr instancePtr, CSteamID steamIDFriend) { }

	public static int ISteamFriends_GetLargeFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend) { }

	public static int ISteamFriends_GetMediumFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend) { }

	public static int ISteamFriends_GetNumChatsWithUnreadPriorityMessages(IntPtr instancePtr) { }

	public static IntPtr ISteamFriends_GetPersonaName(IntPtr instancePtr) { }

	public static EPersonaState ISteamFriends_GetPersonaState(IntPtr instancePtr) { }

	public static IntPtr ISteamFriends_GetPlayerNickname(IntPtr instancePtr, CSteamID steamIDPlayer) { }

	public static int ISteamFriends_GetSmallFriendAvatar(IntPtr instancePtr, CSteamID steamIDFriend) { }

	public static uint ISteamFriends_GetUserRestrictions(IntPtr instancePtr) { }

	public static bool ISteamFriends_HasFriend(IntPtr instancePtr, CSteamID steamIDFriend, EFriendFlags iFriendFlags) { }

	public static bool ISteamFriends_InviteUserToGame(IntPtr instancePtr, CSteamID steamIDFriend, UTF8StringHandle pchConnectString) { }

	public static bool ISteamFriends_IsClanChatAdmin(IntPtr instancePtr, CSteamID steamIDClanChat, CSteamID steamIDUser) { }

	public static bool ISteamFriends_IsClanChatWindowOpenInSteam(IntPtr instancePtr, CSteamID steamIDClanChat) { }

	public static bool ISteamFriends_IsClanOfficialGameGroup(IntPtr instancePtr, CSteamID steamIDClan) { }

	public static bool ISteamFriends_IsClanPublic(IntPtr instancePtr, CSteamID steamIDClan) { }

	public static ulong ISteamFriends_IsFollowing(IntPtr instancePtr, CSteamID steamID) { }

	public static bool ISteamFriends_IsUserInSource(IntPtr instancePtr, CSteamID steamIDUser, CSteamID steamIDSource) { }

	public static ulong ISteamFriends_JoinClanChatRoom(IntPtr instancePtr, CSteamID steamIDClan) { }

	public static bool ISteamFriends_LeaveClanChatRoom(IntPtr instancePtr, CSteamID steamIDClan) { }

	public static bool ISteamFriends_OpenClanChatWindowInSteam(IntPtr instancePtr, CSteamID steamIDClanChat) { }

	public static bool ISteamFriends_RegisterProtocolInOverlayBrowser(IntPtr instancePtr, UTF8StringHandle pchProtocol) { }

	public static bool ISteamFriends_ReplyToFriendMessage(IntPtr instancePtr, CSteamID steamIDFriend, UTF8StringHandle pchMsgToSend) { }

	public static ulong ISteamFriends_RequestClanOfficerList(IntPtr instancePtr, CSteamID steamIDClan) { }

	public static void ISteamFriends_RequestFriendRichPresence(IntPtr instancePtr, CSteamID steamIDFriend) { }

	public static bool ISteamFriends_RequestUserInformation(IntPtr instancePtr, CSteamID steamIDUser, bool bRequireNameOnly) { }

	public static bool ISteamFriends_SendClanChatMessage(IntPtr instancePtr, CSteamID steamIDClanChat, UTF8StringHandle pchText) { }

	public static void ISteamFriends_SetInGameVoiceSpeaking(IntPtr instancePtr, CSteamID steamIDUser, bool bSpeaking) { }

	public static bool ISteamFriends_SetListenForFriendsMessages(IntPtr instancePtr, bool bInterceptEnabled) { }

	public static ulong ISteamFriends_SetPersonaName(IntPtr instancePtr, UTF8StringHandle pchPersonaName) { }

	public static void ISteamFriends_SetPlayedWith(IntPtr instancePtr, CSteamID steamIDUserPlayedWith) { }

	public static bool ISteamFriends_SetRichPresence(IntPtr instancePtr, UTF8StringHandle pchKey, UTF8StringHandle pchValue) { }

	public static EGameSearchErrorCode_t ISteamGameSearch_AcceptGame(IntPtr instancePtr) { }

	public static EGameSearchErrorCode_t ISteamGameSearch_AddGameSearchParams(IntPtr instancePtr, UTF8StringHandle pchKeyToFind, UTF8StringHandle pchValuesToFind) { }

	public static EGameSearchErrorCode_t ISteamGameSearch_CancelRequestPlayersForGame(IntPtr instancePtr) { }

	public static EGameSearchErrorCode_t ISteamGameSearch_DeclineGame(IntPtr instancePtr) { }

	public static EGameSearchErrorCode_t ISteamGameSearch_EndGame(IntPtr instancePtr, ulong ullUniqueGameID) { }

	public static EGameSearchErrorCode_t ISteamGameSearch_EndGameSearch(IntPtr instancePtr) { }

	public static EGameSearchErrorCode_t ISteamGameSearch_HostConfirmGameStart(IntPtr instancePtr, ulong ullUniqueGameID) { }

	public static EGameSearchErrorCode_t ISteamGameSearch_RequestPlayersForGame(IntPtr instancePtr, int nPlayerMin, int nPlayerMax, int nMaxTeamSize) { }

	public static EGameSearchErrorCode_t ISteamGameSearch_RetrieveConnectionDetails(IntPtr instancePtr, CSteamID steamIDHost, IntPtr pchConnectionDetails, int cubConnectionDetails) { }

	public static EGameSearchErrorCode_t ISteamGameSearch_SearchForGameSolo(IntPtr instancePtr, int nPlayerMin, int nPlayerMax) { }

	public static EGameSearchErrorCode_t ISteamGameSearch_SearchForGameWithLobby(IntPtr instancePtr, CSteamID steamIDLobby, int nPlayerMin, int nPlayerMax) { }

	public static EGameSearchErrorCode_t ISteamGameSearch_SetConnectionDetails(IntPtr instancePtr, UTF8StringHandle pchConnectionDetails, int cubConnectionDetails) { }

	public static EGameSearchErrorCode_t ISteamGameSearch_SetGameHostParams(IntPtr instancePtr, UTF8StringHandle pchKey, UTF8StringHandle pchValue) { }

	public static EGameSearchErrorCode_t ISteamGameSearch_SubmitPlayerResult(IntPtr instancePtr, ulong ullUniqueGameID, CSteamID steamIDPlayer, EPlayerResult_t EPlayerResult) { }

	public static ulong ISteamGameServer_AssociateWithClan(IntPtr instancePtr, CSteamID steamIDClan) { }

	public static EBeginAuthSessionResult ISteamGameServer_BeginAuthSession(IntPtr instancePtr, Byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID) { }

	public static bool ISteamGameServer_BLoggedOn(IntPtr instancePtr) { }

	public static bool ISteamGameServer_BSecure(IntPtr instancePtr) { }

	public static bool ISteamGameServer_BUpdateUserData(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchPlayerName, uint uScore) { }

	public static void ISteamGameServer_CancelAuthTicket(IntPtr instancePtr, HAuthTicket hAuthTicket) { }

	public static void ISteamGameServer_ClearAllKeyValues(IntPtr instancePtr) { }

	public static ulong ISteamGameServer_ComputeNewPlayerCompatibility(IntPtr instancePtr, CSteamID steamIDNewPlayer) { }

	public static ulong ISteamGameServer_CreateUnauthenticatedUserConnection(IntPtr instancePtr) { }

	public static void ISteamGameServer_EndAuthSession(IntPtr instancePtr, CSteamID steamID) { }

	public static uint ISteamGameServer_GetAuthSessionTicket(IntPtr instancePtr, Byte[] pTicket, int cbMaxTicket, out uint pcbTicket) { }

	public static void ISteamGameServer_GetGameplayStats(IntPtr instancePtr) { }

	public static int ISteamGameServer_GetNextOutgoingPacket(IntPtr instancePtr, Byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort) { }

	public static SteamIPAddress_t ISteamGameServer_GetPublicIP(IntPtr instancePtr) { }

	public static ulong ISteamGameServer_GetServerReputation(IntPtr instancePtr) { }

	public static ulong ISteamGameServer_GetSteamID(IntPtr instancePtr) { }

	public static bool ISteamGameServer_HandleIncomingPacket(IntPtr instancePtr, Byte[] pData, int cbData, uint srcIP, ushort srcPort) { }

	public static void ISteamGameServer_LogOff(IntPtr instancePtr) { }

	public static void ISteamGameServer_LogOn(IntPtr instancePtr, UTF8StringHandle pszToken) { }

	public static void ISteamGameServer_LogOnAnonymous(IntPtr instancePtr) { }

	public static bool ISteamGameServer_RequestUserGroupStatus(IntPtr instancePtr, CSteamID steamIDUser, CSteamID steamIDGroup) { }

	public static bool ISteamGameServer_SendUserConnectAndAuthenticate_DEPRECATED(IntPtr instancePtr, uint unIPClient, Byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser) { }

	public static void ISteamGameServer_SendUserDisconnect_DEPRECATED(IntPtr instancePtr, CSteamID steamIDUser) { }

	public static void ISteamGameServer_SetAdvertiseServerActive(IntPtr instancePtr, bool bActive) { }

	public static void ISteamGameServer_SetBotPlayerCount(IntPtr instancePtr, int cBotplayers) { }

	public static void ISteamGameServer_SetDedicatedServer(IntPtr instancePtr, bool bDedicated) { }

	public static void ISteamGameServer_SetGameData(IntPtr instancePtr, UTF8StringHandle pchGameData) { }

	public static void ISteamGameServer_SetGameDescription(IntPtr instancePtr, UTF8StringHandle pszGameDescription) { }

	public static void ISteamGameServer_SetGameTags(IntPtr instancePtr, UTF8StringHandle pchGameTags) { }

	public static void ISteamGameServer_SetKeyValue(IntPtr instancePtr, UTF8StringHandle pKey, UTF8StringHandle pValue) { }

	public static void ISteamGameServer_SetMapName(IntPtr instancePtr, UTF8StringHandle pszMapName) { }

	public static void ISteamGameServer_SetMaxPlayerCount(IntPtr instancePtr, int cPlayersMax) { }

	public static void ISteamGameServer_SetModDir(IntPtr instancePtr, UTF8StringHandle pszModDir) { }

	public static void ISteamGameServer_SetPasswordProtected(IntPtr instancePtr, bool bPasswordProtected) { }

	public static void ISteamGameServer_SetProduct(IntPtr instancePtr, UTF8StringHandle pszProduct) { }

	public static void ISteamGameServer_SetRegion(IntPtr instancePtr, UTF8StringHandle pszRegion) { }

	public static void ISteamGameServer_SetServerName(IntPtr instancePtr, UTF8StringHandle pszServerName) { }

	public static void ISteamGameServer_SetSpectatorPort(IntPtr instancePtr, ushort unSpectatorPort) { }

	public static void ISteamGameServer_SetSpectatorServerName(IntPtr instancePtr, UTF8StringHandle pszSpectatorServerName) { }

	public static EUserHasLicenseForAppResult ISteamGameServer_UserHasLicenseForApp(IntPtr instancePtr, CSteamID steamID, AppId_t appID) { }

	public static bool ISteamGameServer_WasRestartRequested(IntPtr instancePtr) { }

	public static bool ISteamGameServerStats_ClearUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName) { }

	public static bool ISteamGameServerStats_GetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName, out bool pbAchieved) { }

	public static bool ISteamGameServerStats_GetUserStatFloat(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName, out float pData) { }

	public static bool ISteamGameServerStats_GetUserStatInt32(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName, out int pData) { }

	public static ulong ISteamGameServerStats_RequestUserStats(IntPtr instancePtr, CSteamID steamIDUser) { }

	public static bool ISteamGameServerStats_SetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName) { }

	public static bool ISteamGameServerStats_SetUserStatFloat(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName, float fData) { }

	public static bool ISteamGameServerStats_SetUserStatInt32(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName, int nData) { }

	public static ulong ISteamGameServerStats_StoreUserStats(IntPtr instancePtr, CSteamID steamIDUser) { }

	public static bool ISteamGameServerStats_UpdateUserAvgRateStat(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName, float flCountThisSession, double dSessionLength) { }

	public static void ISteamHTMLSurface_AddHeader(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, UTF8StringHandle pchKey, UTF8StringHandle pchValue) { }

	public static void ISteamHTMLSurface_AllowStartRequest(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bAllowed) { }

	public static void ISteamHTMLSurface_CopyToClipboard(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	public static ulong ISteamHTMLSurface_CreateBrowser(IntPtr instancePtr, UTF8StringHandle pchUserAgent, UTF8StringHandle pchUserCSS) { }

	public static void ISteamHTMLSurface_ExecuteJavascript(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, UTF8StringHandle pchScript) { }

	public static void ISteamHTMLSurface_FileLoadDialogResponse(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles) { }

	public static void ISteamHTMLSurface_Find(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, UTF8StringHandle pchSearchStr, bool bCurrentlyInFind, bool bReverse) { }

	public static void ISteamHTMLSurface_GetLinkAtPosition(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int x, int y) { }

	public static void ISteamHTMLSurface_GoBack(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	public static void ISteamHTMLSurface_GoForward(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	public static bool ISteamHTMLSurface_Init(IntPtr instancePtr) { }

	public static void ISteamHTMLSurface_JSDialogResponse(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bResult) { }

	public static void ISteamHTMLSurface_KeyChar(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers) { }

	public static void ISteamHTMLSurface_KeyDown(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers, bool bIsSystemKey) { }

	public static void ISteamHTMLSurface_KeyUp(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers) { }

	public static void ISteamHTMLSurface_LoadURL(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, UTF8StringHandle pchURL, UTF8StringHandle pchPostData) { }

	public static void ISteamHTMLSurface_MouseDoubleClick(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) { }

	public static void ISteamHTMLSurface_MouseDown(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) { }

	public static void ISteamHTMLSurface_MouseMove(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int x, int y) { }

	public static void ISteamHTMLSurface_MouseUp(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton) { }

	public static void ISteamHTMLSurface_MouseWheel(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, int nDelta) { }

	public static void ISteamHTMLSurface_OpenDeveloperTools(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	public static void ISteamHTMLSurface_PasteFromClipboard(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	public static void ISteamHTMLSurface_Reload(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	public static void ISteamHTMLSurface_RemoveBrowser(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	public static void ISteamHTMLSurface_SetBackgroundMode(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bBackgroundMode) { }

	public static void ISteamHTMLSurface_SetCookie(IntPtr instancePtr, UTF8StringHandle pchHostname, UTF8StringHandle pchKey, UTF8StringHandle pchValue, UTF8StringHandle pchPath, uint nExpires, bool bSecure, bool bHTTPOnly) { }

	public static void ISteamHTMLSurface_SetDPIScalingFactor(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, float flDPIScaling) { }

	public static void ISteamHTMLSurface_SetHorizontalScroll(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll) { }

	public static void ISteamHTMLSurface_SetKeyFocus(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, bool bHasKeyFocus) { }

	public static void ISteamHTMLSurface_SetPageScaleFactor(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY) { }

	public static void ISteamHTMLSurface_SetSize(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight) { }

	public static void ISteamHTMLSurface_SetVerticalScroll(IntPtr instancePtr, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll) { }

	public static bool ISteamHTMLSurface_Shutdown(IntPtr instancePtr) { }

	public static void ISteamHTMLSurface_StopFind(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	public static void ISteamHTMLSurface_StopLoad(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	public static void ISteamHTMLSurface_ViewSource(IntPtr instancePtr, HHTMLBrowser unBrowserHandle) { }

	public static uint ISteamHTTP_CreateCookieContainer(IntPtr instancePtr, bool bAllowResponsesToModify) { }

	public static uint ISteamHTTP_CreateHTTPRequest(IntPtr instancePtr, EHTTPMethod eHTTPRequestMethod, UTF8StringHandle pchAbsoluteURL) { }

	public static bool ISteamHTTP_DeferHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest) { }

	public static bool ISteamHTTP_GetHTTPDownloadProgressPct(IntPtr instancePtr, HTTPRequestHandle hRequest, out float pflPercentOut) { }

	public static bool ISteamHTTP_GetHTTPRequestWasTimedOut(IntPtr instancePtr, HTTPRequestHandle hRequest, out bool pbWasTimedOut) { }

	public static bool ISteamHTTP_GetHTTPResponseBodyData(IntPtr instancePtr, HTTPRequestHandle hRequest, Byte[] pBodyDataBuffer, uint unBufferSize) { }

	public static bool ISteamHTTP_GetHTTPResponseBodySize(IntPtr instancePtr, HTTPRequestHandle hRequest, out uint unBodySize) { }

	public static bool ISteamHTTP_GetHTTPResponseHeaderSize(IntPtr instancePtr, HTTPRequestHandle hRequest, UTF8StringHandle pchHeaderName, out uint unResponseHeaderSize) { }

	public static bool ISteamHTTP_GetHTTPResponseHeaderValue(IntPtr instancePtr, HTTPRequestHandle hRequest, UTF8StringHandle pchHeaderName, Byte[] pHeaderValueBuffer, uint unBufferSize) { }

	public static bool ISteamHTTP_GetHTTPStreamingResponseBodyData(IntPtr instancePtr, HTTPRequestHandle hRequest, uint cOffset, Byte[] pBodyDataBuffer, uint unBufferSize) { }

	public static bool ISteamHTTP_PrioritizeHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest) { }

	public static bool ISteamHTTP_ReleaseCookieContainer(IntPtr instancePtr, HTTPCookieContainerHandle hCookieContainer) { }

	public static bool ISteamHTTP_ReleaseHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest) { }

	public static bool ISteamHTTP_SendHTTPRequest(IntPtr instancePtr, HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) { }

	public static bool ISteamHTTP_SendHTTPRequestAndStreamResponse(IntPtr instancePtr, HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle) { }

	public static bool ISteamHTTP_SetCookie(IntPtr instancePtr, HTTPCookieContainerHandle hCookieContainer, UTF8StringHandle pchHost, UTF8StringHandle pchUrl, UTF8StringHandle pchCookie) { }

	public static bool ISteamHTTP_SetHTTPRequestAbsoluteTimeoutMS(IntPtr instancePtr, HTTPRequestHandle hRequest, uint unMilliseconds) { }

	public static bool ISteamHTTP_SetHTTPRequestContextValue(IntPtr instancePtr, HTTPRequestHandle hRequest, ulong ulContextValue) { }

	public static bool ISteamHTTP_SetHTTPRequestCookieContainer(IntPtr instancePtr, HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer) { }

	public static bool ISteamHTTP_SetHTTPRequestGetOrPostParameter(IntPtr instancePtr, HTTPRequestHandle hRequest, UTF8StringHandle pchParamName, UTF8StringHandle pchParamValue) { }

	public static bool ISteamHTTP_SetHTTPRequestHeaderValue(IntPtr instancePtr, HTTPRequestHandle hRequest, UTF8StringHandle pchHeaderName, UTF8StringHandle pchHeaderValue) { }

	public static bool ISteamHTTP_SetHTTPRequestNetworkActivityTimeout(IntPtr instancePtr, HTTPRequestHandle hRequest, uint unTimeoutSeconds) { }

	public static bool ISteamHTTP_SetHTTPRequestRawPostBody(IntPtr instancePtr, HTTPRequestHandle hRequest, UTF8StringHandle pchContentType, Byte[] pubBody, uint unBodyLen) { }

	public static bool ISteamHTTP_SetHTTPRequestRequiresVerifiedCertificate(IntPtr instancePtr, HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate) { }

	public static bool ISteamHTTP_SetHTTPRequestUserAgentInfo(IntPtr instancePtr, HTTPRequestHandle hRequest, UTF8StringHandle pchUserAgentInfo) { }

	public static void ISteamInput_ActivateActionSet(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle) { }

	public static void ISteamInput_ActivateActionSetLayer(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle) { }

	public static bool ISteamInput_BNewDataAvailable(IntPtr instancePtr) { }

	public static bool ISteamInput_BWaitForData(IntPtr instancePtr, bool bWaitForever, uint unTimeout) { }

	public static void ISteamInput_DeactivateActionSetLayer(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle) { }

	public static void ISteamInput_DeactivateAllActionSetLayers(IntPtr instancePtr, InputHandle_t inputHandle) { }

	public static void ISteamInput_EnableActionEventCallbacks(IntPtr instancePtr, SteamInputActionEventCallbackPointer pCallback) { }

	public static void ISteamInput_EnableDeviceCallbacks(IntPtr instancePtr) { }

	public static EInputActionOrigin ISteamInput_GetActionOriginFromXboxOrigin(IntPtr instancePtr, InputHandle_t inputHandle, EXboxOrigin eOrigin) { }

	public static ulong ISteamInput_GetActionSetHandle(IntPtr instancePtr, UTF8StringHandle pszActionSetName) { }

	public static int ISteamInput_GetActiveActionSetLayers(IntPtr instancePtr, InputHandle_t inputHandle, out InputActionSetHandle_t[] handlesOut) { }

	public static InputAnalogActionData_t ISteamInput_GetAnalogActionData(IntPtr instancePtr, InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle) { }

	public static ulong ISteamInput_GetAnalogActionHandle(IntPtr instancePtr, UTF8StringHandle pszActionName) { }

	public static int ISteamInput_GetAnalogActionOrigins(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputAnalogActionHandle_t analogActionHandle, out EInputActionOrigin[] originsOut) { }

	public static int ISteamInput_GetConnectedControllers(IntPtr instancePtr, out InputHandle_t[] handlesOut) { }

	public static ulong ISteamInput_GetControllerForGamepadIndex(IntPtr instancePtr, int nIndex) { }

	public static ulong ISteamInput_GetCurrentActionSet(IntPtr instancePtr, InputHandle_t inputHandle) { }

	public static bool ISteamInput_GetDeviceBindingRevision(IntPtr instancePtr, InputHandle_t inputHandle, out int pMajor, out int pMinor) { }

	public static InputDigitalActionData_t ISteamInput_GetDigitalActionData(IntPtr instancePtr, InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle) { }

	public static ulong ISteamInput_GetDigitalActionHandle(IntPtr instancePtr, UTF8StringHandle pszActionName) { }

	public static int ISteamInput_GetDigitalActionOrigins(IntPtr instancePtr, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputDigitalActionHandle_t digitalActionHandle, out EInputActionOrigin[] originsOut) { }

	public static int ISteamInput_GetGamepadIndexForController(IntPtr instancePtr, InputHandle_t ulinputHandle) { }

	public static IntPtr ISteamInput_GetGlyphForActionOrigin_Legacy(IntPtr instancePtr, EInputActionOrigin eOrigin) { }

	public static IntPtr ISteamInput_GetGlyphForXboxOrigin(IntPtr instancePtr, EXboxOrigin eOrigin) { }

	public static IntPtr ISteamInput_GetGlyphPNGForActionOrigin(IntPtr instancePtr, EInputActionOrigin eOrigin, ESteamInputGlyphSize eSize, uint unFlags) { }

	public static IntPtr ISteamInput_GetGlyphSVGForActionOrigin(IntPtr instancePtr, EInputActionOrigin eOrigin, uint unFlags) { }

	public static ESteamInputType ISteamInput_GetInputTypeForHandle(IntPtr instancePtr, InputHandle_t inputHandle) { }

	public static InputMotionData_t ISteamInput_GetMotionData(IntPtr instancePtr, InputHandle_t inputHandle) { }

	public static uint ISteamInput_GetRemotePlaySessionID(IntPtr instancePtr, InputHandle_t inputHandle) { }

	public static ushort ISteamInput_GetSessionInputConfigurationSettings(IntPtr instancePtr) { }

	public static IntPtr ISteamInput_GetStringForActionOrigin(IntPtr instancePtr, EInputActionOrigin eOrigin) { }

	public static IntPtr ISteamInput_GetStringForAnalogActionName(IntPtr instancePtr, InputAnalogActionHandle_t eActionHandle) { }

	public static IntPtr ISteamInput_GetStringForDigitalActionName(IntPtr instancePtr, InputDigitalActionHandle_t eActionHandle) { }

	public static IntPtr ISteamInput_GetStringForXboxOrigin(IntPtr instancePtr, EXboxOrigin eOrigin) { }

	public static bool ISteamInput_Init(IntPtr instancePtr, bool bExplicitlyCallRunFrame) { }

	public static void ISteamInput_Legacy_TriggerHapticPulse(IntPtr instancePtr, InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec) { }

	public static void ISteamInput_Legacy_TriggerRepeatedHapticPulse(IntPtr instancePtr, InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags) { }

	public static void ISteamInput_RunFrame(IntPtr instancePtr, bool bReservedValue) { }

	public static bool ISteamInput_SetInputActionManifestFilePath(IntPtr instancePtr, UTF8StringHandle pchInputActionManifestAbsolutePath) { }

	public static void ISteamInput_SetLEDColor(IntPtr instancePtr, InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags) { }

	public static bool ISteamInput_ShowBindingPanel(IntPtr instancePtr, InputHandle_t inputHandle) { }

	public static bool ISteamInput_Shutdown(IntPtr instancePtr) { }

	public static void ISteamInput_StopAnalogActionMomentum(IntPtr instancePtr, InputHandle_t inputHandle, InputAnalogActionHandle_t eAction) { }

	public static EInputActionOrigin ISteamInput_TranslateActionOrigin(IntPtr instancePtr, ESteamInputType eDestinationInputType, EInputActionOrigin eSourceOrigin) { }

	public static void ISteamInput_TriggerSimpleHapticEvent(IntPtr instancePtr, InputHandle_t inputHandle, EControllerHapticLocation eHapticLocation, byte nIntensity, char nGainDB, byte nOtherIntensity, char nOtherGainDB) { }

	public static void ISteamInput_TriggerVibration(IntPtr instancePtr, InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed) { }

	public static void ISteamInput_TriggerVibrationExtended(IntPtr instancePtr, InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed, ushort usLeftTriggerSpeed, ushort usRightTriggerSpeed) { }

	public static bool ISteamInventory_AddPromoItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef) { }

	public static bool ISteamInventory_AddPromoItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, out SteamItemDef_t[] pArrayItemDefs, uint unArrayLength) { }

	public static bool ISteamInventory_CheckResultSteamID(IntPtr instancePtr, SteamInventoryResult_t resultHandle, CSteamID steamIDExpected) { }

	public static bool ISteamInventory_ConsumeItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity) { }

	public static bool ISteamInventory_DeserializeResult(IntPtr instancePtr, out SteamInventoryResult_t pOutResultHandle, Byte[] pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE) { }

	public static void ISteamInventory_DestroyResult(IntPtr instancePtr, SteamInventoryResult_t resultHandle) { }

	public static bool ISteamInventory_ExchangeItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, out SteamItemDef_t[] pArrayGenerate, out UInt32[] punArrayGenerateQuantity, uint unArrayGenerateLength, out SteamItemInstanceID_t[] pArrayDestroy, out UInt32[] punArrayDestroyQuantity, uint unArrayDestroyLength) { }

	public static bool ISteamInventory_GenerateItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, out SteamItemDef_t[] pArrayItemDefs, out UInt32[] punArrayQuantity, uint unArrayLength) { }

	public static bool ISteamInventory_GetAllItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle) { }

	public static bool ISteamInventory_GetEligiblePromoItemDefinitionIDs(IntPtr instancePtr, CSteamID steamID, out SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	public static bool ISteamInventory_GetItemDefinitionIDs(IntPtr instancePtr, out SteamItemDef_t[] pItemDefIDs, ref uint punItemDefIDsArraySize) { }

	public static bool ISteamInventory_GetItemDefinitionProperty(IntPtr instancePtr, SteamItemDef_t iDefinition, UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut) { }

	public static bool ISteamInventory_GetItemPrice(IntPtr instancePtr, SteamItemDef_t iDefinition, out ulong pCurrentPrice, out ulong pBasePrice) { }

	public static bool ISteamInventory_GetItemsByID(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, out SteamItemInstanceID_t[] pInstanceIDs, uint unCountInstanceIDs) { }

	public static bool ISteamInventory_GetItemsWithPrices(IntPtr instancePtr, out SteamItemDef_t[] pArrayItemDefs, out UInt64[] pCurrentPrices, out UInt64[] pBasePrices, uint unArrayLength) { }

	public static uint ISteamInventory_GetNumItemsWithPrices(IntPtr instancePtr) { }

	public static bool ISteamInventory_GetResultItemProperty(IntPtr instancePtr, SteamInventoryResult_t resultHandle, uint unItemIndex, UTF8StringHandle pchPropertyName, IntPtr pchValueBuffer, ref uint punValueBufferSizeOut) { }

	public static bool ISteamInventory_GetResultItems(IntPtr instancePtr, SteamInventoryResult_t resultHandle, out SteamItemDetails_t[] pOutItemsArray, ref uint punOutItemsArraySize) { }

	public static EResult ISteamInventory_GetResultStatus(IntPtr instancePtr, SteamInventoryResult_t resultHandle) { }

	public static uint ISteamInventory_GetResultTimestamp(IntPtr instancePtr, SteamInventoryResult_t resultHandle) { }

	public static bool ISteamInventory_GrantPromoItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle) { }

	public static bool ISteamInventory_InspectItem(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, UTF8StringHandle pchItemToken) { }

	public static bool ISteamInventory_LoadItemDefinitions(IntPtr instancePtr) { }

	public static bool ISteamInventory_RemoveProperty(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, UTF8StringHandle pchPropertyName) { }

	public static ulong ISteamInventory_RequestEligiblePromoItemDefinitionsIDs(IntPtr instancePtr, CSteamID steamID) { }

	public static ulong ISteamInventory_RequestPrices(IntPtr instancePtr) { }

	public static void ISteamInventory_SendItemDropHeartbeat(IntPtr instancePtr) { }

	public static bool ISteamInventory_SerializeResult(IntPtr instancePtr, SteamInventoryResult_t resultHandle, Byte[] pOutBuffer, out uint punOutBufferSize) { }

	public static bool ISteamInventory_SetPropertyBool(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, UTF8StringHandle pchPropertyName, bool bValue) { }

	public static bool ISteamInventory_SetPropertyFloat(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, UTF8StringHandle pchPropertyName, float flValue) { }

	public static bool ISteamInventory_SetPropertyInt64(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, UTF8StringHandle pchPropertyName, long nValue) { }

	public static bool ISteamInventory_SetPropertyString(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, UTF8StringHandle pchPropertyName, UTF8StringHandle pchPropertyValue) { }

	public static ulong ISteamInventory_StartPurchase(IntPtr instancePtr, out SteamItemDef_t[] pArrayItemDefs, out UInt32[] punArrayQuantity, uint unArrayLength) { }

	public static ulong ISteamInventory_StartUpdateProperties(IntPtr instancePtr) { }

	public static bool ISteamInventory_SubmitUpdateProperties(IntPtr instancePtr, SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle) { }

	public static bool ISteamInventory_TradeItems(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, out SteamItemInstanceID_t[] pArrayGive, out UInt32[] pArrayGiveQuantity, uint nArrayGiveLength, out SteamItemInstanceID_t[] pArrayGet, out UInt32[] pArrayGetQuantity, uint nArrayGetLength) { }

	public static bool ISteamInventory_TransferItemQuantity(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest) { }

	public static bool ISteamInventory_TriggerItemDrop(IntPtr instancePtr, out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition) { }

	public static int ISteamMatchmaking_AddFavoriteGame(IntPtr instancePtr, AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer) { }

	public static void ISteamMatchmaking_AddRequestLobbyListCompatibleMembersFilter(IntPtr instancePtr, CSteamID steamIDLobby) { }

	public static void ISteamMatchmaking_AddRequestLobbyListDistanceFilter(IntPtr instancePtr, ELobbyDistanceFilter eLobbyDistanceFilter) { }

	public static void ISteamMatchmaking_AddRequestLobbyListFilterSlotsAvailable(IntPtr instancePtr, int nSlotsAvailable) { }

	public static void ISteamMatchmaking_AddRequestLobbyListNearValueFilter(IntPtr instancePtr, UTF8StringHandle pchKeyToMatch, int nValueToBeCloseTo) { }

	public static void ISteamMatchmaking_AddRequestLobbyListNumericalFilter(IntPtr instancePtr, UTF8StringHandle pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType) { }

	public static void ISteamMatchmaking_AddRequestLobbyListResultCountFilter(IntPtr instancePtr, int cMaxResults) { }

	public static void ISteamMatchmaking_AddRequestLobbyListStringFilter(IntPtr instancePtr, UTF8StringHandle pchKeyToMatch, UTF8StringHandle pchValueToMatch, ELobbyComparison eComparisonType) { }

	public static ulong ISteamMatchmaking_CreateLobby(IntPtr instancePtr, ELobbyType eLobbyType, int cMaxMembers) { }

	public static bool ISteamMatchmaking_DeleteLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, UTF8StringHandle pchKey) { }

	public static bool ISteamMatchmaking_GetFavoriteGame(IntPtr instancePtr, int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer) { }

	public static int ISteamMatchmaking_GetFavoriteGameCount(IntPtr instancePtr) { }

	public static ulong ISteamMatchmaking_GetLobbyByIndex(IntPtr instancePtr, int iLobby) { }

	public static int ISteamMatchmaking_GetLobbyChatEntry(IntPtr instancePtr, CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, Byte[] pvData, int cubData, out EChatEntryType peChatEntryType) { }

	public static IntPtr ISteamMatchmaking_GetLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, UTF8StringHandle pchKey) { }

	public static bool ISteamMatchmaking_GetLobbyDataByIndex(IntPtr instancePtr, CSteamID steamIDLobby, int iLobbyData, IntPtr pchKey, int cchKeyBufferSize, IntPtr pchValue, int cchValueBufferSize) { }

	public static int ISteamMatchmaking_GetLobbyDataCount(IntPtr instancePtr, CSteamID steamIDLobby) { }

	public static bool ISteamMatchmaking_GetLobbyGameServer(IntPtr instancePtr, CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer) { }

	public static ulong ISteamMatchmaking_GetLobbyMemberByIndex(IntPtr instancePtr, CSteamID steamIDLobby, int iMember) { }

	public static IntPtr ISteamMatchmaking_GetLobbyMemberData(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDUser, UTF8StringHandle pchKey) { }

	public static int ISteamMatchmaking_GetLobbyMemberLimit(IntPtr instancePtr, CSteamID steamIDLobby) { }

	public static ulong ISteamMatchmaking_GetLobbyOwner(IntPtr instancePtr, CSteamID steamIDLobby) { }

	public static int ISteamMatchmaking_GetNumLobbyMembers(IntPtr instancePtr, CSteamID steamIDLobby) { }

	public static bool ISteamMatchmaking_InviteUserToLobby(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDInvitee) { }

	public static ulong ISteamMatchmaking_JoinLobby(IntPtr instancePtr, CSteamID steamIDLobby) { }

	public static void ISteamMatchmaking_LeaveLobby(IntPtr instancePtr, CSteamID steamIDLobby) { }

	public static bool ISteamMatchmaking_RemoveFavoriteGame(IntPtr instancePtr, AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags) { }

	public static bool ISteamMatchmaking_RequestLobbyData(IntPtr instancePtr, CSteamID steamIDLobby) { }

	public static ulong ISteamMatchmaking_RequestLobbyList(IntPtr instancePtr) { }

	public static bool ISteamMatchmaking_SendLobbyChatMsg(IntPtr instancePtr, CSteamID steamIDLobby, Byte[] pvMsgBody, int cubMsgBody) { }

	public static bool ISteamMatchmaking_SetLinkedLobby(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDLobbyDependent) { }

	public static bool ISteamMatchmaking_SetLobbyData(IntPtr instancePtr, CSteamID steamIDLobby, UTF8StringHandle pchKey, UTF8StringHandle pchValue) { }

	public static void ISteamMatchmaking_SetLobbyGameServer(IntPtr instancePtr, CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer) { }

	public static bool ISteamMatchmaking_SetLobbyJoinable(IntPtr instancePtr, CSteamID steamIDLobby, bool bLobbyJoinable) { }

	public static void ISteamMatchmaking_SetLobbyMemberData(IntPtr instancePtr, CSteamID steamIDLobby, UTF8StringHandle pchKey, UTF8StringHandle pchValue) { }

	public static bool ISteamMatchmaking_SetLobbyMemberLimit(IntPtr instancePtr, CSteamID steamIDLobby, int cMaxMembers) { }

	public static bool ISteamMatchmaking_SetLobbyOwner(IntPtr instancePtr, CSteamID steamIDLobby, CSteamID steamIDNewOwner) { }

	public static bool ISteamMatchmaking_SetLobbyType(IntPtr instancePtr, CSteamID steamIDLobby, ELobbyType eLobbyType) { }

	public static void ISteamMatchmakingServers_CancelQuery(IntPtr instancePtr, HServerListRequest hRequest) { }

	public static void ISteamMatchmakingServers_CancelServerQuery(IntPtr instancePtr, HServerQuery hServerQuery) { }

	public static int ISteamMatchmakingServers_GetServerCount(IntPtr instancePtr, HServerListRequest hRequest) { }

	public static IntPtr ISteamMatchmakingServers_GetServerDetails(IntPtr instancePtr, HServerListRequest hRequest, int iServer) { }

	public static bool ISteamMatchmakingServers_IsRefreshing(IntPtr instancePtr, HServerListRequest hRequest) { }

	public static int ISteamMatchmakingServers_PingServer(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse) { }

	public static int ISteamMatchmakingServers_PlayerDetails(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse) { }

	public static void ISteamMatchmakingServers_RefreshQuery(IntPtr instancePtr, HServerListRequest hRequest) { }

	public static void ISteamMatchmakingServers_RefreshServer(IntPtr instancePtr, HServerListRequest hRequest, int iServer) { }

	public static void ISteamMatchmakingServers_ReleaseRequest(IntPtr instancePtr, HServerListRequest hServerListRequest) { }

	public static IntPtr ISteamMatchmakingServers_RequestFavoritesServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	public static IntPtr ISteamMatchmakingServers_RequestFriendsServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	public static IntPtr ISteamMatchmakingServers_RequestHistoryServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	public static IntPtr ISteamMatchmakingServers_RequestInternetServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	public static IntPtr ISteamMatchmakingServers_RequestLANServerList(IntPtr instancePtr, AppId_t iApp, IntPtr pRequestServersResponse) { }

	public static IntPtr ISteamMatchmakingServers_RequestSpectatorServerList(IntPtr instancePtr, AppId_t iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	public static int ISteamMatchmakingServers_ServerRules(IntPtr instancePtr, uint unIP, ushort usPort, IntPtr pRequestServersResponse) { }

	public static bool ISteamMusic_BIsEnabled(IntPtr instancePtr) { }

	public static bool ISteamMusic_BIsPlaying(IntPtr instancePtr) { }

	public static AudioPlayback_Status ISteamMusic_GetPlaybackStatus(IntPtr instancePtr) { }

	public static float ISteamMusic_GetVolume(IntPtr instancePtr) { }

	public static void ISteamMusic_Pause(IntPtr instancePtr) { }

	public static void ISteamMusic_Play(IntPtr instancePtr) { }

	public static void ISteamMusic_PlayNext(IntPtr instancePtr) { }

	public static void ISteamMusic_PlayPrevious(IntPtr instancePtr) { }

	public static void ISteamMusic_SetVolume(IntPtr instancePtr, float flVolume) { }

	public static bool ISteamMusicRemote_BActivationSuccess(IntPtr instancePtr, bool bValue) { }

	public static bool ISteamMusicRemote_BIsCurrentMusicRemote(IntPtr instancePtr) { }

	public static bool ISteamMusicRemote_CurrentEntryDidChange(IntPtr instancePtr) { }

	public static bool ISteamMusicRemote_CurrentEntryIsAvailable(IntPtr instancePtr, bool bAvailable) { }

	public static bool ISteamMusicRemote_CurrentEntryWillChange(IntPtr instancePtr) { }

	public static bool ISteamMusicRemote_DeregisterSteamMusicRemote(IntPtr instancePtr) { }

	public static bool ISteamMusicRemote_EnableLooped(IntPtr instancePtr, bool bValue) { }

	public static bool ISteamMusicRemote_EnablePlaylists(IntPtr instancePtr, bool bValue) { }

	public static bool ISteamMusicRemote_EnablePlayNext(IntPtr instancePtr, bool bValue) { }

	public static bool ISteamMusicRemote_EnablePlayPrevious(IntPtr instancePtr, bool bValue) { }

	public static bool ISteamMusicRemote_EnableQueue(IntPtr instancePtr, bool bValue) { }

	public static bool ISteamMusicRemote_EnableShuffled(IntPtr instancePtr, bool bValue) { }

	public static bool ISteamMusicRemote_PlaylistDidChange(IntPtr instancePtr) { }

	public static bool ISteamMusicRemote_PlaylistWillChange(IntPtr instancePtr) { }

	public static bool ISteamMusicRemote_QueueDidChange(IntPtr instancePtr) { }

	public static bool ISteamMusicRemote_QueueWillChange(IntPtr instancePtr) { }

	public static bool ISteamMusicRemote_RegisterSteamMusicRemote(IntPtr instancePtr, UTF8StringHandle pchName) { }

	public static bool ISteamMusicRemote_ResetPlaylistEntries(IntPtr instancePtr) { }

	public static bool ISteamMusicRemote_ResetQueueEntries(IntPtr instancePtr) { }

	public static bool ISteamMusicRemote_SetCurrentPlaylistEntry(IntPtr instancePtr, int nID) { }

	public static bool ISteamMusicRemote_SetCurrentQueueEntry(IntPtr instancePtr, int nID) { }

	public static bool ISteamMusicRemote_SetDisplayName(IntPtr instancePtr, UTF8StringHandle pchDisplayName) { }

	public static bool ISteamMusicRemote_SetPlaylistEntry(IntPtr instancePtr, int nID, int nPosition, UTF8StringHandle pchEntryText) { }

	public static bool ISteamMusicRemote_SetPNGIcon_64x64(IntPtr instancePtr, Byte[] pvBuffer, uint cbBufferLength) { }

	public static bool ISteamMusicRemote_SetQueueEntry(IntPtr instancePtr, int nID, int nPosition, UTF8StringHandle pchEntryText) { }

	public static bool ISteamMusicRemote_UpdateCurrentEntryCoverArt(IntPtr instancePtr, Byte[] pvBuffer, uint cbBufferLength) { }

	public static bool ISteamMusicRemote_UpdateCurrentEntryElapsedSeconds(IntPtr instancePtr, int nValue) { }

	public static bool ISteamMusicRemote_UpdateCurrentEntryText(IntPtr instancePtr, UTF8StringHandle pchText) { }

	public static bool ISteamMusicRemote_UpdateLooped(IntPtr instancePtr, bool bValue) { }

	public static bool ISteamMusicRemote_UpdatePlaybackStatus(IntPtr instancePtr, AudioPlayback_Status nStatus) { }

	public static bool ISteamMusicRemote_UpdateShuffled(IntPtr instancePtr, bool bValue) { }

	public static bool ISteamMusicRemote_UpdateVolume(IntPtr instancePtr, float flValue) { }

	public static bool ISteamNetworking_AcceptP2PSessionWithUser(IntPtr instancePtr, CSteamID steamIDRemote) { }

	public static bool ISteamNetworking_AllowP2PPacketRelay(IntPtr instancePtr, bool bAllow) { }

	public static bool ISteamNetworking_CloseP2PChannelWithUser(IntPtr instancePtr, CSteamID steamIDRemote, int nChannel) { }

	public static bool ISteamNetworking_CloseP2PSessionWithUser(IntPtr instancePtr, CSteamID steamIDRemote) { }

	public static uint ISteamNetworking_CreateConnectionSocket(IntPtr instancePtr, SteamIPAddress_t nIP, ushort nPort, int nTimeoutSec) { }

	public static uint ISteamNetworking_CreateListenSocket(IntPtr instancePtr, int nVirtualP2PPort, SteamIPAddress_t nIP, ushort nPort, bool bAllowUseOfPacketRelay) { }

	public static uint ISteamNetworking_CreateP2PConnectionSocket(IntPtr instancePtr, CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay) { }

	public static bool ISteamNetworking_DestroyListenSocket(IntPtr instancePtr, SNetListenSocket_t hSocket, bool bNotifyRemoteEnd) { }

	public static bool ISteamNetworking_DestroySocket(IntPtr instancePtr, SNetSocket_t hSocket, bool bNotifyRemoteEnd) { }

	public static bool ISteamNetworking_GetListenSocketInfo(IntPtr instancePtr, SNetListenSocket_t hListenSocket, out SteamIPAddress_t pnIP, out ushort pnPort) { }

	public static int ISteamNetworking_GetMaxPacketSize(IntPtr instancePtr, SNetSocket_t hSocket) { }

	public static bool ISteamNetworking_GetP2PSessionState(IntPtr instancePtr, CSteamID steamIDRemote, out P2PSessionState_t pConnectionState) { }

	public static ESNetSocketConnectionType ISteamNetworking_GetSocketConnectionType(IntPtr instancePtr, SNetSocket_t hSocket) { }

	public static bool ISteamNetworking_GetSocketInfo(IntPtr instancePtr, SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out SteamIPAddress_t punIPRemote, out ushort punPortRemote) { }

	public static bool ISteamNetworking_IsDataAvailable(IntPtr instancePtr, SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket) { }

	public static bool ISteamNetworking_IsDataAvailableOnSocket(IntPtr instancePtr, SNetSocket_t hSocket, out uint pcubMsgSize) { }

	public static bool ISteamNetworking_IsP2PPacketAvailable(IntPtr instancePtr, out uint pcubMsgSize, int nChannel) { }

	public static bool ISteamNetworking_ReadP2PPacket(IntPtr instancePtr, Byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel) { }

	public static bool ISteamNetworking_RetrieveData(IntPtr instancePtr, SNetListenSocket_t hListenSocket, Byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket) { }

	public static bool ISteamNetworking_RetrieveDataFromSocket(IntPtr instancePtr, SNetSocket_t hSocket, Byte[] pubDest, uint cubDest, out uint pcubMsgSize) { }

	public static bool ISteamNetworking_SendDataOnSocket(IntPtr instancePtr, SNetSocket_t hSocket, Byte[] pubData, uint cubData, bool bReliable) { }

	public static bool ISteamNetworking_SendP2PPacket(IntPtr instancePtr, CSteamID steamIDRemote, Byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel) { }

	public static bool ISteamNetworkingMessages_AcceptSessionWithUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote) { }

	public static bool ISteamNetworkingMessages_CloseChannelWithUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, int nLocalChannel) { }

	public static bool ISteamNetworkingMessages_CloseSessionWithUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote) { }

	public static ESteamNetworkingConnectionState ISteamNetworkingMessages_GetSessionConnectionInfo(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, out SteamNetConnectionInfo_t pConnectionInfo, out SteamNetworkingQuickConnectionStatus pQuickStatus) { }

	public static int ISteamNetworkingMessages_ReceiveMessagesOnChannel(IntPtr instancePtr, int nLocalChannel, out IntPtr[] ppOutMessages, int nMaxMessages) { }

	public static EResult ISteamNetworkingMessages_SendMessageToUser(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, IntPtr pubData, uint cubData, int nSendFlags, int nRemoteChannel) { }

	public static EResult ISteamNetworkingSockets_AcceptConnection(IntPtr instancePtr, HSteamNetConnection hConn) { }

	public static bool ISteamNetworkingSockets_CloseConnection(IntPtr instancePtr, HSteamNetConnection hPeer, int nReason, UTF8StringHandle pszDebug, bool bEnableLinger) { }

	public static bool ISteamNetworkingSockets_CloseListenSocket(IntPtr instancePtr, HSteamListenSocket hSocket) { }

	public static uint ISteamNetworkingSockets_ConnectByIPAddress(IntPtr instancePtr, ref SteamNetworkingIPAddr address, int nOptions, out SteamNetworkingConfigValue_t[] pOptions) { }

	public static uint ISteamNetworkingSockets_ConnectP2P(IntPtr instancePtr, ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, out SteamNetworkingConfigValue_t[] pOptions) { }

	public static uint ISteamNetworkingSockets_ConnectP2PCustomSignaling(IntPtr instancePtr, out ISteamNetworkingConnectionSignaling pSignaling, ref SteamNetworkingIdentity pPeerIdentity, int nRemoteVirtualPort, int nOptions, out SteamNetworkingConfigValue_t[] pOptions) { }

	public static uint ISteamNetworkingSockets_ConnectToHostedDedicatedServer(IntPtr instancePtr, ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, out SteamNetworkingConfigValue_t[] pOptions) { }

	public static uint ISteamNetworkingSockets_CreateHostedDedicatedServerListenSocket(IntPtr instancePtr, int nLocalVirtualPort, int nOptions, out SteamNetworkingConfigValue_t[] pOptions) { }

	public static uint ISteamNetworkingSockets_CreateListenSocketIP(IntPtr instancePtr, ref SteamNetworkingIPAddr localAddress, int nOptions, out SteamNetworkingConfigValue_t[] pOptions) { }

	public static uint ISteamNetworkingSockets_CreateListenSocketP2P(IntPtr instancePtr, int nLocalVirtualPort, int nOptions, out SteamNetworkingConfigValue_t[] pOptions) { }

	public static uint ISteamNetworkingSockets_CreatePollGroup(IntPtr instancePtr) { }

	public static bool ISteamNetworkingSockets_CreateSocketPair(IntPtr instancePtr, out HSteamNetConnection pOutConnection1, out HSteamNetConnection pOutConnection2, bool bUseNetworkLoopback, ref SteamNetworkingIdentity pIdentity1, ref SteamNetworkingIdentity pIdentity2) { }

	public static bool ISteamNetworkingSockets_DestroyPollGroup(IntPtr instancePtr, HSteamNetPollGroup hPollGroup) { }

	public static int ISteamNetworkingSockets_FindRelayAuthTicketForServer(IntPtr instancePtr, ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, out SteamDatagramRelayAuthTicket pOutParsedTicket) { }

	public static EResult ISteamNetworkingSockets_FlushMessagesOnConnection(IntPtr instancePtr, HSteamNetConnection hConn) { }

	public static ESteamNetworkingAvailability ISteamNetworkingSockets_GetAuthenticationStatus(IntPtr instancePtr, out SteamNetAuthenticationStatus_t pDetails) { }

	public static bool ISteamNetworkingSockets_GetCertificateRequest(IntPtr instancePtr, out int pcbBlob, IntPtr pBlob, out SteamNetworkingErrMsg errMsg) { }

	public static bool ISteamNetworkingSockets_GetConnectionInfo(IntPtr instancePtr, HSteamNetConnection hConn, out SteamNetConnectionInfo_t pInfo) { }

	public static bool ISteamNetworkingSockets_GetConnectionName(IntPtr instancePtr, HSteamNetConnection hPeer, IntPtr pszName, int nMaxLen) { }

	public static long ISteamNetworkingSockets_GetConnectionUserData(IntPtr instancePtr, HSteamNetConnection hPeer) { }

	public static int ISteamNetworkingSockets_GetDetailedConnectionStatus(IntPtr instancePtr, HSteamNetConnection hConn, IntPtr pszBuf, int cbBuf) { }

	public static EResult ISteamNetworkingSockets_GetGameCoordinatorServerLogin(IntPtr instancePtr, IntPtr pLoginInfo, out int pcbSignedBlob, IntPtr pBlob) { }

	public static EResult ISteamNetworkingSockets_GetHostedDedicatedServerAddress(IntPtr instancePtr, out SteamDatagramHostedAddress pRouting) { }

	public static uint ISteamNetworkingSockets_GetHostedDedicatedServerPOPID(IntPtr instancePtr) { }

	public static ushort ISteamNetworkingSockets_GetHostedDedicatedServerPort(IntPtr instancePtr) { }

	public static bool ISteamNetworkingSockets_GetIdentity(IntPtr instancePtr, out SteamNetworkingIdentity pIdentity) { }

	public static bool ISteamNetworkingSockets_GetListenSocketAddress(IntPtr instancePtr, HSteamListenSocket hSocket, out SteamNetworkingIPAddr address) { }

	public static bool ISteamNetworkingSockets_GetQuickConnectionStatus(IntPtr instancePtr, HSteamNetConnection hConn, out SteamNetworkingQuickConnectionStatus pStats) { }

	public static ESteamNetworkingAvailability ISteamNetworkingSockets_InitAuthentication(IntPtr instancePtr) { }

	public static bool ISteamNetworkingSockets_ReceivedP2PCustomSignal(IntPtr instancePtr, IntPtr pMsg, int cbMsg, out ISteamNetworkingSignalingRecvContext pContext) { }

	public static bool ISteamNetworkingSockets_ReceivedRelayAuthTicket(IntPtr instancePtr, IntPtr pvTicket, int cbTicket, out SteamDatagramRelayAuthTicket pOutParsedTicket) { }

	public static int ISteamNetworkingSockets_ReceiveMessagesOnConnection(IntPtr instancePtr, HSteamNetConnection hConn, out IntPtr[] ppOutMessages, int nMaxMessages) { }

	public static int ISteamNetworkingSockets_ReceiveMessagesOnPollGroup(IntPtr instancePtr, HSteamNetPollGroup hPollGroup, out IntPtr[] ppOutMessages, int nMaxMessages) { }

	public static void ISteamNetworkingSockets_RunCallbacks(IntPtr instancePtr) { }

	public static void ISteamNetworkingSockets_SendMessages(IntPtr instancePtr, int nMessages, out SteamNetworkingMessage_t[] pMessages, out Int64[] pOutMessageNumberOrResult) { }

	public static EResult ISteamNetworkingSockets_SendMessageToConnection(IntPtr instancePtr, HSteamNetConnection hConn, IntPtr pData, uint cbData, int nSendFlags, out long pOutMessageNumber) { }

	public static bool ISteamNetworkingSockets_SetCertificate(IntPtr instancePtr, IntPtr pCertificate, int cbCertificate, out SteamNetworkingErrMsg errMsg) { }

	public static void ISteamNetworkingSockets_SetConnectionName(IntPtr instancePtr, HSteamNetConnection hPeer, UTF8StringHandle pszName) { }

	public static bool ISteamNetworkingSockets_SetConnectionPollGroup(IntPtr instancePtr, HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup) { }

	public static bool ISteamNetworkingSockets_SetConnectionUserData(IntPtr instancePtr, HSteamNetConnection hPeer, long nUserData) { }

	public static IntPtr ISteamNetworkingUtils_AllocateMessage(IntPtr instancePtr, int cbAllocateBuffer) { }

	public static bool ISteamNetworkingUtils_CheckPingDataUpToDate(IntPtr instancePtr, float flMaxAgeSeconds) { }

	public static void ISteamNetworkingUtils_ConvertPingLocationToString(IntPtr instancePtr, ref SteamNetworkPingLocation_t location, IntPtr pszBuf, int cchBufSize) { }

	public static int ISteamNetworkingUtils_EstimatePingTimeBetweenTwoLocations(IntPtr instancePtr, ref SteamNetworkPingLocation_t location1, ref SteamNetworkPingLocation_t location2) { }

	public static int ISteamNetworkingUtils_EstimatePingTimeFromLocalHost(IntPtr instancePtr, ref SteamNetworkPingLocation_t remoteLocation) { }

	public static ESteamNetworkingGetConfigValueResult ISteamNetworkingUtils_GetConfigValue(IntPtr instancePtr, ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, out ESteamNetworkingConfigDataType pOutDataType, IntPtr pResult, ref ulong cbResult) { }

	public static bool ISteamNetworkingUtils_GetConfigValueInfo(IntPtr instancePtr, ESteamNetworkingConfigValue eValue, IntPtr pOutName, out ESteamNetworkingConfigDataType pOutDataType, out ESteamNetworkingConfigScope pOutScope, out ESteamNetworkingConfigValue pOutNextValue) { }

	public static int ISteamNetworkingUtils_GetDirectPingToPOP(IntPtr instancePtr, SteamNetworkingPOPID popID) { }

	public static ESteamNetworkingConfigValue ISteamNetworkingUtils_GetFirstConfigValue(IntPtr instancePtr) { }

	public static float ISteamNetworkingUtils_GetLocalPingLocation(IntPtr instancePtr, out SteamNetworkPingLocation_t result) { }

	public static long ISteamNetworkingUtils_GetLocalTimestamp(IntPtr instancePtr) { }

	public static int ISteamNetworkingUtils_GetPingToDataCenter(IntPtr instancePtr, SteamNetworkingPOPID popID, out SteamNetworkingPOPID pViaRelayPoP) { }

	public static int ISteamNetworkingUtils_GetPOPCount(IntPtr instancePtr) { }

	public static int ISteamNetworkingUtils_GetPOPList(IntPtr instancePtr, out SteamNetworkingPOPID list, int nListSz) { }

	public static ESteamNetworkingAvailability ISteamNetworkingUtils_GetRelayNetworkStatus(IntPtr instancePtr, out SteamRelayNetworkStatus_t pDetails) { }

	public static void ISteamNetworkingUtils_InitRelayNetworkAccess(IntPtr instancePtr) { }

	public static bool ISteamNetworkingUtils_ParsePingLocationString(IntPtr instancePtr, UTF8StringHandle pszString, out SteamNetworkPingLocation_t result) { }

	public static bool ISteamNetworkingUtils_SetConfigValue(IntPtr instancePtr, ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, ESteamNetworkingConfigDataType eDataType, IntPtr pArg) { }

	public static void ISteamNetworkingUtils_SetDebugOutputFunction(IntPtr instancePtr, ESteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc) { }

	public static bool ISteamNetworkingUtils_SteamNetworkingIdentity_ParseString(IntPtr instancePtr, out SteamNetworkingIdentity pIdentity, UTF8StringHandle pszStr) { }

	public static void ISteamNetworkingUtils_SteamNetworkingIdentity_ToString(IntPtr instancePtr, ref SteamNetworkingIdentity identity, IntPtr buf, uint cbBuf) { }

	public static bool ISteamNetworkingUtils_SteamNetworkingIPAddr_ParseString(IntPtr instancePtr, out SteamNetworkingIPAddr pAddr, UTF8StringHandle pszStr) { }

	public static void ISteamNetworkingUtils_SteamNetworkingIPAddr_ToString(IntPtr instancePtr, ref SteamNetworkingIPAddr addr, IntPtr buf, uint cbBuf, bool bWithPort) { }

	public static bool ISteamParentalSettings_BIsAppBlocked(IntPtr instancePtr, AppId_t nAppID) { }

	public static bool ISteamParentalSettings_BIsAppInBlockList(IntPtr instancePtr, AppId_t nAppID) { }

	public static bool ISteamParentalSettings_BIsFeatureBlocked(IntPtr instancePtr, EParentalFeature eFeature) { }

	public static bool ISteamParentalSettings_BIsFeatureInBlockList(IntPtr instancePtr, EParentalFeature eFeature) { }

	public static bool ISteamParentalSettings_BIsParentalLockEnabled(IntPtr instancePtr) { }

	public static bool ISteamParentalSettings_BIsParentalLockLocked(IntPtr instancePtr) { }

	public static void ISteamParties_CancelReservation(IntPtr instancePtr, PartyBeaconID_t ulBeacon, CSteamID steamIDUser) { }

	public static ulong ISteamParties_ChangeNumOpenSlots(IntPtr instancePtr, PartyBeaconID_t ulBeacon, uint unOpenSlots) { }

	public static ulong ISteamParties_CreateBeacon(IntPtr instancePtr, uint unOpenSlots, ref SteamPartyBeaconLocation_t pBeaconLocation, UTF8StringHandle pchConnectString, UTF8StringHandle pchMetadata) { }

	public static bool ISteamParties_DestroyBeacon(IntPtr instancePtr, PartyBeaconID_t ulBeacon) { }

	public static bool ISteamParties_GetAvailableBeaconLocations(IntPtr instancePtr, out SteamPartyBeaconLocation_t[] pLocationList, uint uMaxNumLocations) { }

	public static ulong ISteamParties_GetBeaconByIndex(IntPtr instancePtr, uint unIndex) { }

	public static bool ISteamParties_GetBeaconDetails(IntPtr instancePtr, PartyBeaconID_t ulBeaconID, out CSteamID pSteamIDBeaconOwner, out SteamPartyBeaconLocation_t pLocation, IntPtr pchMetadata, int cchMetadata) { }

	public static bool ISteamParties_GetBeaconLocationData(IntPtr instancePtr, SteamPartyBeaconLocation_t BeaconLocation, ESteamPartyBeaconLocationData eData, IntPtr pchDataStringOut, int cchDataStringOut) { }

	public static uint ISteamParties_GetNumActiveBeacons(IntPtr instancePtr) { }

	public static bool ISteamParties_GetNumAvailableBeaconLocations(IntPtr instancePtr, out uint puNumLocations) { }

	public static ulong ISteamParties_JoinParty(IntPtr instancePtr, PartyBeaconID_t ulBeaconID) { }

	public static void ISteamParties_OnReservationCompleted(IntPtr instancePtr, PartyBeaconID_t ulBeacon, CSteamID steamIDUser) { }

	public static bool ISteamRemotePlay_BGetSessionClientResolution(IntPtr instancePtr, RemotePlaySessionID_t unSessionID, out int pnResolutionX, out int pnResolutionY) { }

	public static bool ISteamRemotePlay_BSendRemotePlayTogetherInvite(IntPtr instancePtr, CSteamID steamIDFriend) { }

	public static ESteamDeviceFormFactor ISteamRemotePlay_GetSessionClientFormFactor(IntPtr instancePtr, RemotePlaySessionID_t unSessionID) { }

	public static IntPtr ISteamRemotePlay_GetSessionClientName(IntPtr instancePtr, RemotePlaySessionID_t unSessionID) { }

	public static uint ISteamRemotePlay_GetSessionCount(IntPtr instancePtr) { }

	public static uint ISteamRemotePlay_GetSessionID(IntPtr instancePtr, int iSessionIndex) { }

	public static ulong ISteamRemotePlay_GetSessionSteamID(IntPtr instancePtr, RemotePlaySessionID_t unSessionID) { }

	public static bool ISteamRemoteStorage_BeginFileWriteBatch(IntPtr instancePtr) { }

	public static ulong ISteamRemoteStorage_CommitPublishedFileUpdate(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle) { }

	public static ulong ISteamRemoteStorage_CreatePublishedFileUpdateRequest(IntPtr instancePtr, PublishedFileId_t unPublishedFileId) { }

	public static ulong ISteamRemoteStorage_DeletePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId) { }

	public static bool ISteamRemoteStorage_EndFileWriteBatch(IntPtr instancePtr) { }

	public static ulong ISteamRemoteStorage_EnumeratePublishedFilesByUserAction(IntPtr instancePtr, EWorkshopFileAction eAction, uint unStartIndex) { }

	public static ulong ISteamRemoteStorage_EnumeratePublishedWorkshopFiles(IntPtr instancePtr, EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IntPtr pTags, IntPtr pUserTags) { }

	public static ulong ISteamRemoteStorage_EnumerateUserPublishedFiles(IntPtr instancePtr, uint unStartIndex) { }

	public static ulong ISteamRemoteStorage_EnumerateUserSharedWorkshopFiles(IntPtr instancePtr, CSteamID steamId, uint unStartIndex, IntPtr pRequiredTags, IntPtr pExcludedTags) { }

	public static ulong ISteamRemoteStorage_EnumerateUserSubscribedFiles(IntPtr instancePtr, uint unStartIndex) { }

	public static bool ISteamRemoteStorage_FileDelete(IntPtr instancePtr, UTF8StringHandle pchFile) { }

	public static bool ISteamRemoteStorage_FileExists(IntPtr instancePtr, UTF8StringHandle pchFile) { }

	public static bool ISteamRemoteStorage_FileForget(IntPtr instancePtr, UTF8StringHandle pchFile) { }

	public static bool ISteamRemoteStorage_FilePersisted(IntPtr instancePtr, UTF8StringHandle pchFile) { }

	public static int ISteamRemoteStorage_FileRead(IntPtr instancePtr, UTF8StringHandle pchFile, Byte[] pvData, int cubDataToRead) { }

	public static ulong ISteamRemoteStorage_FileReadAsync(IntPtr instancePtr, UTF8StringHandle pchFile, uint nOffset, uint cubToRead) { }

	public static bool ISteamRemoteStorage_FileReadAsyncComplete(IntPtr instancePtr, SteamAPICall_t hReadCall, Byte[] pvBuffer, uint cubToRead) { }

	public static ulong ISteamRemoteStorage_FileShare(IntPtr instancePtr, UTF8StringHandle pchFile) { }

	public static bool ISteamRemoteStorage_FileWrite(IntPtr instancePtr, UTF8StringHandle pchFile, Byte[] pvData, int cubData) { }

	public static ulong ISteamRemoteStorage_FileWriteAsync(IntPtr instancePtr, UTF8StringHandle pchFile, Byte[] pvData, uint cubData) { }

	public static bool ISteamRemoteStorage_FileWriteStreamCancel(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle) { }

	public static bool ISteamRemoteStorage_FileWriteStreamClose(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle) { }

	public static ulong ISteamRemoteStorage_FileWriteStreamOpen(IntPtr instancePtr, UTF8StringHandle pchFile) { }

	public static bool ISteamRemoteStorage_FileWriteStreamWriteChunk(IntPtr instancePtr, UGCFileWriteStreamHandle_t writeHandle, Byte[] pvData, int cubData) { }

	public static int ISteamRemoteStorage_GetCachedUGCCount(IntPtr instancePtr) { }

	public static ulong ISteamRemoteStorage_GetCachedUGCHandle(IntPtr instancePtr, int iCachedContent) { }

	public static int ISteamRemoteStorage_GetFileCount(IntPtr instancePtr) { }

	public static IntPtr ISteamRemoteStorage_GetFileNameAndSize(IntPtr instancePtr, int iFile, out int pnFileSizeInBytes) { }

	public static int ISteamRemoteStorage_GetFileSize(IntPtr instancePtr, UTF8StringHandle pchFile) { }

	public static long ISteamRemoteStorage_GetFileTimestamp(IntPtr instancePtr, UTF8StringHandle pchFile) { }

	public static IntPtr ISteamRemoteStorage_GetLocalFileChange(IntPtr instancePtr, int iFile, out ERemoteStorageLocalFileChange pEChangeType, out ERemoteStorageFilePathType pEFilePathType) { }

	public static int ISteamRemoteStorage_GetLocalFileChangeCount(IntPtr instancePtr) { }

	public static ulong ISteamRemoteStorage_GetPublishedFileDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld) { }

	public static ulong ISteamRemoteStorage_GetPublishedItemVoteDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId) { }

	public static bool ISteamRemoteStorage_GetQuota(IntPtr instancePtr, out ulong pnTotalBytes, out ulong puAvailableBytes) { }

	public static ERemoteStoragePlatform ISteamRemoteStorage_GetSyncPlatforms(IntPtr instancePtr, UTF8StringHandle pchFile) { }

	public static bool ISteamRemoteStorage_GetUGCDetails(IntPtr instancePtr, UGCHandle_t hContent, out AppId_t pnAppID, out IntPtr ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner) { }

	public static bool ISteamRemoteStorage_GetUGCDownloadProgress(IntPtr instancePtr, UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected) { }

	public static ulong ISteamRemoteStorage_GetUserPublishedItemVoteDetails(IntPtr instancePtr, PublishedFileId_t unPublishedFileId) { }

	public static bool ISteamRemoteStorage_IsCloudEnabledForAccount(IntPtr instancePtr) { }

	public static bool ISteamRemoteStorage_IsCloudEnabledForApp(IntPtr instancePtr) { }

	public static ulong ISteamRemoteStorage_PublishVideo(IntPtr instancePtr, EWorkshopVideoProvider eVideoProvider, UTF8StringHandle pchVideoAccount, UTF8StringHandle pchVideoIdentifier, UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, UTF8StringHandle pchTitle, UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags) { }

	public static ulong ISteamRemoteStorage_PublishWorkshopFile(IntPtr instancePtr, UTF8StringHandle pchFile, UTF8StringHandle pchPreviewFile, AppId_t nConsumerAppId, UTF8StringHandle pchTitle, UTF8StringHandle pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IntPtr pTags, EWorkshopFileType eWorkshopFileType) { }

	public static void ISteamRemoteStorage_SetCloudEnabledForApp(IntPtr instancePtr, bool bEnabled) { }

	public static bool ISteamRemoteStorage_SetSyncPlatforms(IntPtr instancePtr, UTF8StringHandle pchFile, ERemoteStoragePlatform eRemoteStoragePlatform) { }

	public static ulong ISteamRemoteStorage_SetUserPublishedFileAction(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction) { }

	public static ulong ISteamRemoteStorage_SubscribePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId) { }

	public static ulong ISteamRemoteStorage_UGCDownload(IntPtr instancePtr, UGCHandle_t hContent, uint unPriority) { }

	public static ulong ISteamRemoteStorage_UGCDownloadToLocation(IntPtr instancePtr, UGCHandle_t hContent, UTF8StringHandle pchLocation, uint unPriority) { }

	public static int ISteamRemoteStorage_UGCRead(IntPtr instancePtr, UGCHandle_t hContent, Byte[] pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction) { }

	public static ulong ISteamRemoteStorage_UnsubscribePublishedFile(IntPtr instancePtr, PublishedFileId_t unPublishedFileId) { }

	public static bool ISteamRemoteStorage_UpdatePublishedFileDescription(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, UTF8StringHandle pchDescription) { }

	public static bool ISteamRemoteStorage_UpdatePublishedFileFile(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, UTF8StringHandle pchFile) { }

	public static bool ISteamRemoteStorage_UpdatePublishedFilePreviewFile(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, UTF8StringHandle pchPreviewFile) { }

	public static bool ISteamRemoteStorage_UpdatePublishedFileSetChangeDescription(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, UTF8StringHandle pchChangeDescription) { }

	public static bool ISteamRemoteStorage_UpdatePublishedFileTags(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, IntPtr pTags) { }

	public static bool ISteamRemoteStorage_UpdatePublishedFileTitle(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, UTF8StringHandle pchTitle) { }

	public static bool ISteamRemoteStorage_UpdatePublishedFileVisibility(IntPtr instancePtr, PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility) { }

	public static ulong ISteamRemoteStorage_UpdateUserPublishedItemVote(IntPtr instancePtr, PublishedFileId_t unPublishedFileId, bool bVoteUp) { }

	public static uint ISteamScreenshots_AddScreenshotToLibrary(IntPtr instancePtr, UTF8StringHandle pchFilename, UTF8StringHandle pchThumbnailFilename, int nWidth, int nHeight) { }

	public static uint ISteamScreenshots_AddVRScreenshotToLibrary(IntPtr instancePtr, EVRScreenshotType eType, UTF8StringHandle pchFilename, UTF8StringHandle pchVRFilename) { }

	public static void ISteamScreenshots_HookScreenshots(IntPtr instancePtr, bool bHook) { }

	public static bool ISteamScreenshots_IsScreenshotsHooked(IntPtr instancePtr) { }

	public static bool ISteamScreenshots_SetLocation(IntPtr instancePtr, ScreenshotHandle hScreenshot, UTF8StringHandle pchLocation) { }

	public static bool ISteamScreenshots_TagPublishedFile(IntPtr instancePtr, ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID) { }

	public static bool ISteamScreenshots_TagUser(IntPtr instancePtr, ScreenshotHandle hScreenshot, CSteamID steamID) { }

	public static void ISteamScreenshots_TriggerScreenshot(IntPtr instancePtr) { }

	public static uint ISteamScreenshots_WriteScreenshot(IntPtr instancePtr, Byte[] pubRGB, uint cubRGB, int nWidth, int nHeight) { }

	public static ulong ISteamUGC_AddAppDependency(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, AppId_t nAppID) { }

	public static ulong ISteamUGC_AddDependency(IntPtr instancePtr, PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) { }

	public static bool ISteamUGC_AddExcludedTag(IntPtr instancePtr, UGCQueryHandle_t handle, UTF8StringHandle pTagName) { }

	public static bool ISteamUGC_AddItemKeyValueTag(IntPtr instancePtr, UGCUpdateHandle_t handle, UTF8StringHandle pchKey, UTF8StringHandle pchValue) { }

	public static bool ISteamUGC_AddItemPreviewFile(IntPtr instancePtr, UGCUpdateHandle_t handle, UTF8StringHandle pszPreviewFile, EItemPreviewType type) { }

	public static bool ISteamUGC_AddItemPreviewVideo(IntPtr instancePtr, UGCUpdateHandle_t handle, UTF8StringHandle pszVideoID) { }

	public static ulong ISteamUGC_AddItemToFavorites(IntPtr instancePtr, AppId_t nAppId, PublishedFileId_t nPublishedFileID) { }

	public static bool ISteamUGC_AddRequiredKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, UTF8StringHandle pKey, UTF8StringHandle pValue) { }

	public static bool ISteamUGC_AddRequiredTag(IntPtr instancePtr, UGCQueryHandle_t handle, UTF8StringHandle pTagName) { }

	public static bool ISteamUGC_AddRequiredTagGroup(IntPtr instancePtr, UGCQueryHandle_t handle, IntPtr pTagGroups) { }

	public static bool ISteamUGC_BInitWorkshopForGameServer(IntPtr instancePtr, DepotId_t unWorkshopDepotID, UTF8StringHandle pszFolder) { }

	public static ulong ISteamUGC_CreateItem(IntPtr instancePtr, AppId_t nConsumerAppId, EWorkshopFileType eFileType) { }

	public static ulong ISteamUGC_CreateQueryAllUGCRequestCursor(IntPtr instancePtr, EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, UTF8StringHandle pchCursor) { }

	public static ulong ISteamUGC_CreateQueryAllUGCRequestPage(IntPtr instancePtr, EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) { }

	public static ulong ISteamUGC_CreateQueryUGCDetailsRequest(IntPtr instancePtr, out PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	public static ulong ISteamUGC_CreateQueryUserUGCRequest(IntPtr instancePtr, AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage) { }

	public static ulong ISteamUGC_DeleteItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID) { }

	public static bool ISteamUGC_DownloadItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, bool bHighPriority) { }

	public static ulong ISteamUGC_GetAppDependencies(IntPtr instancePtr, PublishedFileId_t nPublishedFileID) { }

	public static bool ISteamUGC_GetItemDownloadInfo(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal) { }

	public static bool ISteamUGC_GetItemInstallInfo(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, IntPtr pchFolder, uint cchFolderSize, out uint punTimeStamp) { }

	public static uint ISteamUGC_GetItemState(IntPtr instancePtr, PublishedFileId_t nPublishedFileID) { }

	public static EItemUpdateStatus ISteamUGC_GetItemUpdateProgress(IntPtr instancePtr, UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal) { }

	public static uint ISteamUGC_GetNumSubscribedItems(IntPtr instancePtr) { }

	public static bool ISteamUGC_GetQueryFirstUGCKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, UTF8StringHandle pchKey, IntPtr pchValue, uint cchValueSize) { }

	public static bool ISteamUGC_GetQueryUGCAdditionalPreview(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint previewIndex, IntPtr pchURLOrVideoID, uint cchURLSize, IntPtr pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType) { }

	public static bool ISteamUGC_GetQueryUGCChildren(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, out PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) { }

	public static bool ISteamUGC_GetQueryUGCKeyValueTag(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, IntPtr pchKey, uint cchKeySize, IntPtr pchValue, uint cchValueSize) { }

	public static bool ISteamUGC_GetQueryUGCMetadata(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, IntPtr pchMetadata, uint cchMetadatasize) { }

	public static uint ISteamUGC_GetQueryUGCNumAdditionalPreviews(IntPtr instancePtr, UGCQueryHandle_t handle, uint index) { }

	public static uint ISteamUGC_GetQueryUGCNumKeyValueTags(IntPtr instancePtr, UGCQueryHandle_t handle, uint index) { }

	public static uint ISteamUGC_GetQueryUGCNumTags(IntPtr instancePtr, UGCQueryHandle_t handle, uint index) { }

	public static bool ISteamUGC_GetQueryUGCPreviewURL(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, IntPtr pchURL, uint cchURLSize) { }

	public static bool ISteamUGC_GetQueryUGCResult(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails) { }

	public static bool ISteamUGC_GetQueryUGCStatistic(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue) { }

	public static bool ISteamUGC_GetQueryUGCTag(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint indexTag, IntPtr pchValue, uint cchValueSize) { }

	public static bool ISteamUGC_GetQueryUGCTagDisplayName(IntPtr instancePtr, UGCQueryHandle_t handle, uint index, uint indexTag, IntPtr pchValue, uint cchValueSize) { }

	public static uint ISteamUGC_GetSubscribedItems(IntPtr instancePtr, out PublishedFileId_t[] pvecPublishedFileID, uint cMaxEntries) { }

	public static ulong ISteamUGC_GetUserItemVote(IntPtr instancePtr, PublishedFileId_t nPublishedFileID) { }

	public static ulong ISteamUGC_GetWorkshopEULAStatus(IntPtr instancePtr) { }

	public static bool ISteamUGC_ReleaseQueryUGCRequest(IntPtr instancePtr, UGCQueryHandle_t handle) { }

	public static bool ISteamUGC_RemoveAllItemKeyValueTags(IntPtr instancePtr, UGCUpdateHandle_t handle) { }

	public static ulong ISteamUGC_RemoveAppDependency(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, AppId_t nAppID) { }

	public static ulong ISteamUGC_RemoveDependency(IntPtr instancePtr, PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID) { }

	public static ulong ISteamUGC_RemoveItemFromFavorites(IntPtr instancePtr, AppId_t nAppId, PublishedFileId_t nPublishedFileID) { }

	public static bool ISteamUGC_RemoveItemKeyValueTags(IntPtr instancePtr, UGCUpdateHandle_t handle, UTF8StringHandle pchKey) { }

	public static bool ISteamUGC_RemoveItemPreview(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index) { }

	public static ulong ISteamUGC_RequestUGCDetails(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds) { }

	public static ulong ISteamUGC_SendQueryUGCRequest(IntPtr instancePtr, UGCQueryHandle_t handle) { }

	public static bool ISteamUGC_SetAllowCachedResponse(IntPtr instancePtr, UGCQueryHandle_t handle, uint unMaxAgeSeconds) { }

	public static bool ISteamUGC_SetAllowLegacyUpload(IntPtr instancePtr, UGCUpdateHandle_t handle, bool bAllowLegacyUpload) { }

	public static bool ISteamUGC_SetCloudFileNameFilter(IntPtr instancePtr, UGCQueryHandle_t handle, UTF8StringHandle pMatchCloudFileName) { }

	public static bool ISteamUGC_SetItemContent(IntPtr instancePtr, UGCUpdateHandle_t handle, UTF8StringHandle pszContentFolder) { }

	public static bool ISteamUGC_SetItemDescription(IntPtr instancePtr, UGCUpdateHandle_t handle, UTF8StringHandle pchDescription) { }

	public static bool ISteamUGC_SetItemMetadata(IntPtr instancePtr, UGCUpdateHandle_t handle, UTF8StringHandle pchMetaData) { }

	public static bool ISteamUGC_SetItemPreview(IntPtr instancePtr, UGCUpdateHandle_t handle, UTF8StringHandle pszPreviewFile) { }

	public static bool ISteamUGC_SetItemTags(IntPtr instancePtr, UGCUpdateHandle_t updateHandle, IntPtr pTags) { }

	public static bool ISteamUGC_SetItemTitle(IntPtr instancePtr, UGCUpdateHandle_t handle, UTF8StringHandle pchTitle) { }

	public static bool ISteamUGC_SetItemUpdateLanguage(IntPtr instancePtr, UGCUpdateHandle_t handle, UTF8StringHandle pchLanguage) { }

	public static bool ISteamUGC_SetItemVisibility(IntPtr instancePtr, UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility) { }

	public static bool ISteamUGC_SetLanguage(IntPtr instancePtr, UGCQueryHandle_t handle, UTF8StringHandle pchLanguage) { }

	public static bool ISteamUGC_SetMatchAnyTag(IntPtr instancePtr, UGCQueryHandle_t handle, bool bMatchAnyTag) { }

	public static bool ISteamUGC_SetRankedByTrendDays(IntPtr instancePtr, UGCQueryHandle_t handle, uint unDays) { }

	public static bool ISteamUGC_SetReturnAdditionalPreviews(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnAdditionalPreviews) { }

	public static bool ISteamUGC_SetReturnChildren(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnChildren) { }

	public static bool ISteamUGC_SetReturnKeyValueTags(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnKeyValueTags) { }

	public static bool ISteamUGC_SetReturnLongDescription(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnLongDescription) { }

	public static bool ISteamUGC_SetReturnMetadata(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnMetadata) { }

	public static bool ISteamUGC_SetReturnOnlyIDs(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnOnlyIDs) { }

	public static bool ISteamUGC_SetReturnPlaytimeStats(IntPtr instancePtr, UGCQueryHandle_t handle, uint unDays) { }

	public static bool ISteamUGC_SetReturnTotalOnly(IntPtr instancePtr, UGCQueryHandle_t handle, bool bReturnTotalOnly) { }

	public static bool ISteamUGC_SetSearchText(IntPtr instancePtr, UGCQueryHandle_t handle, UTF8StringHandle pSearchText) { }

	public static ulong ISteamUGC_SetUserItemVote(IntPtr instancePtr, PublishedFileId_t nPublishedFileID, bool bVoteUp) { }

	public static bool ISteamUGC_ShowWorkshopEULA(IntPtr instancePtr) { }

	public static ulong ISteamUGC_StartItemUpdate(IntPtr instancePtr, AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID) { }

	public static ulong ISteamUGC_StartPlaytimeTracking(IntPtr instancePtr, out PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	public static ulong ISteamUGC_StopPlaytimeTracking(IntPtr instancePtr, out PublishedFileId_t[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	public static ulong ISteamUGC_StopPlaytimeTrackingForAllItems(IntPtr instancePtr) { }

	public static ulong ISteamUGC_SubmitItemUpdate(IntPtr instancePtr, UGCUpdateHandle_t handle, UTF8StringHandle pchChangeNote) { }

	public static ulong ISteamUGC_SubscribeItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID) { }

	public static void ISteamUGC_SuspendDownloads(IntPtr instancePtr, bool bSuspend) { }

	public static ulong ISteamUGC_UnsubscribeItem(IntPtr instancePtr, PublishedFileId_t nPublishedFileID) { }

	public static bool ISteamUGC_UpdateItemPreviewFile(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index, UTF8StringHandle pszPreviewFile) { }

	public static bool ISteamUGC_UpdateItemPreviewVideo(IntPtr instancePtr, UGCUpdateHandle_t handle, uint index, UTF8StringHandle pszVideoID) { }

	public static void ISteamUser_AdvertiseGame(IntPtr instancePtr, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer) { }

	public static EBeginAuthSessionResult ISteamUser_BeginAuthSession(IntPtr instancePtr, Byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID) { }

	public static bool ISteamUser_BIsBehindNAT(IntPtr instancePtr) { }

	public static bool ISteamUser_BIsPhoneIdentifying(IntPtr instancePtr) { }

	public static bool ISteamUser_BIsPhoneRequiringVerification(IntPtr instancePtr) { }

	public static bool ISteamUser_BIsPhoneVerified(IntPtr instancePtr) { }

	public static bool ISteamUser_BIsTwoFactorEnabled(IntPtr instancePtr) { }

	public static bool ISteamUser_BLoggedOn(IntPtr instancePtr) { }

	public static bool ISteamUser_BSetDurationControlOnlineState(IntPtr instancePtr, EDurationControlOnlineState eNewState) { }

	public static void ISteamUser_CancelAuthTicket(IntPtr instancePtr, HAuthTicket hAuthTicket) { }

	public static EVoiceResult ISteamUser_DecompressVoice(IntPtr instancePtr, Byte[] pCompressed, uint cbCompressed, Byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate) { }

	public static void ISteamUser_EndAuthSession(IntPtr instancePtr, CSteamID steamID) { }

	public static uint ISteamUser_GetAuthSessionTicket(IntPtr instancePtr, Byte[] pTicket, int cbMaxTicket, out uint pcbTicket) { }

	public static EVoiceResult ISteamUser_GetAvailableVoice(IntPtr instancePtr, out uint pcbCompressed, IntPtr pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	public static ulong ISteamUser_GetDurationControl(IntPtr instancePtr) { }

	public static bool ISteamUser_GetEncryptedAppTicket(IntPtr instancePtr, Byte[] pTicket, int cbMaxTicket, out uint pcbTicket) { }

	public static int ISteamUser_GetGameBadgeLevel(IntPtr instancePtr, int nSeries, bool bFoil) { }

	public static int ISteamUser_GetHSteamUser(IntPtr instancePtr) { }

	public static ulong ISteamUser_GetMarketEligibility(IntPtr instancePtr) { }

	public static int ISteamUser_GetPlayerSteamLevel(IntPtr instancePtr) { }

	public static ulong ISteamUser_GetSteamID(IntPtr instancePtr) { }

	public static bool ISteamUser_GetUserDataFolder(IntPtr instancePtr, IntPtr pchBuffer, int cubBuffer) { }

	public static EVoiceResult ISteamUser_GetVoice(IntPtr instancePtr, bool bWantCompressed, Byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, IntPtr nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	public static uint ISteamUser_GetVoiceOptimalSampleRate(IntPtr instancePtr) { }

	public static int ISteamUser_InitiateGameConnection_DEPRECATED(IntPtr instancePtr, Byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure) { }

	public static ulong ISteamUser_RequestEncryptedAppTicket(IntPtr instancePtr, Byte[] pDataToInclude, int cbDataToInclude) { }

	public static ulong ISteamUser_RequestStoreAuthURL(IntPtr instancePtr, UTF8StringHandle pchRedirectURL) { }

	public static void ISteamUser_StartVoiceRecording(IntPtr instancePtr) { }

	public static void ISteamUser_StopVoiceRecording(IntPtr instancePtr) { }

	public static void ISteamUser_TerminateGameConnection_DEPRECATED(IntPtr instancePtr, uint unIPServer, ushort usPortServer) { }

	public static void ISteamUser_TrackAppUsageEvent(IntPtr instancePtr, CGameID gameID, int eAppUsageEvent, UTF8StringHandle pchExtraInfo) { }

	public static EUserHasLicenseForAppResult ISteamUser_UserHasLicenseForApp(IntPtr instancePtr, CSteamID steamID, AppId_t appID) { }

	public static ulong ISteamUserStats_AttachLeaderboardUGC(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC) { }

	public static bool ISteamUserStats_ClearAchievement(IntPtr instancePtr, UTF8StringHandle pchName) { }

	public static ulong ISteamUserStats_DownloadLeaderboardEntries(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd) { }

	public static ulong ISteamUserStats_DownloadLeaderboardEntriesForUsers(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, out CSteamID[] prgUsers, int cUsers) { }

	public static ulong ISteamUserStats_FindLeaderboard(IntPtr instancePtr, UTF8StringHandle pchLeaderboardName) { }

	public static ulong ISteamUserStats_FindOrCreateLeaderboard(IntPtr instancePtr, UTF8StringHandle pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType) { }

	public static bool ISteamUserStats_GetAchievement(IntPtr instancePtr, UTF8StringHandle pchName, out bool pbAchieved) { }

	public static bool ISteamUserStats_GetAchievementAchievedPercent(IntPtr instancePtr, UTF8StringHandle pchName, out float pflPercent) { }

	public static bool ISteamUserStats_GetAchievementAndUnlockTime(IntPtr instancePtr, UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime) { }

	public static IntPtr ISteamUserStats_GetAchievementDisplayAttribute(IntPtr instancePtr, UTF8StringHandle pchName, UTF8StringHandle pchKey) { }

	public static int ISteamUserStats_GetAchievementIcon(IntPtr instancePtr, UTF8StringHandle pchName) { }

	public static IntPtr ISteamUserStats_GetAchievementName(IntPtr instancePtr, uint iAchievement) { }

	public static bool ISteamUserStats_GetAchievementProgressLimitsFloat(IntPtr instancePtr, UTF8StringHandle pchName, out float pfMinProgress, out float pfMaxProgress) { }

	public static bool ISteamUserStats_GetAchievementProgressLimitsInt32(IntPtr instancePtr, UTF8StringHandle pchName, out int pnMinProgress, out int pnMaxProgress) { }

	public static bool ISteamUserStats_GetDownloadedLeaderboardEntry(IntPtr instancePtr, SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, out Int32[] pDetails, int cDetailsMax) { }

	public static bool ISteamUserStats_GetGlobalStatDouble(IntPtr instancePtr, UTF8StringHandle pchStatName, out double pData) { }

	public static int ISteamUserStats_GetGlobalStatHistoryDouble(IntPtr instancePtr, UTF8StringHandle pchStatName, out Double[] pData, uint cubData) { }

	public static int ISteamUserStats_GetGlobalStatHistoryInt64(IntPtr instancePtr, UTF8StringHandle pchStatName, out Int64[] pData, uint cubData) { }

	public static bool ISteamUserStats_GetGlobalStatInt64(IntPtr instancePtr, UTF8StringHandle pchStatName, out long pData) { }

	public static ELeaderboardDisplayType ISteamUserStats_GetLeaderboardDisplayType(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard) { }

	public static int ISteamUserStats_GetLeaderboardEntryCount(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard) { }

	public static IntPtr ISteamUserStats_GetLeaderboardName(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard) { }

	public static ELeaderboardSortMethod ISteamUserStats_GetLeaderboardSortMethod(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard) { }

	public static int ISteamUserStats_GetMostAchievedAchievementInfo(IntPtr instancePtr, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved) { }

	public static int ISteamUserStats_GetNextMostAchievedAchievementInfo(IntPtr instancePtr, int iIteratorPrevious, IntPtr pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved) { }

	public static uint ISteamUserStats_GetNumAchievements(IntPtr instancePtr) { }

	public static ulong ISteamUserStats_GetNumberOfCurrentPlayers(IntPtr instancePtr) { }

	public static bool ISteamUserStats_GetStatFloat(IntPtr instancePtr, UTF8StringHandle pchName, out float pData) { }

	public static bool ISteamUserStats_GetStatInt32(IntPtr instancePtr, UTF8StringHandle pchName, out int pData) { }

	public static bool ISteamUserStats_GetUserAchievement(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName, out bool pbAchieved) { }

	public static bool ISteamUserStats_GetUserAchievementAndUnlockTime(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName, out bool pbAchieved, out uint punUnlockTime) { }

	public static bool ISteamUserStats_GetUserStatFloat(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName, out float pData) { }

	public static bool ISteamUserStats_GetUserStatInt32(IntPtr instancePtr, CSteamID steamIDUser, UTF8StringHandle pchName, out int pData) { }

	public static bool ISteamUserStats_IndicateAchievementProgress(IntPtr instancePtr, UTF8StringHandle pchName, uint nCurProgress, uint nMaxProgress) { }

	public static bool ISteamUserStats_RequestCurrentStats(IntPtr instancePtr) { }

	public static ulong ISteamUserStats_RequestGlobalAchievementPercentages(IntPtr instancePtr) { }

	public static ulong ISteamUserStats_RequestGlobalStats(IntPtr instancePtr, int nHistoryDays) { }

	public static ulong ISteamUserStats_RequestUserStats(IntPtr instancePtr, CSteamID steamIDUser) { }

	public static bool ISteamUserStats_ResetAllStats(IntPtr instancePtr, bool bAchievementsToo) { }

	public static bool ISteamUserStats_SetAchievement(IntPtr instancePtr, UTF8StringHandle pchName) { }

	public static bool ISteamUserStats_SetStatFloat(IntPtr instancePtr, UTF8StringHandle pchName, float fData) { }

	public static bool ISteamUserStats_SetStatInt32(IntPtr instancePtr, UTF8StringHandle pchName, int nData) { }

	public static bool ISteamUserStats_StoreStats(IntPtr instancePtr) { }

	public static bool ISteamUserStats_UpdateAvgRateStat(IntPtr instancePtr, UTF8StringHandle pchName, float flCountThisSession, double dSessionLength) { }

	public static ulong ISteamUserStats_UploadLeaderboardScore(IntPtr instancePtr, SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, out Int32[] pScoreDetails, int cScoreDetailsCount) { }

	public static bool ISteamUtils_BOverlayNeedsPresent(IntPtr instancePtr) { }

	public static ulong ISteamUtils_CheckFileSignature(IntPtr instancePtr, UTF8StringHandle szFileName) { }

	public static int ISteamUtils_FilterText(IntPtr instancePtr, ETextFilteringContext eContext, CSteamID sourceSteamID, UTF8StringHandle pchInputMessage, IntPtr pchOutFilteredText, uint nByteSizeOutFilteredText) { }

	public static ESteamAPICallFailure ISteamUtils_GetAPICallFailureReason(IntPtr instancePtr, SteamAPICall_t hSteamAPICall) { }

	public static bool ISteamUtils_GetAPICallResult(IntPtr instancePtr, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed) { }

	public static uint ISteamUtils_GetAppID(IntPtr instancePtr) { }

	public static EUniverse ISteamUtils_GetConnectedUniverse(IntPtr instancePtr) { }

	public static byte ISteamUtils_GetCurrentBatteryPower(IntPtr instancePtr) { }

	public static bool ISteamUtils_GetEnteredGamepadTextInput(IntPtr instancePtr, IntPtr pchText, uint cchText) { }

	public static uint ISteamUtils_GetEnteredGamepadTextLength(IntPtr instancePtr) { }

	public static bool ISteamUtils_GetImageRGBA(IntPtr instancePtr, int iImage, Byte[] pubDest, int nDestBufferSize) { }

	public static bool ISteamUtils_GetImageSize(IntPtr instancePtr, int iImage, out uint pnWidth, out uint pnHeight) { }

	public static uint ISteamUtils_GetIPCCallCount(IntPtr instancePtr) { }

	public static IntPtr ISteamUtils_GetIPCountry(IntPtr instancePtr) { }

	public static ESteamIPv6ConnectivityState ISteamUtils_GetIPv6ConnectivityState(IntPtr instancePtr, ESteamIPv6ConnectivityProtocol eProtocol) { }

	public static uint ISteamUtils_GetSecondsSinceAppActive(IntPtr instancePtr) { }

	public static uint ISteamUtils_GetSecondsSinceComputerActive(IntPtr instancePtr) { }

	public static uint ISteamUtils_GetServerRealTime(IntPtr instancePtr) { }

	public static IntPtr ISteamUtils_GetSteamUILanguage(IntPtr instancePtr) { }

	public static bool ISteamUtils_InitFilterText(IntPtr instancePtr, uint unFilterOptions) { }

	public static bool ISteamUtils_IsAPICallCompleted(IntPtr instancePtr, SteamAPICall_t hSteamAPICall, out bool pbFailed) { }

	public static bool ISteamUtils_IsOverlayEnabled(IntPtr instancePtr) { }

	public static bool ISteamUtils_IsSteamChinaLauncher(IntPtr instancePtr) { }

	public static bool ISteamUtils_IsSteamInBigPictureMode(IntPtr instancePtr) { }

	public static bool ISteamUtils_IsSteamRunningInVR(IntPtr instancePtr) { }

	public static bool ISteamUtils_IsSteamRunningOnSteamDeck(IntPtr instancePtr) { }

	public static bool ISteamUtils_IsVRHeadsetStreamingEnabled(IntPtr instancePtr) { }

	public static void ISteamUtils_SetGameLauncherMode(IntPtr instancePtr, bool bLauncherMode) { }

	public static void ISteamUtils_SetOverlayNotificationInset(IntPtr instancePtr, int nHorizontalInset, int nVerticalInset) { }

	public static void ISteamUtils_SetOverlayNotificationPosition(IntPtr instancePtr, ENotificationPosition eNotificationPosition) { }

	public static void ISteamUtils_SetVRHeadsetStreamingEnabled(IntPtr instancePtr, bool bEnabled) { }

	public static void ISteamUtils_SetWarningMessageHook(IntPtr instancePtr, SteamAPIWarningMessageHook_t pFunction) { }

	public static bool ISteamUtils_ShowFloatingGamepadTextInput(IntPtr instancePtr, EFloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight) { }

	public static bool ISteamUtils_ShowGamepadTextInput(IntPtr instancePtr, EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, UTF8StringHandle pchDescription, uint unCharMax, UTF8StringHandle pchExistingText) { }

	public static void ISteamUtils_StartVRDashboard(IntPtr instancePtr) { }

	public static void ISteamVideo_GetOPFSettings(IntPtr instancePtr, AppId_t unVideoAppID) { }

	public static bool ISteamVideo_GetOPFStringForApp(IntPtr instancePtr, AppId_t unVideoAppID, IntPtr pchBuffer, ref int pnBufferSize) { }

	public static void ISteamVideo_GetVideoURL(IntPtr instancePtr, AppId_t unVideoAppID) { }

	public static bool ISteamVideo_IsBroadcasting(IntPtr instancePtr, out int pnNumViewers) { }

	public static int SteamAPI_GetHSteamPipe() { }

	public static int SteamAPI_GetHSteamUser() { }

	public static int SteamAPI_GetSteamInstallPath() { }

	public static bool SteamAPI_Init() { }

	public static bool SteamAPI_IsSteamRunning() { }

	public static void SteamAPI_ISteamNetworkingConnectionSignaling_Release(ref ISteamNetworkingConnectionSignaling self) { }

	public static bool SteamAPI_ISteamNetworkingConnectionSignaling_SendSignal(ref ISteamNetworkingConnectionSignaling self, HSteamNetConnection hConn, ref SteamNetConnectionInfo_t info, IntPtr pMsg, int cbMsg) { }

	public static IntPtr SteamAPI_ISteamNetworkingSignalingRecvContext_OnConnectRequest(ref ISteamNetworkingSignalingRecvContext self, HSteamNetConnection hConn, ref SteamNetworkingIdentity identityPeer, int nLocalVirtualPort) { }

	public static void SteamAPI_ISteamNetworkingSignalingRecvContext_SendRejectionSignal(ref ISteamNetworkingSignalingRecvContext self, ref SteamNetworkingIdentity identityPeer, IntPtr pMsg, int cbMsg) { }

	public static void SteamAPI_ManualDispatch_FreeLastCallback(HSteamPipe hSteamPipe) { }

	public static bool SteamAPI_ManualDispatch_GetAPICallResult(HSteamPipe hSteamPipe, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed) { }

	public static bool SteamAPI_ManualDispatch_GetNextCallback(HSteamPipe hSteamPipe, IntPtr pCallbackMsg) { }

	public static void SteamAPI_ManualDispatch_Init() { }

	public static void SteamAPI_ManualDispatch_RunFrame(HSteamPipe hSteamPipe) { }

	public static void SteamAPI_RegisterCallback(IntPtr pCallback, int iCallback) { }

	public static void SteamAPI_RegisterCallResult(IntPtr pCallback, ulong hAPICall) { }

	public static void SteamAPI_ReleaseCurrentThreadMemory() { }

	public static bool SteamAPI_RestartAppIfNecessary(AppId_t unOwnAppID) { }

	public static void SteamAPI_RunCallbacks() { }

	public static void SteamAPI_SetBreakpadAppID(uint unAppID) { }

	public static void SteamAPI_SetMiniDumpComment(UTF8StringHandle pchMsg) { }

	public static void SteamAPI_SetTryCatchCallbacks(bool bTryCatchCallbacks) { }

	public static void SteamAPI_Shutdown() { }

	public static void SteamAPI_SteamNetworkingIdentity_Clear(ref SteamNetworkingIdentity self) { }

	public static IntPtr SteamAPI_SteamNetworkingIdentity_GetGenericBytes(ref SteamNetworkingIdentity self, out int cbLen) { }

	public static IntPtr SteamAPI_SteamNetworkingIdentity_GetGenericString(ref SteamNetworkingIdentity self) { }

	public static IntPtr SteamAPI_SteamNetworkingIdentity_GetIPAddr(ref SteamNetworkingIdentity self) { }

	public static ulong SteamAPI_SteamNetworkingIdentity_GetSteamID(ref SteamNetworkingIdentity self) { }

	public static ulong SteamAPI_SteamNetworkingIdentity_GetSteamID64(ref SteamNetworkingIdentity self) { }

	public static IntPtr SteamAPI_SteamNetworkingIdentity_GetXboxPairwiseID(ref SteamNetworkingIdentity self) { }

	public static bool SteamAPI_SteamNetworkingIdentity_IsEqualTo(ref SteamNetworkingIdentity self, ref SteamNetworkingIdentity x) { }

	public static bool SteamAPI_SteamNetworkingIdentity_IsInvalid(ref SteamNetworkingIdentity self) { }

	public static bool SteamAPI_SteamNetworkingIdentity_IsLocalHost(ref SteamNetworkingIdentity self) { }

	public static bool SteamAPI_SteamNetworkingIdentity_ParseString(ref SteamNetworkingIdentity self, UTF8StringHandle pszStr) { }

	public static bool SteamAPI_SteamNetworkingIdentity_SetGenericBytes(ref SteamNetworkingIdentity self, out Byte[] data, uint cbLen) { }

	public static bool SteamAPI_SteamNetworkingIdentity_SetGenericString(ref SteamNetworkingIdentity self, UTF8StringHandle pszString) { }

	public static IntPtr SteamAPI_SteamNetworkingIdentity_SetIPAddr(ref SteamNetworkingIdentity self, ref SteamNetworkingIPAddr addr) { }

	public static void SteamAPI_SteamNetworkingIdentity_SetLocalHost(ref SteamNetworkingIdentity self) { }

	public static void SteamAPI_SteamNetworkingIdentity_SetSteamID(ref SteamNetworkingIdentity self, ulong steamID) { }

	public static void SteamAPI_SteamNetworkingIdentity_SetSteamID64(ref SteamNetworkingIdentity self, ulong steamID) { }

	public static bool SteamAPI_SteamNetworkingIdentity_SetXboxPairwiseID(ref SteamNetworkingIdentity self, UTF8StringHandle pszString) { }

	public static void SteamAPI_SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity self, IntPtr buf, uint cbBuf) { }

	public static void SteamAPI_SteamNetworkingIPAddr_Clear(ref SteamNetworkingIPAddr self) { }

	public static uint SteamAPI_SteamNetworkingIPAddr_GetIPv4(ref SteamNetworkingIPAddr self) { }

	public static bool SteamAPI_SteamNetworkingIPAddr_IsEqualTo(ref SteamNetworkingIPAddr self, ref SteamNetworkingIPAddr x) { }

	public static bool SteamAPI_SteamNetworkingIPAddr_IsIPv4(ref SteamNetworkingIPAddr self) { }

	public static bool SteamAPI_SteamNetworkingIPAddr_IsIPv6AllZeros(ref SteamNetworkingIPAddr self) { }

	public static bool SteamAPI_SteamNetworkingIPAddr_IsLocalHost(ref SteamNetworkingIPAddr self) { }

	public static bool SteamAPI_SteamNetworkingIPAddr_ParseString(ref SteamNetworkingIPAddr self, UTF8StringHandle pszStr) { }

	public static void SteamAPI_SteamNetworkingIPAddr_SetIPv4(ref SteamNetworkingIPAddr self, uint nIP, ushort nPort) { }

	public static void SteamAPI_SteamNetworkingIPAddr_SetIPv6(ref SteamNetworkingIPAddr self, out Byte[] ipv6, ushort nPort) { }

	public static void SteamAPI_SteamNetworkingIPAddr_SetIPv6LocalHost(ref SteamNetworkingIPAddr self, ushort nPort) { }

	public static void SteamAPI_SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr self, IntPtr buf, uint cbBuf, bool bWithPort) { }

	public static void SteamAPI_SteamNetworkingMessage_t_Release(IntPtr self) { }

	public static void SteamAPI_UnregisterCallback(IntPtr pCallback) { }

	public static void SteamAPI_UnregisterCallResult(IntPtr pCallback, ulong hAPICall) { }

	public static void SteamAPI_UseBreakpadCrashHandler(UTF8StringHandle pchVersion, UTF8StringHandle pchDate, UTF8StringHandle pchTime, bool bFullMemoryDumps, IntPtr pvContext, IntPtr m_pfnPreMinidumpCallback) { }

	public static void SteamAPI_WriteMiniDump(uint uStructuredExceptionCode, IntPtr pvExceptionInfo, uint uBuildID) { }

	public static IntPtr SteamClient() { }

	public static bool SteamEncryptedAppTicket_BDecryptTicket(out Byte[] rgubTicketEncrypted, uint cubTicketEncrypted, out Byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, Byte[] rgubKey, int cubKey) { }

	public static bool SteamEncryptedAppTicket_BIsLicenseBorrowed(out Byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	public static bool SteamEncryptedAppTicket_BIsLicenseTemporary(out Byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	public static bool SteamEncryptedAppTicket_BIsTicketForApp(out Byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID) { }

	public static bool SteamEncryptedAppTicket_BIsTicketSigned(out Byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out Byte[] pubRSAKey, uint cubRSAKey) { }

	public static bool SteamEncryptedAppTicket_BUserIsVacBanned(out Byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	public static bool SteamEncryptedAppTicket_BUserOwnsAppInTicket(out Byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID) { }

	public static uint SteamEncryptedAppTicket_GetTicketAppID(out Byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	public static uint SteamEncryptedAppTicket_GetTicketIssueTime(out Byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	public static void SteamEncryptedAppTicket_GetTicketSteamID(out Byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID) { }

	public static IntPtr SteamEncryptedAppTicket_GetUserVariableData(out Byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData) { }

	public static bool SteamGameServer_BSecure() { }

	public static int SteamGameServer_GetHSteamPipe() { }

	public static int SteamGameServer_GetHSteamUser() { }

	public static ulong SteamGameServer_GetSteamID() { }

	public static void SteamGameServer_ReleaseCurrentThreadMemory() { }

	public static void SteamGameServer_RunCallbacks() { }

	public static void SteamGameServer_Shutdown() { }

	public static IntPtr SteamGameServerClient() { }

	public static IntPtr SteamInternal_ContextInit(IntPtr pContextInitData) { }

	public static IntPtr SteamInternal_CreateInterface(UTF8StringHandle ver) { }

	public static IntPtr SteamInternal_FindOrCreateGameServerInterface(HSteamUser hSteamUser, UTF8StringHandle pszVersion) { }

	public static IntPtr SteamInternal_FindOrCreateUserInterface(HSteamUser hSteamUser, UTF8StringHandle pszVersion) { }

	public static bool SteamInternal_GameServer_Init(uint unIP, ushort usPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, UTF8StringHandle pchVersionString) { }

}

