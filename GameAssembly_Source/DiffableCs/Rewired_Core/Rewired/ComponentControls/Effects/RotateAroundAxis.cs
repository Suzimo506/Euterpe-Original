namespace Rewired.ComponentControls.Effects;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class RotateAroundAxis : MonoBehaviour
{
	internal enum RotationAxis
	{
		X = 0,
		Y = 1,
		Z = 2,
	}

	internal enum Speed
	{
		Stopped = 0,
		Slow = 1,
		Fast = 2,
	}

	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Speed _speed; //Field offset: 0x18
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _slowRotationSpeed; //Field offset: 0x1C
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _fastRotationSpeed; //Field offset: 0x20
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private RotationAxis _rotateAroundAxis; //Field offset: 0x24
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Space _relativeTo; //Field offset: 0x28
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _reverse; //Field offset: 0x2C

	public float fastRotationSpeed
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public Space relativeTo
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public bool reverse
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public RotationAxis rotateAroundAxis
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float slowRotationSpeed
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public Speed speed
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public RotateAroundAxis() { }

	public float get_fastRotationSpeed() { }

	public Space get_relativeTo() { }

	public bool get_reverse() { }

	public RotationAxis get_rotateAroundAxis() { }

	public float get_slowRotationSpeed() { }

	public Speed get_speed() { }

	public void set_fastRotationSpeed(float value) { }

	public void set_relativeTo(Space value) { }

	public void set_reverse(bool value) { }

	public void set_rotateAroundAxis(RotationAxis value) { }

	public void set_slowRotationSpeed(float value) { }

	public void set_speed(Speed value) { }

	public void SetSpeed(int speed) { }

	public void SetSpeed(Speed speed) { }

	[CustomObfuscation]
	private void Update() { }

	private static Vector3 ZFLDcbHRkTxuusOuvKvPwHILhlEM(RotationAxis unnamed_param_0) { }

}

