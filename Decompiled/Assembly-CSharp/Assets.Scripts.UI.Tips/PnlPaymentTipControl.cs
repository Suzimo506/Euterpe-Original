using System.Runtime.CompilerServices;
using Account.Modules;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.Tips;

[Token(Token = "0x2000886")]
public class PnlPaymentTipControl : BaseMessageBox
{
	[Token(Token = "0x17000872")]
	public float PayValue
	{
		[Token(Token = "0x6004DA0")]
		[Address(RVA = "0x5FDF20", Offset = "0x5FC720", Length = "0x9")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		[Token(Token = "0x6004DA1")]
		[Address(RVA = "0x5FDF30", Offset = "0x5FC730", Length = "0x9")]
		set
		{
		}
	}

	[Token(Token = "0x6004DA2")]
	[Address(RVA = "0x5FDDC0", Offset = "0x5FC5C0", Length = "0x153")]
	public void SetContent(MinorPaymentLimit.PaymentTipType tipType)
	{
	}

	[Address(RVA = "0x5FD840", Offset = "0x5FC040", Length = "0x258")]
	[Token(Token = "0x6004DA3")]
	private string GetLimitContentByAgeRange()
	{
		return null;
	}

	[Token(Token = "0x6004DA4")]
	[Address(RVA = "0x5FDAA0", Offset = "0x5FC2A0", Length = "0x31E")]
	private string GetPayPromptContentByAgeRange()
	{
		return null;
	}

	[Token(Token = "0x6004DA5")]
	[Address(RVA = "0x5F96A0", Offset = "0x5F7EA0", Length = "0x51")]
	public PnlPaymentTipControl()
	{
	}
}
