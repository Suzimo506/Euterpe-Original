namespace System.ComponentModel;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class DesignerCategoryAttribute : Attribute
{
	public static readonly DesignerCategoryAttribute Component; //Field offset: 0x0
	public static readonly DesignerCategoryAttribute Default; //Field offset: 0x8
	public static readonly DesignerCategoryAttribute Form; //Field offset: 0x10
	public static readonly DesignerCategoryAttribute Generic; //Field offset: 0x18
	private string category; //Field offset: 0x10
	private string typeId; //Field offset: 0x18

	public string Category
	{
		 get { } //Length: 5
	}

	public virtual object TypeId
	{
		 get { } //Length: 104
	}

	private static DesignerCategoryAttribute() { }

	public DesignerCategoryAttribute() { }

	public DesignerCategoryAttribute(string category) { }

	public virtual bool Equals(object obj) { }

	public string get_Category() { }

	public virtual object get_TypeId() { }

	public virtual int GetHashCode() { }

	public virtual bool IsDefaultAttribute() { }

}

