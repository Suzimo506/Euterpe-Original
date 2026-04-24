using Cpp2ILInjected;
using Spine.Unity;
using UnityEngine;

namespace Assets.Scripts.UI.Specials;

[Token(Token = "0x2000874")]
public class ElfinBetaDogAnimHandle : MonoBehaviour
{
	[Token(Token = "0x4002C2C")]
	private const string m_PlayMainShowStandby = "main_show_standby";

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002C2D")]
	private SkeletonGraphic mSkeletonGraphic;

	[Token(Token = "0x6004D30")]
	[Address(RVA = "0x60F3C0", Offset = "0x60DBC0", Length = "0xE3")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004D31")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public ElfinBetaDogAnimHandle()
	{
	}
}
