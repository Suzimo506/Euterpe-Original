using Assets.Scripts.PeroTools.PreWarm;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000A2")]
public class DisableFSVPreloadOnUnSupportASTCPlatform : MonoBehaviour, IPreWarm
{
	[Address(RVA = "0x99FBF0", Offset = "0x99E3F0", Length = "0x6D")]
	[Token(Token = "0x60004FF")]
	public void PreWarm(int slice)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000500")]
	public DisableFSVPreloadOnUnSupportASTCPlatform()
	{
	}
}
