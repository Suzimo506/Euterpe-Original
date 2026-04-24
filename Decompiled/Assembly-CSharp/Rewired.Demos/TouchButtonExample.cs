using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Demos;

[Attribute(Name = "AddComponentMenu", RVA = "0xD5B0", Offset = "0xC9B0")]
[Attribute(Name = "RequireComponent", RVA = "0xD5B0", Offset = "0xC9B0")]
[Token(Token = "0x2000216")]
public class TouchButtonExample : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	[Token(Token = "0x4000F2A")]
	[FieldOffset(Offset = "0x18")]
	public bool allowMouseControl;

	[Token(Token = "0x1700040B")]
	public bool isPressed
	{
		[Token(Token = "0x60013F0")]
		[Address(RVA = "0x575490", Offset = "0x573C90", Length = "0x5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x60013F1")]
		[Address(RVA = "0x575860", Offset = "0x574060", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x60013F2")]
	[Address(RVA = "0xFA5260", Offset = "0xFA3A60", Length = "0x1F")]
	private void Awake()
	{
	}

	[Address(RVA = "0x51B6F0", Offset = "0x519EF0", Length = "0x5")]
	[Token(Token = "0x60013F3")]
	private void Restart()
	{
	}

	[Address(RVA = "0xFA52A0", Offset = "0xFA3AA0", Length = "0x33")]
	[Token(Token = "0x60013F4")]
	private void UnityEngine_002EEventSystems_002EIPointerDownHandler_002EOnPointerDown(PointerEventData eventData)
	{
	}

	[Address(RVA = "0xFA52E0", Offset = "0xFA3AE0", Length = "0x33")]
	[Token(Token = "0x60013F5")]
	private void UnityEngine_002EEventSystems_002EIPointerUpHandler_002EOnPointerUp(PointerEventData eventData)
	{
	}

	[Address(RVA = "0xFA5280", Offset = "0xFA3A80", Length = "0x12")]
	[Token(Token = "0x60013F6")]
	private static bool IsMousePointerId(int id)
	{
		return default(bool);
	}

	[Address(RVA = "0x507DF0", Offset = "0x5065F0", Length = "0xB")]
	[Token(Token = "0x60013F7")]
	public TouchButtonExample()
	{
	}
}
