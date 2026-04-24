namespace Assets.Scripts.PeroTools.UI;

public class BtnIAP : SerializedMonoBehaviour, IPreWarm
{
	private static string s_defaultUnlcokAllUid; //Field offset: 0x0
	private static bool s_Inited; //Field offset: 0x8
	private IAPType m_IapType; //Field offset: 0x58
	private string m_ProductId; //Field offset: 0x60

	public static string default_unlock_all
	{
		 get { } //Length: 169
	}

	public BtnIAP() { }

	public static string get_default_unlock_all() { }

	public override void PreWarm(int slice) { }

}

