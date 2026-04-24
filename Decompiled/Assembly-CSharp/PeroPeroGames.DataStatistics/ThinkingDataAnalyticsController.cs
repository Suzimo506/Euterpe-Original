using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace PeroPeroGames.DataStatistics;

[Token(Token = "0x20004ED")]
public class ThinkingDataAnalyticsController : DataStatisticsManager
{
	[Token(Token = "0x4001AAB")]
	private const string app_id = "374bfde32ff3436890ff977bc94f8015";

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001AAC")]
	private ThinkingDataSteamPurchase m_SteamPurchase;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001AAD")]
	private ThinkingDataTapTapPurchase m_TapTapPurchase;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001AAE")]
	private ThinkingDataIOSPurchase m_IOSPurchase;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001AAF")]
	private ThinkingDataGooglePurchase m_GooglePurchase;

	[Token(Token = "0x4001AB0")]
	[FieldOffset(Offset = "0x38")]
	public ThinkingDataBattleHelper battleHelper;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001AB1")]
	public ThinkingDataPeripheralHelper peripheralHelper;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001AB2")]
	private bool isPushDevice;

	[Token(Token = "0x4001AB3")]
	[FieldOffset(Offset = "0x50")]
	private WaitForSeconds m_WaitForTime;

	[Token(Token = "0x600367D")]
	[Address(RVA = "0x8763E0", Offset = "0x874BE0", Length = "0x1F5")]
	public ThinkingDataAnalyticsController()
	{
	}

	[Token(Token = "0x600367E")]
	[Address(RVA = "0x874BE0", Offset = "0x8733E0", Length = "0x178")]
	public override void Init()
	{
	}

	[Token(Token = "0x600367F")]
	[Address(RVA = "0x873E00", Offset = "0x872600", Length = "0x523")]
	private void CommonEvent()
	{
	}

	[Address(RVA = "0x875F80", Offset = "0x874780", Length = "0x1E")]
	[Token(Token = "0x6003680")]
	public void SteamPurchseInfo(Dictionary<string, object> infos)
	{
	}

	[Address(RVA = "0x875FA0", Offset = "0x8747A0", Length = "0x1E")]
	[Token(Token = "0x6003681")]
	public void SteamSendPayment(string res)
	{
	}

	[Token(Token = "0x6003682")]
	[Address(RVA = "0x873B80", Offset = "0x872380", Length = "0xA1")]
	private void AddDictionary(Dictionary<string, object> dictionary, string key, object value)
	{
	}

	[Token(Token = "0x6003683")]
	[Address(RVA = "0x875D80", Offset = "0x874580", Length = "0x1FA")]
	private void StartThinkingDataSDK()
	{
	}

	[Address(RVA = "0x874890", Offset = "0x873090", Length = "0x341")]
	[Token(Token = "0x6003684")]
	private void InitThinkingDataEvent()
	{
	}

	[Token(Token = "0x6003685")]
	[Address(RVA = "0x874720", Offset = "0x872F20", Length = "0x111")]
	private void GetNtpServerTime()
	{
	}

	[Token(Token = "0x6003686")]
	[Address(RVA = "0x874550", Offset = "0x872D50", Length = "0x176")]
	private void GetDeviceAtivateEvent()
	{
	}

	[Address(RVA = "0x875270", Offset = "0x873A70", Length = "0x41")]
	[Token(Token = "0x6003687")]
	private void SaveDataInLocal(bool islocal)
	{
	}

	[Token(Token = "0x6003688")]
	[Address(RVA = "0x875120", Offset = "0x873920", Length = "0x57")]
	private void RecordAppOnlineTime()
	{
	}

	[Token(Token = "0x6003689")]
	[Address(RVA = "0x876110", Offset = "0x874910", Length = "0x174")]
	private void UploadDriverOffset(int offset)
	{
	}

	[Token(Token = "0x600368A")]
	[Address(RVA = "0x875FC0", Offset = "0x8747C0", Length = "0x147")]
	private void SwitchPlatform()
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x64420", Offset = "0x63820")]
	[Token(Token = "0x600368B")]
	[Address(RVA = "0x875180", Offset = "0x873980", Length = "0x65")]
	private IEnumerator RefreshUserProperty()
	{
		return null;
	}

	[Token(Token = "0x600368C")]
	[Address(RVA = "0x873D50", Offset = "0x872550", Length = "0xA0")]
	private void CheckPlatformFirstPurchase()
	{
	}

	[Token(Token = "0x600368D")]
	[Address(RVA = "0x873C50", Offset = "0x872450", Length = "0xF9")]
	public void CheckIOSPurchase()
	{
	}

	[Address(RVA = "0x873C30", Offset = "0x872430", Length = "0x15")]
	[Token(Token = "0x600368E")]
	public void CheckGooglePurchase()
	{
	}

	[Address(RVA = "0x8759F0", Offset = "0x8741F0", Length = "0x38F")]
	[Token(Token = "0x600368F")]
	private void SetUserProperty()
	{
	}

	[Token(Token = "0x6003690")]
	[Address(RVA = "0x8746D0", Offset = "0x872ED0", Length = "0x50")]
	private string GetInternetType()
	{
		return null;
	}

	[Address(RVA = "0x8751F0", Offset = "0x8739F0", Length = "0x71")]
	[Token(Token = "0x6003691")]
	private void SaveCommonProperties()
	{
	}

	[Address(RVA = "0x874330", Offset = "0x872B30", Length = "0x1AC")]
	[Token(Token = "0x6003692")]
	private void CommonPropertySet()
	{
	}

	[Address(RVA = "0x873830", Offset = "0x872030", Length = "0x1A4")]
	[Token(Token = "0x6003693")]
	private void AccountLogin(string peroUid)
	{
	}

	[Address(RVA = "0x876290", Offset = "0x874A90", Length = "0x65")]
	[Token(Token = "0x6003694")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x64680", Offset = "0x63A80")]
	private IEnumerator UserOnline()
	{
		return null;
	}

	[Address(RVA = "0x874840", Offset = "0x873040", Length = "0x4A")]
	[Token(Token = "0x6003695")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x64A30", Offset = "0x63E30")]
	private IEnumerator Heartbeat()
	{
		return null;
	}

	[Token(Token = "0x6003696")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x64BD0", Offset = "0x63FD0")]
	[Address(RVA = "0x875380", Offset = "0x873B80", Length = "0x4A")]
	private IEnumerator SetConsecutiveLoginDays()
	{
		return null;
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x65090", Offset = "0x64490")]
	[Address(RVA = "0x875330", Offset = "0x873B30", Length = "0x4A")]
	[Token(Token = "0x6003697")]
	private IEnumerator SetAbilityPropertie()
	{
		return null;
	}

	[Address(RVA = "0x8752C0", Offset = "0x873AC0", Length = "0x65")]
	[Token(Token = "0x6003698")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x65230", Offset = "0x64630")]
	private IEnumerator SendUserLoginEvent()
	{
		return null;
	}

	[Token(Token = "0x6003699")]
	[Address(RVA = "0x8753D0", Offset = "0x873BD0", Length = "0x185")]
	private void SetSuperCommonProperties(Dictionary<string, object> trackInfo)
	{
	}

	[Address(RVA = "0x875560", Offset = "0x873D60", Length = "0x48D")]
	[Token(Token = "0x600369A")]
	private void SetUserProperties()
	{
	}

	[Address(RVA = "0x8739E0", Offset = "0x8721E0", Length = "0x19E")]
	[Token(Token = "0x600369B")]
	private void AccountLogout()
	{
	}

	[Token(Token = "0x600369C")]
	[Address(RVA = "0x8750A0", Offset = "0x8738A0", Length = "0x73")]
	protected override void OnLogin(string peroUid)
	{
	}

	[Token(Token = "0x600369D")]
	[Address(RVA = "0x874D60", Offset = "0x873560", Length = "0xD4")]
	private string IsOldJustAsPlanned()
	{
		return null;
	}

	[Token(Token = "0x600369E")]
	[Address(RVA = "0x874E40", Offset = "0x873640", Length = "0x256")]
	protected override void OnLoginFinished()
	{
	}

	[Address(RVA = "0x876300", Offset = "0x874B00", Length = "0xD3")]
	[Token(Token = "0x600369F")]
	private void UserRegisterTime()
	{
	}

	[Token(Token = "0x60036A0")]
	[Address(RVA = "0x8744E0", Offset = "0x872CE0", Length = "0x65")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x65730", Offset = "0x64B30")]
	private IEnumerator Enumerator()
	{
		return null;
	}

	[Token(Token = "0x60036A1")]
	[Address(RVA = "0x8739E0", Offset = "0x8721E0", Length = "0x19E")]
	protected override void OnLogout()
	{
	}
}
