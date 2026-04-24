namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct RemoteStorageGetPublishedFileDetailsResult_t
{
	public const int k_iCallback = 1318; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8
	public AppId_t m_nCreatorAppID; //Field offset: 0x10
	public AppId_t m_nConsumerAppID; //Field offset: 0x14
	private Byte[] m_rgchTitle_; //Field offset: 0x18
	private Byte[] m_rgchDescription_; //Field offset: 0x20
	public UGCHandle_t m_hFile; //Field offset: 0x28
	public UGCHandle_t m_hPreviewFile; //Field offset: 0x30
	public ulong m_ulSteamIDOwner; //Field offset: 0x38
	public uint m_rtimeCreated; //Field offset: 0x40
	public uint m_rtimeUpdated; //Field offset: 0x44
	public ERemoteStoragePublishedFileVisibility m_eVisibility; //Field offset: 0x48
	public bool m_bBanned; //Field offset: 0x4C
	private Byte[] m_rgchTags_; //Field offset: 0x50
	public bool m_bTagsTruncated; //Field offset: 0x58
	private Byte[] m_pchFileName_; //Field offset: 0x60
	public int m_nFileSize; //Field offset: 0x68
	public int m_nPreviewFileSize; //Field offset: 0x6C
	private Byte[] m_rgchURL_; //Field offset: 0x70
	public EWorkshopFileType m_eFileType; //Field offset: 0x78
	public bool m_bAcceptedForUse; //Field offset: 0x7C

	public string m_pchFileName
	{
		 get { } //Length: 11
		 set { } //Length: 24
	}

	public string m_rgchDescription
	{
		 get { } //Length: 11
		 set { } //Length: 24
	}

	public string m_rgchTags
	{
		 get { } //Length: 11
		 set { } //Length: 24
	}

	public string m_rgchTitle
	{
		 get { } //Length: 11
		 set { } //Length: 24
	}

	public string m_rgchURL
	{
		 get { } //Length: 11
		 set { } //Length: 24
	}

	public string get_m_pchFileName() { }

	public string get_m_rgchDescription() { }

	public string get_m_rgchTags() { }

	public string get_m_rgchTitle() { }

	public string get_m_rgchURL() { }

	public void set_m_pchFileName(string value) { }

	public void set_m_rgchDescription(string value) { }

	public void set_m_rgchTags(string value) { }

	public void set_m_rgchTitle(string value) { }

	public void set_m_rgchURL(string value) { }

}

