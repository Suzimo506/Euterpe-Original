namespace Rewired.UI.ControlMapper;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ThemedElement : MonoBehaviour
{
	internal class ElementInfo
	{
		[SerializeField]
		private string _themeClass; //Field offset: 0x10
		[SerializeField]
		private Component _component; //Field offset: 0x18

		public Component component
		{
			 get { } //Length: 5
		}

		public string themeClass
		{
			 get { } //Length: 5
		}

		public ElementInfo() { }

		public Component get_component() { }

		public string get_themeClass() { }

	}

	[SerializeField]
	private ElementInfo[] _elements; //Field offset: 0x18

	public ThemedElement() { }

	private void Start() { }

}

