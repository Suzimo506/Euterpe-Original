namespace Rewired.ComponentControls;

[DisallowMultipleComponent]
[ExecuteInEditMode]
public abstract class TouchInteractable : TouchControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	internal interface IInteractionStateTransitionHandler
	{

		public void OnInteractionStateTransition(InteractionStateTransitionArgs data) { }

	}

	internal enum InteractionState
	{
		Normal = 0,
		Highlighted = 1,
		Pressed = 2,
		Disabled = 3,
	}

	internal class InteractionStateTransitionArgs
	{
		private TouchInteractable xLJfCpiTHsExhmMaMgIGWSDstdOmA; //Field offset: 0x10
		private InteractionState LWHFVhdvZYeCRjHTxAFuJgrCbGAv; //Field offset: 0x18
		private float kYZaPAzdpNBURStaeFZUEIBBbPzx; //Field offset: 0x1C

		public float duration
		{
			 get { } //Length: 6
		}

		public TouchInteractable sender
		{
			 get { } //Length: 5
		}

		public InteractionState state
		{
			 get { } //Length: 4
		}

		internal InteractionStateTransitionArgs() { }

		public float get_duration() { }

		public TouchInteractable get_sender() { }

		public InteractionState get_state() { }

		internal void LhOHkUrFtwRUrsbQgaaTfeNGmmPB(TouchInteractable unnamed_param_0, InteractionState unnamed_param_1, float unnamed_param_2) { }

	}

	internal class InteractionStateTransitionEventHandler : UnityEvent<InteractionStateTransitionArgs>
	{

		public InteractionStateTransitionEventHandler() { }

	}

	[Flags]
	internal enum MouseButtonFlags
	{
		None = 0,
		LeftButton = 1,
		RightButton = 2,
		MiddleButton = 4,
		AnyButton = -1,
	}

	[Flags]
	internal enum TransitionTypeFlags
	{
		None = 0,
		ColorTint = 1,
		SpriteSwap = 2,
		Animation = 4,
	}

	internal class VisibilityChangedEventHandler : UnityEvent<Boolean>
	{

		public VisibilityChangedEventHandler() { }

	}

	[CompilerGenerated]
	private sealed class vjEGOHFmLHPHJhpuLeoaJNyfSLKcB
	{
		public static readonly vjEGOHFmLHPHJhpuLeoaJNyfSLKcB <>9; //Field offset: 0x0
		public static EventFunction<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> <>9__152_0; //Field offset: 0x8

		private static vjEGOHFmLHPHJhpuLeoaJNyfSLKcB() { }

		public vjEGOHFmLHPHJhpuLeoaJNyfSLKcB() { }

		internal void jcehQYLpteGrcKFySwfpOzkXUVaaA(IInteractionStateTransitionHandler unnamed_param_0, InteractionStateTransitionArgs unnamed_param_1) { }

	}

	public const int POINTER_ID_NULL = -2147483648; //Field offset: 0x0
	public const int POINTER_ID_MOUSE_LEFT_BUTTON = -1; //Field offset: 0x0
	public const int POINTER_ID_MOUSE_RIGHT_BUTTON = -2; //Field offset: 0x0
	public const int POINTER_ID_MOUSE_MIDDLE_BUTTON = -3; //Field offset: 0x0
	internal const int MAX_MOUSE_BUTTONS = 3; //Field offset: 0x0
	private static InteractionStateTransitionArgs _transitionArgs; //Field offset: 0x0
	private static EventFunction<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> __interactionStateTransitionHandlerDelegate; //Field offset: 0x8
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _interactable; //Field offset: 0x38
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _visible; //Field offset: 0x39
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _hideWhenIdle; //Field offset: 0x3A
	[Bitmask(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private MouseButtonFlags _allowedMouseButtons; //Field offset: 0x3C
	[Bitmask(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private TransitionTypeFlags _transitionType; //Field offset: 0x40
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ColorBlock _transitionColorTint; //Field offset: 0x44
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private SpriteState _transitionSpriteState; //Field offset: 0xA0
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private AnimationTriggers _transitionAnimationTriggers; //Field offset: 0xC0
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Graphic _targetGraphic; //Field offset: 0xC8
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private InteractionStateTransitionEventHandler _onInteractionStateTransition; //Field offset: 0xD0
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private VisibilityChangedEventHandler _onVisibilityChanged; //Field offset: 0xD8
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private UnityEvent _onInteractionStateChangedToNormal; //Field offset: 0xE0
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private UnityEvent _onInteractionStateChangedToHighlighted; //Field offset: 0xE8
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private UnityEvent _onInteractionStateChangedToPressed; //Field offset: 0xF0
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private UnityEvent _onInteractionStateChangedToDisabled; //Field offset: 0xF8
	private readonly List<CanvasGroup> _canvasGroupCache; //Field offset: 0x100
	private bool _groupsAllowInteraction; //Field offset: 0x108
	private InteractionState _interactionState; //Field offset: 0x10C
	private bool gTLwGImOoZuPWcDofNJbHqzbgTvp; //Field offset: 0x110
	private bool DuJcSUBjODzIYmtFcaHJBSqEkpNCB; //Field offset: 0x111
	private bool _varWatch_visible; //Field offset: 0x112
	private bool _varWatch_interactable; //Field offset: 0x113
	private bool _allowSendingEvents; //Field offset: 0x114
	private HierarchyEventHelper<IVisibilityChangedHandler, Boolean> __hierarchyVisibilityChangedHandlers; //Field offset: 0x118
	private HierarchyEventHelper<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> __hierarchyInteractionStateTransitionHandlers; //Field offset: 0x120

	public event UnityAction InteractionStateChangedToDisabled
	{
		 add { } //Length: 33
		 remove { } //Length: 33
	}

	public event UnityAction InteractionStateChangedToHighlighted
	{
		 add { } //Length: 33
		 remove { } //Length: 33
	}

	public event UnityAction InteractionStateChangedToNormal
	{
		 add { } //Length: 33
		 remove { } //Length: 33
	}

	public event UnityAction InteractionStateChangedToPressed
	{
		 add { } //Length: 33
		 remove { } //Length: 33
	}

	public event UnityAction<InteractionStateTransitionArgs> InteractionStateSetEvent
	{
		 add { } //Length: 85
		 remove { } //Length: 85
	}

	public event UnityAction<Boolean> VisibilityChangedEvent
	{
		 add { } //Length: 85
		 remove { } //Length: 85
	}

	public MouseButtonFlags allowedMouseButtons
	{
		 get { } //Length: 4
		 set { } //Length: 26
	}

	public Animator animator
	{
		 get { } //Length: 76
	}

	internal static EventFunction<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> fGeaISJlLjRSCiOaZdWhdoluRHiWA
	{
		internal get { } //Length: 412
	}

	public bool hideWhenIdle
	{
		 get { } //Length: 5
		 set { } //Length: 26
	}

	private HierarchyEventHelper<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> ijnkEUAJMwLlVROIEePpERSciekjb
	{
		private get { } //Length: 593
	}

	public Image image
	{
		 get { } //Length: 128
		 set { } //Length: 170
	}

	public bool interactable
	{
		 get { } //Length: 5
		 set { } //Length: 26
	}

	public InteractionState interactionState
	{
		 get { } //Length: 7
	}

	public Graphic targetGraphic
	{
		 get { } //Length: 8
		 set { } //Length: 170
	}

	public AnimationTriggers transitionAnimationTriggers
	{
		 get { } //Length: 8
		 set { } //Length: 60
	}

	public ColorBlock transitionColorTint
	{
		 get { } //Length: 59
		 set { } //Length: 72
	}

	public SpriteState transitionSpriteState
	{
		 get { } //Length: 25
		 set { } //Length: 132
	}

	public TransitionTypeFlags transitionType
	{
		 get { } //Length: 4
		 set { } //Length: 26
	}

	public bool visible
	{
		 get { } //Length: 5
		 set { } //Length: 181
	}

	private HierarchyEventHelper<IVisibilityChangedHandler, Boolean> zuQcsSdowJuVERrllZBVwycRDqQRA
	{
		private get { } //Length: 200
	}

	private static TouchInteractable() { }

	[CustomObfuscation]
	internal TouchInteractable() { }

	public void add_InteractionStateChangedToDisabled(UnityAction value) { }

	public void add_InteractionStateChangedToHighlighted(UnityAction value) { }

	public void add_InteractionStateChangedToNormal(UnityAction value) { }

	public void add_InteractionStateChangedToPressed(UnityAction value) { }

	public void add_InteractionStateSetEvent(UnityAction<InteractionStateTransitionArgs> value) { }

	public void add_VisibilityChangedEvent(UnityAction<Boolean> value) { }

	[CustomObfuscation]
	internal virtual void Awake() { }

	private void bYgwHRgUjtLYntbMRrgSJBSzemFG() { }

	private void FReFAoqYPBBeQrIMxInPfuGiMlLAb() { }

	public MouseButtonFlags get_allowedMouseButtons() { }

	public Animator get_animator() { }

	public bool get_hideWhenIdle() { }

	public Image get_image() { }

	public bool get_interactable() { }

	public InteractionState get_interactionState() { }

	public Graphic get_targetGraphic() { }

	public AnimationTriggers get_transitionAnimationTriggers() { }

	public ColorBlock get_transitionColorTint() { }

	public SpriteState get_transitionSpriteState() { }

	public TransitionTypeFlags get_transitionType() { }

	public bool get_visible() { }

	internal virtual void GGUFBODifwtqRTAdHQHNIcUblmBKc() { }

	private void GmEUEsqliwjYNcOOCXltjCsshxBR() { }

	private void gucsiAihJsCrBLFlYNplMhgFxLgT(Color unnamed_param_0, bool unnamed_param_1) { }

	private void GwNNPbynGEwRllaEOxYxWNOTIYbF() { }

	private bool hgmVSucPPhCpteVksvxZmBzRbWdgb(bool unnamed_param_0, GameObject unnamed_param_1) { }

	private bool hgmVSucPPhCpteVksvxZmBzRbWdgb(BaseEventData unnamed_param_0) { }

	private static bool hUlXyzSWnwMWxhSnZStJVqlqRkwm(MouseButtonFlags unnamed_param_0, int unnamed_param_1) { }

	private HierarchyEventHelper<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> IdMiCKWRuabzsHyhQIkxWaOCbKMeb() { }

	public bool IsInteractable() { }

	internal override bool isWdyIkfRtppWEidkYkMlNEXluNI() { }

	internal static bool JnoTCbJMEybIWwksINGjaukvVpnm(MouseButtonFlags unnamed_param_0, int unnamed_param_1) { }

	internal static bool JnoTCbJMEybIWwksINGjaukvVpnm(int unnamed_param_0, MouseButtonFlags unnamed_param_1, EventTriggerType unnamed_param_2) { }

	internal void JuJCZiYCZCosKFhXDwYbHBJlaAEhA(BaseEventData unnamed_param_0) { }

	internal static bool KMCrTzPfpzPZyDVBvIJREdZxSGTM(MouseButtonFlags unnamed_param_0) { }

	internal static EventFunction<IInteractionStateTransitionHandler, InteractionStateTransitionArgs> KptKmUhQJdohuXgTROhSvsKAUili() { }

	private HierarchyEventHelper<IVisibilityChangedHandler, Boolean> kzyaiImrlSIrXEAOKFlKggetGfKXA() { }

	internal virtual void LxKjvdrXOBGicmmuPDIRYDKodYgm() { }

	internal static bool mRqZxQKFTnXeAHgaxTupPSeKNZjC(int unnamed_param_0) { }

	private void nePsvHCeJujOSxThkoKWhRUoMRLV(Sprite unnamed_param_0) { }

	private void nRDPCeDgrMVPTYcnBkLizhxSdaCg() { }

	internal override void OnBeginDrag(PointerEventData eventData) { }

	[CustomObfuscation]
	internal virtual void OnCanvasGroupChanged() { }

	[CustomObfuscation]
	internal virtual void OnDidApplyAnimationProperties() { }

	[CustomObfuscation]
	internal virtual void OnDisable() { }

	internal override void OnDrag(PointerEventData eventData) { }

	[CustomObfuscation]
	internal virtual void OnEnable() { }

	internal override void OnEndDrag(PointerEventData eventData) { }

	internal override void OnPointerDown(PointerEventData eventData) { }

	internal override void OnPointerEnter(PointerEventData eventData) { }

	internal override void OnPointerExit(PointerEventData eventData) { }

	internal override void OnPointerUp(PointerEventData eventData) { }

	[CustomObfuscation]
	internal virtual void OnValidate() { }

	internal static bool pQqwthMsLwRaXpYsULGaySxZcZIEA(int unnamed_param_0) { }

	[CompilerGenerated]
	private void qHuNerFXPZtwGCBkKhZvdOSVOKsh(bool unnamed_param_0) { }

	private bool qVAgwpAsjjqeZHJicORqJBdMfxwIc(InteractionState unnamed_param_0) { }

	public void remove_InteractionStateChangedToDisabled(UnityAction value) { }

	public void remove_InteractionStateChangedToHighlighted(UnityAction value) { }

	public void remove_InteractionStateChangedToNormal(UnityAction value) { }

	public void remove_InteractionStateChangedToPressed(UnityAction value) { }

	public void remove_InteractionStateSetEvent(UnityAction<InteractionStateTransitionArgs> value) { }

	public void remove_VisibilityChangedEvent(UnityAction<Boolean> value) { }

	[CustomObfuscation]
	internal virtual void Reset() { }

	public void set_allowedMouseButtons(MouseButtonFlags value) { }

	public void set_hideWhenIdle(bool value) { }

	public void set_image(Image value) { }

	public void set_interactable(bool value) { }

	public void set_targetGraphic(Graphic value) { }

	public void set_transitionAnimationTriggers(AnimationTriggers value) { }

	public void set_transitionColorTint(ColorBlock value) { }

	public void set_transitionSpriteState(SpriteState value) { }

	public void set_transitionType(TransitionTypeFlags value) { }

	public void set_visible(bool value) { }

	private void sjtLxatrqjQlHIQjXNvMfTDxkhPW(string unnamed_param_0) { }

	internal static Vector3 SzMSUfLKHllvMCDPPbazECpkgtvV(int unnamed_param_0) { }

	private override void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IDragHandler.OnDrag(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

	private void uuDVEIsWkYOTGoAphuigxalCoeQo(bool unnamed_param_0, bool unnamed_param_1) { }

	internal override bool vegXsJqHqSwpTTYKNnVEnmAxixoK(GameObject unnamed_param_0) { }

	internal static bool vfFGgSvuGtXZBZWgQDwXSRlvmCRS(int unnamed_param_0) { }

	private static int VXALQNcmrsRCspPSBuBXzChMUSGc(int unnamed_param_0) { }

	private void WMSTkgPfCDksiRxBTrJYdIdgbrVkA() { }

	private void wxrMHGTAyGmAKzhuQHHkRQNtaeRG(InteractionState unnamed_param_0, bool unnamed_param_1) { }

	private void XnzGVkpEunZfFEtEzrWuBUQYwbCc(bool unnamed_param_0) { }

	private static int YGKYXmXtLhQALYkMoJCxYrIhuazy(int unnamed_param_0) { }

	internal static bool YiAEVLoQhMrCsdtoUMJiFWaZzxfg(MouseButtonFlags unnamed_param_0, out int unnamed_param_1) { }

	private InteractionState YjQHgMLnhbvREwpDOnGPAtEoNuBX(BaseEventData unnamed_param_0) { }

	private void zFlSvnlOPsgpzHGWLhtuQetLpUdx() { }

}

