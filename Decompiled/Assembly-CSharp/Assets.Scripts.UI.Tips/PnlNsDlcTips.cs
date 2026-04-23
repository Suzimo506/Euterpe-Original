using Assets.Scripts.Database;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.Tips;

[Token(Token = "0x2000882")]
public class PnlNsDlcTips : BaseMessageBox
{
	[Token(Token = "0x4002C6E")]
	[FieldOffset(Offset = "0xF0")]
	private UISelectManage m_UISelectManage;

	[Token(Token = "0x6004D8B")]
	[Address(RVA = "0x5FCCD0", Offset = "0x5FB4D0", Length = "0x4A")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004D8C")]
	[Address(RVA = "0x5FCD90", Offset = "0x5FB590", Length = "0x99")]
	public void ShowWithProductName(DBConfigAlbums.AlbumsInfo albumName)
	{
	}

	[Token(Token = "0x6004D8D")]
	[Address(RVA = "0x5FCD20", Offset = "0x5FB520", Length = "0x67")]
	protected override void OnYesClicked()
	{
	}

	[Address(RVA = "0x5F96A0", Offset = "0x5F7EA0", Length = "0x51")]
	[Token(Token = "0x6004D8E")]
	public PnlNsDlcTips()
	{
	}
}
