using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.UI.Components.NiceReplacement;

[Token(Token = "0x20008BC")]
public class ReplacedOnActive : MonoBehaviour, IPlayable
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002D96")]
	[SerializeField]
	private UnityEvent m_Event;

	[Token(Token = "0x6004EDC")]
	[Address(RVA = "0x5B2EE0", Offset = "0x5B16E0", Length = "0x1D")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x5B2EE0", Offset = "0x5B16E0", Length = "0x1D")]
	[Token(Token = "0x6004EDD")]
	public void Execute()
	{
	}

	[Token(Token = "0x6004EDE")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public ReplacedOnActive()
	{
	}
}
