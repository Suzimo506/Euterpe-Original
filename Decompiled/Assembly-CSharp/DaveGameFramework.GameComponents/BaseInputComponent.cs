using System.Collections.Generic;
using Cpp2ILInjected;
using DaveGameFramework.Interfaces;

namespace DaveGameFramework.GameComponents;

[Token(Token = "0x20004CA")]
public abstract class BaseInputComponent : IUpdateController
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001A1D")]
	protected Dictionary<InputAction, List<int>> m_InputInfo;

	[Token(Token = "0x170004F8")]
	public Dictionary<InputAction, List<int>> InputInfo
	{
		[Token(Token = "0x60035B4")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x60035B5")]
	public abstract void AwakeInit();

	[Token(Token = "0x60035B6")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void Reset()
	{
	}

	[Token(Token = "0x60035B7")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void OnUpdate()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60035B8")]
	public virtual void OnFixedUpdate()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60035B9")]
	public virtual void OnLateUpdate()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60035BA")]
	protected BaseInputComponent()
	{
	}
}
