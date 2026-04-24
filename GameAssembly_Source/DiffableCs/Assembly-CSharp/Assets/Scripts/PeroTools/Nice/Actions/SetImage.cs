namespace Assets.Scripts.PeroTools.Nice.Actions;

public class SetImage : Action
{
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_Object; //Field offset: 0x10
	[OnConstanceChanged(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IVariable m_ImageSource; //Field offset: 0x18
	[HideInInspector]
	[SerializeField]
	private string m_Path; //Field offset: 0x20
	[HideInInspector]
	[SerializeField]
	private List<String> m_TextureNames; //Field offset: 0x28

	public SetImage() { }

	public virtual void Enter() { }

	public virtual void Execute() { }

	private void OnImageSourceChanged() { }

}

