namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class Rigidbody : Component
{

	public Vector3 angularVelocity
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public float maxAngularVelocity
	{
		 set { } //Length: 67
	}

	public Vector3 position
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public Quaternion rotation
	{
		 get { } //Length: 75
		 set { } //Length: 66
	}

	public Vector3 velocity
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public Rigidbody() { }

	public void AddForce(Vector3 force, ForceMode mode) { }

	private void AddForce_Injected(ref Vector3 force, ForceMode mode) { }

	public void AddRelativeTorque(Vector3 torque, ForceMode mode) { }

	private void AddRelativeTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	public Vector3 get_angularVelocity() { }

	private void get_angularVelocity_Injected(out Vector3 ret) { }

	public Vector3 get_position() { }

	private void get_position_Injected(out Vector3 ret) { }

	public Quaternion get_rotation() { }

	private void get_rotation_Injected(out Quaternion ret) { }

	public Vector3 get_velocity() { }

	private void get_velocity_Injected(out Vector3 ret) { }

	public void MovePosition(Vector3 position) { }

	private void MovePosition_Injected(ref Vector3 position) { }

	public void MoveRotation(Quaternion rot) { }

	private void MoveRotation_Injected(ref Quaternion rot) { }

	public void set_angularVelocity(Vector3 value) { }

	private void set_angularVelocity_Injected(ref Vector3 value) { }

	public void set_maxAngularVelocity(float value) { }

	public void set_position(Vector3 value) { }

	private void set_position_Injected(ref Vector3 value) { }

	public void set_rotation(Quaternion value) { }

	private void set_rotation_Injected(ref Quaternion value) { }

	public void set_velocity(Vector3 value) { }

	private void set_velocity_Injected(ref Vector3 value) { }

}

