namespace PeroTools.GeneralLocalization.Modles;

public class RectTramPosOption : OptionGeneric<RectTramPosSource, RectTramPos>
{

	public RectTramPosOption() { }

	protected virtual RectTramPos DefaultValue(Localization localization) { }

	protected virtual void OnApply(RectTramPosSource source, Localization localization) { }

}

