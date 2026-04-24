namespace Assets.Scripts.ReplaceTools;

public class ReplaceTools : SerializedMonoBehaviour
{
	public const int bad_apple = 0; //Field offset: 0x0
	public bool AwakeInit; //Field offset: 0x58
	[SerializeField]
	private AbstractReplace[] m_Replaces; //Field offset: 0x60

	public ReplaceTools() { }

	private void Awake() { }

	public void Replace(int index) { }

}

