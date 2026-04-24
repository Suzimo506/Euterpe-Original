namespace UnityEngine;

[NativeClass(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter
{

	[NativeProperty]
	public float alpha
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	[NativeProperty]
	public bool blocksRaycasts
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeProperty]
	public bool ignoreParentGroups
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeProperty]
	public bool interactable
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public CanvasGroup() { }

	public float get_alpha() { }

	public bool get_blocksRaycasts() { }

	public bool get_ignoreParentGroups() { }

	public bool get_interactable() { }

	public override bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	public void set_alpha(float value) { }

	public void set_blocksRaycasts(bool value) { }

	public void set_ignoreParentGroups(bool value) { }

	public void set_interactable(bool value) { }

}

