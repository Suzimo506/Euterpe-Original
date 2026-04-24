namespace Steamworks;

public struct SteamUGCDetails_t
{
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x8
	public EWorkshopFileType m_eFileType; //Field offset: 0xC
	public AppId_t m_nCreatorAppID; //Field offset: 0x10
	public AppId_t m_nConsumerAppID; //Field offset: 0x14
	private Byte[] m_rgchTitle_; //Field offset: 0x18
	private Byte[] m_rgchDescription_; //Field offset: 0x20
	public ulong m_ulSteamIDOwner; //Field offset: 0x28
	public uint m_rtimeCreated; //Field offset: 0x30
	public uint m_rtimeUpdated; //Field offset: 0x34
	public uint m_rtimeAddedToUserList; //Field offset: 0x38
	public ERemoteStoragePublishedFileVisibility m_eVisibility; //Field offset: 0x3C
	public bool m_bBanned; //Field offset: 0x40
	public bool m_bAcceptedForUse; //Field offset: 0x41
	public bool m_bTagsTruncated; //Field offset: 0x42
	private Byte[] m_rgchTags_; //Field offset: 0x48
	public UGCHandle_t m_hFile; //Field offset: 0x50
	public UGCHandle_t m_hPreviewFile; //Field offset: 0x58
	private Byte[] m_pchFileName_; //Field offset: 0x60
	public int m_nFileSize; //Field offset: 0x68
	public int m_nPreviewFileSize; //Field offset: 0x6C
	private Byte[] m_rgchURL_; //Field offset: 0x70
	public uint m_unVotesUp; //Field offset: 0x78
	public uint m_unVotesDown; //Field offset: 0x7C
	public float m_flScore; //Field offset: 0x80
	public uint m_unNumChildren; //Field offset: 0x84

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

