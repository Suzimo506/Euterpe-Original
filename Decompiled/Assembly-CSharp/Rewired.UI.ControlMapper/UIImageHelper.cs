using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7A90", Offset = "0x6E90")]
[Token(Token = "0x200020D")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7A90", Offset = "0x6E90")]
public class UIImageHelper : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000AA8")]
	private class State
	{
		[SerializeField]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400380B")]
		public Color color;

		[Address(RVA = "0xDCA600", Offset = "0xDC8E00", Length = "0x90")]
		[Token(Token = "0x6005B88")]
		public void Set(Image image)
		{
		}

		[Token(Token = "0x6005B89")]
		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		public State()
		{
		}
	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000EE8")]
	[SerializeField]
	private State enabledState;

	[SerializeField]
	[Token(Token = "0x4000EE9")]
	[FieldOffset(Offset = "0x20")]
	private State disabledState;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000EEA")]
	private bool currentState;

	[Token(Token = "0x600135F")]
	[Address(RVA = "0xDCD3B0", Offset = "0xDCBBB0", Length = "0x150")]
	public void SetEnabledState(bool newState)
	{
	}

	[Address(RVA = "0xDCD390", Offset = "0xDCBB90", Length = "0x1E")]
	[Token(Token = "0x6001360")]
	public void SetEnabledStateColor(Color color)
	{
	}

	[Token(Token = "0x6001361")]
	[Address(RVA = "0xDCD370", Offset = "0xDCBB70", Length = "0x1E")]
	public void SetDisabledStateColor(Color color)
	{
	}

	[Address(RVA = "0xDCD250", Offset = "0xDCBA50", Length = "0x111")]
	[Token(Token = "0x6001362")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6001363")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public UIImageHelper()
	{
	}
}
