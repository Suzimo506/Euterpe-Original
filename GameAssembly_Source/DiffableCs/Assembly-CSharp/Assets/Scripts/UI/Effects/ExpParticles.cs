namespace Assets.Scripts.UI.Effects;

public class ExpParticles : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<IData> <>9__17_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <OnEnable>b__17_0(IData d) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public bool isRate; //Field offset: 0x10
		public ExpParticles <>4__this; //Field offset: 0x18

		public <>c__DisplayClass18_0() { }

		internal void <LateUpdate>b__0() { }

	}

	public float expRate; //Field offset: 0x18
	public Transform target; //Field offset: 0x20
	private ParticleSystem m_System; //Field offset: 0x28
	private Particle[] m_Particles; //Field offset: 0x30
	private IVariable m_ExpVariable; //Field offset: 0x38
	private IVariable m_ExpCount; //Field offset: 0x40
	private IVariable m_Level; //Field offset: 0x48
	private IVariable m_ExpPercent; //Field offset: 0x50
	private List<IData> m_Messages; //Field offset: 0x58
	private IData m_Message; //Field offset: 0x60
	private int m_Num; //Field offset: 0x68
	private float m_Sum; //Field offset: 0x6C
	private RectTransform m_TargeTransform; //Field offset: 0x70
	private float m_X; //Field offset: 0x78
	private bool m_IsLevelUp; //Field offset: 0x7C

	public ExpParticles() { }

	private void Awake() { }

	private void InitializeIfNeeded() { }

	private void LateUpdate() { }

	private void OnDisable() { }

	private void OnEnable() { }

}

