namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

public class TextOption : OptionGeneric<TextSource, String>
{

	public TextOption() { }

	protected virtual void OnApply(TextSource source, Localization localization) { }

}

