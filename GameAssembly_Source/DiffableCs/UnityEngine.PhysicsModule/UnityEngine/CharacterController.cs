namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class CharacterController : Collider
{

	public CollisionFlags Move(Vector3 motion) { }

	private CollisionFlags Move_Injected(ref Vector3 motion) { }

}

