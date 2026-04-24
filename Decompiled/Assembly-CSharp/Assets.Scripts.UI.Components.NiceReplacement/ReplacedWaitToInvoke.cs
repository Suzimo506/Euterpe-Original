using System.Collections;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.UI.Components.NiceReplacement;

[Token(Token = "0x20008C4")]
public class ReplacedWaitToInvoke : MonoBehaviour, IPlayable
{
	[Token(Token = "0x4002DC5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float m_Delay;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002DC6")]
	[SerializeField]
	private UnityEvent m_Event;

	[Token(Token = "0x6004F03")]
	[Address(RVA = "0x5B5410", Offset = "0x5B3C10", Length = "0x6F")]
	public void Execute()
	{
	}

	[Address(RVA = "0x5B5480", Offset = "0x5B3C80", Length = "0x65")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x4A640", Offset = "0x49A40")]
	[Token(Token = "0x6004F04")]
	private IEnumerator Invoke()
	{
		return null;
	}

	[Token(Token = "0x6004F05")]
	[Address(RVA = "0x4E21B0", Offset = "0x4E09B0", Length = "0xE")]
	public ReplacedWaitToInvoke()
	{
	}
}
