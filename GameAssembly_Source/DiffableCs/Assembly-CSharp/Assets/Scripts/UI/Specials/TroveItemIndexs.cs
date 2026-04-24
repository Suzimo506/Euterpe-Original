namespace Assets.Scripts.UI.Specials;

[Obsolete]
public class TroveItemIndexs : MonoBehaviour, IPreWarm
{
	private List<VariableBehaviour> m_Variables; //Field offset: 0x18
	public GameObject itemPrefab; //Field offset: 0x20
	public Transform parent; //Field offset: 0x28

	public TroveItemIndexs() { }

	private int CheckMissCount() { }

	public override void PreWarm(int slice) { }

	private void RefreshIndexs() { }

}

