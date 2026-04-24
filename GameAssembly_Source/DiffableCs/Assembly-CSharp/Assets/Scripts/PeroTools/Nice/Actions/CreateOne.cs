namespace Assets.Scripts.PeroTools.Nice.Actions;

public class CreateOne : Action
{
	[SerializeField]
	private bool m_IsPro; //Field offset: 0x10
	[SerializeField]
	private object m_List; //Field offset: 0x18
	[SerializeField]
	private string m_JsonKey; //Field offset: 0x20
	[HideInInspector]
	[SerializeField]
	private List<String> m_ObjectNames; //Field offset: 0x28
	[HideInInspector]
	[SerializeField]
	private GameObject m_GameObject; //Field offset: 0x30
	[HideInInspector]
	[SerializeField]
	private string m_Path; //Field offset: 0x38
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Index; //Field offset: 0x40
	[SerializeField]
	private int m_Preload; //Field offset: 0x48
	[SerializeField]
	private int m_Capacity; //Field offset: 0x4C
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Position; //Field offset: 0x50
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Rotation; //Field offset: 0x58
	[HideInInspector]
	public GameObject rootGameObject; //Field offset: 0x60
	private GameObject m_CreatedGameObject; //Field offset: 0x68
	private Effect m_Effect; //Field offset: 0x70
	private List<String> m_JsonKeys; //Field offset: 0x78

	public int count
	{
		 get { } //Length: 60
	}

	public CreateOne() { }

	public virtual void Enter() { }

	public virtual void Execute() { }

	public virtual void Exit() { }

	public int get_count() { }

	private void OnJsonKeyChanged(string value) { }

	public void OnListChanged() { }

	public virtual void Pause() { }

	public virtual void Resume() { }

	public void SetIndex(int index) { }

}

