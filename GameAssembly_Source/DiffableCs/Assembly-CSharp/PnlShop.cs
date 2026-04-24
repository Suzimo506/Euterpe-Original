//Type is in global namespace

public class PnlShop : MonoBehaviour, IPreWarm, IRelease
{
	private static PnlShop m_Instance; //Field offset: 0x0
	public GameObject itemGoods1Objs; //Field offset: 0x18
	public GameObject itemGoods2Objs; //Field offset: 0x20
	public GameObject itemGoods3Objs; //Field offset: 0x28
	public GameObject itemGoods4Objs; //Field offset: 0x30
	public Dictionary<Int32, FastPool> moduleObjs; //Field offset: 0x38
	public Transform moduleTrans; //Field offset: 0x40
	[SerializeField]
	private GameObject m_LoadingAnim; //Field offset: 0x48
	[SerializeField]
	private CanvasGroup m_ShopViewPort; //Field offset: 0x50
	[SerializeField]
	private CanvasGroup m_ScorllViewRaycast; //Field offset: 0x58
	[SerializeField]
	private CanvasGroup m_ScorllBar; //Field offset: 0x60
	private bool m_Dirty; //Field offset: 0x68

	internal static PnlShop Instance
	{
		internal get { } //Length: 53
	}

	public PnlShop() { }

	[CompilerGenerated]
	private bool <Awake>b__13_0() { }

	[CompilerGenerated]
	private bool <OnEnable>b__20_0() { }

	private void AsyncEnable() { }

	private void Awake() { }

	private void FastAllDestroy() { }

	internal static PnlShop get_Instance() { }

	private ShopModuleCell GetNewCell(int key) { }

	private void OnDestroy() { }

	private void OnEnable() { }

	private void OnLanguageChanged(int languageIndex) { }

	private void OnOpenShop(object sender, object reciever, Object[] args) { }

	public override void PreWarm(int slice) { }

	private void PrewarmInit() { }

	private void RefreshShopUI() { }

	public override void Release(bool isEditor) { }

}

