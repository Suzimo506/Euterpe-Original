using System.Collections.Generic;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;

namespace Assets.Scripts.UI.PnlMusicStage.MusicPromotion;

[Token(Token = "0x2000861")]
public class MusicPromotionDataManager
{
	[Token(Token = "0x4002BBF")]
	private const float req_timeout_amount = 1f;

	[Token(Token = "0x4002BC0")]
	private const string req_promotion_data_url = "musedash/v1/billboards/active_list";

	[Token(Token = "0x4002BC1")]
	private static MusicPromotionRequestState s_RequestState;

	[Token(Token = "0x4002BC2")]
	private static List<PromotionIndexData> s_PromotionDatas;

	[Token(Token = "0x17000865")]
	public static MusicPromotionRequestState RequestState
	{
		[Token(Token = "0x6004CAA")]
		[Address(RVA = "0x4C15D0", Offset = "0x4BFDD0", Length = "0x55")]
		get
		{
			return default(MusicPromotionRequestState);
		}
	}

	[Token(Token = "0x6004CAB")]
	[Address(RVA = "0x4C0C50", Offset = "0x4BF450", Length = "0x12A")]
	public static void RequestPromotionInfo()
	{
	}

	[Token(Token = "0x6004CAC")]
	[Address(RVA = "0x4C0770", Offset = "0x4BEF70", Length = "0x245")]
	public static PromotionIndexData GetPromotionDataByMusicUid(string musicUid)
	{
		return null;
	}

	[Token(Token = "0x6004CAD")]
	[Address(RVA = "0x4C09C0", Offset = "0x4BF1C0", Length = "0x280")]
	private static bool HandleResponseData(JObject resData)
	{
		return default(bool);
	}

	[Address(RVA = "0x4C0D80", Offset = "0x4BF580", Length = "0x7F0")]
	[Token(Token = "0x6004CAE")]
	private static PromotionIndexData SetPromotionData(JToken dataObj)
	{
		return null;
	}

	[Token(Token = "0x6004CAF")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public MusicPromotionDataManager()
	{
	}
}
