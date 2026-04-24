//Type is in global namespace

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class NonBreakingSpaceText : MonoBehaviour
{
	private const string NonBreakingSpace = "�"; //Field offset: 0x0
	private Text txt; //Field offset: 0x18

	public NonBreakingSpaceText() { }

	private void Awake() { }

	private void OnTextChange() { }

}

