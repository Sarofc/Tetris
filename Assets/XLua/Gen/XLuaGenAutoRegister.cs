﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;
using System.Collections.Generic;
using System.Reflection;


namespace XLua.CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
        
        
        static void wrapInit0(LuaEnv luaenv, ObjectTranslator translator)
        {
        
            translator.DelayWrapLoader(typeof(Saro.SceneManagerLuaEx), SaroSceneManagerLuaExWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Saro.Lua.SoundComponentEx), SaroLuaSoundComponentExWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Saro.Lua.UI.UIComponentLuaExt), SaroLuaUIUIComponentLuaExtWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Saro.Lua.UI.XLuaUI), SaroLuaUIXLuaUIWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Tetris.SoundComponentEx), TetrisSoundComponentExWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(object), SystemObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Object), UnityEngineObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector2), UnityEngineVector2Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector3), UnityEngineVector3Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Vector4), UnityEngineVector4Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Quaternion), UnityEngineQuaternionWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Color), UnityEngineColorWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray), UnityEngineRayWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Bounds), UnityEngineBoundsWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Ray2D), UnityEngineRay2DWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Time), UnityEngineTimeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.GameObject), UnityEngineGameObjectWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Component), UnityEngineComponentWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Behaviour), UnityEngineBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Transform), UnityEngineTransformWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Resources), UnityEngineResourcesWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.TextAsset), UnityEngineTextAssetWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Keyframe), UnityEngineKeyframeWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationCurve), UnityEngineAnimationCurveWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.AnimationClip), UnityEngineAnimationClipWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.MonoBehaviour), UnityEngineMonoBehaviourWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem), UnityEngineParticleSystemWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.SkinnedMeshRenderer), UnityEngineSkinnedMeshRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Renderer), UnityEngineRendererWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Light), UnityEngineLightWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Mathf), UnityEngineMathfWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(System.Collections.Generic.List<int>), SystemCollectionsGenericList_1_SystemInt32_Wrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(UnityEngine.Debug), UnityEngineDebugWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Saro.Main), SaroMainWrap.__Register);
        
        
            translator.DelayWrapLoader(typeof(Saro.Log), SaroLogWrap.__Register);
        
        
        
        }
        
        static void Init(LuaEnv luaenv, ObjectTranslator translator)
        {
            
            wrapInit0(luaenv, translator);
            
            
            translator.AddInterfaceBridgeCreator(typeof(System.Collections.IEnumerator), SystemCollectionsIEnumeratorBridge.__Create);
            
        }
        
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter(Init);
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua.CSObjectWrap.XLua_Gen_Initer_Register__();
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	internal partial class InternalGlobals
    {
	    
		delegate void __GEN_DELEGATE0( Saro.Audio.SoundComponent self,  float val);
		
		delegate float __GEN_DELEGATE1( Saro.Audio.SoundComponent self);
		
		delegate void __GEN_DELEGATE2( Saro.Audio.SoundComponent self,  float val);
		
		delegate float __GEN_DELEGATE3( Saro.Audio.SoundComponent self);
		
		delegate Cysharp.Threading.Tasks.UniTask __GEN_DELEGATE4( Saro.Audio.SoundComponent self,  string assetName);
		
		delegate Cysharp.Threading.Tasks.UniTask __GEN_DELEGATE5( Saro.Audio.SoundComponent self,  string assetName);
		
		delegate Cysharp.Threading.Tasks.UniTask<Saro.UI.UIBase> __GEN_DELEGATE6( Saro.UI.UIComponent self,  string uiName);
		
		delegate Cysharp.Threading.Tasks.UniTask<Saro.UI.UIBase> __GEN_DELEGATE7( Saro.UI.UIComponent self,  System.Type uiType,  string uiName);
		
		delegate void __GEN_DELEGATE8( Saro.UI.UIComponent self,  string uiName);
		
		delegate void __GEN_DELEGATE9( Saro.UI.UIBase self,  UnityEngine.Events.UnityEvent src,  UnityEngine.Events.UnityAction dst);
		
		delegate void __GEN_DELEGATE10( Saro.UI.UIBase self,  UnityEngine.Events.UnityEvent<float> src,  UnityEngine.Events.UnityAction<float> dst);
		
		delegate void __GEN_DELEGATE11( Saro.UI.UIBase self,  UnityEngine.Events.UnityEvent<int> src,  UnityEngine.Events.UnityAction<int> dst);
		
		delegate void __GEN_DELEGATE12( Saro.UI.UIBase self);
		
		delegate void __GEN_DELEGATE13( Saro.Audio.SoundComponent self);
		
		delegate void __GEN_DELEGATE14( Saro.Audio.SoundComponent self);
		
	    static InternalGlobals()
		{
		    extensionMethodMap = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
				{typeof(Saro.Audio.SoundComponent), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE0(Saro.Lua.SoundComponentEx.SetVolumeBGM)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE1(Saro.Lua.SoundComponentEx.GetVolumeBGM)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE2(Saro.Lua.SoundComponentEx.SetVolumeSE)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE3(Saro.Lua.SoundComponentEx.GetVolumeSE)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE4(Saro.Lua.SoundComponentEx.PlayBGMAsync)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE5(Saro.Lua.SoundComponentEx.PlaySEAsync)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE13(Tetris.SoundComponentEx.ApplySettings)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE14(Tetris.SoundComponentEx.StoreSettings)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(Saro.UI.UIComponent), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE6(Saro.Lua.UI.UIComponentLuaExt.OpenUIAsync)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE7(Saro.Lua.UI.UIComponentLuaExt.OpenUIAsync)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE8(Saro.Lua.UI.UIComponentLuaExt.CloseUI)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
				{typeof(Saro.UI.UIBase), new List<MethodInfo>(){
				
				  new __GEN_DELEGATE9(Saro.Lua.UI.UIComponentLuaExt.Listen)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE10(Saro.Lua.UI.UIComponentLuaExt.Listen)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE11(Saro.Lua.UI.UIComponentLuaExt.Listen)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				  new __GEN_DELEGATE12(Saro.Lua.UI.UIComponentLuaExt.Close)
#if UNITY_WSA && !UNITY_EDITOR
                                      .GetMethodInfo(),
#else
                                      .Method,
#endif
				
				}},
				
			};
			
			genTryArrayGetPtr = StaticLuaCallbacks.__tryArrayGet;
            genTryArraySetPtr = StaticLuaCallbacks.__tryArraySet;
		}
	}
}
