namespace Assets.Scripts.GameCore.Managers;

public class ShopModule
{
	public string module_name; //Field offset: 0x10
	public ModuleLayout module_type; //Field offset: 0x18
	public List<ModuleGoods> goods; //Field offset: 0x20

	public ShopModule() { }

	public bool HasShopGoods(string language) { }

	public void Init() { }

}

