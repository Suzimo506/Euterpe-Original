using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Serializable]
[Token(Token = "0x2000913")]
public class SpecialAlbumDlcPair : UnitySerializedDictionary<int, GameObject>
{
	[Token(Token = "0x6005266")]
	[Address(RVA = "0x834720", Offset = "0x832F20", Length = "0x38")]
	public SpecialAlbumDlcPair()
	{
		((UnitySerializedDictionary<, >)(object)this)._002Ector();
	}
}
