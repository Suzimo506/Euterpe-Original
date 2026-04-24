using Assets.Scripts.PeroTools.PreWarm;
using Assets.Scripts.Purchase;
using Assets.Scripts.UI.Tips;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.UI;

[Token(Token = "0x20005AC")]
public class BtnIAP : MonoBehaviour, IPreWarm
{
	[Token(Token = "0x4002109")]
	private static string s_defaultUnlcokAllUid;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400210A")]
	private IAPType m_IapType;

	[Token(Token = "0x400210B")]
	[FieldOffset(Offset = "0x20")]
	private string m_ProductId;

	[Token(Token = "0x400210C")]
	private static bool s_Inited;

	[Token(Token = "0x400210D")]
	private static AbstractMessageBox s_PurchasedSuccessMessageBox;

	[Token(Token = "0x17000538")]
	public static string default_unlock_all
	{
		[Token(Token = "0x600391B")]
		[Address(RVA = "0x974E60", Offset = "0x973660", Length = "0xA9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000539")]
	public string productId
	{
		[Token(Token = "0x600391D")]
		[Address(RVA = "0x974F60", Offset = "0x973760", Length = "0x66")]
		get
		{
			return null;
		}
		[Address(RVA = "0x483E40", Offset = "0x482640", Length = "0xC")]
		[Token(Token = "0x600391C")]
		set
		{
		}
	}

	[Token(Token = "0x1700053A")]
	private bool is_unlock_all_package
	{
		[Address(RVA = "0x974F10", Offset = "0x973710", Length = "0x46")]
		[Token(Token = "0x600391F")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x44A0F0", Offset = "0x4488F0", Length = "0x4")]
	[Token(Token = "0x600391E")]
	internal void SetIAPType(IAPType type)
	{
	}

	[Address(RVA = "0x974DF0", Offset = "0x9735F0", Length = "0x61")]
	[Token(Token = "0x6003920")]
	private static void OnRestoreCompleted(bool isOk, TransactionResult result)
	{
	}

	[Token(Token = "0x6003921")]
	[Address(RVA = "0x974900", Offset = "0x973100", Length = "0xC")]
	public void InvokeBuy()
	{
	}

	[Address(RVA = "0x974910", Offset = "0x973110", Length = "0x2B7")]
	[Token(Token = "0x6003922")]
	private void InvokeBuy(string selectProductId)
	{
	}

	[Token(Token = "0x6003923")]
	[Address(RVA = "0x974C70", Offset = "0x973470", Length = "0x178")]
	private void NS_Purchase(string productId)
	{
	}

	[Token(Token = "0x6003924")]
	[Address(RVA = "0x974BD0", Offset = "0x9733D0", Length = "0x93")]
	private bool IsFreePackage(string productId)
	{
		return default(bool);
	}

	[Token(Token = "0x6003925")]
	[Address(RVA = "0x9738C0", Offset = "0x9720C0", Length = "0x3A8")]
	private void FreePackageLogic(string productId)
	{
	}

	[Token(Token = "0x6003926")]
	[Address(RVA = "0x973CF0", Offset = "0x9724F0", Length = "0xC08")]
	public static string GetJustAsPlannedUnlockId()
	{
		return null;
	}

	[Token(Token = "0x6003927")]
	[Address(RVA = "0x973C70", Offset = "0x972470", Length = "0x75")]
	private string GetFreeSucceeded()
	{
		return null;
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6003928")]
	public void PreWarm(int slice)
	{
	}

	[Token(Token = "0x6003929")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public BtnIAP()
	{
	}
}
