namespace Assets.Scripts.PeroTools.GeneralLocalization;

public abstract class Option
{

	protected Option() { }

	public abstract void Apply(Localization localization) { }

	public abstract void Default(Localization localization) { }

}

