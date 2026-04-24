//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class TextSpacing : BaseMeshEffect
{
	internal enum HorizontalAligmentType
	{
		Left = 0,
		Center = 1,
		Right = 2,
	}

	internal class Line
	{
		private int _startVertexIndex; //Field offset: 0x10
		private int _endVertexIndex; //Field offset: 0x14
		private int _vertexCount; //Field offset: 0x18

		public int EndVertexIndex
		{
			 get { } //Length: 4
		}

		public int StartVertexIndex
		{
			 get { } //Length: 4
		}

		public int VertexCount
		{
			 get { } //Length: 4
		}

		public Line(int startVertexIndex, int length) { }

		public int get_EndVertexIndex() { }

		public int get_StartVertexIndex() { }

		public int get_VertexCount() { }

	}

	public float Spacing; //Field offset: 0x20

	public TextSpacing() { }

	public virtual void ModifyMesh(VertexHelper vh) { }

}

