using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Components.NiceReplacement;

[Token(Token = "0x20008BD")]
public class ReplacedOnToggle : MonoBehaviour
{
	[Token(Token = "0x4002D97")]
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	private Toggle m_Toggle;

	[Token(Token = "0x4002D98")]
	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	private UnityEvent m_OnEvent;

	[SerializeField]
	[Token(Token = "0x4002D99")]
	[FieldOffset(Offset = "0x28")]
	private UnityEvent m_OffEvent;

	[Address(RVA = "0x5B2F00", Offset = "0x5B1700", Length = "0x35")]
	[Token(Token = "0x6004EDF")]
	public void OnToggle(bool isOn)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6004EE0")]
	public ReplacedOnToggle()
	{
	}
}
