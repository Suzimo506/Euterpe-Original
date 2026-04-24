namespace Rewired.Internal;

public static class ControllerTemplateFactory
{
	private static readonly Type[] _defaultTemplateTypes; //Field offset: 0x0
	private static readonly Type[] _defaultTemplateInterfaceTypes; //Field offset: 0x8

	public static Type[] templateInterfaceTypes
	{
		 get { } //Length: 87
	}

	public static Type[] templateTypes
	{
		 get { } //Length: 86
	}

	private static ControllerTemplateFactory() { }

	public static IControllerTemplate Create(Guid typeGuid, object payload) { }

	public static Type[] get_templateInterfaceTypes() { }

	public static Type[] get_templateTypes() { }

}

