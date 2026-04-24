using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x200092A")]
public class FoolDayHandle : MonoBehaviour
{
	[Token(Token = "0x6005319")]
	[Address(RVA = "0x42E600", Offset = "0x42CE00", Length = "0xB1")]
	public void RegisterDlcChange()
	{
	}

	[Token(Token = "0x600531A")]
	[Address(RVA = "0x42E6C0", Offset = "0x42CEC0", Length = "0xB1")]
	public void RemoveDlcChange()
	{
	}

	[Token(Token = "0x600531B")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x600531C")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void ChangeByAlbumJsonIndex(int albumJsonIndex)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600531D")]
	public FoolDayHandle()
	{
	}
}
