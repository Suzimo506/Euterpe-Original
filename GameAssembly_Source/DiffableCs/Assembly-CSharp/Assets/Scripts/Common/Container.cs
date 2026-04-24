namespace Assets.Scripts.Common;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class Container : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public string key; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal bool <get_Item>b__0(Component c) { }

	}

	[SerializeField]
	private Component[] components; //Field offset: 0x18

	public Component Item
	{
		 get { } //Length: 175
	}

	public Container() { }

	public Component get_Item(string key) { }

}

