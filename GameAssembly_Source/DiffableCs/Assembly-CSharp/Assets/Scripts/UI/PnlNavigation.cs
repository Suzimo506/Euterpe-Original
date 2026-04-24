namespace Assets.Scripts.UI;

public class PnlNavigation : UISelectManage
{
	private static GameObject s_Shine; //Field offset: 0x0
	private static MenuType m_LastType; //Field offset: 0x8
	private static MenuType m_Type; //Field offset: 0xC
	[SerializeField]
	private Button m_BtnOption; //Field offset: 0x110
	[SerializeField]
	private Button m_BtnRole; //Field offset: 0x118
	[SerializeField]
	private Button m_BtnElfin; //Field offset: 0x120
	[SerializeField]
	private Button m_BtnTrove; //Field offset: 0x128
	[SerializeField]
	private Button m_BtnAchv; //Field offset: 0x130
	[SerializeField]
	private GameObject m_Shine; //Field offset: 0x138
	[SerializeField]
	private PnlMenu m_PnlMenu; //Field offset: 0x140

	private static PnlNavigation() { }

	public PnlNavigation() { }

	public static void ClearNewTip(MenuType menuType) { }

	public virtual bool IsThisUiManager() { }

	private void OnAchvClicked() { }

	public virtual void OnAwake() { }

	private void OnElfinClicked() { }

	private void OnOptionClicked() { }

	private void OnRoleClicked() { }

	private void OnTroveClicked() { }

	private void PlayClickSfx() { }

	public static void SetLastType(MenuType type) { }

	public static void UnlockNew(MenuType t) { }

}

