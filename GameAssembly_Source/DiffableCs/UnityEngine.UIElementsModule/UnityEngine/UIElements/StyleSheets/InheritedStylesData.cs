namespace UnityEngine.UIElements.StyleSheets;

internal class InheritedStylesData : IEquatable<InheritedStylesData>
{
	public static readonly InheritedStylesData none; //Field offset: 0x0
	public StyleColor color; //Field offset: 0x10
	public StyleFont font; //Field offset: 0x28
	public StyleLength fontSize; //Field offset: 0x40
	public StyleInt unityFontStyle; //Field offset: 0x50
	public StyleInt unityTextAlign; //Field offset: 0x5C
	public StyleInt visibility; //Field offset: 0x68
	public StyleInt whiteSpace; //Field offset: 0x74

	private static InheritedStylesData() { }

	public InheritedStylesData() { }

	public override bool Equals(InheritedStylesData other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

}

