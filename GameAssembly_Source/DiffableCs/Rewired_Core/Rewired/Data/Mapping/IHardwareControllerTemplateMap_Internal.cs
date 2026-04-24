namespace Rewired.Data.Mapping;

[CustomClassObfuscation]
[CustomObfuscation]
internal interface IHardwareControllerTemplateMap_Internal
{

	public string name
	{
		 get { } //Length: 0
	}

	public Guid typeGuid
	{
		 get { } //Length: 0
	}

	public string get_name() { }

	public Guid get_typeGuid() { }

	public EOKrBWwFWFlsxOBzKuftPINpDfyg GetAxisTarget(Controller controller, int elementIdentifierId) { }

	public EOKrBWwFWFlsxOBzKuftPINpDfyg GetButtonTarget(Controller controller, int elementIdentifierId) { }

	public int GetElementIdentifierCount() { }

	public IControllerTemplateMapSpecialElement_Internal GetSpecialTemplateElementByElementIdentifierId(int id) { }

	public IControllerTemplateElementIdentifier GetTemplateElementIdentifier(int index) { }

	public IControllerTemplateElementIdentifier GetTemplateElementIdentifierById(int elementIdentifierId) { }

}

