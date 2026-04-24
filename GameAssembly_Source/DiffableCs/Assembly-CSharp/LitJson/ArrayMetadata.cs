namespace LitJson;

internal struct ArrayMetadata
{
	private Type element_type; //Field offset: 0x0
	private bool is_array; //Field offset: 0x8
	private bool is_list; //Field offset: 0x9

	public Type ElementType
	{
		 get { } //Length: 161
		 set { } //Length: 8
	}

	public bool IsArray
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool IsList
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public Type get_ElementType() { }

	public bool get_IsArray() { }

	public bool get_IsList() { }

	public void set_ElementType(Type value) { }

	public void set_IsArray(bool value) { }

	public void set_IsList(bool value) { }

}

