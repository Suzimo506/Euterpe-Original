namespace PeroTools2.GeneralLocalization.Modles;

public class RectTramSizeOption : OptionGeneric<RectTramSizeSource, RectTramSize>
{

	public RectTramSizeOption() { }

	protected virtual RectTramSize DefaultValue(Localization localization) { }

	protected virtual void OnApply(RectTramSizeSource source, Localization localization) { }

}

