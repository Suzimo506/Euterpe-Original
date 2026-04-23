using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace GameCore.Scene.Controllers;

[Token(Token = "0x2000466")]
[Attribute(Name = "RequireComponent", RVA = "0x3BA40", Offset = "0x3AE40")]
public class SceneScrollableControl : MonoBehaviour
{
	[Token(Token = "0x40017FB")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float m_DefaultStepPerSecond;

	[Token(Token = "0x40017FC")]
	[FieldOffset(Offset = "0x20")]
	private ScrollableGear m_Gear;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40017FD")]
	private float m_PassTime;

	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40017FE")]
	private float m_Tick;

	[Token(Token = "0x40017FF")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsPause;

	[Token(Token = "0x1700048D")]
	public float speedMul
	{
		[Address(RVA = "0x90CF00", Offset = "0x90B700", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x60032F0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60032F1")]
		[Address(RVA = "0x746D00", Offset = "0x745500", Length = "0x6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Address(RVA = "0x90CBF0", Offset = "0x90B3F0", Length = "0x47")]
	[Token(Token = "0x60032F2")]
	private void Awake()
	{
	}

	[Token(Token = "0x60032F3")]
	[Address(RVA = "0x90CE80", Offset = "0x90B680", Length = "0x4")]
	public void SetPause(bool isPause)
	{
	}

	[Token(Token = "0x60032F4")]
	[Address(RVA = "0x90CE90", Offset = "0x90B690", Length = "0x42")]
	private void Update()
	{
	}

	[Token(Token = "0x60032F5")]
	[Address(RVA = "0x90CC40", Offset = "0x90B440", Length = "0x223")]
	private void OnUpdate(float tick)
	{
	}

	[Address(RVA = "0x90CE70", Offset = "0x90B670", Length = "0x8")]
	[Token(Token = "0x60032F6")]
	public void ResetScrollProgress()
	{
	}

	[Token(Token = "0x60032F7")]
	[Address(RVA = "0x90CEE0", Offset = "0x90B6E0", Length = "0x15")]
	public SceneScrollableControl()
	{
	}
}
