namespace Discord;

public class StoreManager
{
	internal sealed class EntitlementCreateHandler : MulticastDelegate
	{

		public EntitlementCreateHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref Entitlement entitlement, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref Entitlement entitlement, IAsyncResult result) { }

		public override void Invoke(ref Entitlement entitlement) { }

	}

	internal sealed class EntitlementDeleteHandler : MulticastDelegate
	{

		public EntitlementDeleteHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref Entitlement entitlement, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref Entitlement entitlement, IAsyncResult result) { }

		public override void Invoke(ref Entitlement entitlement) { }

	}

	internal sealed class FetchEntitlementsHandler : MulticastDelegate
	{

		public FetchEntitlementsHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	internal sealed class FetchSkusHandler : MulticastDelegate
	{

		public FetchSkusHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	public struct FFIEvents
	{
		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class EntitlementCreateHandler : MulticastDelegate
		{

			public EntitlementCreateHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, ref Entitlement entitlement, AsyncCallback callback, object object) { }

			public override void EndInvoke(ref Entitlement entitlement, IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, ref Entitlement entitlement) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class EntitlementDeleteHandler : MulticastDelegate
		{

			public EntitlementDeleteHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, ref Entitlement entitlement, AsyncCallback callback, object object) { }

			public override void EndInvoke(ref Entitlement entitlement, IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, ref Entitlement entitlement) { }

		}

		internal EntitlementCreateHandler OnEntitlementCreate; //Field offset: 0x0
		internal EntitlementDeleteHandler OnEntitlementDelete; //Field offset: 0x8

	}

	public struct FFIMethods
	{
		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class CountEntitlementsMethod : MulticastDelegate
		{

			public CountEntitlementsMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, object object) { }

			public override void EndInvoke(ref int count, IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, ref int count) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class CountSkusMethod : MulticastDelegate
		{

			public CountSkusMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, object object) { }

			public override void EndInvoke(ref int count, IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, ref int count) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class FetchEntitlementsCallback : MulticastDelegate
		{

			public FetchEntitlementsCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class FetchEntitlementsMethod : MulticastDelegate
		{

			public FetchEntitlementsMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, FetchEntitlementsCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, IntPtr callbackData, FetchEntitlementsCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class FetchSkusCallback : MulticastDelegate
		{

			public FetchSkusCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class FetchSkusMethod : MulticastDelegate
		{

			public FetchSkusMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, FetchSkusCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, IntPtr callbackData, FetchSkusCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetEntitlementAtMethod : MulticastDelegate
		{

			public GetEntitlementAtMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, int index, ref Entitlement entitlement, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref Entitlement entitlement, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, int index, ref Entitlement entitlement) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetEntitlementMethod : MulticastDelegate
		{

			public GetEntitlementMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long entitlementId, ref Entitlement entitlement, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref Entitlement entitlement, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long entitlementId, ref Entitlement entitlement) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetSkuAtMethod : MulticastDelegate
		{

			public GetSkuAtMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, int index, ref Sku sku, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref Sku sku, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, int index, ref Sku sku) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetSkuMethod : MulticastDelegate
		{

			public GetSkuMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long skuId, ref Sku sku, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref Sku sku, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long skuId, ref Sku sku) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class HasSkuEntitlementMethod : MulticastDelegate
		{

			public HasSkuEntitlementMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long skuId, ref bool hasEntitlement, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref bool hasEntitlement, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long skuId, ref bool hasEntitlement) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class StartPurchaseCallback : MulticastDelegate
		{

			public StartPurchaseCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class StartPurchaseMethod : MulticastDelegate
		{

			public StartPurchaseMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long skuId, IntPtr callbackData, StartPurchaseCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, long skuId, IntPtr callbackData, StartPurchaseCallback callback) { }

		}

		internal FetchSkusMethod FetchSkus; //Field offset: 0x0
		internal CountSkusMethod CountSkus; //Field offset: 0x8
		internal GetSkuMethod GetSku; //Field offset: 0x10
		internal GetSkuAtMethod GetSkuAt; //Field offset: 0x18
		internal FetchEntitlementsMethod FetchEntitlements; //Field offset: 0x20
		internal CountEntitlementsMethod CountEntitlements; //Field offset: 0x28
		internal GetEntitlementMethod GetEntitlement; //Field offset: 0x30
		internal GetEntitlementAtMethod GetEntitlementAt; //Field offset: 0x38
		internal HasSkuEntitlementMethod HasSkuEntitlement; //Field offset: 0x40
		internal StartPurchaseMethod StartPurchase; //Field offset: 0x48

	}

	internal sealed class StartPurchaseHandler : MulticastDelegate
	{

		public StartPurchaseHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	private IntPtr MethodsPtr; //Field offset: 0x10
	private object MethodsStructure; //Field offset: 0x18
	[CompilerGenerated]
	private EntitlementCreateHandler OnEntitlementCreate; //Field offset: 0x20
	[CompilerGenerated]
	private EntitlementDeleteHandler OnEntitlementDelete; //Field offset: 0x28

	public event EntitlementCreateHandler OnEntitlementCreate
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event EntitlementDeleteHandler OnEntitlementDelete
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	private FFIMethods Methods
	{
		private get { } //Length: 286
	}

	internal StoreManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events) { }

	[CompilerGenerated]
	public void add_OnEntitlementCreate(EntitlementCreateHandler value) { }

	[CompilerGenerated]
	public void add_OnEntitlementDelete(EntitlementDeleteHandler value) { }

	public int CountEntitlements() { }

	public int CountSkus() { }

	public void FetchEntitlements(FetchEntitlementsHandler callback) { }

	[MonoPInvokeCallback]
	private static void FetchEntitlementsCallbackImpl(IntPtr ptr, Result result) { }

	public void FetchSkus(FetchSkusHandler callback) { }

	[MonoPInvokeCallback]
	private static void FetchSkusCallbackImpl(IntPtr ptr, Result result) { }

	private FFIMethods get_Methods() { }

	public Entitlement GetEntitlement(long entitlementId) { }

	public Entitlement GetEntitlementAt(int index) { }

	public IEnumerable<Entitlement> GetEntitlements() { }

	public Sku GetSku(long skuId) { }

	public Sku GetSkuAt(int index) { }

	public IEnumerable<Sku> GetSkus() { }

	public bool HasSkuEntitlement(long skuId) { }

	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

	[MonoPInvokeCallback]
	private static void OnEntitlementCreateImpl(IntPtr ptr, ref Entitlement entitlement) { }

	[MonoPInvokeCallback]
	private static void OnEntitlementDeleteImpl(IntPtr ptr, ref Entitlement entitlement) { }

	[CompilerGenerated]
	public void remove_OnEntitlementCreate(EntitlementCreateHandler value) { }

	[CompilerGenerated]
	public void remove_OnEntitlementDelete(EntitlementDeleteHandler value) { }

	public void StartPurchase(long skuId, StartPurchaseHandler callback) { }

	[MonoPInvokeCallback]
	private static void StartPurchaseCallbackImpl(IntPtr ptr, Result result) { }

}

