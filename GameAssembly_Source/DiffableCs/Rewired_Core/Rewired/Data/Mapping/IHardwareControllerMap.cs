namespace Rewired.Data.Mapping;

[CustomClassObfuscation]
public interface IHardwareControllerMap
{

	public bool ContainsElementIdentifier(int id) { }

	public Int32[] GetElementIdentifierIds() { }

	public String[] GetElementIdentifierNames() { }

	public int GetMappableElementIdentifierInfo(out String[] names, out Int32[] ids) { }

}

