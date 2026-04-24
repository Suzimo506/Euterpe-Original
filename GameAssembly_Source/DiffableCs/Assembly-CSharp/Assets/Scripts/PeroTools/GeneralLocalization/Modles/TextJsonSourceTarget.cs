namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

public class TextJsonSourceTarget
{
	public Event event; //Field offset: 0x10
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int index; //Field offset: 0x18

	public TextJsonSourceTarget() { }

	public static SetText GetSetText(Event event, int index, out int indexInPlayables) { }

	public SetText GetSetText(out int indexInPlayables) { }

}

