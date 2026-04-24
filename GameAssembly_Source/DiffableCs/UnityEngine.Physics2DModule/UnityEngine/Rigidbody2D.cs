namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class Rigidbody2D : Component
{

	public RigidbodyType2D bodyType
	{
		[NativeMethod]
		 set { } //Length: 64
	}

	public float gravityScale
	{
		 set { } //Length: 67
	}

	public bool isKinematic
	{
		 set { } //Length: 75
	}

	public Vector2 position
	{
		 get { } //Length: 70
		 set { } //Length: 61
	}

	public float rotation
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public Rigidbody2D() { }

	public Vector2 get_position() { }

	private void get_position_Injected(out Vector2 ret) { }

	public float get_rotation() { }

	public void MovePosition(Vector2 position) { }

	private void MovePosition_Injected(ref Vector2 position) { }

	public void MoveRotation(float angle) { }

	[NativeMethod]
	private void MoveRotation_Angle(float angle) { }

	[NativeMethod]
	public void set_bodyType(RigidbodyType2D value) { }

	public void set_gravityScale(float value) { }

	public void set_isKinematic(bool value) { }

	public void set_position(Vector2 value) { }

	private void set_position_Injected(ref Vector2 value) { }

	public void set_rotation(float value) { }

}

