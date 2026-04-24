using System.Collections.Generic;
using Cpp2ILInjected;
using Spine.Unity;
using UnityEngine;

namespace Assets.Scripts.ReplaceTools;

[Token(Token = "0x20005A3")]
public class ReplaceSpine : AbstractReplace
{
	[Token(Token = "0x2000B9E")]
	public class ReplaceSpinePart
	{
		[Token(Token = "0x4003AC9")]
		[FieldOffset(Offset = "0x10")]
		public SkeletonDataAsset spineAsset;

		[Token(Token = "0x4003ACA")]
		[FieldOffset(Offset = "0x18")]
		public RuntimeAnimatorController animatorController;

		[Address(RVA = "0x6595D0", Offset = "0x657DD0", Length = "0xD1")]
		[Token(Token = "0x6005EE9")]
		public void Replace(SkeletonAnimation animation)
		{
		}

		[Address(RVA = "0x6594A0", Offset = "0x657CA0", Length = "0x125")]
		[Token(Token = "0x6005EEA")]
		public void Replace(SkeletonMecanim mecanim, Animator animator)
		{
		}

		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		[Token(Token = "0x6005EEB")]
		public ReplaceSpinePart()
		{
		}
	}

	[Token(Token = "0x40020FA")]
	[FieldOffset(Offset = "0x10")]
	public SpineType spineType;

	[Token(Token = "0x40020FB")]
	[FieldOffset(Offset = "0x18")]
	public SkeletonAnimation skeleton;

	[Token(Token = "0x40020FC")]
	[FieldOffset(Offset = "0x20")]
	public Animator animator;

	[Token(Token = "0x40020FD")]
	[FieldOffset(Offset = "0x28")]
	public SkeletonMecanim skeletonMecanim;

	[Token(Token = "0x40020FE")]
	[FieldOffset(Offset = "0x30")]
	public List<ReplaceSpinePart> parts;

	[Token(Token = "0x60038E6")]
	[Address(RVA = "0x6596B0", Offset = "0x657EB0", Length = "0x261")]
	public override void Replace(int index)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60038E7")]
	public ReplaceSpine()
	{
	}
}
