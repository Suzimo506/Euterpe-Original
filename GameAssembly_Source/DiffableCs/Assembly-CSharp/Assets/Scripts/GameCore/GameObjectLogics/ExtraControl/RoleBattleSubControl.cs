namespace Assets.Scripts.GameCore.GameObjectLogics.ExtraControl;

public class RoleBattleSubControl : MonoBehaviour, IRelease
{
	[SerializeField]
	protected Animator m_Animator; //Field offset: 0x18
	[SerializeField]
	protected SkeletonAnimation m_SkAnimator; //Field offset: 0x20
	[SerializeField]
	protected RuntimeAnimatorController m_NormalController; //Field offset: 0x28
	[SerializeField]
	protected RuntimeAnimatorController m_TouhouController; //Field offset: 0x30
	[SerializeField]
	private RoleType m_RoleType; //Field offset: 0x38

	public RoleBattleSubControl() { }

	private void FailHandler(bool isTouhou, bool girlIsAir) { }

	public override void Init() { }

	private void OnFail() { }

	public override void Release(bool isEditor) { }

}

