//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class VisTargetTrigger : VisBaseTrigger
{
	[CompilerGenerated]
	private TriggeredDelegate Triggered; //Field offset: 0x50
	public List<GameObject> targetGameObjects; //Field offset: 0x58

	public event TriggeredDelegate Triggered
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public VisTargetTrigger() { }

	[CompilerGenerated]
	public void add_Triggered(TriggeredDelegate value) { }

	public void AddGameObject(GameObject gameObject) { }

	public void CreateAllDelegates() { }

	public void DestroyAllDelegates() { }

	public virtual void OnDestroy() { }

	public virtual void OnTriggered(float current, float previous, float difference, float adjustedDifference) { }

	[CompilerGenerated]
	public void remove_Triggered(TriggeredDelegate value) { }

	public void RemoveGameObject(GameObject gameObject) { }

	public virtual void Start() { }

	public virtual void Update() { }

}

