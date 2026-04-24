namespace UniMerge.Demo;

public class TestScript : MonoBehaviour
{
	internal class Test
	{
		public Vector3 vec3; //Field offset: 0x10
		public Quaternion quat; //Field offset: 0x1C
		public Test nested; //Field offset: 0x30

		public Test() { }

	}

	public GameObject ref1; //Field offset: 0x18
	public GameObject ref2; //Field offset: 0x20
	public GameObject ref3; //Field offset: 0x28
	public Collider col1; //Field offset: 0x30
	public MonoBehaviour mb; //Field offset: 0x38
	public Rigidbody rigid; //Field offset: 0x40
	public Bounds bounds; //Field offset: 0x48
	public Quaternion quat; //Field offset: 0x60
	public Rect rect; //Field offset: 0x70
	public Vector2 vec2; //Field offset: 0x80
	public Vector3 vec3; //Field offset: 0x88
	public Vector4 vec4; //Field offset: 0x94
	public string str; //Field offset: 0xA8
	public int i; //Field offset: 0xB0
	public bool b; //Field offset: 0xB4
	public float f; //Field offset: 0xB8
	public Color c; //Field offset: 0xBC
	public LayerMask l; //Field offset: 0xCC
	public Transform[] arr; //Field offset: 0xD0
	public char ch; //Field offset: 0xD8
	public AnimationCurve anim; //Field offset: 0xE0
	public Gradient g; //Field offset: 0xE8
	public Test test; //Field offset: 0xF0

	public TestScript() { }

}

