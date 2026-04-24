using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Attribute(Name = "RequireComponent", RVA = "0x95C00", Offset = "0x95000")]
[Token(Token = "0x20000A0")]
public class UICanvasScalerHandle : MonoBehaviour
{
	[Token(Token = "0x400045A")]
	[FieldOffset(Offset = "0x18")]
	private CanvasScaler m_CanvasScaler;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400045B")]
	private Canvas m_Canvas;

	[Token(Token = "0x400045C")]
	private static UICanvasScalerHandle m_Instance;

	[Token(Token = "0x17000076")]
	public static UICanvasScalerHandle Instance
	{
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x4E5660", Offset = "0x4E3E60", Length = "0x35")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x4E54A0", Offset = "0x4E3CA0", Length = "0x7E")]
	private void Awake()
	{
	}

	[Address(RVA = "0x4E55C0", Offset = "0x4E3DC0", Length = "0x43")]
	[Token(Token = "0x60004F3")]
	public static CanvasScaler GetUICanvasScaler()
	{
		return null;
	}

	[Address(RVA = "0x4E5610", Offset = "0x4E3E10", Length = "0x43")]
	[Token(Token = "0x60004F4")]
	public static Canvas GetUICanvas()
	{
		return null;
	}

	[Address(RVA = "0x4E5570", Offset = "0x4E3D70", Length = "0x4F")]
	[Token(Token = "0x60004F5")]
	public static void ChangeToScreenShotMode()
	{
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x4E5520", Offset = "0x4E3D20", Length = "0x4F")]
	public static void ChangeToNormalMode()
	{
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public UICanvasScalerHandle()
	{
	}
}
