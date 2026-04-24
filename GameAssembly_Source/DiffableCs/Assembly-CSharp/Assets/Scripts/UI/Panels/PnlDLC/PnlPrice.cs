namespace Assets.Scripts.UI.Panels.PnlDLC;

public class PnlPrice
{
	private class PriceText
	{
		private GameObject m_GameObject; //Field offset: 0x10
		private Text m_Current; //Field offset: 0x18
		private Text m_Discount; //Field offset: 0x20
		private Text m_CountDown; //Field offset: 0x28

		public PriceText(GameObject obj, Text discount, Text countDown) { }

	}

	private PriceText m_PriceText; //Field offset: 0x10
	private PriceText m_PriceTextCountDown; //Field offset: 0x18
	private bool m_OnDiscount; //Field offset: 0x20
	private DateTime m_EndTime; //Field offset: 0x28
	private Looper m_Looper; //Field offset: 0x30
	private Action m_OnCountDownComplete; //Field offset: 0x38

	public PnlPrice(GameObject price, GameObject priceCountdown, Text discount, Text countDown) { }

}

