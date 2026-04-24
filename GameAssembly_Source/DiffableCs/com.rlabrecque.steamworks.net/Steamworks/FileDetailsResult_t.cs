namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct FileDetailsResult_t
{
	public const int k_iCallback = 1023; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public ulong m_ulFileSize; //Field offset: 0x8
	public Byte[] m_FileSHA; //Field offset: 0x10
	public uint m_unFlags; //Field offset: 0x18

}

