using Cpp2ILInjected;
using Spine.Unity;
using UnityEngine;

[Token(Token = "0x200002C")]
public class DancerVictoryShowHandLayerController : MonoBehaviour
{
	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0x18")]
	private SkeletonAnimation m_SklAnimation;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000CF")]
	private Renderer m_SklAnimationRenderer;

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x46D020", Offset = "0x46B820", Length = "0x65")]
	private void Awake()
	{
	}

	[Address(RVA = "0x46D090", Offset = "0x46B890", Length = "0x20")]
	[Token(Token = "0x6000108")]
	private void Start()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x46D0C0", Offset = "0x46B8C0", Length = "0x63")]
	private void Update()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public DancerVictoryShowHandLayerController()
	{
	}
}
