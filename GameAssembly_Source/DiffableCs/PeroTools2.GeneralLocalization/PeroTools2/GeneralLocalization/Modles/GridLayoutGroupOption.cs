namespace PeroTools2.GeneralLocalization.Modles;

public class GridLayoutGroupOption : OptionGeneric<GridLayoutGroupSource, Property>
{

	public GridLayoutGroupOption() { }

	protected virtual Property DefaultValue(Localization localization) { }

	protected virtual void OnApply(GridLayoutGroupSource source, Localization localization) { }

}

