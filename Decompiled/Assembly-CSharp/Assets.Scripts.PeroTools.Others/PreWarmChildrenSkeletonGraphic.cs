using Assets.Scripts.PeroTools.PreWarm;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Others;

[Token(Token = "0x20005C1")]
public class PreWarmChildrenSkeletonGraphic : MonoBehaviour, IPreWarm
{
	[Address(RVA = "0x9819A0", Offset = "0x9801A0", Length = "0x98")]
	[Token(Token = "0x600398C")]
	public void PreWarm(int slice)
	{
	}

	[Token(Token = "0x600398D")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PreWarmChildrenSkeletonGraphic()
	{
	}
}
