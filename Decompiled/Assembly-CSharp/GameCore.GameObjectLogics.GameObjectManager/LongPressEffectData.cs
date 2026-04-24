using Cpp2ILInjected;
using Spine.Unity;

namespace GameCore.GameObjectLogics.GameObjectManager;

[Token(Token = "0x2000475")]
internal struct LongPressEffectData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001818")]
	public bool isVfxOn;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001819")]
	public SkeletonAnimation vfx;
}
