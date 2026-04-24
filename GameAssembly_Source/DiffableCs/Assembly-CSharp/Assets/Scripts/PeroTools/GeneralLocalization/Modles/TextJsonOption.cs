namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

public class TextJsonOption : OptionGeneric<TextJsonSource, SetText>
{

	public TextJsonOption() { }

	protected virtual SetText DefaultValue(Localization localization) { }

	protected virtual void OnApply(TextJsonSource source, Localization localization) { }

}

