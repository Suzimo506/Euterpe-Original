using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;
using Spine.Unity;
using UnityEngine;

namespace GameCore.GameObjectLogics.GameObjectControl.MutiGirlController;

[Token(Token = "0x200048E")]
public class MultiGirlStateController : MonoBehaviour, IPause
{
	[Token(Token = "0x400189D")]
	[FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x170004BA")]
	public bool IsGlobal
	{
		[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
		[Token(Token = "0x6003429")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003425")]
	[Address(RVA = "0x847220", Offset = "0x845A20", Length = "0x47")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003426")]
	[Address(RVA = "0x847270", Offset = "0x845A70", Length = "0x7")]
	public void Init()
	{
	}

	[Address(RVA = "0x847780", Offset = "0x845F80", Length = "0x7E")]
	[Token(Token = "0x6003427")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x6003428")]
	[Address(RVA = "0x847D00", Offset = "0x846500", Length = "0x7E")]
	public void Resume()
	{
	}

	[Token(Token = "0x600342A")]
	[Address(RVA = "0x847830", Offset = "0x846030", Length = "0x4C3")]
	private void RegistEvents()
	{
	}

	[Address(RVA = "0x848D20", Offset = "0x847520", Length = "0x1AF")]
	[Token(Token = "0x600342B")]
	private void UnRegistEvents()
	{
	}

	[Address(RVA = "0x847670", Offset = "0x845E70", Length = "0x104")]
	[Token(Token = "0x600342C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600342D")]
	[Address(RVA = "0x848C60", Offset = "0x847460", Length = "0x53")]
	private void StateMultiHitEnd()
	{
	}

	[Token(Token = "0x600342E")]
	[Address(RVA = "0x848CC0", Offset = "0x8474C0", Length = "0x53")]
	private void StateMultiHits(int hitCounts)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x600342F")]
	private void StateDead()
	{
	}

	[Token(Token = "0x6003430")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void StateAfterHurt()
	{
	}

	[Token(Token = "0x6003431")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void StateHurt()
	{
	}

	[Token(Token = "0x6003432")]
	[Address(RVA = "0x8484C0", Offset = "0x846CC0", Length = "0x53")]
	private void StateComeOut()
	{
	}

	[Address(RVA = "0x8488C0", Offset = "0x8470C0", Length = "0x395")]
	[Token(Token = "0x6003433")]
	private void StateLongPress(bool isPress, bool isAir)
	{
	}

	[Address(RVA = "0x848630", Offset = "0x846E30", Length = "0x53")]
	[Token(Token = "0x6003434")]
	private void StateDoubleAttack()
	{
	}

	[Address(RVA = "0x8487B0", Offset = "0x846FB0", Length = "0x10D")]
	[Token(Token = "0x6003435")]
	private void StateHurtChange(SkeletonAnimation sa)
	{
	}

	[Token(Token = "0x6003436")]
	[Address(RVA = "0x848520", Offset = "0x846D20", Length = "0x10D")]
	private void StateDeadChange(SkeletonAnimation sa)
	{
	}

	[Token(Token = "0x6003437")]
	[Address(RVA = "0x847D80", Offset = "0x846580", Length = "0x734")]
	private void StateAttack(string actKey, uint noteResult, int noteIdx = -1)
	{
	}

	[Token(Token = "0x6003438")]
	[Address(RVA = "0x848690", Offset = "0x846E90", Length = "0x118")]
	private void StateEmptyAttack(string actionKey)
	{
	}

	[Token(Token = "0x6003439")]
	[Address(RVA = "0x847800", Offset = "0x846000", Length = "0x24")]
	private void PlayAnimatorState(string actionKey, int layer = 0, float duration = 0f)
	{
	}

	[Token(Token = "0x600343A")]
	[Address(RVA = "0x847280", Offset = "0x845A80", Length = "0x3E4")]
	private string JumpAttack(string atkName, uint result, int id = -1)
	{
		return null;
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600343B")]
	public MultiGirlStateController()
	{
	}
}
