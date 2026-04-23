using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace PeroPeroGames.DataStatistics;

[Token(Token = "0x20004EE")]
public class ThinkingDataAnalyticsManager : DataStatisticsManager
{
	[Token(Token = "0x4001AB4")]
	private const string app_id = "374bfde32ff3436890ff977bc94f8015";

	[Token(Token = "0x60036A2")]
	[Address(RVA = "0x878210", Offset = "0x876A10", Length = "0x4C")]
	public ThinkingDataAnalyticsManager()
	{
	}

	[Address(RVA = "0x877530", Offset = "0x875D30", Length = "0x2B")]
	[Token(Token = "0x60036A3")]
	public override void Init()
	{
	}

	[Token(Token = "0x60036A4")]
	[Address(RVA = "0x878140", Offset = "0x876940", Length = "0x5C")]
	public override void UserCreateEvent()
	{
	}

	[Token(Token = "0x60036A5")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void UserCancelEvent()
	{
	}

	[Token(Token = "0x60036A6")]
	[Address(RVA = "0x876D60", Offset = "0x875560", Length = "0x4C6")]
	private void InitSDK()
	{
	}

	[Token(Token = "0x60036A7")]
	[Address(RVA = "0x877230", Offset = "0x875A30", Length = "0x2F6")]
	private void InitSteam()
	{
	}

	[Address(RVA = "0x876BB0", Offset = "0x8753B0", Length = "0x1A5")]
	[Token(Token = "0x60036A8")]
	private void GetPaymentInfo(string productId, Dictionary<string, object> trackInfo)
	{
	}

	[Address(RVA = "0x8765E0", Offset = "0x874DE0", Length = "0x116")]
	[Token(Token = "0x60036A9")]
	private void AccountLogin()
	{
	}

	[Address(RVA = "0x876700", Offset = "0x874F00", Length = "0x1BE")]
	[Token(Token = "0x60036AA")]
	private void AccountLogout()
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x6C640", Offset = "0x6BA40")]
	[Token(Token = "0x60036AB")]
	[Address(RVA = "0x8781A0", Offset = "0x8769A0", Length = "0x65")]
	private IEnumerator UserOnline()
	{
		return null;
	}

	[Address(RVA = "0x877A60", Offset = "0x876260", Length = "0x14A")]
	[Token(Token = "0x60036AC")]
	private void SendHeartbeat()
	{
	}

	[Address(RVA = "0x877BB0", Offset = "0x8763B0", Length = "0x4A")]
	[Token(Token = "0x60036AD")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x6C840", Offset = "0x6BC40")]
	private IEnumerator SendUserLoginEvent()
	{
		return null;
	}

	[Address(RVA = "0x8779F0", Offset = "0x8761F0", Length = "0x65")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x6CA70", Offset = "0x6BE70")]
	[Token(Token = "0x60036AE")]
	private IEnumerator RefreshUserProperty()
	{
		return null;
	}

	[Token(Token = "0x60036AF")]
	[Address(RVA = "0x877E30", Offset = "0x876630", Length = "0x18C")]
	private void SwitchPlatform()
	{
	}

	[Token(Token = "0x60036B0")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void CheckFistOrder()
	{
	}

	[Address(RVA = "0x877710", Offset = "0x875F10", Length = "0x2DC")]
	[Token(Token = "0x60036B1")]
	private void RefreshLoginInfo()
	{
	}

	[Token(Token = "0x60036B2")]
	[Address(RVA = "0x877FC0", Offset = "0x8767C0", Length = "0x174")]
	private void UploadDriverOffset(int offset)
	{
	}

	[Token(Token = "0x60036B3")]
	[Address(RVA = "0x8768C0", Offset = "0x8750C0", Length = "0x220")]
	private void CommonPropertySet()
	{
	}

	[Token(Token = "0x60036B4")]
	[Address(RVA = "0x8776B0", Offset = "0x875EB0", Length = "0x57")]
	private void RecordAppOnlineTime()
	{
	}

	[Address(RVA = "0x876B60", Offset = "0x875360", Length = "0x50")]
	[Token(Token = "0x60036B5")]
	private string GetInternetType()
	{
		return null;
	}

	[Address(RVA = "0x877C50", Offset = "0x876450", Length = "0x4A")]
	[Token(Token = "0x60036B6")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x6E240", Offset = "0x6D640")]
	private IEnumerator SetConsecutiveLoginDays()
	{
		return null;
	}

	[Token(Token = "0x60036B7")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x6E440", Offset = "0x6D840")]
	[Address(RVA = "0x877C00", Offset = "0x876400", Length = "0x4A")]
	private IEnumerator SetAbilityPropertie()
	{
		return null;
	}

	[Token(Token = "0x60036B8")]
	[Address(RVA = "0x877CA0", Offset = "0x8764A0", Length = "0x189")]
	private void SetUserProperties()
	{
	}

	[Token(Token = "0x60036B9")]
	[Address(RVA = "0x8765E0", Offset = "0x874DE0", Length = "0x116")]
	protected override void OnLogin(string peroUid)
	{
	}

	[Token(Token = "0x60036BA")]
	[Address(RVA = "0x877560", Offset = "0x875D60", Length = "0xED")]
	protected override void OnLoginFinished()
	{
	}

	[Token(Token = "0x60036BB")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x6E680", Offset = "0x6DA80")]
	[Address(RVA = "0x876AF0", Offset = "0x8752F0", Length = "0x65")]
	private IEnumerator Enumerator()
	{
		return null;
	}

	[Token(Token = "0x60036BC")]
	[Address(RVA = "0x877650", Offset = "0x875E50", Length = "0x5F")]
	protected override void OnLogout()
	{
	}
}
