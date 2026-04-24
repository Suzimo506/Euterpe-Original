namespace Sirenix.OdinInspector.Internal;

public interface ISubGroupProviderAttribute
{

	public IList<PropertyGroupAttribute> GetSubGroupAttributes() { }

	public string RepathMemberAttribute(PropertyGroupAttribute attr) { }

}

