namespace Rewired;

[Browsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[CustomClassObfuscation]
[EditorBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class Initializer : MonoBehaviour
{
	[SerializeField]
	private GameObject _inputManagerPrefab; //Field offset: 0x18
	[SerializeField]
	private bool _destroySelf; //Field offset: 0x20

	public bool destroySelf
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public GameObject inputManagerPrefab
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public Initializer() { }

	private void Awake() { }

	public bool get_destroySelf() { }

	public GameObject get_inputManagerPrefab() { }

	public bool Initialize() { }

	public void set_destroySelf(bool value) { }

	public void set_inputManagerPrefab(GameObject value) { }

}

