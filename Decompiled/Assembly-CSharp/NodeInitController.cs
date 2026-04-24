using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000046")]
public class NodeInitController : MonoBehaviour
{
	[Token(Token = "0x40001AE")]
	[FieldOffset(Offset = "0x18")]
	private int idx;

	[Token(Token = "0x40001AF")]
	[FieldOffset(Offset = "0x1C")]
	private decimal countdown;

	[Token(Token = "0x40001B0")]
	[FieldOffset(Offset = "0x30")]
	private SpineActionController m_Sac;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001B1")]
	private MeshRenderer m_MeshRenderer;

	[Token(Token = "0x40001B2")]
	[FieldOffset(Offset = "0x40")]
	private Animator m_Animator;

	[Address(RVA = "0x86B9B0", Offset = "0x86A1B0", Length = "0x148")]
	[Token(Token = "0x60001FA")]
	public void InitWithoutRun(int index)
	{
	}

	[Address(RVA = "0x86BB00", Offset = "0x86A300", Length = "0xF6")]
	[Token(Token = "0x60001FB")]
	public void Run()
	{
	}

	[Address(RVA = "0x86B920", Offset = "0x86A120", Length = "0x8E")]
	[Token(Token = "0x60001FC")]
	public void AddCoundDown(decimal value)
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x86BC00", Offset = "0x86A400", Length = "0x71")]
	public NodeInitController()
	{
	}
}
