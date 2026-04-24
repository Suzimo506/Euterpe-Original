namespace Assets.Scripts.GameCore.Skill;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class SkillInfoAttribute : Attribute
{
	private int m_Index; //Field offset: 0x10
	private int m_Type; //Field offset: 0x14

	public int index
	{
		 get { } //Length: 4
	}

	public int type
	{
		 get { } //Length: 4
	}

	internal SkillInfoAttribute(int type, int index) { }

	public int get_index() { }

	public int get_type() { }

}

