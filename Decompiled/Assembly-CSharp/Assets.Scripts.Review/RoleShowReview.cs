using Cpp2ILInjected;
using Spine.Unity;
using UnityEngine;

namespace Assets.Scripts.Review;

[Token(Token = "0x20006EA")]
public class RoleShowReview : MonoBehaviour
{
	[Token(Token = "0x4002512")]
	[FieldOffset(Offset = "0x18")]
	public RoleShowType roleShowType;

	[Token(Token = "0x4002513")]
	[FieldOffset(Offset = "0x20")]
	public SkeletonRenderer skeletonRenderer;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002514")]
	public Animator animator;

	[Token(Token = "0x4002515")]
	[FieldOffset(Offset = "0x30")]
	public RuntimeAnimatorController reviewController;

	[Token(Token = "0x4002516")]
	[FieldOffset(Offset = "0x38")]
	public SkeletonGraphic skeletonGraphic;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002517")]
	public string startingAnimation;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002518")]
	public SkeletonDataAsset reviewDataAsset;

	[Token(Token = "0x600415D")]
	[Address(RVA = "0x65AB90", Offset = "0x659390", Length = "0xBF")]
	private void Start()
	{
	}

	[Token(Token = "0x600415E")]
	[Address(RVA = "0x65AA10", Offset = "0x659210", Length = "0x172")]
	private void ReviewReplace()
	{
	}

	[Token(Token = "0x600415F")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public RoleShowReview()
	{
	}
}
