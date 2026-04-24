using Assets.Scripts.PeroTools.PreWarm;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Common;

[Token(Token = "0x200097D")]
public class GameMainGraphicSetting : MonoBehaviour, IPreWarm
{
	[Token(Token = "0x6005672")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void PreWarm(int slice)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6005673")]
	public GameMainGraphicSetting()
	{
	}
}
