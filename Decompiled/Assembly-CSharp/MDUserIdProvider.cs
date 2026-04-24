using Cpp2ILInjected;
using PeroTools2.Log;

[Token(Token = "0x2000093")]
public class MDUserIdProvider : IDeviceIdProvider
{
	[Token(Token = "0x40003A2")]
	[FieldOffset(Offset = "0x10")]
	private string m_DeviceId;

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x8C1180", Offset = "0x8BF980", Length = "0xE5")]
	public MDUserIdProvider()
	{
	}

	[Address(RVA = "0x8C1110", Offset = "0x8BF910", Length = "0x6B")]
	[Token(Token = "0x600042A")]
	private void OnPlayerAgreePrivacyPolicy()
	{
	}

	[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
	[Token(Token = "0x600042B")]
	public string GetDeviceId()
	{
		return null;
	}
}
