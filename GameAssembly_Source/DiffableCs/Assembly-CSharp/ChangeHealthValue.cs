//Type is in global namespace

public class ChangeHealthValue : MonoBehaviour
{
	public Text text; //Field offset: 0x18
	[SerializeField]
	private Image m_BackImage; //Field offset: 0x20
	[SerializeField]
	private AnimationCurve m_Curve; //Field offset: 0x28
	[SerializeField]
	private float m_Duration; //Field offset: 0x30
	private Slider m_Slider; //Field offset: 0x38
	private bool m_IsEvil; //Field offset: 0x40
	private Sequence m_Sequence; //Field offset: 0x48
	private Tweener m_HpTweener; //Field offset: 0x50
	private PeroString m_PeroString; //Field offset: 0x58

	public ChangeHealthValue() { }

	[CompilerGenerated]
	private float <OnFail>b__15_0() { }

	[CompilerGenerated]
	private void <OnFail>b__15_1(float x) { }

	[CompilerGenerated]
	private float <OnHpAdd>b__14_0() { }

	[CompilerGenerated]
	private void <OnHpAdd>b__14_1(float x) { }

	[CompilerGenerated]
	private float <OnHpRateChange>b__12_0() { }

	[CompilerGenerated]
	private void <OnHpRateChange>b__12_1(float x) { }

	private void Awake() { }

	private void OnDestroy() { }

	private void OnFail() { }

	private void OnGameStart(object sender, object rev, Object[] args) { }

	private void OnHpAdd(object sender, object reciever, Object[] args) { }

	private void OnHpDeduct(object sender, object reciever, Object[] args) { }

	private void OnHpRateChange(object sender, object reciever, Object[] args) { }

}

