#ifndef LUA2C_H
#define LUA2C_H

#include "uv.h"
extern "C"
{
#include "lua.h"
#include "lualib.h"
#include "lauxlib.h"
}

#include<iostream>
using namespace std;

void loadLib(lua_State * L);

extern "C" 
{
LUA_API void xdInit(lua_State* L);
LUA_API void xdRegistFunc(lua_State* L);
LUA_API void xdRunOnce();
}
#endif // !LUA2C_H

