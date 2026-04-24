namespace PeroTools2.GeneralLocalization.Modles;

public class FontSizeOption : OptionGeneric<FontSizeSource, FontSize>
{

	public FontSizeOption() { }

	protected virtual FontSize DefaultValue(Localization localization) { }

	protected virtual void OnApply(FontSizeSource source, Localization localization) { }

}

