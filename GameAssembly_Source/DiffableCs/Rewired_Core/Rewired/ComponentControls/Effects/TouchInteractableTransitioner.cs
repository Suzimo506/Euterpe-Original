namespace Rewired.ComponentControls.Effects;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DisallowMultipleComponent]
[ExecuteInEditMode]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class TouchInteractableTransitioner : MonoBehaviour, IInteractionStateTransitionHandler, IVisibilityChangedHandler
{
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _visible; //Field offset: 0x18
	[Bitmask(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private TransitionTypeFlags _transitionType; //Field offset: 0x1C
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ColorBlock _transitionColorTint; //Field offset: 0x20
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private SpriteState _transitionSpriteState; //Field offset: 0x78
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private AnimationTriggers _transitionAnimationTriggers; //Field offset: 0x98
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Graphic _targetGraphic; //Field offset: 0xA0
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _syncFadeDurationWithTransitionEvent; //Field offset: 0xA8
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _syncColorTintWithTransitionEvent; //Field offset: 0xA9
	private InteractionState CJziXPdfnqAFhzmIKDybdzrcFiSvA; //Field offset: 0xAC

	public Animator animator
	{
		 get { } //Length: 76
	}

	public Image image
	{
		 get { } //Length: 128
		 set { } //Length: 187
	}

	public bool syncColorTintWithTransitionEvent
	{
		 get { } //Length: 8
		 set { } //Length: 78
	}

	public bool syncFadeDurationWithTransitionEvent
	{
		 get { } //Length: 8
		 set { } //Length: 78
	}

	public Graphic targetGraphic
	{
		 get { } //Length: 8
		 set { } //Length: 187
	}

	public AnimationTriggers transitionAnimationTriggers
	{
		 get { } //Length: 8
		 set { } //Length: 84
	}

	public ColorBlock transitionColorTint
	{
		 get { } //Length: 53
		 set { } //Length: 93
	}

	public SpriteState transitionSpriteState
	{
		 get { } //Length: 22
		 set { } //Length: 140
	}

	public TransitionTypeFlags transitionType
	{
		 get { } //Length: 4
		 set { } //Length: 72
	}

	public bool visible
	{
		 get { } //Length: 5
		 set { } //Length: 72
	}

	[CustomObfuscation]
	private TouchInteractableTransitioner() { }

	[CustomObfuscation]
	private void Awake() { }

	private void bYgwHRgUjtLYntbMRrgSJBSzemFG() { }

	private void FReFAoqYPBBeQrIMxInPfuGiMlLAb() { }

	public Animator get_animator() { }

	public Image get_image() { }

	public bool get_syncColorTintWithTransitionEvent() { }

	public bool get_syncFadeDurationWithTransitionEvent() { }

	public Graphic get_targetGraphic() { }

	public AnimationTriggers get_transitionAnimationTriggers() { }

	public ColorBlock get_transitionColorTint() { }

	public SpriteState get_transitionSpriteState() { }

	public TransitionTypeFlags get_transitionType() { }

	public bool get_visible() { }

	private void GGUFBODifwtqRTAdHQHNIcUblmBKc() { }

	private void gucsiAihJsCrBLFlYNplMhgFxLgT(Color unnamed_param_0, bool unnamed_param_1) { }

	private bool HSLxjpoiOtDyPbeLDGZpKozEJbgA() { }

	private void nePsvHCeJujOSxThkoKWhRUoMRLV(Sprite unnamed_param_0) { }

	[CustomObfuscation]
	private void OnAnimationPropertiesWereApplied() { }

	[CustomObfuscation]
	private void OnCanvasGroupWasChanged() { }

	[CustomObfuscation]
	private void OnDisable() { }

	[CustomObfuscation]
	private void OnEnable() { }

	public override void OnInteractionStateTransition(InteractionStateTransitionArgs args) { }

	[CustomObfuscation]
	private void OnValidate() { }

	public override void OnVisibilityChanged(bool state) { }

	[CustomObfuscation]
	private void Reset() { }

	public void set_image(Image value) { }

	public void set_syncColorTintWithTransitionEvent(bool value) { }

	public void set_syncFadeDurationWithTransitionEvent(bool value) { }

	public void set_targetGraphic(Graphic value) { }

	public void set_transitionAnimationTriggers(AnimationTriggers value) { }

	public void set_transitionColorTint(ColorBlock value) { }

	public void set_transitionSpriteState(SpriteState value) { }

	public void set_transitionType(TransitionTypeFlags value) { }

	public void set_visible(bool value) { }

	private void sjtLxatrqjQlHIQjXNvMfTDxkhPW(string unnamed_param_0) { }

	private void uuDVEIsWkYOTGoAphuigxalCoeQo(bool unnamed_param_0, bool unnamed_param_1) { }

	private void wxrMHGTAyGmAKzhuQHHkRQNtaeRG(InteractionState unnamed_param_0, bool unnamed_param_1) { }

	private void XnzGVkpEunZfFEtEzrWuBUQYwbCc(bool unnamed_param_0) { }

}

