using Cpp2ILInjected;
using Spine.Unity;

namespace Assets.Scripts.ReplaceTools;

[Token(Token = "0x20005A1")]
public class ReplaceSkeletonCustomMaterials : AbstractReplace
{
	[Token(Token = "0x40020F5")]
	[FieldOffset(Offset = "0x10")]
	public SkeletonRendererCustomMaterials skeletonCustomMaterials;

	[Token(Token = "0x40020F6")]
	[FieldOffset(Offset = "0x18")]
	public bool enable;

	[Token(Token = "0x60038E4")]
	[Address(RVA = "0x659470", Offset = "0x657C70", Length = "0x25")]
	public override void Replace(int index)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60038E5")]
	public ReplaceSkeletonCustomMaterials()
	{
	}
}
