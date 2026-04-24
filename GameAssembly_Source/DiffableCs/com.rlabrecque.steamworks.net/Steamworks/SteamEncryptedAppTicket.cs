namespace Steamworks;

public static class SteamEncryptedAppTicket
{

	public static bool BDecryptTicket(Byte[] rgubTicketEncrypted, uint cubTicketEncrypted, Byte[] rgubTicketDecrypted, ref uint pcubTicketDecrypted, Byte[] rgubKey, int cubKey) { }

	public static bool BIsTicketForApp(Byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID) { }

	public static bool BIsTicketSigned(Byte[] rgubTicketDecrypted, uint cubTicketDecrypted, Byte[] pubRSAKey, uint cubRSAKey) { }

	public static bool BUserIsVacBanned(Byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	public static bool BUserOwnsAppInTicket(Byte[] rgubTicketDecrypted, uint cubTicketDecrypted, AppId_t nAppID) { }

	public static uint GetTicketAppID(Byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	public static uint GetTicketIssueTime(Byte[] rgubTicketDecrypted, uint cubTicketDecrypted) { }

	public static void GetTicketSteamID(Byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out CSteamID psteamID) { }

	public static Byte[] GetUserVariableData(Byte[] rgubTicketDecrypted, uint cubTicketDecrypted, out uint pcubUserData) { }

}

