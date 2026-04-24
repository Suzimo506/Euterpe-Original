namespace Assets.Scripts.Graphics;

public class DynamicColor : SerializedMonoBehaviour
{
	[Variable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public IVariable source; //Field offset: 0x58
	[Space]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float timeLength; //Field offset: 0x60
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Gradient gradient; //Field offset: 0x68
	private float m_PassTime; //Field offset: 0x70

	public DynamicColor() { }

	private void Update() { }

}

