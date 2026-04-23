using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000019")]
public class SpineSynchroObjects : MonoBehaviour
{
	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<GameObject> synchroObjects;

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60000A6")]
	public SpineSynchroObjects()
	{
	}
}
