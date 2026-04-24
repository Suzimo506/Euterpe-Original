//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class VisTargetModifier : VisBaseModifier
{
	[CompilerGenerated]
	private ValueUpdatedDelegate ValueUpdated; //Field offset: 0x38
	public List<GameObject> targetGameObjects; //Field offset: 0x40

	public event ValueUpdatedDelegate ValueUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public VisTargetModifier() { }

	[CompilerGenerated]
	public void add_ValueUpdated(ValueUpdatedDelegate value) { }

	public void AddGameObject(GameObject gameObject) { }

	public void CreateAllDelegates() { }

	public void DestroyAllDelegates() { }

	public virtual void OnDestroy() { }

	public virtual void OnValueUpdated(float current, float previous, float difference, float adjustedDifference) { }

	[CompilerGenerated]
	public void remove_ValueUpdated(ValueUpdatedDelegate value) { }

	public void RemoveGameObject(GameObject gameObject) { }

	public virtual void Start() { }

}

