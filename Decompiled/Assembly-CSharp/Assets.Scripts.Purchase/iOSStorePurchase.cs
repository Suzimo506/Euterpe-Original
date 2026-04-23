using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;
using PeroTools2.Commons.Purchase;
using UnityEngine.Networking;

namespace Assets.Scripts.Purchase;

[Token(Token = "0x20006DD")]
internal class iOSStorePurchase : IStoreListener
{
	[Token(Token = "0x2000C6D")]
	private struct IOSCollectionBundleRestoreRequest
	{
		[Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003D10")]
		public string transaction_id;

		[Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4003D11")]
		public bool is_sandbox;
	}

	[Token(Token = "0x2000C6E")]
	private delegate void ActionBoolUIntString(bool b, uint i, string s);

	[Token(Token = "0x2000C6F")]
	private delegate void ActionBool(bool b);

	[Token(Token = "0x2000C70")]
	private delegate void ActionString(string s);

	[Token(Token = "0x2000C71")]
	private delegate void TransactionCallback([Out] TransactionInfo transaction);

	[Token(Token = "0x2000C72")]
	private delegate void RestoreCallback(bool isOk, int count, string info);

	[Token(Token = "0x40024C2")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool m_IsInited;

	[Token(Token = "0x40024C3")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x11")]
	private bool m_IsFirstPurchase;

	[Token(Token = "0x40024C4")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private Product[] m_Products;

	[Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40024C5")]
	private string[] m_ProductIds;

	[Token(Token = "0x40024C6")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private ProductInfo m_ProductInfoSelected;

	[Token(Token = "0x40024C7")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private string orderIdCache;

	[Token(Token = "0x40024C8")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private bool isChecking;

	[Token(Token = "0x40024C9")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private JObject m_ConsumptionLimitInfo;

	[Token(Token = "0x40024CA")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private Dictionary<string, string> m_OrderUploadFailedCache;

	[Token(Token = "0x40024CB")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	private Dictionary<string, string> m_PostedOrderDatas;

	[Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40024CC")]
	private string m_PeroOrderUUID;

	[Token(Token = "0x40024CD")]
	private static iOSStorePurchase s_Instance;

	[Token(Token = "0x40024D5")]
	private static Dictionary<string, ProductInfo> m_ProductInfos;

	[Token(Token = "0x40024D6")]
	private const string m_iOSFinishRequestUrl = "purchase/apppay/ios/finish";

	[Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40024D7")]
	private List<Receipt> m_Receipts;

	[Token(Token = "0x40024D8")]
	[Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	private List<IOSCollectionBundleRestoreRequest> m_iOSReceiptRequest;

	[Token(Token = "0x40024D9")]
	private const string standardVerifyReceiptUrl = "https://buy.itunes.apple.com/verifyReceipt";

	[Token(Token = "0x40024DA")]
	private const string sandboxVerifyReceiptUrl = "https://sandbox.itunes.apple.com/verifyReceipt";

	[Token(Token = "0x40024DB")]
	private const int sandboxErrorCode = 21007;

	[Token(Token = "0x40024DC")]
	private static List<string> s_EditorTestRestoreProducts;

	[Token(Token = "0x40024DD")]
	[Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	private bool m_IsSandbox;

	[Token(Token = "0x170005F1")]
	public bool Inited
	{
		[Token(Token = "0x6004035")]
		[Address(RVA = "0x45CA50", Offset = "0x45B250", Length = "0x5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170005F2")]
	public bool IsFirstPurchase
	{
		[Address(RVA = "0x45CA60", Offset = "0x45B260", Length = "0x5")]
		[Token(Token = "0x6004036")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170005F3")]
	public Product[] products
	{
		[Token(Token = "0x6004037")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1400007D")]
	public event Action<bool> onInitSucceed
	{
		[CompilerGenerated]
		[Token(Token = "0x6004038")]
		[Address(RVA = "0x6682B0", Offset = "0x666AB0", Length = "0x9E")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6004039")]
		[Address(RVA = "0x668710", Offset = "0x666F10", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x1400007E")]
	public event Action<TransactionResult> onTransactionCompleted
	{
		[Address(RVA = "0x668670", Offset = "0x666E70", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600403A")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x600403B")]
		[Address(RVA = "0x668AD0", Offset = "0x6672D0", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x1400007F")]
	public event Action<bool, TransactionResult> onRestoreCompleted
	{
		[Address(RVA = "0x6685D0", Offset = "0x666DD0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600403C")]
		add
		{
		}
		[Token(Token = "0x600403D")]
		[Address(RVA = "0x668A30", Offset = "0x667230", Length = "0x9E")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000080")]
	public event Action<string[]> onReceiptCompleted
	{
		[CompilerGenerated]
		[Token(Token = "0x600403E")]
		[Address(RVA = "0x668530", Offset = "0x666D30", Length = "0x9E")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x600403F")]
		[Address(RVA = "0x668990", Offset = "0x667190", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x14000081")]
	public event Action<ProductInfo[]> onReceipToProductInfos
	{
		[CompilerGenerated]
		[Token(Token = "0x6004040")]
		[Address(RVA = "0x668490", Offset = "0x666C90", Length = "0x9E")]
		add
		{
		}
		[Address(RVA = "0x6688F0", Offset = "0x6670F0", Length = "0x9E")]
		[Token(Token = "0x6004041")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000082")]
	public event Action<string> onReceipDataCallback
	{
		[Address(RVA = "0x6683F0", Offset = "0x666BF0", Length = "0x9E")]
		[Token(Token = "0x6004042")]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[Address(RVA = "0x668850", Offset = "0x667050", Length = "0x9E")]
		[Token(Token = "0x6004043")]
		remove
		{
		}
	}

	[Token(Token = "0x14000083")]
	public event Action<List<ProductInfo>> onProductRefresh
	{
		[Address(RVA = "0x668350", Offset = "0x666B50", Length = "0x9E")]
		[Token(Token = "0x6004044")]
		[CompilerGenerated]
		add
		{
		}
		[Address(RVA = "0x6687B0", Offset = "0x666FB0", Length = "0x9E")]
		[Token(Token = "0x6004045")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6004046")]
	[Address(RVA = "0x667D30", Offset = "0x666530", Length = "0x57E")]
	public iOSStorePurchase()
	{
	}

	[Address(RVA = "0x663B40", Offset = "0x662340", Length = "0x10")]
	[Token(Token = "0x6004047")]
	public void InitStoreIAP(string[] productIds)
	{
	}

	[Address(RVA = "0x6664B0", Offset = "0x664CB0", Length = "0xA0")]
	[Token(Token = "0x6004048")]
	public void RefreshStoreIAP()
	{
	}

	[Token(Token = "0x6004049")]
	[Address(RVA = "0x665E90", Offset = "0x664690", Length = "0x610")]
	private void RefreshProductInfo()
	{
	}

	[Token(Token = "0x600404A")]
	[Obsolete]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void BeforePurchase(Action action, string productId = null)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x600404B")]
	public void Purchase(string productId)
	{
	}

	[Token(Token = "0x600404C")]
	[Address(RVA = "0x665580", Offset = "0x663D80", Length = "0x1BA")]
	public void Purchase(IAPOrder order)
	{
	}

	[Address(RVA = "0x666890", Offset = "0x665090", Length = "0x51")]
	[Token(Token = "0x600404D")]
	public void Restore(string productId)
	{
	}

	[Token(Token = "0x600404E")]
	[Address(RVA = "0x666980", Offset = "0x665180", Length = "0x67")]
	public static void SetEditorRestoreProducts(List<string> productIds)
	{
	}

	[Token(Token = "0x600404F")]
	[Address(RVA = "0x6669F0", Offset = "0x6651F0", Length = "0x594")]
	private void SimulateRestoreInEditor()
	{
	}

	[Token(Token = "0x6004050")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void RestoreAll()
	{
	}

	[Token(Token = "0x6004051")]
	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	public bool IsStoreAvailable()
	{
		return default(bool);
	}

	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x5F350", Offset = "0x5E750")]
	[Token(Token = "0x6004052")]
	[Address(RVA = "0x663DE0", Offset = "0x6625E0", Length = "0x23C")]
	private static void OnInitSucceed(bool isOK, uint productCount, string info)
	{
	}

	[Token(Token = "0x6004053")]
	[Address(RVA = "0x665E00", Offset = "0x664600", Length = "0x8F")]
	private static void RefreshProductAfterRestore(string[] obj)
	{
	}

	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x5F4E0", Offset = "0x5E8E0")]
	[Token(Token = "0x6004054")]
	[Address(RVA = "0x664EB0", Offset = "0x6636B0", Length = "0xF0")]
	private static void OnTransactionCompleted(TransactionInfo info)
	{
	}

	[Token(Token = "0x6004055")]
	[Address(RVA = "0x6634B0", Offset = "0x661CB0", Length = "0x4AD")]
	private void IOSPurchased(TransactionInfo info)
	{
	}

	[Address(RVA = "0x6633E0", Offset = "0x661BE0", Length = "0xC2")]
	[Token(Token = "0x6004056")]
	private void IOSPurchasedCollectionBundle(TransactionInfo info)
	{
	}

	[Token(Token = "0x6004057")]
	[Address(RVA = "0x664A80", Offset = "0x663280", Length = "0x423")]
	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x5F630", Offset = "0x5EA30")]
	private static void OnRestoreCompleted(bool isOk, int count, string info)
	{
	}

	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x5F810", Offset = "0x5EC10")]
	[Token(Token = "0x6004058")]
	[Address(RVA = "0x664020", Offset = "0x662820", Length = "0x1F0")]
	private static void OnReceiptCompleted(string receiptData)
	{
	}

	[Token(Token = "0x6004059")]
	[Address(RVA = "0x6653B0", Offset = "0x663BB0", Length = "0x1C4")]
	private void PostData(string receiptData)
	{
	}

	[Address(RVA = "0x665740", Offset = "0x663F40", Length = "0x6B2")]
	[Token(Token = "0x600405A")]
	private void ReceiptDataVerifyAndPostTdData(JObject jObject)
	{
	}

	[Address(RVA = "0x664220", Offset = "0x662A20", Length = "0x6A2")]
	[Token(Token = "0x600405B")]
	private static void OnReceiptDataVerify(JObject jObject)
	{
	}

	[Address(RVA = "0x6648D0", Offset = "0x6630D0", Length = "0x98")]
	[Token(Token = "0x600405C")]
	private static bool OnReceiptDataVerify(JObject jObject, ProductInfo product, out int status)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref status) = null;
		return default(bool);
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x600405D")]
	public void SecondaryVerify(TransactionResult transactionResult, Action<bool> callback)
	{
	}

	[Token(Token = "0x600405E")]
	[Address(RVA = "0x663B50", Offset = "0x662350", Length = "0x84")]
	private void InvokeNativePurchase(ProductInfo payProductInfo)
	{
	}

	[Address(RVA = "0x666560", Offset = "0x664D60", Length = "0xD1")]
	[Token(Token = "0x600405F")]
	private void RestoreCollectionBundle()
	{
	}

	[Address(RVA = "0x6672E0", Offset = "0x665AE0", Length = "0x98F")]
	[Token(Token = "0x6004060")]
	private void VerifyReceiptToRestore(JObject jsonData)
	{
	}

	[Token(Token = "0x6004061")]
	[Address(RVA = "0x663960", Offset = "0x662160", Length = "0x1DD")]
	private void IOSRestorePackageGroupFromPeroServer(List<IOSCollectionBundleRestoreRequest> requestData, Action<JObject> successCallback, Action<long, string> failCallback)
	{
	}

	[Address(RVA = "0x664970", Offset = "0x663170", Length = "0x89")]
	[Token(Token = "0x6004062")]
	private void OnRestoreCollectionBundleFailed(long code, string msg)
	{
	}

	[Token(Token = "0x6004063")]
	[Address(RVA = "0x664A00", Offset = "0x663200", Length = "0x7D")]
	private void OnRestoreCollectionBundleSuccess(JObject jsonData)
	{
	}

	[Address(RVA = "0x662880", Offset = "0x661080", Length = "0x5EB")]
	[Token(Token = "0x6004064")]
	private static void AnalyzeDataFromPeroServerToUnlockCollectionBundle(Dictionary<string, ProductInfo> unlockProductInfo, JObject jsonData)
	{
	}

	[Token(Token = "0x6004065")]
	[Address(RVA = "0x666640", Offset = "0x664E40", Length = "0x242")]
	private void RestoreFinish(string errorMsg = null)
	{
	}

	[Token(Token = "0x6004066")]
	[Address(RVA = "0x6672B0", Offset = "0x665AB0", Length = "0x2A")]
	private static TransactionState TransactionToState(int state)
	{
		return default(TransactionState);
	}

	[Token(Token = "0x6004067")]
	[Address(RVA = "0x662E70", Offset = "0x661670", Length = "0xB5")]
	private static DateTime ChangeChineseTime(string OriginTime)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6004068")]
	[Address(RVA = "0x663BE0", Offset = "0x6623E0", Length = "0xFC")]
	private static bool IsDataTimeClose(DateTime timeA, DateTime timeB)
	{
		return default(bool);
	}

	[Address(RVA = "0x6632C0", Offset = "0x661AC0", Length = "0x35")]
	[Token(Token = "0x6004069")]
	private static string GetBase64Receipt()
	{
		return null;
	}

	[Address(RVA = "0x667020", Offset = "0x665820", Length = "0x282")]
	[Token(Token = "0x600406A")]
	private void StartVerifyReceipt(Action<JObject> callback)
	{
	}

	[Address(RVA = "0x666F90", Offset = "0x665790", Length = "0x81")]
	[Token(Token = "0x600406B")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5F970", Offset = "0x5ED70")]
	private static IEnumerator StandardVerify(string receiptData, Action<JObject> callback)
	{
		return null;
	}

	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5FB10", Offset = "0x5EF10")]
	[Address(RVA = "0x6668F0", Offset = "0x6650F0", Length = "0x81")]
	[Token(Token = "0x600406C")]
	private static IEnumerator SandBoxVerify(string receiptData, Action<JObject> callback)
	{
		return null;
	}

	[Address(RVA = "0x663300", Offset = "0x661B00", Length = "0xD8")]
	[Token(Token = "0x600406D")]
	private static UnityWebRequest GetReceiptVerifyUnityWebRequest(string url, byte[] binaryData)
	{
		return null;
	}

	[Token(Token = "0x600406E")]
	[Address(RVA = "0x662F70", Offset = "0x661770", Length = "0x16A")]
	private Receipt ConvertiOSPurchaseToReceipt(JToken inAppJsonData)
	{
		return default(Receipt);
	}

	[Address(RVA = "0x662F30", Offset = "0x661730", Length = "0x38")]
	[Token(Token = "0x600406F")]
	private static IOSCollectionBundleRestoreRequest ConvertReceiptToIOSCollectionBundleRestoreRequest(Receipt receipt)
	{
		return default(IOSCollectionBundleRestoreRequest);
	}

	[Address(RVA = "0x663140", Offset = "0x661940", Length = "0x179")]
	[Token(Token = "0x6004070")]
	private List<ProductInfo> DictionaryToList(Dictionary<string, ProductInfo> set)
	{
		return null;
	}

	[Address(RVA = "0x6630E0", Offset = "0x6618E0", Length = "0x5C")]
	[Token(Token = "0x6004071")]
	private ProductInfo[] DictionaryToArray(Dictionary<string, ProductInfo> dictionary)
	{
		return null;
	}

	[Token(Token = "0x6004072")]
	[Address(RVA = "0x664FB0", Offset = "0x6637B0", Length = "0x3F0")]
	private static bool ParseDateTimeWithTimeZone(string dateTimeStr, out DateTime dateTime)
	{
		System.Runtime.CompilerServices.Unsafe.As<DateTime, @null>(ref dateTime) = null;
		return default(bool);
	}

	[Address(RVA = "0x663D60", Offset = "0x662560", Length = "0x7A")]
	[Token(Token = "0x6004073")]
	private static void Log(string msg)
	{
	}

	[Address(RVA = "0x663CE0", Offset = "0x6624E0", Length = "0x7A")]
	[Token(Token = "0x6004074")]
	private static void LogError(string msg)
	{
	}
}
