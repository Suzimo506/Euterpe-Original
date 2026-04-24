namespace Discord;

public class AchievementManager
{
	internal sealed class FetchUserAchievementsHandler : MulticastDelegate
	{

		public FetchUserAchievementsHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	public struct FFIEvents
	{
		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class UserAchievementUpdateHandler : MulticastDelegate
		{

			public UserAchievementUpdateHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, ref UserAchievement userAchievement, AsyncCallback callback, object object) { }

			public override void EndInvoke(ref UserAchievement userAchievement, IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, ref UserAchievement userAchievement) { }

		}

		internal UserAchievementUpdateHandler OnUserAchievementUpdate; //Field offset: 0x0

	}

	public struct FFIMethods
	{
		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class CountUserAchievementsMethod : MulticastDelegate
		{

			public CountUserAchievementsMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, object object) { }

			public override void EndInvoke(ref int count, IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, ref int count) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class FetchUserAchievementsCallback : MulticastDelegate
		{

			public FetchUserAchievementsCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class FetchUserAchievementsMethod : MulticastDelegate
		{

			public FetchUserAchievementsMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, FetchUserAchievementsCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, IntPtr callbackData, FetchUserAchievementsCallback callback) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetUserAchievementAtMethod : MulticastDelegate
		{

			public GetUserAchievementAtMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, int index, ref UserAchievement userAchievement, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref UserAchievement userAchievement, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, int index, ref UserAchievement userAchievement) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class GetUserAchievementMethod : MulticastDelegate
		{

			public GetUserAchievementMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long userAchievementId, ref UserAchievement userAchievement, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref UserAchievement userAchievement, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, long userAchievementId, ref UserAchievement userAchievement) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SetUserAchievementCallback : MulticastDelegate
		{

			public SetUserAchievementCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public sealed class SetUserAchievementMethod : MulticastDelegate
		{

			public SetUserAchievementMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long achievementId, byte percentComplete, IntPtr callbackData, SetUserAchievementCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, long achievementId, byte percentComplete, IntPtr callbackData, SetUserAchievementCallback callback) { }

		}

		internal SetUserAchievementMethod SetUserAchievement; //Field offset: 0x0
		internal FetchUserAchievementsMethod FetchUserAchievements; //Field offset: 0x8
		internal CountUserAchievementsMethod CountUserAchievements; //Field offset: 0x10
		internal GetUserAchievementMethod GetUserAchievement; //Field offset: 0x18
		internal GetUserAchievementAtMethod GetUserAchievementAt; //Field offset: 0x20

	}

	internal sealed class SetUserAchievementHandler : MulticastDelegate
	{

		public SetUserAchievementHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Result result) { }

	}

	internal sealed class UserAchievementUpdateHandler : MulticastDelegate
	{

		public UserAchievementUpdateHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref UserAchievement userAchievement, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref UserAchievement userAchievement, IAsyncResult result) { }

		public override void Invoke(ref UserAchievement userAchievement) { }

	}

	private IntPtr MethodsPtr; //Field offset: 0x10
	private object MethodsStructure; //Field offset: 0x18
	[CompilerGenerated]
	private UserAchievementUpdateHandler OnUserAchievementUpdate; //Field offset: 0x20

	public event UserAchievementUpdateHandler OnUserAchievementUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	private FFIMethods Methods
	{
		private get { } //Length: 272
	}

	internal AchievementManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events) { }

	[CompilerGenerated]
	public void add_OnUserAchievementUpdate(UserAchievementUpdateHandler value) { }

	public int CountUserAchievements() { }

	public void FetchUserAchievements(FetchUserAchievementsHandler callback) { }

	[MonoPInvokeCallback]
	private static void FetchUserAchievementsCallbackImpl(IntPtr ptr, Result result) { }

	private FFIMethods get_Methods() { }

	public UserAchievement GetUserAchievement(long userAchievementId) { }

	public UserAchievement GetUserAchievementAt(int index) { }

	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

	[MonoPInvokeCallback]
	private static void OnUserAchievementUpdateImpl(IntPtr ptr, ref UserAchievement userAchievement) { }

	[CompilerGenerated]
	public void remove_OnUserAchievementUpdate(UserAchievementUpdateHandler value) { }

	public void SetUserAchievement(long achievementId, byte percentComplete, SetUserAchievementHandler callback) { }

	[MonoPInvokeCallback]
	private static void SetUserAchievementCallbackImpl(IntPtr ptr, Result result) { }

}

