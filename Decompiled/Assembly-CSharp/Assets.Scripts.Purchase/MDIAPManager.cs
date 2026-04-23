using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using MEC;
using Newtonsoft.Json.Linq;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006D6")]
public class MDIAPManager : IAPManager
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400247D")]
	private readonly List<string> m_PurchasedAlbumIds;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400247E")]
	public List<ProductInfo> serverProductInfos;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400247F")]
	private string productIdSelected;

	[Token(Token = "0x4002480")]
	private static bool s_IsDevicePurchaseCheat;

	[Token(Token = "0x4002481")]
	private static bool s_IsThirdPartyPurchaseCheat;

	[Token(Token = "0x4002482")]
	private static bool s_IsAccountPurchaseCheat;

	[Token(Token = "0x4002483")]
	[FieldOffset(Offset = "0xA8")]
	private bool m_IsForceShowTips;

	[Token(Token = "0x4002484")]
	[FieldOffset(Offset = "0xB0")]
	private Action checkOutPassCallback;

	[Token(Token = "0x4002485")]
	[FieldOffset(Offset = "0xB8")]
	private Action checkOutBanCallback;

	[Token(Token = "0x4002486")]
	[FieldOffset(Offset = "0xC0")]
	private CoroutineHandle m_StoreVersionRequestCoroutine;

	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4002487")]
	private Action m_SucccessCallback;

	[Token(Token = "0x4002488")]
	[FieldOffset(Offset = "0xD0")]
	private Action m_CheckPuchaseFailCallback;

	[Token(Token = "0x4002489")]
	public const float timeout_duration = 10f;

	[Token(Token = "0x6003F9E")]
	[Address(RVA = "0xFDDC00", Offset = "0xFDC400", Length = "0x101")]
	public MDIAPManager()
	{
	}

	[Token(Token = "0x6003F9F")]
	[Address(RVA = "0xFDB510", Offset = "0xFD9D10", Length = "0x319")]
	public override void InitIAP(string[] productIds)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6003FA0")]
	private void AddCommand()
	{
	}

	[Token(Token = "0x6003FA1")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void BuyForce(string productId)
	{
	}

	[Address(RVA = "0xFDC7F0", Offset = "0xFDAFF0", Length = "0xD6")]
	[Token(Token = "0x6003FA2")]
	public override void Purchase(string productId)
	{
	}

	[Address(RVA = "0xFD9CF0", Offset = "0xFD84F0", Length = "0x753")]
	[Token(Token = "0x6003FA3")]
	public override void ClearPurchase()
	{
	}

	[Address(RVA = "0xFDA980", Offset = "0xFD9180", Length = "0x5F")]
	[Token(Token = "0x6003FA4")]
	public void GetLocalPurchasedList(List<string> buffer)
	{
	}

	[Token(Token = "0x6003FA5")]
	[Address(RVA = "0xFDD9A0", Offset = "0xFDC1A0", Length = "0x252")]
	public bool UnlockByTerminal(string musicPackageId)
	{
		return default(bool);
	}

	[Address(RVA = "0xFDB0F0", Offset = "0xFD98F0", Length = "0x399")]
	[Token(Token = "0x6003FA6")]
	private void InitEvents()
	{
	}

	[Address(RVA = "0xFDC380", Offset = "0xFDAB80", Length = "0x1A0")]
	[Token(Token = "0x6003FA7")]
	private void Private_RefreshLocalPurchasedList()
	{
	}

	[Address(RVA = "0xFDC8D0", Offset = "0xFDB0D0", Length = "0x295")]
	[Token(Token = "0x6003FA8")]
	private void RefreshProductByPeroServer()
	{
	}

	[Token(Token = "0x6003FA9")]
	[Address(RVA = "0xFDBC50", Offset = "0xFDA450", Length = "0x111")]
	private void OnInitCompleted(bool succeed)
	{
	}

	[Address(RVA = "0xFDB490", Offset = "0xFD9C90", Length = "0x71")]
	[Token(Token = "0x6003FAA")]
	private void InitFailed()
	{
	}

	[Address(RVA = "0xFDBD70", Offset = "0xFDA570", Length = "0x4E")]
	[Token(Token = "0x6003FAB")]
	private void OnReceiptCompleted(string[] ps)
	{
	}

	[Address(RVA = "0xFDBDC0", Offset = "0xFDA5C0", Length = "0x23A")]
	[Token(Token = "0x6003FAC")]
	private void OnReceiptProductsCallBack(ProductInfo[] infos)
	{
	}

	[Token(Token = "0x6003FAD")]
	[Address(RVA = "0xFDC000", Offset = "0xFDA800", Length = "0x173")]
	private void OnTransactionComplete(TransactionResult result)
	{
	}

	[Token(Token = "0x6003FAE")]
	[Address(RVA = "0xFD9480", Offset = "0xFD7C80", Length = "0x536")]
	private void AfterRestoreCompleted(bool isOK, TransactionResult transResult)
	{
	}

	[Token(Token = "0x6003FAF")]
	[Address(RVA = "0xFDB0E0", Offset = "0xFD98E0", Length = "0xE")]
	public void GetServerProductInfos(Product[] products, Action<List<ProductInfo>> callback, Action failCallback = null)
	{
	}

	[Token(Token = "0x6003FB0")]
	[Address(RVA = "0xFDCB70", Offset = "0xFDB370", Length = "0x260")]
	private void RequestProductInfosFromPeroServer(Product[] products, Action<List<ProductInfo>> callback, Action failCallback = null)
	{
	}

	[Address(RVA = "0xFDCDE0", Offset = "0xFDB5E0", Length = "0xBB")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4FA60", Offset = "0x4EE60")]
	[Token(Token = "0x6003FB1")]
	private IEnumerator<float> RequestServerProductsSuccess(Product[] products, JObject jobj, Action<List<ProductInfo>> callback)
	{
		return null;
	}

	[Token(Token = "0x6003FB2")]
	[Address(RVA = "0xFDA9E0", Offset = "0xFD91E0", Length = "0x6FF")]
	private List<ProductInfo> GetProductDataFromPeroServer(JObject jobj)
	{
		return null;
	}

	[Address(RVA = "0xFDB890", Offset = "0xFDA090", Length = "0x3BF")]
	[Token(Token = "0x6003FB3")]
	private void ModifyServerProductByPlatformProduct(Product[] platformProducts, List<ProductInfo> repleaceProductInfos)
	{
	}

	[Token(Token = "0x6003FB4")]
	[Address(RVA = "0xFDD610", Offset = "0xFDBE10", Length = "0xBA")]
	public override bool TryGetProduct(string productId, out Product product)
	{
		product = null;
		return default(bool);
	}

	[Address(RVA = "0xFDD6D0", Offset = "0xFDBED0", Length = "0x232")]
	[Token(Token = "0x6003FB5")]
	private bool TryGetProductsByProductId(string productId, out string[] productIds)
	{
		productIds = null;
		return default(bool);
	}

	[Token(Token = "0x6003FB6")]
	[Address(RVA = "0xFDC180", Offset = "0xFDA980", Length = "0x1FD")]
	private void OverwriteClientDiscount()
	{
	}

	[Token(Token = "0x6003FB7")]
	[Address(RVA = "0xFDD4D0", Offset = "0xFDBCD0", Length = "0x136")]
	public bool TryGetProductInfoByProductId(string productId, out ProductInfo productInfo)
	{
		System.Runtime.CompilerServices.Unsafe.As<ProductInfo, @null>(ref productInfo) = null;
		return default(bool);
	}

	[Token(Token = "0x6003FB8")]
	[Address(RVA = "0xFDB830", Offset = "0xFDA030", Length = "0x52")]
	public int IsUnlockall()
	{
		return default(int);
	}

	[Address(RVA = "0xFDA450", Offset = "0xFD8C50", Length = "0x11C")]
	[Token(Token = "0x6003FB9")]
	private bool CodeCheck(int code)
	{
		return default(bool);
	}

	[Address(RVA = "0xFDA570", Offset = "0xFD8D70", Length = "0x76")]
	[Token(Token = "0x6003FBA")]
	[Obsolete]
	private string DLCGetRealProductId(string id)
	{
		return null;
	}

	[Token(Token = "0x6003FBB")]
	[Address(RVA = "0xFDA8F0", Offset = "0xFD90F0", Length = "0x32")]
	public string GetDiscountProductId(string productId)
	{
		return null;
	}

	[Address(RVA = "0xFDA870", Offset = "0xFD9070", Length = "0x77")]
	[Token(Token = "0x6003FBC")]
	public DiscountInfo GetDiscountInfo(string productId)
	{
		return default(DiscountInfo);
	}

	[Address(RVA = "0xFDD030", Offset = "0xFDB830", Length = "0xCA")]
	[Token(Token = "0x6003FBD")]
	private void RequestTime()
	{
	}

	[Token(Token = "0x6003FBE")]
	[Address(RVA = "0xFDCF90", Offset = "0xFDB790", Length = "0x99")]
	private void RequestTimeSuccessCallback(DateTime _)
	{
	}

	[Token(Token = "0x6003FBF")]
	[Address(RVA = "0xFDCEA0", Offset = "0xFDB6A0", Length = "0xE8")]
	private void RequestTimeFailCallback(long err, string msg)
	{
	}

	[Address(RVA = "0xFD99C0", Offset = "0xFD81C0", Length = "0x133")]
	[Token(Token = "0x6003FC0")]
	public void CheckPuchaseState(Action successCallback = null, Action failCallback = null, bool controllOverlay = true)
	{
	}

	[Address(RVA = "0xFDA5F0", Offset = "0xFD8DF0", Length = "0x76")]
	[Token(Token = "0x6003FC1")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4FD40", Offset = "0x4F140")]
	private IEnumerator<float> E_GetProductInfoFromPeroServer(bool controllOverlay = true)
	{
		return null;
	}

	[Address(RVA = "0xFDA670", Offset = "0xFD8E70", Length = "0x1FF")]
	[Token(Token = "0x6003FC2")]
	private void ExcuteWithServerResult(JObject result)
	{
	}

	[Address(RVA = "0xFDD290", Offset = "0xFDBA90", Length = "0x15D")]
	[Token(Token = "0x6003FC3")]
	private void ShowStoreUpdateConfirm()
	{
	}

	[Address(RVA = "0xFD9B00", Offset = "0xFD8300", Length = "0x1EC")]
	[Token(Token = "0x6003FC4")]
	public void CheckPurchasePermission(bool forceShowTips = false, Action passCallback = null, Action banCallback = null)
	{
	}

	[Address(RVA = "0xFDC5D0", Offset = "0xFDADD0", Length = "0x21E")]
	[Token(Token = "0x6003FC5")]
	private void PurchasePermissionCallback()
	{
	}

	[Address(RVA = "0xFDA930", Offset = "0xFD9130", Length = "0x48")]
	[Token(Token = "0x6003FC6")]
	public bool GetIsPurchaseBan()
	{
		return default(bool);
	}

	[Address(RVA = "0xFDC530", Offset = "0xFDAD30", Length = "0x91")]
	[Token(Token = "0x6003FC7")]
	public void PurchaseMusic(string testProduct)
	{
	}

	[Address(RVA = "0xFDD3F0", Offset = "0xFDBBF0", Length = "0xD2")]
	[Token(Token = "0x6003FC8")]
	public void TestAllProduct(string productId)
	{
	}

	[Address(RVA = "0xFDD100", Offset = "0xFDB900", Length = "0x18C")]
	[Token(Token = "0x6003FC9")]
	public string SerializePurchaseHistory()
	{
		return null;
	}
}
