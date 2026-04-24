//Type is in global namespace

public class ShopGoodsCell : MonoBehaviour
{
	public int index; //Field offset: 0x18
	private string m_Name; //Field offset: 0x20
	private string m_Link; //Field offset: 0x28
	private Image m_Img; //Field offset: 0x30
	[SerializeField]
	private LongSongNameController m_Txt; //Field offset: 0x38
	[SerializeField]
	private GameObject m_LoadingUi; //Field offset: 0x40
	private Button m_Btn; //Field offset: 0x48
	private Color m_EmptyColor; //Field offset: 0x50
	private ModuleGoods m_ModuleGoods; //Field offset: 0x60

	public ShopGoodsCell() { }

	[CompilerGenerated]
	private void <RefreshGoodsInfo>b__12_0(Texture2D tex) { }

	private void Awake() { }

	public void InitGoodsInfo(bool isEmpty = false) { }

	private void OnClickOpenUrl() { }

	public void RefreshGoodsInfo(ModuleGoods goods, int idx) { }

	public void SetEmpty() { }

}

