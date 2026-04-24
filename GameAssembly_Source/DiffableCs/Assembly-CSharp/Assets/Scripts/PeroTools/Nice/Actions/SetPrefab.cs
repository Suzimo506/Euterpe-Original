namespace Assets.Scripts.PeroTools.Nice.Actions;

public class SetPrefab : Action
{
	[SerializeField]
	private bool m_IsPro; //Field offset: 0x10
	[SerializeField]
	private IVariable m_Prefab; //Field offset: 0x18
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Count; //Field offset: 0x20
	[SerializeField]
	private Transform m_Transform; //Field offset: 0x28
	private List<GameObject> m_GameObjects; //Field offset: 0x30

	public SetPrefab() { }

	[CompilerGenerated]
	private void <Execute>b__5_0() { }

	public virtual void Execute() { }

}

