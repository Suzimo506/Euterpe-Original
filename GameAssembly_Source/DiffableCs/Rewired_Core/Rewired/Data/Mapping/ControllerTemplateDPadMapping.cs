namespace Rewired.Data.Mapping;

[CustomClassObfuscation]
[CustomObfuscation]
[Preserve]
internal class ControllerTemplateDPadMapping : ControllerTemplateSpecialElementMapping
{
	public int eid_up; //Field offset: 0x10
	public int eid_right; //Field offset: 0x14
	public int eid_down; //Field offset: 0x18
	public int eid_left; //Field offset: 0x1C
	public int eid_press; //Field offset: 0x20

	public ControllerTemplateDPadMapping() { }

}

