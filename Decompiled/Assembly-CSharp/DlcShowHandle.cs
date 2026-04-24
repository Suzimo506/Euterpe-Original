using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000109")]
public class DlcShowHandle : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x400068C")]
	[FieldOffset(Offset = "0x18")]
	private List<GameObject> m_NormalShows;

	[SerializeField]
	[Token(Token = "0x400068D")]
	[FieldOffset(Offset = "0x20")]
	private List<GameObject> m_DlcShows;

	[Token(Token = "0x60007C0")]
	[Address(RVA = "0x442B90", Offset = "0x441390", Length = "0x6F")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x442A00", Offset = "0x441200", Length = "0x65")]
	[Token(Token = "0x60007C1")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x16A70", Offset = "0x15E70")]
	private IEnumerator AfterOnEnableCoroutine()
	{
		return null;
	}

	[Address(RVA = "0x442A70", Offset = "0x441270", Length = "0x11C")]
	[Token(Token = "0x60007C2")]
	private void AfterOnEnableMethod()
	{
	}

	[Token(Token = "0x60007C3")]
	[Address(RVA = "0x442C00", Offset = "0x441400", Length = "0x96")]
	public DlcShowHandle()
	{
	}
}
