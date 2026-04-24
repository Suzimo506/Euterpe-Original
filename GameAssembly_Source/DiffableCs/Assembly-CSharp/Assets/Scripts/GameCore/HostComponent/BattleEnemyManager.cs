namespace Assets.Scripts.GameCore.HostComponent;

public class BattleEnemyManager : Singleton<BattleEnemyManager>
{
	private int m_CurrentGenIdx; //Field offset: 0x10
	private Int32[] m_Hp; //Field offset: 0x18
	private Byte[] m_Evaluates; //Field offset: 0x20
	private Boolean[] m_LeftRight; //Field offset: 0x28
	public bool isAirPressing; //Field offset: 0x30
	public bool isGroundPressing; //Field offset: 0x31
	public bool isCharacterGroundHitting; //Field offset: 0x32
	public bool isCharacterAirHitting; //Field offset: 0x33
	public bool isGhostHitting; //Field offset: 0x34
	public bool isGhostOnAir; //Field offset: 0x35
	public bool isMulHitting; //Field offset: 0x36
	public float damageRatio; //Field offset: 0x38

	public BattleEnemyManager() { }

	public void AddHp(int idx, int value) { }

	public void CreateBattleEnemy(int idx) { }

	private void CreateObj(int idx, bool isVisible = true) { }

	public int GetCurrentGenIdx() { }

	public int GetDamageValueByIndex(int idx) { }

	public string GetHitEffectByIdx(int idx) { }

	public string GetNodeAudioByIdx(int idx) { }

	public string GetNodeUidByIdx(int idx) { }

	public byte GetPlayResult(int idx) { }

	public void Init() { }

	public bool IsDead(int idx) { }

	public bool IsPlayLeft(int idx) { }

	private void ObjInit(GameObject obj, int idx, bool isVisible) { }

	public void PreloadCreateBattleEnemy() { }

	public static void ReleaseReferences() { }

	public void SetLongPressEffect(bool isTo, bool isAir = false, bool isForce = false) { }

	public void SetPlayResult(int idx, byte result, bool isMulStart = false, bool isMulEnd = false, bool isLeft = false) { }

}

