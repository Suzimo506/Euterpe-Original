using Assets.Scripts.PeroTools.PreWarm;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.GameCore;

[Token(Token = "0x20006F8")]
public class GameInit : MonoBehaviour, IPreWarm
{
	[Token(Token = "0x400257D")]
	private static bool m_FirstInited;

	[Token(Token = "0x60041AE")]
	[Address(RVA = "0x49C970", Offset = "0x49B170", Length = "0x3A")]
	private void FirstInit()
	{
	}

	[Token(Token = "0x60041AF")]
	[Address(RVA = "0x49C7E0", Offset = "0x49AFE0", Length = "0x18E")]
	private void Awake()
	{
	}

	[Address(RVA = "0x49CA00", Offset = "0x49B200", Length = "0x187")]
	[Token(Token = "0x60041B0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60041B1")]
	[Address(RVA = "0x49C9B0", Offset = "0x49B1B0", Length = "0x4F")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60041B2")]
	[Address(RVA = "0x49CC10", Offset = "0x49B410", Length = "0x93E")]
	private void SpecialLogic()
	{
	}

	[Token(Token = "0x60041B3")]
	[Address(RVA = "0x49CB90", Offset = "0x49B390", Length = "0x7D")]
	public void PreWarm(int slice)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60041B4")]
	public GameInit()
	{
	}
}
