namespace PeroTools2.Commons;

[DisallowMultipleComponent]
public class IBindingHook : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public ValueDelegate valueDelegate; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal void <RefreshBinding>g__OnVariableChanged|0(IVariable var) { }

	}

	private IBinding[] m_Binding; //Field offset: 0x18
	private Dictionary<String, Action`1<IVariable>> m_VariableActions; //Field offset: 0x20

	public IBindingHook() { }

	private void Awake() { }

	private void OnDestroy() { }

	private void RefreshBinding(bool add) { }

}

