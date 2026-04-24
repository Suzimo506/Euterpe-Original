using System.Collections;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000170")]
public class AutoHideMouseHandler : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4000915")]
	[FieldOffset(Offset = "0x18")]
	private float m_WaitHideTime;

	[Token(Token = "0x4000916")]
	[FieldOffset(Offset = "0x1C")]
	private Vector3 m_MousePosition;

	[Token(Token = "0x4000917")]
	[FieldOffset(Offset = "0x28")]
	private WaitForSeconds m_WaitHideForSeconds;

	[Token(Token = "0x4000918")]
	[FieldOffset(Offset = "0x30")]
	private WaitForSeconds m_CheckWaitForSeconds;

	[Token(Token = "0x4000919")]
	[FieldOffset(Offset = "0x38")]
	private Coroutine m_HideMouseCoroutine;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400091A")]
	private bool m_IsHiding;

	[Address(RVA = "0x5F3070", Offset = "0x5F1870", Length = "0x9E")]
	[Token(Token = "0x6000A8E")]
	private void Awake()
	{
	}

	[Address(RVA = "0x5F3180", Offset = "0x5F1980", Length = "0x6F")]
	[Token(Token = "0x6000A8F")]
	private void OnEnable()
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x37180", Offset = "0x36580")]
	[Address(RVA = "0x5F31F0", Offset = "0x5F19F0", Length = "0x65")]
	[Token(Token = "0x6000A90")]
	private IEnumerator ShowMouseCortinue()
	{
		return null;
	}

	[Token(Token = "0x6000A91")]
	[Address(RVA = "0x5F3110", Offset = "0x5F1910", Length = "0x65")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x37360", Offset = "0x36760")]
	private IEnumerator HideMouseCortinue()
	{
		return null;
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000A92")]
	public AutoHideMouseHandler()
	{
	}
}
