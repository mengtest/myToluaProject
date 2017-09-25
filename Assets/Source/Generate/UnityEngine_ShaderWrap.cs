﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_ShaderWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Shader), typeof(UnityEngine.Object));
		L.RegFunction("Find", Find);
		L.RegFunction("EnableKeyword", EnableKeyword);
		L.RegFunction("DisableKeyword", DisableKeyword);
		L.RegFunction("IsKeywordEnabled", IsKeywordEnabled);
		L.RegFunction("SetGlobalColor", SetGlobalColor);
		L.RegFunction("SetGlobalVector", SetGlobalVector);
		L.RegFunction("SetGlobalFloat", SetGlobalFloat);
		L.RegFunction("SetGlobalInt", SetGlobalInt);
		L.RegFunction("SetGlobalTexture", SetGlobalTexture);
		L.RegFunction("SetGlobalMatrix", SetGlobalMatrix);
		L.RegFunction("SetGlobalBuffer", SetGlobalBuffer);
		L.RegFunction("PropertyToID", PropertyToID);
		L.RegFunction("WarmupAllShaders", WarmupAllShaders);
		L.RegFunction("New", _CreateUnityEngine_Shader);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("isSupported", get_isSupported, null);
		L.RegVar("maximumLOD", get_maximumLOD, set_maximumLOD);
		L.RegVar("globalMaximumLOD", get_globalMaximumLOD, set_globalMaximumLOD);
		L.RegVar("renderQueue", get_renderQueue, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Shader(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.Shader obj = new UnityEngine.Shader();
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.Shader.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Find(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			UnityEngine.Shader o = UnityEngine.Shader.Find(arg0);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int EnableKeyword(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			UnityEngine.Shader.EnableKeyword(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DisableKeyword(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			UnityEngine.Shader.DisableKeyword(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsKeywordEnabled(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			bool o = UnityEngine.Shader.IsKeywordEnabled(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGlobalColor(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<int, UnityEngine.Color>(L, 1))
			{
				int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
				UnityEngine.Color arg1 = ToLua.ToColor(L, 2);
				UnityEngine.Shader.SetGlobalColor(arg0, arg1);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<string, UnityEngine.Color>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				UnityEngine.Color arg1 = ToLua.ToColor(L, 2);
				UnityEngine.Shader.SetGlobalColor(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Shader.SetGlobalColor");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGlobalVector(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<int, UnityEngine.Vector4>(L, 1))
			{
				int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
				UnityEngine.Vector4 arg1 = ToLua.ToVector4(L, 2);
				UnityEngine.Shader.SetGlobalVector(arg0, arg1);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<string, UnityEngine.Vector4>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				UnityEngine.Vector4 arg1 = ToLua.ToVector4(L, 2);
				UnityEngine.Shader.SetGlobalVector(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Shader.SetGlobalVector");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGlobalFloat(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<int, float>(L, 1))
			{
				int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
				UnityEngine.Shader.SetGlobalFloat(arg0, arg1);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<string, float>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
				UnityEngine.Shader.SetGlobalFloat(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Shader.SetGlobalFloat");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGlobalInt(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<int, int>(L, 1))
			{
				int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
				UnityEngine.Shader.SetGlobalInt(arg0, arg1);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<string, int>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 2);
				UnityEngine.Shader.SetGlobalInt(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Shader.SetGlobalInt");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGlobalTexture(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<int, UnityEngine.Texture>(L, 1))
			{
				int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
				UnityEngine.Texture arg1 = (UnityEngine.Texture)ToLua.ToObject(L, 2);
				UnityEngine.Shader.SetGlobalTexture(arg0, arg1);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<string, UnityEngine.Texture>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				UnityEngine.Texture arg1 = (UnityEngine.Texture)ToLua.ToObject(L, 2);
				UnityEngine.Shader.SetGlobalTexture(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Shader.SetGlobalTexture");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGlobalMatrix(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<int, UnityEngine.Matrix4x4>(L, 1))
			{
				int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
				UnityEngine.Matrix4x4 arg1 = StackTraits<UnityEngine.Matrix4x4>.To(L, 2);
				UnityEngine.Shader.SetGlobalMatrix(arg0, arg1);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<string, UnityEngine.Matrix4x4>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				UnityEngine.Matrix4x4 arg1 = StackTraits<UnityEngine.Matrix4x4>.To(L, 2);
				UnityEngine.Shader.SetGlobalMatrix(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Shader.SetGlobalMatrix");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetGlobalBuffer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			UnityEngine.ComputeBuffer arg1 = (UnityEngine.ComputeBuffer)ToLua.CheckObject(L, 2, typeof(UnityEngine.ComputeBuffer));
			UnityEngine.Shader.SetGlobalBuffer(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PropertyToID(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			int o = UnityEngine.Shader.PropertyToID(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WarmupAllShaders(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UnityEngine.Shader.WarmupAllShaders();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isSupported(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Shader obj = (UnityEngine.Shader)o;
			bool ret = obj.isSupported;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isSupported on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maximumLOD(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Shader obj = (UnityEngine.Shader)o;
			int ret = obj.maximumLOD;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index maximumLOD on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_globalMaximumLOD(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, UnityEngine.Shader.globalMaximumLOD);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_renderQueue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Shader obj = (UnityEngine.Shader)o;
			int ret = obj.renderQueue;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index renderQueue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maximumLOD(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Shader obj = (UnityEngine.Shader)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.maximumLOD = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index maximumLOD on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_globalMaximumLOD(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.Shader.globalMaximumLOD = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

