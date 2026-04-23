using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;
using Spine.Unity;

namespace PeroTools.GeneralLocalization.Modles;

[Attribute(Name = "SourcePathAttribute", RVA = "0x370C0", Offset = "0x364C0")]
[Token(Token = "0x2000458")]
public class SpineSkeletonGraphicSource : SourceGeneric<SkeletonGraphic>
{
	[Token(Token = "0x6003288")]
	[Address(RVA = "0x505240", Offset = "0x503A40", Length = "0x42")]
	protected override SkeletonGraphic DefaultSource(Localization localiation)
	{
		return null;
	}

	[Token(Token = "0x6003289")]
	[Address(RVA = "0x505290", Offset = "0x503A90", Length = "0x38")]
	public SpineSkeletonGraphicSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
