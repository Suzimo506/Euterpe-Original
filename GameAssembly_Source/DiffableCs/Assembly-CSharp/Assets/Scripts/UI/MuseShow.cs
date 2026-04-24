namespace Assets.Scripts.UI;

public class MuseShow : MonoBehaviour
{
	private int m_Index; //Field offset: 0x18
	private GameObject m_MuseShow; //Field offset: 0x20
	private CharacterApply m_CharacterApply; //Field offset: 0x28
	[SerializeField]
	private CharacterExpression m_Expression; //Field offset: 0x30
	private bool m_Inited; //Field offset: 0x38

	public CharacterApply apply
	{
		 get { } //Length: 5
	}

	public MuseShow() { }

	public CharacterApply get_apply() { }

	public void Init() { }

	private void OnEnable() { }

}

