namespace PeroTools2.GeneralLocalization.Modles;

public class TextOption : OptionGeneric<TextSource, String>
{

	public TextOption() { }

	protected virtual void OnApply(TextSource source, Localization localization) { }

}

