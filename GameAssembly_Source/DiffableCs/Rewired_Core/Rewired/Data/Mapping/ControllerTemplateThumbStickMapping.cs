namespace Rewired.Data.Mapping;

[CustomClassObfuscation]
[CustomObfuscation]
[Preserve]
internal class ControllerTemplateThumbStickMapping : ControllerTemplateSpecialElementMapping
{
	public int eid_axisX; //Field offset: 0x10
	public int eid_axisY; //Field offset: 0x14
	public int eid_button; //Field offset: 0x18

	public ControllerTemplateThumbStickMapping() { }

}

