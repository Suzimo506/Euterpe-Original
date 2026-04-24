namespace Assets.Scripts.GameCore.GameObjectLogics.GameObjectManager;

public class AttackEffects : IPause
{
	public string eventType; //Field offset: 0x10
	public bool isPro; //Field offset: 0x18
	private Effect m_Effect; //Field offset: 0x20
	public GameObject normal; //Field offset: 0x28
	public GameObject gc; //Field offset: 0x30
	public GameObject touhouBlack; //Field offset: 0x38
	public GameObject djMax; //Field offset: 0x40
	public int preload; //Field offset: 0x48
	public int capacity; //Field offset: 0x4C
	public Vector3 position; //Field offset: 0x50
	public Vector3 rotation; //Field offset: 0x5C

	public override bool IsGlobal
	{
		 get { } //Length: 3
	}

	public AttackEffects() { }

	public override bool get_IsGlobal() { }

	public void Init() { }

	public void Invoke(object sender, object rev, Object[] pars) { }

	public override void Pause(bool pauseCorountine) { }

	public void Release() { }

	public override void Resume() { }

}

