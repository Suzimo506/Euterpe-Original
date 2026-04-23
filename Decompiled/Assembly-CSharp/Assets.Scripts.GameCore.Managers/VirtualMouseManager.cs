using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using GamePadVirtualMouse;
using UnityEngine;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x200075A")]
public class VirtualMouseManager : SingletonMonoBehaviour<VirtualMouseManager>
{
	[Token(Token = "0x40026E5")]
	[FieldOffset(Offset = "0x18")]
	private GamePadMouseCursor m_GamepadMouseCursor;

	[Token(Token = "0x40026E6")]
	[FieldOffset(Offset = "0x20")]
	private Transform m_VirtualMouseTransform;

	[Token(Token = "0x40026E7")]
	[FieldOffset(Offset = "0x28")]
	private Coroutine m_OpenMouseCorotine;

	[Token(Token = "0x1700067B")]
	public GamePadMouseCursor gamepadMouseCursor
	{
		[Token(Token = "0x600451A")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x7DFFF0", Offset = "0x7DE7F0", Length = "0x132")]
	[Token(Token = "0x6004519")]
	private void Start()
	{
	}

	[Token(Token = "0x600451B")]
	[Address(RVA = "0x7DFE40", Offset = "0x7DE640", Length = "0x1AE")]
	public void OpenVirtualMouse(bool delayOpen = false)
	{
	}

	[Address(RVA = "0x7DFBE0", Offset = "0x7DE3E0", Length = "0x25F")]
	[Token(Token = "0x600451C")]
	public void CloseVirtualMouse()
	{
	}

	[Token(Token = "0x600451D")]
	[Address(RVA = "0x7E0180", Offset = "0x7DE980", Length = "0x38")]
	public VirtualMouseManager()
	{
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
	}
}
