//Type is in global namespace

public class SpineAnimationTest : MonoBehaviour
{
	[SerializeField]
	[SpineAnimation(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string animName; //Field offset: 0x18
	private SkeletonAnimation m_SkeletonAnimation; //Field offset: 0x20
	private float m_AnimPlayTime; //Field offset: 0x28
	private float m_curPlayTime; //Field offset: 0x2C
	private bool m_IsTrigger; //Field offset: 0x30
	private bool m_IsTriggerTime1; //Field offset: 0x31
	private bool m_IsTriggerTime2; //Field offset: 0x32

	public SpineAnimationTest() { }

	private void OnCarryOnAnim() { }

	private void OnGUI() { }

	private void OnPauseAinm() { }

	private void OnStopAnim() { }

	private void Start() { }

	private void Update() { }

}

