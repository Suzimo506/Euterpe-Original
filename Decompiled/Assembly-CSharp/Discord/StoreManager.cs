using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x200043D")]
public class StoreManager
{
	[Token(Token = "0x2000B13")]
	internal struct FFIEvents
	{
		[Token(Token = "0x2000EA7")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void EntitlementCreateHandler(IntPtr ptr, ref Entitlement entitlement);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000EA8")]
		internal delegate void EntitlementDeleteHandler(IntPtr ptr, ref Entitlement entitlement);

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400393A")]
		internal EntitlementCreateHandler OnEntitlementCreate;

		[Token(Token = "0x400393B")]
		[FieldOffset(Offset = "0x8")]
		internal EntitlementDeleteHandler OnEntitlementDelete;
	}

	[Token(Token = "0x2000B14")]
	internal struct FFIMethods
	{
		[Token(Token = "0x2000EA9")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void FetchSkusCallback(IntPtr ptr, Result result);

		[Token(Token = "0x2000EAA")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void FetchSkusMethod(IntPtr methodsPtr, IntPtr callbackData, FetchSkusCallback callback);

		[Token(Token = "0x2000EAB")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void CountSkusMethod(IntPtr methodsPtr, ref int count);

		[Token(Token = "0x2000EAC")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result GetSkuMethod(IntPtr methodsPtr, long skuId, ref Sku sku);

		[Token(Token = "0x2000EAD")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result GetSkuAtMethod(IntPtr methodsPtr, int index, ref Sku sku);

		[Token(Token = "0x2000EAE")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void FetchEntitlementsCallback(IntPtr ptr, Result result);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000EAF")]
		internal delegate void FetchEntitlementsMethod(IntPtr methodsPtr, IntPtr callbackData, FetchEntitlementsCallback callback);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000EB0")]
		internal delegate void CountEntitlementsMethod(IntPtr methodsPtr, ref int count);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000EB1")]
		internal delegate Result GetEntitlementMethod(IntPtr methodsPtr, long entitlementId, ref Entitlement entitlement);

		[Token(Token = "0x2000EB2")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result GetEntitlementAtMethod(IntPtr methodsPtr, int index, ref Entitlement entitlement);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000EB3")]
		internal delegate Result HasSkuEntitlementMethod(IntPtr methodsPtr, long skuId, ref bool hasEntitlement);

		[Token(Token = "0x2000EB4")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void StartPurchaseCallback(IntPtr ptr, Result result);

		[Token(Token = "0x2000EB5")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void StartPurchaseMethod(IntPtr methodsPtr, long skuId, IntPtr callbackData, StartPurchaseCallback callback);

		[Token(Token = "0x400393C")]
		[FieldOffset(Offset = "0x0")]
		internal FetchSkusMethod FetchSkus;

		[Token(Token = "0x400393D")]
		[FieldOffset(Offset = "0x8")]
		internal CountSkusMethod CountSkus;

		[Token(Token = "0x400393E")]
		[FieldOffset(Offset = "0x10")]
		internal GetSkuMethod GetSku;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400393F")]
		internal GetSkuAtMethod GetSkuAt;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003940")]
		internal FetchEntitlementsMethod FetchEntitlements;

		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4003941")]
		internal CountEntitlementsMethod CountEntitlements;

		[Token(Token = "0x4003942")]
		[FieldOffset(Offset = "0x30")]
		internal GetEntitlementMethod GetEntitlement;

		[Token(Token = "0x4003943")]
		[FieldOffset(Offset = "0x38")]
		internal GetEntitlementAtMethod GetEntitlementAt;

		[Token(Token = "0x4003944")]
		[FieldOffset(Offset = "0x40")]
		internal HasSkuEntitlementMethod HasSkuEntitlement;

		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003945")]
		internal StartPurchaseMethod StartPurchase;
	}

	[Token(Token = "0x2000B15")]
	public delegate void FetchSkusHandler(Result result);

	[Token(Token = "0x2000B16")]
	public delegate void FetchEntitlementsHandler(Result result);

	[Token(Token = "0x2000B17")]
	public delegate void StartPurchaseHandler(Result result);

	[Token(Token = "0x2000B18")]
	public delegate void EntitlementCreateHandler(ref Entitlement entitlement);

	[Token(Token = "0x2000B19")]
	public delegate void EntitlementDeleteHandler(ref Entitlement entitlement);

	[Token(Token = "0x4001796")]
	[FieldOffset(Offset = "0x10")]
	private IntPtr MethodsPtr;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001797")]
	private object MethodsStructure;

	[Token(Token = "0x1700047C")]
	private FFIMethods Methods
	{
		[Token(Token = "0x6003218")]
		[Address(RVA = "0x21BDB80", Offset = "0x21BC380", Length = "0x11E")]
		get
		{
			return default(FFIMethods);
		}
	}

	[Token(Token = "0x1400003D")]
	public event EntitlementCreateHandler OnEntitlementCreate
	{
		[CompilerGenerated]
		[Token(Token = "0x6003219")]
		[Address(RVA = "0x21BDA40", Offset = "0x21BC240", Length = "0x9E")]
		add
		{
		}
		[Token(Token = "0x600321A")]
		[CompilerGenerated]
		[Address(RVA = "0x21BDCA0", Offset = "0x21BC4A0", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x1400003E")]
	public event EntitlementDeleteHandler OnEntitlementDelete
	{
		[Address(RVA = "0x21BDAE0", Offset = "0x21BC2E0", Length = "0x9E")]
		[Token(Token = "0x600321B")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600321C")]
		[CompilerGenerated]
		[Address(RVA = "0x21BDD40", Offset = "0x21BC540", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x600321D")]
	[Address(RVA = "0x21BD860", Offset = "0x21BC060", Length = "0x1D1")]
	internal StoreManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[Address(RVA = "0x21BD410", Offset = "0x21BBC10", Length = "0x10B")]
	[Token(Token = "0x600321E")]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[Address(RVA = "0x21BCAB0", Offset = "0x21BB2B0", Length = "0x90")]
	[Token(Token = "0x600321F")]
	[MonoPInvokeCallback]
	private static void FetchSkusCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Address(RVA = "0x21BCB50", Offset = "0x21BB350", Length = "0xD8")]
	[Token(Token = "0x6003220")]
	public void FetchSkus(FetchSkusHandler callback)
	{
	}

	[Address(RVA = "0x21BC8D0", Offset = "0x21BB0D0", Length = "0x59")]
	[Token(Token = "0x6003221")]
	public int CountSkus()
	{
		return default(int);
	}

	[Address(RVA = "0x21BD070", Offset = "0x21BB870", Length = "0xC9")]
	[Token(Token = "0x6003222")]
	public Sku GetSku(long skuId)
	{
		return default(Sku);
	}

	[Token(Token = "0x6003223")]
	[Address(RVA = "0x21BCFA0", Offset = "0x21BB7A0", Length = "0xC9")]
	public Sku GetSkuAt(int index)
	{
		return default(Sku);
	}

	[Address(RVA = "0x21BC930", Offset = "0x21BB130", Length = "0x90")]
	[MonoPInvokeCallback]
	[Token(Token = "0x6003224")]
	private static void FetchEntitlementsCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Token(Token = "0x6003225")]
	[Address(RVA = "0x21BC9D0", Offset = "0x21BB1D0", Length = "0xD9")]
	public void FetchEntitlements(FetchEntitlementsHandler callback)
	{
	}

	[Token(Token = "0x6003226")]
	[Address(RVA = "0x21BC870", Offset = "0x21BB070", Length = "0x59")]
	public int CountEntitlements()
	{
		return default(int);
	}

	[Address(RVA = "0x21BCD00", Offset = "0x21BB500", Length = "0xC5")]
	[Token(Token = "0x6003227")]
	public Entitlement GetEntitlement(long entitlementId)
	{
		return default(Entitlement);
	}

	[Address(RVA = "0x21BCC30", Offset = "0x21BB430", Length = "0xC5")]
	[Token(Token = "0x6003228")]
	public Entitlement GetEntitlementAt(int index)
	{
		return default(Entitlement);
	}

	[Address(RVA = "0x21BD350", Offset = "0x21BBB50", Length = "0xBF")]
	[Token(Token = "0x6003229")]
	public bool HasSkuEntitlement(long skuId)
	{
		return default(bool);
	}

	[Address(RVA = "0x21BD6C0", Offset = "0x21BBEC0", Length = "0x90")]
	[Token(Token = "0x600322A")]
	[MonoPInvokeCallback]
	private static void StartPurchaseCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Address(RVA = "0x21BD760", Offset = "0x21BBF60", Length = "0xF4")]
	[Token(Token = "0x600322B")]
	public void StartPurchase(long skuId, StartPurchaseHandler callback)
	{
	}

	[MonoPInvokeCallback]
	[Address(RVA = "0x21BD520", Offset = "0x21BBD20", Length = "0xC5")]
	[Token(Token = "0x600322C")]
	private static void OnEntitlementCreateImpl(IntPtr ptr, ref Entitlement entitlement)
	{
	}

	[MonoPInvokeCallback]
	[Address(RVA = "0x21BD5F0", Offset = "0x21BBDF0", Length = "0xC5")]
	[Token(Token = "0x600322D")]
	private static void OnEntitlementDeleteImpl(IntPtr ptr, ref Entitlement entitlement)
	{
	}

	[Token(Token = "0x600322E")]
	[Address(RVA = "0x21BCDD0", Offset = "0x21BB5D0", Length = "0x1CB")]
	public IEnumerable<Entitlement> GetEntitlements()
	{
		return null;
	}

	[Address(RVA = "0x21BD140", Offset = "0x21BB940", Length = "0x209")]
	[Token(Token = "0x600322F")]
	public IEnumerable<Sku> GetSkus()
	{
		return null;
	}
}
