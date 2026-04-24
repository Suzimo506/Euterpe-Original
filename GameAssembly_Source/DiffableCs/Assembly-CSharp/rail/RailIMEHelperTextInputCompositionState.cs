namespace rail;

public class RailIMEHelperTextInputCompositionState : EventBase
{
	public string composition_text; //Field offset: 0x30
	public RailIMETextInputCompositionState composition_state; //Field offset: 0x38

	public RailIMEHelperTextInputCompositionState() { }

}

