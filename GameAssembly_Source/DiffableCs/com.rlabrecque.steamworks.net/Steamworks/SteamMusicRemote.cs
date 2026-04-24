namespace Steamworks;

public static class SteamMusicRemote
{

	public static bool BActivationSuccess(bool bValue) { }

	public static bool BIsCurrentMusicRemote() { }

	public static bool CurrentEntryDidChange() { }

	public static bool CurrentEntryIsAvailable(bool bAvailable) { }

	public static bool CurrentEntryWillChange() { }

	public static bool DeregisterSteamMusicRemote() { }

	public static bool EnableLooped(bool bValue) { }

	public static bool EnablePlaylists(bool bValue) { }

	public static bool EnablePlayNext(bool bValue) { }

	public static bool EnablePlayPrevious(bool bValue) { }

	public static bool EnableQueue(bool bValue) { }

	public static bool EnableShuffled(bool bValue) { }

	public static bool PlaylistDidChange() { }

	public static bool PlaylistWillChange() { }

	public static bool QueueDidChange() { }

	public static bool QueueWillChange() { }

	public static bool RegisterSteamMusicRemote(string pchName) { }

	public static bool ResetPlaylistEntries() { }

	public static bool ResetQueueEntries() { }

	public static bool SetCurrentPlaylistEntry(int nID) { }

	public static bool SetCurrentQueueEntry(int nID) { }

	public static bool SetDisplayName(string pchDisplayName) { }

	public static bool SetPlaylistEntry(int nID, int nPosition, string pchEntryText) { }

	public static bool SetPNGIcon_64x64(Byte[] pvBuffer, uint cbBufferLength) { }

	public static bool SetQueueEntry(int nID, int nPosition, string pchEntryText) { }

	public static bool UpdateCurrentEntryCoverArt(Byte[] pvBuffer, uint cbBufferLength) { }

	public static bool UpdateCurrentEntryElapsedSeconds(int nValue) { }

	public static bool UpdateCurrentEntryText(string pchText) { }

	public static bool UpdateLooped(bool bValue) { }

	public static bool UpdatePlaybackStatus(AudioPlayback_Status nStatus) { }

	public static bool UpdateShuffled(bool bValue) { }

	public static bool UpdateVolume(float flValue) { }

}

