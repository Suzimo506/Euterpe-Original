using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Common;

[Token(Token = "0x2000983")]
public class SyncPositionOnEnable : MonoBehaviour
{
	[Token(Token = "0x4003412")]
	[FieldOffset(Offset = "0x18")]
	public Transform targetTrans;

	[Token(Token = "0x600568E")]
	[Address(RVA = "0x702F60", Offset = "0x701760", Length = "0x63")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600568F")]
	public SyncPositionOnEnable()
	{
	}
}
