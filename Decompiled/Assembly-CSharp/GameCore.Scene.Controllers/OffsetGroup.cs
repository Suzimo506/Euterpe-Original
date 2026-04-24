using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace GameCore.Scene.Controllers;

[Token(Token = "0x2000465")]
public class OffsetGroup : MonoBehaviour
{
	[Token(Token = "0x40017F8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public bool m_IgnoreZ;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40017F9")]
	private IMixOffset[] m_MixOffsets;

	[Token(Token = "0x1700048C")]
	public Vector3 originPos
	{
		[CompilerGenerated]
		[Address(RVA = "0x90A750", Offset = "0x908F50", Length = "0x13")]
		[Token(Token = "0x60032EA")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60032EB")]
		[Address(RVA = "0x90A770", Offset = "0x908F70", Length = "0x10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60032EC")]
	[Address(RVA = "0x90A420", Offset = "0x908C20", Length = "0xA9")]
	private void Awake()
	{
	}

	[Address(RVA = "0x90A4D0", Offset = "0x908CD0", Length = "0x275")]
	[Token(Token = "0x60032ED")]
	private void Update()
	{
	}

	[Address(RVA = "0x90A3E0", Offset = "0x908BE0", Length = "0x3F")]
	[Token(Token = "0x60032EE")]
	public void AnchorOrigin()
	{
	}

	[Address(RVA = "0x507DF0", Offset = "0x5065F0", Length = "0xB")]
	[Token(Token = "0x60032EF")]
	public OffsetGroup()
	{
	}
}
