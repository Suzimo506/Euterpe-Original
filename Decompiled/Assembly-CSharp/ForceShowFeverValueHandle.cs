using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000E6")]
public class ForceShowFeverValueHandle : MonoBehaviour
{
	[Token(Token = "0x40005B7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<Transform> m_AllFeverValueItems;

	[Token(Token = "0x60006AB")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x44F450", Offset = "0x44DC50", Length = "0x69")]
	[Token(Token = "0x60006AC")]
	public ForceShowFeverValueHandle()
	{
	}
}
