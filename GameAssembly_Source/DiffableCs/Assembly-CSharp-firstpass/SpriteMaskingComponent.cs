//Type is in global namespace

public class SpriteMaskingComponent : MonoBehaviour
{
	public SpriteMask owner; //Field offset: 0x18

	public override bool isEnabled
	{
		 get { } //Length: 135
	}

	public SpriteMaskingComponent() { }

	protected override void doUpdateSprite(Transform t, CompareFunction comp, int stencil) { }

	public override bool get_isEnabled() { }

}

