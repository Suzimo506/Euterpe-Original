namespace Spine.Unity.AnimationTools;

[Extension]
public static class TimelineExtensions
{

	[Extension]
	public static Vector2 Evaluate(TranslateTimeline timeline, float time, SkeletonData skeletonData = null) { }

	[Extension]
	public static TranslateTimeline FindTranslateTimelineForBone(Animation a, int boneIndex) { }

}

