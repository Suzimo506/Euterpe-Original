namespace PeroTools2.GeneralLocalization.Modles;

public class ComponentOption : OptionGeneric<ComponentSource, Boolean>
{

	public ComponentOption() { }

	protected virtual void OnApply(ComponentSource source, Localization localization) { }

}

