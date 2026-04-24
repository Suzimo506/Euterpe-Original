namespace Rewired.Data.Mapping;

[CustomClassObfuscation]
[CustomObfuscation]
[Preserve]
internal class ControllerTemplateHatMapping : ControllerTemplateSpecialElementMapping
{
	public int eid_up; //Field offset: 0x10
	public int eid_upRight; //Field offset: 0x14
	public int eid_right; //Field offset: 0x18
	public int eid_downRight; //Field offset: 0x1C
	public int eid_down; //Field offset: 0x20
	public int eid_downLeft; //Field offset: 0x24
	public int eid_left; //Field offset: 0x28
	public int eid_upLeft; //Field offset: 0x2C

	public ControllerTemplateHatMapping() { }

}

