namespace Rewired.Demos;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class Bullet : MonoBehaviour
{
	public float lifeTime; //Field offset: 0x18
	private bool die; //Field offset: 0x1C
	private float deathTime; //Field offset: 0x20

	public Bullet() { }

	private void Start() { }

	private void Update() { }

}

