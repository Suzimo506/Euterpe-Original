namespace Assets.Scripts.Purchase;

public class MDIAPManager : IAPManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Boolean> <>9__8_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <InitProductDiscount>b__8_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public String[] ps; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal void <OnReceiptCompleted>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public TransactionResult result; //Field offset: 0x10
		public MDIAPManager <>4__this; //Field offset: 0x40

		public <>c__DisplayClass12_0() { }

		internal void <OnTransactionComplete>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_1
	{
		public string productId; //Field offset: 0x10
		public <>c__DisplayClass12_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass12_1() { }

		internal void <OnTransactionComplete>b__1(bool isSuccueed) { }

	}

	private readonly List<String> m_AlbumIds; //Field offset: 0x40

	public MDIAPManager() { }

	[CompilerGenerated]
	private void <InitProductDiscount>b__8_0() { }

	[CompilerGenerated]
	private void <InitProductDiscount>b__8_2(JObject jObj) { }

	[CompilerGenerated]
	private void <OnInitSucceed>b__4_0() { }

	public virtual void ClearPurchase() { }

	private void CompletedCallback(DateTime _) { }

	private void FailCallback(long err, string msg) { }

	public void GetLocalPurchasedList(List<String> buffer) { }

	private void InitEvents() { }

	public virtual void InitIAP(String[] productIds) { }

	private void InitProductDiscount(Action<Boolean> callback = null) { }

	private void OnInitSucceed(bool succeed) { }

	private void OnReceiptCompleted(String[] ps) { }

	private void OnTransactionComplete(TransactionResult result) { }

	private void Private_RefreshLocalPurchasedList() { }

	public virtual void Purchase(string productId) { }

}

