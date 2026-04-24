namespace Sirenix.OdinInspector.Demos;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class TextureMotion : MonoBehaviour
{
	internal class MyTabObject
	{
		internal enum SomeEnum
		{
			Normal = 0,
			Multiply = 1,
			Overlay = 2,
			Lighten = 3,
		}

		internal enum SomeEnum1
		{
			Move = 0,
			Rotation = 1,
		}

		public bool on; //Field offset: 0x10
		public Sprite texture; //Field offset: 0x18
		public SomeEnum superimposition; //Field offset: 0x20
		public bool showMaskGraphic; //Field offset: 0x24
		[Space]
		public SomeEnum1 MontionType; //Field offset: 0x28
		public Vector2 pivot; //Field offset: 0x2C
		public float roataeSpeed; //Field offset: 0x34
		public Vector2 offsetSpeed; //Field offset: 0x38

		public MyTabObject() { }

	}

	[Space]
	public Sprite tartget; //Field offset: 0x18
	public MyTabObject TabA; //Field offset: 0x20
	public MyTabObject TabB; //Field offset: 0x28
	public MyTabObject TabC; //Field offset: 0x30

	public TextureMotion() { }

}

