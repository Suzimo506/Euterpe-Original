namespace rail;

public class IRailInGameCoinImpl : RailObject, IRailInGameCoin
{

	internal IRailInGameCoinImpl(IntPtr cPtr) { }

	public override RailResult AsyncPurchaseCoins(RailCoins purchase_info, string user_data) { }

	public override RailResult AsyncRequestCoinInfo(string user_data) { }

	protected virtual void Finalize() { }

}

