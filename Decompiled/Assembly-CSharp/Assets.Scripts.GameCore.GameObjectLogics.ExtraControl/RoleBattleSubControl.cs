using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;
using Spine.Unity;
using UnityEngine;

namespace Assets.Scripts.GameCore.GameObjectLogics.ExtraControl;

[Token(Token = "0x200076E")]
public class RoleBattleSubControl : MonoBehaviour, IRelease
{
	[Token(Token = "0x4002759")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected Animator m_Animator;

	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400275A")]
	protected SkeletonAnimation m_SkAnimator;

	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400275B")]
	protected RuntimeAnimatorController m_NormalController;

	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400275C")]
	protected RuntimeAnimatorController m_TouhouController;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400275D")]
	[SerializeField]
	private RoleType m_RoleType;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400275E")]
	protected SpineActionController m_ActionController;

	[Address(RVA = "0x4A41A0", Offset = "0x4A29A0", Length = "0x1AB")]
	[Token(Token = "0x60045A5")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x60045A6")]
	[Address(RVA = "0x4A4520", Offset = "0x4A2D20", Length = "0x9D")]
	public virtual void Release(bool isEditor)
	{
	}

	[Address(RVA = "0x4A4350", Offset = "0x4A2B50", Length = "0x1C5")]
	[Token(Token = "0x60045A7")]
	protected void OnFail()
	{
	}

	[Address(RVA = "0x4A40F0", Offset = "0x4A28F0", Length = "0xA1")]
	[Token(Token = "0x60045A8")]
	private void FailHandler(bool isTouhou, bool girlIsAir)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60045A9")]
	public RoleBattleSubControl()
	{
	}
}
