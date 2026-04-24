namespace PeroTools2.GeneralLocalization.Modles;

public class FontTypeOption : OptionGeneric<FontTypeSource, FontType>
{

	public FontTypeOption() { }

	protected virtual FontType DefaultValue(Localization localization) { }

	protected virtual void OnApply(FontTypeSource source, Localization localization) { }

}

