namespace Assets.Scripts.PeroTools.Nice.Events;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class OnFancyScrollViewFinalSelectItem : Event, IPreWarm
{
	private VariableBehaviour m_Variables; //Field offset: 0x70
	public FancyScrollView target; //Field offset: 0x78

	public OnFancyScrollViewFinalSelectItem() { }

	protected virtual void OnEnter() { }

	private void OnFinalSelectItem(int i) { }

}

