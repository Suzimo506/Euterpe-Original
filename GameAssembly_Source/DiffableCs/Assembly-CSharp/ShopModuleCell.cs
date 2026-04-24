//Type is in global namespace

public class ShopModuleCell : MonoBehaviour, IFastPoolItem
{
	public ShopGoodsCell[] cells; //Field offset: 0x18
	private ShopModule m_Module; //Field offset: 0x20
	private PnlShop m_Parent; //Field offset: 0x28

	private ModuleLayout type
	{
		private get { } //Length: 14
	}

	public ShopModuleCell() { }

	private ModuleLayout get_type() { }

	private void InitCellsInfo() { }

	public override void OnFastDestroy() { }

	public override void OnFastInstantiate() { }

	public void RefreshCellsInfo(ShopModule module, PnlShop parent) { }

}

