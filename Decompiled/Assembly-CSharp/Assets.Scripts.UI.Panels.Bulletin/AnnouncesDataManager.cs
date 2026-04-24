using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;

namespace Assets.Scripts.UI.Panels.Bulletin;

[Token(Token = "0x200094E")]
public class AnnouncesDataManager
{
	[Token(Token = "0x2000DBD")]
	private struct AnnouncePopSetting
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40040A6")]
		public bool isPop;

		[Token(Token = "0x40040A7")]
		[FieldOffset(Offset = "0x8")]
		public long stateChangeTime;

		[Token(Token = "0x6006595")]
		[Address(RVA = "0x6BEE20", Offset = "0x6BD620", Length = "0xA")]
		public static AnnouncePopSetting Default()
		{
			return default(AnnouncePopSetting);
		}
	}

	[Token(Token = "0x40032B3")]
	private static AnnouncesDataManager s_Instance;

	[Token(Token = "0x40032B6")]
	private const string local_announce_pop_state_time = "announce_pop_state_change_time";

	[Token(Token = "0x40032B8")]
	[FieldOffset(Offset = "0x40")]
	private AnnoucneStateContents m_AnnoucneStateContents;

	[Token(Token = "0x40032B9")]
	[FieldOffset(Offset = "0x60")]
	private List<string> m_LocalAnnounceUidList;

	[Token(Token = "0x40032BA")]
	[FieldOffset(Offset = "0x68")]
	private List<string> m_NetAnnounceUidList;

	[Token(Token = "0x170008DA")]
	public static AnnouncesDataManager Instance
	{
		[Address(RVA = "0x6C04B0", Offset = "0x6BECB0", Length = "0x129")]
		[Token(Token = "0x6005473")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008DB")]
	public AnnounceRequestResult RequestProgressInfo
	{
		[CompilerGenerated]
		[Token(Token = "0x6005474")]
		[Address(RVA = "0x6C05F0", Offset = "0x6BEDF0", Length = "0x15")]
		get
		{
			return default(AnnounceRequestResult);
		}
		[Token(Token = "0x6005475")]
		[CompilerGenerated]
		[Address(RVA = "0x6C06B0", Offset = "0x6BEEB0", Length = "0x1C")]
		private set
		{
		}
	}

	[Token(Token = "0x170008DC")]
	public Dictionary<string, List<PnlStageBulletinDataModel>> BulletInDataModels
	{
		[CompilerGenerated]
		[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
		[Token(Token = "0x6005476")]
		get
		{
			return null;
		}
		[Address(RVA = "0x48F110", Offset = "0x48D910", Length = "0xC")]
		[Token(Token = "0x6005477")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170008DD")]
	public AnnoucneStateContents AnnounceStatusContent
	{
		[Address(RVA = "0x6C0490", Offset = "0x6BEC90", Length = "0x13")]
		[Token(Token = "0x6005478")]
		get
		{
			return default(AnnoucneStateContents);
		}
	}

	[Token(Token = "0x170008DE")]
	private AnnouncePopSetting PopSets
	{
		[Token(Token = "0x6005479")]
		[CompilerGenerated]
		[Address(RVA = "0x6C05E0", Offset = "0x6BEDE0", Length = "0xB")]
		get
		{
			return default(AnnouncePopSetting);
		}
		[Address(RVA = "0x6C06A0", Offset = "0x6BEEA0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600547A")]
		set
		{
		}
	}

	[Token(Token = "0x170008DF")]
	private long AnnounceChangeTime
	{
		[Token(Token = "0x600547B")]
		[Address(RVA = "0x6C0410", Offset = "0x6BEC10", Length = "0x7C")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600547C")]
		[Address(RVA = "0x6C0610", Offset = "0x6BEE10", Length = "0x80")]
		set
		{
		}
	}

	[Token(Token = "0x600547D")]
	[Address(RVA = "0x6C0340", Offset = "0x6BEB40", Length = "0xCB")]
	private AnnouncesDataManager()
	{
	}

	[Token(Token = "0x600547E")]
	[Address(RVA = "0x6BF780", Offset = "0x6BDF80", Length = "0x1D9")]
	public void RequestAnnounceData(Action<Dictionary<string, List<PnlStageBulletinDataModel>>> successCallback = null, Action<long, string> failCallBack = null)
	{
	}

	[Address(RVA = "0x6BF960", Offset = "0x6BE160", Length = "0x11D")]
	[Token(Token = "0x600547F")]
	public void RequestAnnounceStatusBarContents()
	{
	}

	[Address(RVA = "0x6BEFC0", Offset = "0x6BD7C0", Length = "0x1A7")]
	[Token(Token = "0x6005480")]
	public bool GetPopState()
	{
		return default(bool);
	}

	[Address(RVA = "0x6BEE30", Offset = "0x6BD630", Length = "0x85")]
	[Token(Token = "0x6005481")]
	public bool CompareToLocalAnnounceData()
	{
		return default(bool);
	}

	[Token(Token = "0x6005482")]
	[Address(RVA = "0x6BFB60", Offset = "0x6BE360", Length = "0x71")]
	public void SetTimeoutResult()
	{
	}

	[Token(Token = "0x6005483")]
	[Address(RVA = "0x6BF570", Offset = "0x6BDD70", Length = "0x207")]
	public bool HaveNewOrUnreadAnnounce()
	{
		return default(bool);
	}

	[Address(RVA = "0x6BEEF0", Offset = "0x6BD6F0", Length = "0xC2")]
	[Token(Token = "0x6005484")]
	private List<string> GetAnnouncesLocalUidData()
	{
		return null;
	}

	[Address(RVA = "0x6BF170", Offset = "0x6BD970", Length = "0x3F8")]
	[Token(Token = "0x6005485")]
	private void HandleBulletinInfos(JToken announce, Dictionary<string, List<PnlStageBulletinDataModel>> models)
	{
	}

	[Address(RVA = "0x6BFA80", Offset = "0x6BE280", Length = "0xD6")]
	[Token(Token = "0x6005486")]
	private void SaveBulletinsUid(List<string> tempUid)
	{
	}

	[Address(RVA = "0x6BEEC0", Offset = "0x6BD6C0", Length = "0x2B")]
	[Token(Token = "0x6005487")]
	private string CurrentPlatform()
	{
		return null;
	}
}
