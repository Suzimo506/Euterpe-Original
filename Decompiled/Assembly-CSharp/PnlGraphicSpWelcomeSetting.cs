using System.Collections.Generic;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;

[Token(Token = "0x2000119")]
[CreateAssetMenu]
public class PnlGraphicSpWelcomeSetting : SerializedScriptableObject
{
	[Token(Token = "0x40006D5")]
	[FieldOffset(Offset = "0x58")]
	public List<int> specialWelcomeIndex;

	[Address(RVA = "0x4A38A0", Offset = "0x4A20A0", Length = "0x7")]
	[Token(Token = "0x6000829")]
	public PnlGraphicSpWelcomeSetting()
	{
	}
}
