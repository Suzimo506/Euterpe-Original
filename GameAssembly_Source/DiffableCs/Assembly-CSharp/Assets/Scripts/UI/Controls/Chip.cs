namespace Assets.Scripts.UI.Controls;

public class Chip : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public string uid; //Field offset: 0x10
		public Chip <>4__this; //Field offset: 0x18
		public ParticleSystem ps; //Field offset: 0x20
		public List<IData> items; //Field offset: 0x28
		public UnityAction<Single> <>9__2; //Field offset: 0x30

		public <>c__DisplayClass14_0() { }

		internal void <OnDisable>b__0() { }

		internal bool <OnDisable>b__1() { }

		internal void <OnDisable>b__2(float t) { }

	}

	private static int m_DoneCount; //Field offset: 0x0
	public Text chipTxt; //Field offset: 0x18
	public Text chipCountText; //Field offset: 0x20
	public Transform character; //Field offset: 0x28
	public Transform elfin; //Field offset: 0x30
	public Transform trove; //Field offset: 0x38
	public Transform parent; //Field offset: 0x40
	public GameObject image; //Field offset: 0x48
	public particleHoming particleHoming; //Field offset: 0x50
	private Particle m_Particle; //Field offset: 0x58
	private GameObject m_GameObject; //Field offset: 0xE0
	private bool m_InvokeEvent; //Field offset: 0xE8

	public Chip() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void SetEnable(bool enable) { }

}

