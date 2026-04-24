namespace Rewired.Interfaces;

[CustomClassObfuscation]
[CustomObfuscation]
internal interface IControllerTemplateElementIdentifier : IControllerElementIdentifierCommon_Internal
{

	public ControllerTemplateElementType elementType
	{
		 get { } //Length: 0
	}

	public ControllerTemplateElementType get_elementType() { }

}

