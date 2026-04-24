namespace Rewired.Integration.UnityUI;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class RewiredEventSystem : EventSystem
{
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _alwaysUpdate; //Field offset: 0x50

	public bool alwaysUpdate
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public RewiredEventSystem() { }

	public bool get_alwaysUpdate() { }

	public void set_alwaysUpdate(bool value) { }

	protected virtual void Update() { }

}

