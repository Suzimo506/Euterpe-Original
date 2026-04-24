namespace Assets.Scripts.UI.Panels.PnlDLC;

[ExecuteInEditMode]
public class PnlDlcQAFormat : MonoBehaviour
{
	private Text m_Text; //Field offset: 0x18
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[TextArea]
	private string m_English; //Field offset: 0x20
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[TextArea]
	private string m_ChineseS; //Field offset: 0x28
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[TextArea]
	private string m_ChineseT; //Field offset: 0x30
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[TextArea]
	private string m_Japanese; //Field offset: 0x38
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[TextArea]
	private string m_Korean; //Field offset: 0x40
	private Dictionary<String, String> m_ReplaceDict; //Field offset: 0x48
	private Dictionary<String, String> m_Language; //Field offset: 0x50

	public PnlDlcQAFormat() { }

	private void Awake() { }

	private string CharacterCount() { }

	private string ElfinCount() { }

	private string InterludeCount() { }

	private void OnEnable() { }

	private string SongCount() { }

	private string WelcomeCount() { }

}

