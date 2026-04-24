namespace Rewired.ComponentControls;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DisallowMultipleComponent]
public sealed class TiltControl : CustomControllerControl
{
	internal enum TiltDirection
	{
		Both = 0,
		Horizontal = 1,
		Forward = 2,
	}

	private const float maxFullTiltAngle = 180; //Field offset: 0x0
	private const float maxAngleOffset = 90; //Field offset: 0x0
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private TiltDirection _allowedTiltDirections; //Field offset: 0x28
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private CustomControllerElementTargetSetForFloat _horizontalTiltCustomControllerElement; //Field offset: 0x30
	[CustomObfuscation]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _horizontalTiltLimit; //Field offset: 0x38
	[CustomObfuscation]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _horizontalRestAngle; //Field offset: 0x3C
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private CustomControllerElementTargetSetForFloat _forwardTiltCustomControllerElement; //Field offset: 0x40
	[CustomObfuscation]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _forwardTiltLimit; //Field offset: 0x48
	[CustomObfuscation]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _forwardRestAngle; //Field offset: 0x4C
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private StandaloneAxis2D _axis2D; //Field offset: 0x50
	private bool _useHAxis; //Field offset: 0x58
	private bool _useFAxis; //Field offset: 0x59
	private Func<Vector3> _getAccelerationValue; //Field offset: 0x60

	public TiltDirection axesToUse
	{
		 get { } //Length: 4
		 set { } //Length: 53
	}

	public Axis2DCalibration axis2DCalibration
	{
		 get { } //Length: 27
	}

	[Obsolete]
	public Axis2DCalibration deadZoneType
	{
		 get { } //Length: 27
	}

	public float forwardRestAngle
	{
		 get { } //Length: 6
		 set { } //Length: 84
	}

	public CustomControllerElementTargetSetForFloat forwardTiltCustomControllerElement
	{
		 get { } //Length: 5
	}

	public float forwardTiltLimit
	{
		 get { } //Length: 6
		 set { } //Length: 79
	}

	public AxisCalibration horizontalAxisCalibration
	{
		 get { } //Length: 36
	}

	public float horizontalRestAngle
	{
		 get { } //Length: 6
		 set { } //Length: 84
	}

	public CustomControllerElementTargetSetForFloat horizontalTiltCustomControllerElement
	{
		 get { } //Length: 5
	}

	public float horizontalTiltLimit
	{
		 get { } //Length: 6
		 set { } //Length: 79
	}

	internal StandaloneAxis2D LlDFiyIJVUyABvwjMsCOsrYCZsvm
	{
		internal get { } //Length: 5
	}

	private Vector3 tBlwZivxUPySeDNQYoRsRsjxKBPI
	{
		private get { } //Length: 114
	}

	public AxisCalibration verticalAxisCalibration
	{
		 get { } //Length: 36
	}

	[CustomObfuscation]
	internal TiltControl() { }

	public virtual void ClearValue() { }

	private void ENxWccdTDmVYCWlIzWTNHNhyGmUFA() { }

	internal StandaloneAxis2D ftMLbfHKEsePTZnHqhpEdmLCCbbeb() { }

	public TiltDirection get_axesToUse() { }

	public Axis2DCalibration get_axis2DCalibration() { }

	public Axis2DCalibration get_deadZoneType() { }

	public float get_forwardRestAngle() { }

	public CustomControllerElementTargetSetForFloat get_forwardTiltCustomControllerElement() { }

	public float get_forwardTiltLimit() { }

	public AxisCalibration get_horizontalAxisCalibration() { }

	public float get_horizontalRestAngle() { }

	public CustomControllerElementTargetSetForFloat get_horizontalTiltCustomControllerElement() { }

	public float get_horizontalTiltLimit() { }

	public AxisCalibration get_verticalAxisCalibration() { }

	internal virtual void gqXZxvvVhElvIzeezXrWFzPcCqCs() { }

	internal virtual bool kwMTcexkBSpageCdqoWCFCzibaIDA() { }

	private Vector3 nbZVhCgiHmKRCtxxJLSzXgKExBfU() { }

	private void NoNlfIaNLEjlrHpYdLppvgzqtZuGA(TiltDirection unnamed_param_0) { }

	[CustomObfuscation]
	internal virtual void OnValidate() { }

	public void set_axesToUse(TiltDirection value) { }

	public void set_forwardRestAngle(float value) { }

	public void set_forwardTiltLimit(float value) { }

	public void set_horizontalRestAngle(float value) { }

	public void set_horizontalTiltLimit(float value) { }

	public void SetAccelerationSourceCallback(Func<Vector3> callback) { }

	public void SetRestOrientation() { }

	internal virtual void WuAJrOPQGZmohVlmObzfeXGkBzEP() { }

	private void wxLpDyNBCtoeGqSzFSOulChHIXw() { }

}

