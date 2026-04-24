namespace Assets.Scripts.GameCore.Managers;

public class ShopManager : Singleton<ShopManager>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public ShopManager <>4__this; //Field offset: 0x10
		public Action<Boolean> callback; //Field offset: 0x18

		public <>c__DisplayClass13_0() { }

		internal void <GetShopEnable>b__0(DownloadHandler h) { }

	}

	internal enum ModuleLayout
	{
		None = 0,
		One = 1,
		VSplit = 2,
		VTrisection = 3,
		AntitheticalCouplet = 4,
		Count = 5,
	}

	public List<ShopModule> shopGoods; //Field offset: 0x10
	[CompilerGenerated]
	private bool <shopEnable>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <goodsInited>k__BackingField; //Field offset: 0x19

	public int curGoodsCount
	{
		 get { } //Length: 59
	}

	public private bool goodsInited
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool shopEnable
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public ShopManager() { }

	[CompilerGenerated]
	private void <GetShopData>b__12_0(bool enable) { }

	[CompilerGenerated]
	private void <GetShopGoodData>b__14_0(DownloadHandler h) { }

	public int get_curGoodsCount() { }

	[CompilerGenerated]
	public bool get_goodsInited() { }

	[CompilerGenerated]
	public bool get_shopEnable() { }

	public void GetShopData() { }

	private void GetShopEnable(Action<Boolean> callback) { }

	public void GetShopGoodData() { }

	public bool HasShopGoods(string language) { }

	[CompilerGenerated]
	private void set_goodsInited(bool value) { }

	[CompilerGenerated]
	private void set_shopEnable(bool value) { }

}

