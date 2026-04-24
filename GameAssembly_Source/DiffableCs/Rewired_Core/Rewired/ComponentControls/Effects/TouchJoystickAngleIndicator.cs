namespace Rewired.ComponentControls.Effects;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DisallowMultipleComponent]
[ExecuteInEditMode]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class TouchJoystickAngleIndicator : MonoBehaviour, IStickPositionChangedHandler, IVisibilityChangedHandler
{
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _visible; //Field offset: 0x18
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _targetAngleFromRotation; //Field offset: 0x19
	[CustomObfuscation]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _targetAngle; //Field offset: 0x1C
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _fadeWithValue; //Field offset: 0x20
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _fadeWithAngle; //Field offset: 0x21
	[CustomObfuscation]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _fadeRange; //Field offset: 0x24
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Color _activeColor; //Field offset: 0x28
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Color _normalColor; //Field offset: 0x38
	private Image ynIxndFOzlnTwhDVEuhbqZPaWHGX; //Field offset: 0x48
	private RectTransform NZEckUdrksvUtSHNNiFlUZaKTqqo; //Field offset: 0x50
	private Vector2 bMSfGymqvmDBckUUSypTcuNXtHLB; //Field offset: 0x58
	private bool BpTylUwMnIPRiwjYdmOUrBwbysLB; //Field offset: 0x60
	private IRegistrar<TouchJoystickAngleIndicator> arcbdkDjSFMdbEKtbqhHvlpAssOkB; //Field offset: 0x68

	public Color activeColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	internal Image BuFRwSsuxclGFoBkkrDdAMIlZEYL
	{
		internal get { } //Length: 99
	}

	internal RectTransform cANNcmbPKEISLBMrcdOrwWYBcSKQ
	{
		internal get { } //Length: 99
	}

	public float fadeRange
	{
		 get { } //Length: 6
		 set { } //Length: 18
	}

	public bool fadeWithAngle
	{
		 get { } //Length: 5
		 set { } //Length: 9
	}

	public bool fadeWithValue
	{
		 get { } //Length: 5
		 set { } //Length: 9
	}

	internal Sprite IUmefwIWXmSjsMBmopKvfHlYwWZO
	{
		internal get { } //Length: 318
	}

	public Color normalColor
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public float targetAngle
	{
		 get { } //Length: 71
		 set { } //Length: 18
	}

	public bool targetAngleFromRotation
	{
		 get { } //Length: 5
		 set { } //Length: 9
	}

	public bool visible
	{
		 get { } //Length: 5
		 set { } //Length: 142
	}

	[CustomObfuscation]
	private TouchJoystickAngleIndicator() { }

	[CustomObfuscation]
	private void Awake() { }

	public Color get_activeColor() { }

	public float get_fadeRange() { }

	public bool get_fadeWithAngle() { }

	public bool get_fadeWithValue() { }

	public Color get_normalColor() { }

	public float get_targetAngle() { }

	public bool get_targetAngleFromRotation() { }

	public bool get_visible() { }

	private void GGUFBODifwtqRTAdHQHNIcUblmBKc() { }

	private void GmEUEsqliwjYNcOOCXltjCsshxBR() { }

	private void GwNNPbynGEwRllaEOxYxWNOTIYbF() { }

	private void jbrwnTxTIRHYNSTJBpFEnNBcdbnj() { }

	internal Image kkzdSTNKfFHPYpdDQczfLkFCryaR() { }

	[CustomObfuscation]
	private void OnDisable() { }

	[CustomObfuscation]
	private void OnEnable() { }

	public void OnTouchJoystickStickPositionChanged(Vector2 value) { }

	[CustomObfuscation]
	private void OnTransformParentChanged() { }

	[CustomObfuscation]
	private void OnValidate() { }

	public override void OnVisibilityChanged(bool state) { }

	private void qijEzQcwADstBJqirWeueWhaaBOOA(Vector2 unnamed_param_0) { }

	private override void Rewired.ComponentControls.TouchJoystick.IStickPositionChangedHandler.OnStickPositionChanged(Vector2 value) { }

	public void set_activeColor(Color value) { }

	public void set_fadeRange(float value) { }

	public void set_fadeWithAngle(bool value) { }

	public void set_fadeWithValue(bool value) { }

	public void set_normalColor(Color value) { }

	public void set_targetAngle(float value) { }

	public void set_targetAngleFromRotation(bool value) { }

	public void set_visible(bool value) { }

	internal Sprite sFNNWbqcRmglJcYYtSuKyLMKiDDC() { }

	private void uuDVEIsWkYOTGoAphuigxalCoeQo(bool unnamed_param_0, bool unnamed_param_1) { }

	internal bool vCAEJXAZiccTGncmcDSIZMxkuPGv(out Vector2 unnamed_param_0) { }

	private void WRoibVPxMHaMwEurbROKIkIgtgrS() { }

	internal RectTransform XzSCrOiFeulPmAecrVaxThHxTSiTA() { }

}

