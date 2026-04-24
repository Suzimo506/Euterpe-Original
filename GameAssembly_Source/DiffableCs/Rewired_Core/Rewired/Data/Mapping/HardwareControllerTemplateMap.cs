namespace Rewired.Data.Mapping;

public abstract class HardwareControllerTemplateMap : ScriptableObject
{

	public abstract Guid Guid
	{
		 get { } //Length: 0
	}

	protected HardwareControllerTemplateMap() { }

	public abstract Guid get_Guid() { }

}

