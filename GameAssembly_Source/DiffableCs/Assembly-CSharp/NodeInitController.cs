//Type is in global namespace

public class NodeInitController : MonoBehaviour
{
	private int idx; //Field offset: 0x18
	private decimal countdown; //Field offset: 0x1C
	private SpineActionController m_Sac; //Field offset: 0x30
	private MeshRenderer m_MeshRenderer; //Field offset: 0x38
	private Animator m_Animator; //Field offset: 0x40

	public NodeInitController() { }

	public void AddCoundDown(decimal value) { }

	public void InitWithoutRun(int index) { }

	public void Run() { }

}

