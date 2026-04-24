namespace Steamworks;

public static class SteamFriends
{

	public static void ActivateGameOverlay(string pchDialog) { }

	public static void ActivateGameOverlayInviteDialog(CSteamID steamIDLobby) { }

	public static void ActivateGameOverlayInviteDialogConnectString(string pchConnectString) { }

	public static void ActivateGameOverlayRemotePlayTogetherInviteDialog(CSteamID steamIDLobby) { }

	public static void ActivateGameOverlayToStore(AppId_t nAppID, EOverlayToStoreFlag eFlag) { }

	public static void ActivateGameOverlayToUser(string pchDialog, CSteamID steamID) { }

	public static void ActivateGameOverlayToWebPage(string pchURL, EActivateGameOverlayToWebPageMode eMode = 0) { }

	public static void ClearRichPresence() { }

	public static bool CloseClanChatWindowInSteam(CSteamID steamIDClanChat) { }

	public static SteamAPICall_t DownloadClanActivityCounts(CSteamID[] psteamIDClans, int cClansToRequest) { }

	public static SteamAPICall_t EnumerateFollowingList(uint unStartIndex) { }

	public static CSteamID GetChatMemberByIndex(CSteamID steamIDClan, int iUser) { }

	public static bool GetClanActivityCounts(CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting) { }

	public static CSteamID GetClanByIndex(int iClan) { }

	public static int GetClanChatMemberCount(CSteamID steamIDClan) { }

	public static int GetClanChatMessage(CSteamID steamIDClanChat, int iMessage, out string prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter) { }

	public static int GetClanCount() { }

	public static string GetClanName(CSteamID steamIDClan) { }

	public static CSteamID GetClanOfficerByIndex(CSteamID steamIDClan, int iOfficer) { }

	public static int GetClanOfficerCount(CSteamID steamIDClan) { }

	public static CSteamID GetClanOwner(CSteamID steamIDClan) { }

	public static string GetClanTag(CSteamID steamIDClan) { }

	public static CSteamID GetCoplayFriend(int iCoplayFriend) { }

	public static int GetCoplayFriendCount() { }

	public static SteamAPICall_t GetFollowerCount(CSteamID steamID) { }

	public static CSteamID GetFriendByIndex(int iFriend, EFriendFlags iFriendFlags) { }

	public static AppId_t GetFriendCoplayGame(CSteamID steamIDFriend) { }

	public static int GetFriendCoplayTime(CSteamID steamIDFriend) { }

	public static int GetFriendCount(EFriendFlags iFriendFlags) { }

	public static int GetFriendCountFromSource(CSteamID steamIDSource) { }

	public static CSteamID GetFriendFromSourceByIndex(CSteamID steamIDSource, int iFriend) { }

	public static bool GetFriendGamePlayed(CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo) { }

	public static int GetFriendMessage(CSteamID steamIDFriend, int iMessageID, out string pvData, int cubData, out EChatEntryType peChatEntryType) { }

	public static string GetFriendPersonaName(CSteamID steamIDFriend) { }

	public static string GetFriendPersonaNameHistory(CSteamID steamIDFriend, int iPersonaName) { }

	public static EPersonaState GetFriendPersonaState(CSteamID steamIDFriend) { }

	public static EFriendRelationship GetFriendRelationship(CSteamID steamIDFriend) { }

	public static string GetFriendRichPresence(CSteamID steamIDFriend, string pchKey) { }

	public static string GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, int iKey) { }

	public static int GetFriendRichPresenceKeyCount(CSteamID steamIDFriend) { }

	public static int GetFriendsGroupCount() { }

	public static FriendsGroupID_t GetFriendsGroupIDByIndex(int iFG) { }

	public static int GetFriendsGroupMembersCount(FriendsGroupID_t friendsGroupID) { }

	public static void GetFriendsGroupMembersList(FriendsGroupID_t friendsGroupID, CSteamID[] pOutSteamIDMembers, int nMembersCount) { }

	public static string GetFriendsGroupName(FriendsGroupID_t friendsGroupID) { }

	public static int GetFriendSteamLevel(CSteamID steamIDFriend) { }

	public static int GetLargeFriendAvatar(CSteamID steamIDFriend) { }

	public static int GetMediumFriendAvatar(CSteamID steamIDFriend) { }

	public static int GetNumChatsWithUnreadPriorityMessages() { }

	public static string GetPersonaName() { }

	public static EPersonaState GetPersonaState() { }

	public static string GetPlayerNickname(CSteamID steamIDPlayer) { }

	public static int GetSmallFriendAvatar(CSteamID steamIDFriend) { }

	public static uint GetUserRestrictions() { }

	public static bool HasFriend(CSteamID steamIDFriend, EFriendFlags iFriendFlags) { }

	public static bool InviteUserToGame(CSteamID steamIDFriend, string pchConnectString) { }

	public static bool IsClanChatAdmin(CSteamID steamIDClanChat, CSteamID steamIDUser) { }

	public static bool IsClanChatWindowOpenInSteam(CSteamID steamIDClanChat) { }

	public static bool IsClanOfficialGameGroup(CSteamID steamIDClan) { }

	public static bool IsClanPublic(CSteamID steamIDClan) { }

	public static SteamAPICall_t IsFollowing(CSteamID steamID) { }

	public static bool IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource) { }

	public static SteamAPICall_t JoinClanChatRoom(CSteamID steamIDClan) { }

	public static bool LeaveClanChatRoom(CSteamID steamIDClan) { }

	public static bool OpenClanChatWindowInSteam(CSteamID steamIDClanChat) { }

	public static bool RegisterProtocolInOverlayBrowser(string pchProtocol) { }

	public static bool ReplyToFriendMessage(CSteamID steamIDFriend, string pchMsgToSend) { }

	public static SteamAPICall_t RequestClanOfficerList(CSteamID steamIDClan) { }

	public static void RequestFriendRichPresence(CSteamID steamIDFriend) { }

	public static bool RequestUserInformation(CSteamID steamIDUser, bool bRequireNameOnly) { }

	public static bool SendClanChatMessage(CSteamID steamIDClanChat, string pchText) { }

	public static void SetInGameVoiceSpeaking(CSteamID steamIDUser, bool bSpeaking) { }

	public static bool SetListenForFriendsMessages(bool bInterceptEnabled) { }

	public static SteamAPICall_t SetPersonaName(string pchPersonaName) { }

	public static void SetPlayedWith(CSteamID steamIDUserPlayedWith) { }

	public static bool SetRichPresence(string pchKey, string pchValue) { }

}

