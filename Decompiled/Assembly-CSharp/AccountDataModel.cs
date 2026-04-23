using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;
using ZenFulcrum.EmbeddedBrowser;

[Token(Token = "0x200001D")]
public class AccountDataModel : DataModel
{
	[Token(Token = "0x17000016")]
	public long CooldownTimestamp
	{
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[Token(Token = "0x60000B1")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[CompilerGenerated]
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x58CAF0", Offset = "0x58B2F0", Length = "0x5")]
		set
		{
		}
	}

	[Address(RVA = "0x58C420", Offset = "0x58AC20", Length = "0x31")]
	[Token(Token = "0x60000B3")]
	public static void OpenFeedback()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x58C110", Offset = "0x58A910", Length = "0x68")]
	public void AppleLogin()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x58C270", Offset = "0x58AA70", Length = "0x5D")]
	public void FacebookLogin()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x58C3C0", Offset = "0x58ABC0", Length = "0x5D")]
	public void GoogleLogin()
	{
	}

	[Address(RVA = "0x58C8A0", Offset = "0x58B0A0", Length = "0x242")]
	[Token(Token = "0x60000B7")]
	public void XdLogin()
	{
	}

	[Address(RVA = "0x58C460", Offset = "0x58AC60", Length = "0x8B")]
	[Token(Token = "0x60000B8")]
	public void PeroLogin(string loginType, string accountStr, string verifyCode)
	{
	}

	[Address(RVA = "0x58C790", Offset = "0x58AF90", Length = "0x61")]
	[Token(Token = "0x60000B9")]
	public void SendPhoneCode(string phoneNumberStr, Action<JObject> callback)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x58C4F0", Offset = "0x58ACF0", Length = "0x61")]
	public void SendEmailCode(string emailStr, Action<JObject> callback)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x58C2D0", Offset = "0x58AAD0", Length = "0xED")]
	public void GoogleLoginWithWebview(Browser pcLoginWebview)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x58C180", Offset = "0x58A980", Length = "0xED")]
	public void FacebookLoginWithWebview(Browser pcLoginWebview)
	{
	}

	[Address(RVA = "0x58C800", Offset = "0x58B000", Length = "0x90")]
	[Token(Token = "0x60000BD")]
	private void StandaloneWebLogin(Browser pcWebview, string url)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x58C560", Offset = "0x58AD60", Length = "0x22B")]
	private void SendLoginVerifyCode(string verifiedStr, string sendType, Action<JObject> callback)
	{
	}

	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	[Token(Token = "0x60000BF")]
	public AccountDataModel()
	{
	}
}
