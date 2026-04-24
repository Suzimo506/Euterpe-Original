using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000104")]
public abstract class DLCInfoBasePurchaseControl : MonoBehaviour
{
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6000798")]
	public virtual void Refresh()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6000799")]
	public virtual void OnPurchaseSuccess()
	{
	}

	[Token(Token = "0x600079A")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	protected DLCInfoBasePurchaseControl()
	{
	}
}
