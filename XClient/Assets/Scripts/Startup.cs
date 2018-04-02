﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;

public class Startup : MonoBehaviour
{

    LuaEnv luaenv;

    void Start()
    {
        luaenv = new LuaEnv();
        luaenv.AddLoader((ref string filename) =>
        {
            string path = Application.dataPath + "/../../XClientLuaScript/lua/" + filename + ".lua";
            if (File.Exists(path))
            {
                return File.ReadAllBytes(path);
            }
            else
            {
                path = Application.dataPath + "/../../XCommon/lua/" + filename + ".lua";
                if (File.Exists(path))
                {
                    return File.ReadAllBytes(path);
                }
                else
                {
                    return null;
                }
            }
        });
        luaenv.DoString("require('startup')");
    }

    void Update()
    {
        if (luaenv != null)
        {
            luaenv.Tick();
        }
    }
}
