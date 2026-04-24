//Type is in global namespace

public class AnchorModeTxt : MonoBehaviour, IInitialization
{
	private Transform m_Trans; //Field offset: 0x18
	[SerializeField]
	private GameObject m_Child; //Field offset: 0x20
	private Dictionary<String, Vector2> m_AnchorTxtOffset; //Field offset: 0x28

	public AnchorModeTxt() { }

	public override void Destroy() { }

	public void OnAnchorModeChanged(object sender, object reciever, Object[] args) { }

	public override void OnAwake() { }

	private void OnSceneChanged(Scene preScene, Scene curScene) { }

	public void OnSetPosition(object sender, object reciever, Object[] args) { }

	public override void OnStart() { }

	private void SetOffset(string offsetName) { }

	private void SetScale(string scaleName) { }

}

