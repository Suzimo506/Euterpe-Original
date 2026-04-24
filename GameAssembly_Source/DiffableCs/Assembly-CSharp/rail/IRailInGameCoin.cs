namespace rail;

public interface IRailInGameCoin
{

	public RailResult AsyncPurchaseCoins(RailCoins purchase_info, string user_data) { }

	public RailResult AsyncRequestCoinInfo(string user_data) { }

}

