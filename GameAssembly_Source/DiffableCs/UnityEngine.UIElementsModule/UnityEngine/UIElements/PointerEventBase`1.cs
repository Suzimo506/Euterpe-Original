namespace UnityEngine.UIElements;

public abstract class PointerEventBase : EventBase<T>, IPointerEvent, IPointerEventInternal
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int <pointerId>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private EventModifiers <modifiers>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Vector2 <radiusVariance>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Vector2 <radius>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float <twist>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float <azimuthAngle>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float <altitudeAngle>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float <tangentialPressure>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float <pressure>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int <clickCount>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float <deltaTime>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Vector3 <deltaPosition>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Vector3 <localPosition>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Vector3 <position>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int <pressedButtons>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int <button>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <isPrimary>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string <pointerType>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <UnityEngine.UIElements.IPointerEventInternal.triggeredByOS>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool <UnityEngine.UIElements.IPointerEventInternal.recomputeTopElementUnderPointer>k__BackingField; //Field offset: 0x0

	public override float altitudeAngle
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public override float azimuthAngle
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public override int button
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override int clickCount
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public internal virtual IEventHandler currentTarget
	{
		 get { } //Length: 25
		internal set { } //Length: 385
	}

	public override Vector3 deltaPosition
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 22
	}

	public override float deltaTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public override bool isPrimary
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override Vector3 localPosition
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 22
	}

	public override EventModifiers modifiers
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override int pointerId
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override string pointerType
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public override Vector3 position
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 22
	}

	public override int pressedButtons
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override float pressure
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public override Vector2 radius
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override Vector2 radiusVariance
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override float tangentialPressure
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public override float twist
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	private override bool UnityEngine.UIElements.IPointerEventInternal.recomputeTopElementUnderPointer
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private override bool UnityEngine.UIElements.IPointerEventInternal.triggeredByOS
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	protected PointerEventBase`1() { }

	[CompilerGenerated]
	public override float get_altitudeAngle() { }

	[CompilerGenerated]
	public override float get_azimuthAngle() { }

	[CompilerGenerated]
	public override int get_button() { }

	[CompilerGenerated]
	public override int get_clickCount() { }

	public virtual IEventHandler get_currentTarget() { }

	[CompilerGenerated]
	public override Vector3 get_deltaPosition() { }

	[CompilerGenerated]
	public override float get_deltaTime() { }

	[CompilerGenerated]
	public override bool get_isPrimary() { }

	[CompilerGenerated]
	public override Vector3 get_localPosition() { }

	[CompilerGenerated]
	public override EventModifiers get_modifiers() { }

	[CompilerGenerated]
	public override int get_pointerId() { }

	[CompilerGenerated]
	public override string get_pointerType() { }

	[CompilerGenerated]
	public override Vector3 get_position() { }

	[CompilerGenerated]
	public override int get_pressedButtons() { }

	[CompilerGenerated]
	public override float get_pressure() { }

	[CompilerGenerated]
	public override Vector2 get_radius() { }

	[CompilerGenerated]
	public override Vector2 get_radiusVariance() { }

	[CompilerGenerated]
	public override float get_tangentialPressure() { }

	[CompilerGenerated]
	public override float get_twist() { }

	public static T GetPooled(IPointerEvent triggerEvent) { }

	internal static T GetPooled(IPointerEvent triggerEvent, Vector2 position, int pointerId) { }

	public static T GetPooled(Event systemEvent) { }

	protected virtual void Init() { }

	private static bool IsMouse(Event systemEvent) { }

	private void LocalInit() { }

	protected private virtual void PostDispatch(IPanel panel) { }

	protected private virtual void PreDispatch(IPanel panel) { }

	[CompilerGenerated]
	protected void set_altitudeAngle(float value) { }

	[CompilerGenerated]
	protected void set_azimuthAngle(float value) { }

	[CompilerGenerated]
	protected void set_button(int value) { }

	[CompilerGenerated]
	protected void set_clickCount(int value) { }

	internal virtual void set_currentTarget(IEventHandler value) { }

	[CompilerGenerated]
	protected void set_deltaPosition(Vector3 value) { }

	[CompilerGenerated]
	protected void set_deltaTime(float value) { }

	[CompilerGenerated]
	protected void set_isPrimary(bool value) { }

	[CompilerGenerated]
	protected void set_localPosition(Vector3 value) { }

	[CompilerGenerated]
	protected void set_modifiers(EventModifiers value) { }

	[CompilerGenerated]
	protected void set_pointerId(int value) { }

	[CompilerGenerated]
	protected void set_pointerType(string value) { }

	[CompilerGenerated]
	protected void set_position(Vector3 value) { }

	[CompilerGenerated]
	protected void set_pressedButtons(int value) { }

	[CompilerGenerated]
	protected void set_pressure(float value) { }

	[CompilerGenerated]
	protected void set_radius(Vector2 value) { }

	[CompilerGenerated]
	protected void set_radiusVariance(Vector2 value) { }

	[CompilerGenerated]
	protected void set_tangentialPressure(float value) { }

	[CompilerGenerated]
	protected void set_twist(float value) { }

	[CompilerGenerated]
	private override bool UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer() { }

	[CompilerGenerated]
	private override bool UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS() { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer(bool value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(bool value) { }

}

