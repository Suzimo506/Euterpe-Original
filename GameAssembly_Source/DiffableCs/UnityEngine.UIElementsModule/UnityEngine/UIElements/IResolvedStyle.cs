namespace UnityEngine.UIElements;

public interface IResolvedStyle
{

	public DisplayStyle display
	{
		 get { } //Length: 0
	}

	public Visibility visibility
	{
		 get { } //Length: 0
	}

	public DisplayStyle get_display() { }

	public Visibility get_visibility() { }

}

