//Type is in global namespace

public class AttacksController : MonoBehaviour
{
	internal enum KeyAudioType
	{
		Hit = 0,
		Touch = 1,
		Others = 2,
		Bass = 3,
		KeyAudioTypeCount = 4,
	}

	public const int FAIL_PLAY_IDX1 = -1; //Field offset: 0x0
	public const int FAIL_PLAY_IDX2 = -2; //Field offset: 0x0
	private static AttacksController instance; //Field offset: 0x0
	[SerializeField]
	public AttackEffectManager attackAttackEffectManager; //Field offset: 0x18
	private DBOther m_DbOther; //Field offset: 0x20
	public AudioSource curHitAs; //Field offset: 0x28
	public AudioSource curTouchAs; //Field offset: 0x30
	public AudioSource curLAs; //Field offset: 0x38
	public AudioSource curBassAs; //Field offset: 0x40
	public bool showAttackAnim; //Field offset: 0x48

	public static AttacksController Instance
	{
		 get { } //Length: 182
	}

	private static AttacksController() { }

	public AttacksController() { }

	public static AttacksController get_Instance() { }

	private void OnDestroy() { }

	public void OnShowAttack(int idx, uint result) { }

	private void PlayAttackAnim(int id, bool isContinue, uint result) { }

	public void PlayJumpAnim() { }

	public void PlayOneShot(string keyAudio, KeyAudioType audioType) { }

	public void ShowAttack(int id, uint resultCode, uint actionType, bool isContinue = false) { }

	private void ShowAttackEffect(int id, uint resultCode, bool isContinue) { }

	private void Start() { }

}

