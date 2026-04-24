//Type is in global namespace

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class StageLikeToggle : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IInputKeyBinding
{
	[SerializeField]
	private string m_ButtonName; //Field offset: 0x18
	[SerializeField]
	private GameObject m_ImgLike; //Field offset: 0x20
	[SerializeField]
	private GameObject m_ImgHide; //Field offset: 0x28
	[SerializeField]
	private Image m_HoldImg; //Field offset: 0x30
	[SerializeField]
	private float m_HoldTime; //Field offset: 0x38
	private bool m_IsHide; //Field offset: 0x3C
	private bool m_IsCollection; //Field offset: 0x3D
	private bool m_IsClickHide; //Field offset: 0x3E
	private bool m_IsBeginHoldAnim; //Field offset: 0x3F
	private Button m_Button; //Field offset: 0x40
	private Effect m_ParTglLikes; //Field offset: 0x48
	private Effect m_ParTglDisLikes; //Field offset: 0x50
	private AbstractMessageBox m_HideMsg; //Field offset: 0x58
	private AbstractMessageBox m_CancelHideMsg; //Field offset: 0x60
	private bool m_IsPointDown; //Field offset: 0x68
	private float m_LongHoldTimer; //Field offset: 0x6C
	[CompilerGenerated]
	private Action<MusicInfo> onAddHide; //Field offset: 0x70
	[CompilerGenerated]
	private Action<MusicInfo> onRemoveHide; //Field offset: 0x78
	[CompilerGenerated]
	private Action<MusicInfo> onAddCollection; //Field offset: 0x80
	[CompilerGenerated]
	private Action<MusicInfo> onRemoveCollection; //Field offset: 0x88
	private UISelectManage m_UiManage; //Field offset: 0x90

	public event Action<MusicInfo> onAddCollection
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<MusicInfo> onAddHide
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<MusicInfo> onRemoveCollection
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<MusicInfo> onRemoveHide
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public override UISelectManage GetPanelOrder
	{
		 get { } //Length: 8
	}

	private bool isOn
	{
		private get { } //Length: 13
	}

	public override bool IsOnCurrentPanel
	{
		 get { } //Length: 149
	}

	private MusicInfo selectMusicInfo
	{
		private get { } //Length: 170
	}

	public StageLikeToggle() { }

	[CompilerGenerated]
	public void add_onAddCollection(Action<MusicInfo> value) { }

	[CompilerGenerated]
	public void add_onAddHide(Action<MusicInfo> value) { }

	[CompilerGenerated]
	public void add_onRemoveCollection(Action<MusicInfo> value) { }

	[CompilerGenerated]
	public void add_onRemoveHide(Action<MusicInfo> value) { }

	private void AddCollection() { }

	private void Awake() { }

	public override UISelectManage get_GetPanelOrder() { }

	private bool get_isOn() { }

	public override bool get_IsOnCurrentPanel() { }

	private MusicInfo get_selectMusicInfo() { }

	private void InitMsg() { }

	private void KeyPress() { }

	private void KeyUp() { }

	public void MusicChanged(MusicInfo mi) { }

	private void OnClicked(bool state) { }

	private void OnHideMsgClose() { }

	private void OnHideMsgShow() { }

	private void OnHideMusic() { }

	public override void OnPointerDown(PointerEventData data) { }

	public override void OnPointerUp(PointerEventData data) { }

	private void OnRemoveHideMusic() { }

	[CompilerGenerated]
	public void remove_onAddCollection(Action<MusicInfo> value) { }

	[CompilerGenerated]
	public void remove_onAddHide(Action<MusicInfo> value) { }

	[CompilerGenerated]
	public void remove_onRemoveCollection(Action<MusicInfo> value) { }

	[CompilerGenerated]
	public void remove_onRemoveHide(Action<MusicInfo> value) { }

	private void RemoveCollection() { }

	public override void SetPanelOrder(UISelectManage uiManage) { }

	private void Update() { }

	private void UpdateIcon() { }

}

