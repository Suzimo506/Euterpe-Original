namespace Assets.Scripts.Graphics;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ChangeMaterialColor : MonoBehaviour
{
	public string propertyName; //Field offset: 0x18
	private Material m_Mtr; //Field offset: 0x20

	public Color color
	{
		 get { } //Length: 58
		 set { } //Length: 51
	}

	public ChangeMaterialColor() { }

	private void Awake() { }

	public Color get_color() { }

	public void set_color(Color value) { }

}

