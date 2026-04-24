namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

public class TMPOption : OptionGeneric<TMPSource, TMPSetting>
{

	public TMPOption() { }

	protected virtual TMPSetting DefaultValue(Localization localization) { }

	protected virtual void OnApply(TMPSource source, Localization localization) { }

}

