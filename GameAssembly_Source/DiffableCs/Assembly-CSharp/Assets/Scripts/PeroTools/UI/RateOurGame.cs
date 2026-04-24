namespace Assets.Scripts.PeroTools.UI;

public class RateOurGame
{
	private static bool m_IsInit; //Field offset: 0x2C927B4

	private static RateOurGame() { }

	public RateOurGame() { }

	public static string GetMuseDashStoreUrl(bool review = true) { }

	public static void Rate(string rateUrl, string title, string message, string rateButton, string postponeButton, string rejectButton = null, bool force = false) { }

}

