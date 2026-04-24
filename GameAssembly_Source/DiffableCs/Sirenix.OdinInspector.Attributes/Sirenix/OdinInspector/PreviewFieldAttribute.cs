namespace Sirenix.OdinInspector;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class PreviewFieldAttribute : Attribute
{
	private ObjectFieldAlignment alignment; //Field offset: 0x10
	private bool alignmentHasValue; //Field offset: 0x14
	public float Height; //Field offset: 0x18

	public ObjectFieldAlignment Alignment
	{
		 get { } //Length: 4
		 set { } //Length: 8
	}

	public bool AlignmentHasValue
	{
		 get { } //Length: 5
	}

	public PreviewFieldAttribute() { }

	public PreviewFieldAttribute(float height) { }

	public PreviewFieldAttribute(float height, ObjectFieldAlignment alignment) { }

	public PreviewFieldAttribute(ObjectFieldAlignment alignment) { }

	public ObjectFieldAlignment get_Alignment() { }

	public bool get_AlignmentHasValue() { }

	public void set_Alignment(ObjectFieldAlignment value) { }

}

