namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

public class ComponentOption : OptionGeneric<ComponentSource, Boolean>
{

	public ComponentOption() { }

	protected virtual void OnApply(ComponentSource source, Localization localization) { }

}

