using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

[Token(Token = "0x2000189")]
public class MusicStageScrollView : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler
{
	[Token(Token = "0x40009A6")]
	[FieldOffset(Offset = "0x20")]
	public bool isDraging;

	[Token(Token = "0x14000006")]
	public event Action<bool> DragHandler
	{
		[CompilerGenerated]
		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x8C7CE0", Offset = "0x8C64E0", Length = "0x9E")]
		add
		{
		}
		[CompilerGenerated]
		[Address(RVA = "0x8C7D80", Offset = "0x8C6580", Length = "0x9E")]
		[Token(Token = "0x6000B25")]
		remove
		{
		}
	}

	[Token(Token = "0x6000B26")]
	[Address(RVA = "0x8C7C40", Offset = "0x8C6440", Length = "0x4A")]
	public void OnBeginDrag(PointerEventData data)
	{
	}

	[Address(RVA = "0x8C7C90", Offset = "0x8C6490", Length = "0x4A")]
	[Token(Token = "0x6000B27")]
	public void OnEndDrag(PointerEventData data)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000B28")]
	public MusicStageScrollView()
	{
	}
}
