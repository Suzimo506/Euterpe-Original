namespace Assets.Scripts.PeroTools.GeneralLocalization;

public class TextGlobalOption : GlobalOptoin
{
	public Font font; //Field offset: 0x10

	public TextGlobalOption() { }

	public virtual void Apply(Localization localization) { }

	public virtual void Default(Localization localization) { }

}

