namespace Assets.Scripts.UI.Specials;

public class EnableDisableHooker : MonoBehaviour
{
	[CompilerGenerated]
	private UnityAction<GameObject, Boolean> onEnable; //Field offset: 0x18
	[CompilerGenerated]
	private UnityAction<GameObject, Boolean> onDisable; //Field offset: 0x20

	public event UnityAction<GameObject, Boolean> onDisable
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event UnityAction<GameObject, Boolean> onEnable
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 342
	}

	public EnableDisableHooker() { }

	[CompilerGenerated]
	public void add_onDisable(UnityAction<GameObject, Boolean> value) { }

	[CompilerGenerated]
	public void add_onEnable(UnityAction<GameObject, Boolean> value) { }

	private void OnDisable() { }

	private void OnEnable() { }

	[CompilerGenerated]
	public void remove_onDisable(UnityAction<GameObject, Boolean> value) { }

	[CompilerGenerated]
	public void remove_onEnable(UnityAction<GameObject, Boolean> value) { }

}

