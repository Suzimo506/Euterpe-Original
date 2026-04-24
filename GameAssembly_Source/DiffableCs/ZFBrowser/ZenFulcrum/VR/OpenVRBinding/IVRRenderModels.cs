namespace ZenFulcrum.VR.OpenVRBinding;

public struct IVRRenderModels
{
	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _FreeRenderModel : MulticastDelegate
	{

		public _FreeRenderModel(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr pRenderModel, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr pRenderModel) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _FreeTexture : MulticastDelegate
	{

		public _FreeTexture(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr pTexture, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr pTexture) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _FreeTextureD3D11 : MulticastDelegate
	{

		public _FreeTextureD3D11(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr pD3D11Texture2D, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr pD3D11Texture2D) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetComponentButtonMask : MulticastDelegate
	{

		public _GetComponentButtonMask(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchRenderModelName, string pchComponentName, AsyncCallback callback, object object) { }

		public override ulong EndInvoke(IAsyncResult result) { }

		public override ulong Invoke(string pchRenderModelName, string pchComponentName) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetComponentCount : MulticastDelegate
	{

		public _GetComponentCount(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchRenderModelName, AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke(string pchRenderModelName) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetComponentName : MulticastDelegate
	{

		public _GetComponentName(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchRenderModelName, uint unComponentIndex, StringBuilder pchComponentName, uint unComponentNameLen, AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke(string pchRenderModelName, uint unComponentIndex, StringBuilder pchComponentName, uint unComponentNameLen) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetComponentRenderModelName : MulticastDelegate
	{

		public _GetComponentRenderModelName(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchRenderModelName, string pchComponentName, StringBuilder pchComponentRenderModelName, uint unComponentRenderModelNameLen, AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke(string pchRenderModelName, string pchComponentName, StringBuilder pchComponentRenderModelName, uint unComponentRenderModelNameLen) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetComponentState : MulticastDelegate
	{

		public _GetComponentState(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchRenderModelName, string pchComponentName, ref VRControllerState_t pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref VRControllerState_t pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState, IAsyncResult result) { }

		public override bool Invoke(string pchRenderModelName, string pchComponentName, ref VRControllerState_t pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetComponentStateForDevicePath : MulticastDelegate
	{

		public _GetComponentStateForDevicePath(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchRenderModelName, string pchComponentName, ulong devicePath, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState, IAsyncResult result) { }

		public override bool Invoke(string pchRenderModelName, string pchComponentName, ulong devicePath, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetRenderModelCount : MulticastDelegate
	{

		public _GetRenderModelCount(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetRenderModelErrorNameFromEnum : MulticastDelegate
	{

		public _GetRenderModelErrorNameFromEnum(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EVRRenderModelError error, AsyncCallback callback, object object) { }

		public override IntPtr EndInvoke(IAsyncResult result) { }

		public override IntPtr Invoke(EVRRenderModelError error) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetRenderModelName : MulticastDelegate
	{

		public _GetRenderModelName(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unRenderModelIndex, StringBuilder pchRenderModelName, uint unRenderModelNameLen, AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke(uint unRenderModelIndex, StringBuilder pchRenderModelName, uint unRenderModelNameLen) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetRenderModelOriginalPath : MulticastDelegate
	{

		public _GetRenderModelOriginalPath(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchRenderModelName, StringBuilder pchOriginalPath, uint unOriginalPathLen, ref EVRRenderModelError peError, AsyncCallback callback, object object) { }

		public override uint EndInvoke(ref EVRRenderModelError peError, IAsyncResult result) { }

		public override uint Invoke(string pchRenderModelName, StringBuilder pchOriginalPath, uint unOriginalPathLen, ref EVRRenderModelError peError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetRenderModelThumbnailURL : MulticastDelegate
	{

		public _GetRenderModelThumbnailURL(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchRenderModelName, StringBuilder pchThumbnailURL, uint unThumbnailURLLen, ref EVRRenderModelError peError, AsyncCallback callback, object object) { }

		public override uint EndInvoke(ref EVRRenderModelError peError, IAsyncResult result) { }

		public override uint Invoke(string pchRenderModelName, StringBuilder pchThumbnailURL, uint unThumbnailURLLen, ref EVRRenderModelError peError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _LoadIntoTextureD3D11_Async : MulticastDelegate
	{

		public _LoadIntoTextureD3D11_Async(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int textureId, IntPtr pDstTexture, AsyncCallback callback, object object) { }

		public override EVRRenderModelError EndInvoke(IAsyncResult result) { }

		public override EVRRenderModelError Invoke(int textureId, IntPtr pDstTexture) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _LoadRenderModel_Async : MulticastDelegate
	{

		public _LoadRenderModel_Async(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchRenderModelName, ref IntPtr ppRenderModel, AsyncCallback callback, object object) { }

		public override EVRRenderModelError EndInvoke(ref IntPtr ppRenderModel, IAsyncResult result) { }

		public override EVRRenderModelError Invoke(string pchRenderModelName, ref IntPtr ppRenderModel) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _LoadTexture_Async : MulticastDelegate
	{

		public _LoadTexture_Async(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int textureId, ref IntPtr ppTexture, AsyncCallback callback, object object) { }

		public override EVRRenderModelError EndInvoke(ref IntPtr ppTexture, IAsyncResult result) { }

		public override EVRRenderModelError Invoke(int textureId, ref IntPtr ppTexture) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _LoadTextureD3D11_Async : MulticastDelegate
	{

		public _LoadTextureD3D11_Async(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int textureId, IntPtr pD3D11Device, ref IntPtr ppD3D11Texture2D, AsyncCallback callback, object object) { }

		public override EVRRenderModelError EndInvoke(ref IntPtr ppD3D11Texture2D, IAsyncResult result) { }

		public override EVRRenderModelError Invoke(int textureId, IntPtr pD3D11Device, ref IntPtr ppD3D11Texture2D) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _RenderModelHasComponent : MulticastDelegate
	{

		public _RenderModelHasComponent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchRenderModelName, string pchComponentName, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(string pchRenderModelName, string pchComponentName) { }

	}

	internal _LoadRenderModel_Async LoadRenderModel_Async; //Field offset: 0x0
	internal _FreeRenderModel FreeRenderModel; //Field offset: 0x8
	internal _LoadTexture_Async LoadTexture_Async; //Field offset: 0x10
	internal _FreeTexture FreeTexture; //Field offset: 0x18
	internal _LoadTextureD3D11_Async LoadTextureD3D11_Async; //Field offset: 0x20
	internal _LoadIntoTextureD3D11_Async LoadIntoTextureD3D11_Async; //Field offset: 0x28
	internal _FreeTextureD3D11 FreeTextureD3D11; //Field offset: 0x30
	internal _GetRenderModelName GetRenderModelName; //Field offset: 0x38
	internal _GetRenderModelCount GetRenderModelCount; //Field offset: 0x40
	internal _GetComponentCount GetComponentCount; //Field offset: 0x48
	internal _GetComponentName GetComponentName; //Field offset: 0x50
	internal _GetComponentButtonMask GetComponentButtonMask; //Field offset: 0x58
	internal _GetComponentRenderModelName GetComponentRenderModelName; //Field offset: 0x60
	internal _GetComponentStateForDevicePath GetComponentStateForDevicePath; //Field offset: 0x68
	internal _GetComponentState GetComponentState; //Field offset: 0x70
	internal _RenderModelHasComponent RenderModelHasComponent; //Field offset: 0x78
	internal _GetRenderModelThumbnailURL GetRenderModelThumbnailURL; //Field offset: 0x80
	internal _GetRenderModelOriginalPath GetRenderModelOriginalPath; //Field offset: 0x88
	internal _GetRenderModelErrorNameFromEnum GetRenderModelErrorNameFromEnum; //Field offset: 0x90

}

