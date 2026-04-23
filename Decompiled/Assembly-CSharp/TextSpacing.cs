using Cpp2ILInjected;
using UnityEngine.UI;

[Token(Token = "0x20001A6")]
[Attribute(Name = "AddComponentMenu", RVA = "0x45360", Offset = "0x44760")]
public class TextSpacing : BaseMeshEffect
{
	[Token(Token = "0x2000A50")]
	public enum HorizontalAligmentType
	{
		[Token(Token = "0x40036AC")]
		Left,
		[Token(Token = "0x40036AD")]
		Center,
		[Token(Token = "0x40036AE")]
		Right
	}

	[Token(Token = "0x2000A51")]
	public class Line
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40036AF")]
		private int _startVertexIndex;

		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40036B0")]
		private int _endVertexIndex;

		[Token(Token = "0x40036B1")]
		[FieldOffset(Offset = "0x18")]
		private int _vertexCount;

		[Token(Token = "0x17000977")]
		public int StartVertexIndex
		{
			[Token(Token = "0x6005951")]
			[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000978")]
		public int EndVertexIndex
		{
			[Address(RVA = "0x50A7E0", Offset = "0x508FE0", Length = "0x4")]
			[Token(Token = "0x6005952")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000979")]
		public int VertexCount
		{
			[Address(RVA = "0x44A0E0", Offset = "0x4488E0", Length = "0x4")]
			[Token(Token = "0x6005953")]
			get
			{
				return default(int);
			}
		}

		[Address(RVA = "0x50A790", Offset = "0x508F90", Length = "0x45")]
		[Token(Token = "0x6005954")]
		public Line(int startVertexIndex, int length)
		{
		}
	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A50")]
	public float Spacing;

	[Token(Token = "0x6000BED")]
	[Address(RVA = "0x51BFE0", Offset = "0x51A7E0", Length = "0x97C")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Address(RVA = "0x51C960", Offset = "0x51B160", Length = "0xE")]
	[Token(Token = "0x6000BEE")]
	public TextSpacing()
	{
	}
}
