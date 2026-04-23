using System;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Serializable]
[Token(Token = "0x2000925")]
public class DlcCharLayoutPair : UnitySerializedDictionary<int, DlcCharLayout>
{
	[Address(RVA = "0x42D220", Offset = "0x42BA20", Length = "0x38")]
	[Token(Token = "0x6005302")]
	public DlcCharLayoutPair()
	{
		((UnitySerializedDictionary<, >)(object)this)._002Ector();
	}
}
