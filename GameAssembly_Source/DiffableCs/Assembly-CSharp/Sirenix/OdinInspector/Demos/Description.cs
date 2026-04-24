namespace Sirenix.OdinInspector.Demos;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class Description : SerializedMonoBehaviour
{
	[Multiline]
	[Space]
	public string WideMultilineTextField; //Field offset: 0x58

	public Description() { }

}

