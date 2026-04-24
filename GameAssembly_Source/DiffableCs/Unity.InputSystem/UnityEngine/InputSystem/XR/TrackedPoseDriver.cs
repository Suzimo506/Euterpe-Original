namespace UnityEngine.InputSystem.XR;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class TrackedPoseDriver : MonoBehaviour, ISerializationCallbackReceiver
{
	internal enum TrackingType
	{
		RotationAndPosition = 0,
		RotationOnly = 1,
		PositionOnly = 2,
	}

	internal enum UpdateType
	{
		UpdateAndBeforeRender = 0,
		Update = 1,
		BeforeRender = 2,
	}

	[SerializeField]
	private TrackingType m_TrackingType; //Field offset: 0x18
	[SerializeField]
	private UpdateType m_UpdateType; //Field offset: 0x1C
	[SerializeField]
	private InputActionProperty m_PositionInput; //Field offset: 0x20
	[SerializeField]
	private InputActionProperty m_RotationInput; //Field offset: 0x38
	private Vector3 m_CurrentPosition; //Field offset: 0x50
	private Quaternion m_CurrentRotation; //Field offset: 0x5C
	private bool m_RotationBound; //Field offset: 0x6C
	private bool m_PositionBound; //Field offset: 0x6D
	[HideInInspector]
	[Obsolete]
	[SerializeField]
	private InputAction m_PositionAction; //Field offset: 0x70
	[HideInInspector]
	[Obsolete]
	[SerializeField]
	private InputAction m_RotationAction; //Field offset: 0x78
	[HideInInspector]
	[SerializeField]
	private bool m_HasMigratedActions; //Field offset: 0x80

	public InputAction positionAction
	{
		 get { } //Length: 11
		 set { } //Length: 152
	}

	public InputActionProperty positionInput
	{
		 get { } //Length: 21
		 set { } //Length: 111
	}

	public InputAction rotationAction
	{
		 get { } //Length: 11
		 set { } //Length: 152
	}

	public InputActionProperty rotationInput
	{
		 get { } //Length: 21
		 set { } //Length: 111
	}

	public TrackingType trackingType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public UpdateType updateType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public TrackedPoseDriver() { }

	protected override void Awake() { }

	private void BindActions() { }

	private void BindPosition() { }

	private void BindRotation() { }

	public InputAction get_positionAction() { }

	public InputActionProperty get_positionInput() { }

	public InputAction get_rotationAction() { }

	public InputActionProperty get_rotationInput() { }

	public TrackingType get_trackingType() { }

	public UpdateType get_updateType() { }

	private bool HasStereoCamera() { }

	protected override void OnBeforeRender() { }

	protected override void OnDestroy() { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	private void OnPositionCanceled(CallbackContext context) { }

	private void OnPositionPerformed(CallbackContext context) { }

	private void OnRotationCanceled(CallbackContext context) { }

	private void OnRotationPerformed(CallbackContext context) { }

	protected override void OnUpdate() { }

	protected override void PerformUpdate() { }

	protected void Reset() { }

	public void set_positionAction(InputAction value) { }

	public void set_positionInput(InputActionProperty value) { }

	public void set_rotationAction(InputAction value) { }

	public void set_rotationInput(InputActionProperty value) { }

	public void set_trackingType(TrackingType value) { }

	public void set_updateType(UpdateType value) { }

	protected override void SetLocalTransform(Vector3 newPosition, Quaternion newRotation) { }

	private void UnbindActions() { }

	private void UnbindPosition() { }

	private void UnbindRotation() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	protected void UpdateCallback() { }

}

