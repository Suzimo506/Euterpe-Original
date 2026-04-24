namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct SteamAppUninstalled_t
{
	public const int k_iCallback = 3902; //Field offset: 0x0
	public AppId_t m_nAppID; //Field offset: 0x0
	public int m_iInstallFolderIndex; //Field offset: 0x4

}

