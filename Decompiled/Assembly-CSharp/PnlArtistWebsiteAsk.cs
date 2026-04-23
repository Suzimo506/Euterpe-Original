using Cpp2ILInjected;
using TMPro;

[Token(Token = "0x20000C1")]
public class PnlArtistWebsiteAsk : BaseMessageBox
{
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40004F5")]
	public TextMeshProUGUI messageInfo;

	[Token(Token = "0x40004F6")]
	[FieldOffset(Offset = "0xF8")]
	public string[] localization;

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40004F7")]
	private int m_ClickIndex;

	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40004F8")]
	private string m_Url;

	[Token(Token = "0x17000081")]
	public int clickIndex
	{
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x4FB790", Offset = "0x4F9F90", Length = "0x7")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x4FB7A0", Offset = "0x4F9FA0", Length = "0x7")]
		[Token(Token = "0x600059F")]
		set
		{
		}
	}

	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x4FB3F0", Offset = "0x4F9BF0", Length = "0x364")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x4FB760", Offset = "0x4F9F60", Length = "0x23")]
	protected override void OnYesClicked()
	{
	}

	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	public PnlArtistWebsiteAsk()
	{
	}
}
