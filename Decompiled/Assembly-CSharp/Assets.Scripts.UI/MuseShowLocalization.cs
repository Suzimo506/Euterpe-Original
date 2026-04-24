using Assets.Scripts.PeroTools.PreWarm;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI;

[Token(Token = "0x2000826")]
public class MuseShowLocalization : MonoBehaviour, IPreWarm
{
	[Token(Token = "0x4002A76")]
	[FieldOffset(Offset = "0x18")]
	public MuseShow Res16_9;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002A77")]
	public MuseShow Res4_3;

	[Address(RVA = "0x6C2400", Offset = "0x6C0C00", Length = "0xB1")]
	[Token(Token = "0x6004B1C")]
	public void PreWarm(int slice)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6004B1D")]
	public MuseShowLocalization()
	{
	}
}
