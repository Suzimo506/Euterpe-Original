//Type is in global namespace

internal class MonoBehaviourCallbackHooks : ComponentSingleton<MonoBehaviourCallbackHooks>
{
	internal Action<Single> m_OnUpdateDelegate; //Field offset: 0x18

	public event Action<Single> OnUpdateDelegate
	{
		 add { } //Length: 118
		 remove { } //Length: 118
	}

	public MonoBehaviourCallbackHooks() { }

	public void add_OnUpdateDelegate(Action<Single> value) { }

	protected virtual string GetGameObjectName() { }

	public void remove_OnUpdateDelegate(Action<Single> value) { }

	internal void Update() { }

}

