namespace Assets.Scripts.PeroTools.Managers;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class EntityManager : Singleton<EntityManager>
{
	public readonly Dictionary<String, Object> entities; //Field offset: 0x10

	public object Item
	{
		 get { } //Length: 123
	}

	public EntityManager() { }

	public object get_Item(string key) { }

}

