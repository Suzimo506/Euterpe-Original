namespace PeroTools2.GeneralLocalization.Modles;

public class RectTramAnchorsOption : OptionGeneric<RectTramAnchorsSource, RectTramAnchors>
{

	public RectTramAnchorsOption() { }

	protected virtual RectTramAnchors DefaultValue(Localization localization) { }

	protected virtual void OnApply(RectTramAnchorsSource source, Localization localization) { }

}

