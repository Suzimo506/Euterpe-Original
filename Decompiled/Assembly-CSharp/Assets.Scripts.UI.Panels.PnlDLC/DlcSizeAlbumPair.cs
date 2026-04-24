using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Serializable]
[Token(Token = "0x2000914")]
public class DlcSizeAlbumPair : UnitySerializedDictionary<int, Vector2>
{
	[Token(Token = "0x6005267")]
	[Address(RVA = "0x42E070", Offset = "0x42C870", Length = "0x38")]
	public DlcSizeAlbumPair()
	{
		((UnitySerializedDictionary<, >)(object)this)._002Ector();
	}
}
