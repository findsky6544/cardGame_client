/*
	Generated by KBEngine!
	Please do not modify this file!
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public struct ServerErr
	{
		public string name;
		public string descr;
		public UInt16 id;
	}

	// defined in */res/server/server_errors.xml

	public class ServerErrorDescrs
	{
		public static Dictionary<UInt16, ServerErr> serverErrs = new Dictionary<UInt16, ServerErr>();

		public ServerErrorDescrs()
		{
			{
				ServerErr e;
				e.id = 0;
				e.name = "SUCCESS";
				e.descr = "成功。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 1;
				e.name = "SERVER_ERR_SRV_NO_READY";
				e.descr = "服务器没有准备好。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 2;
				e.name = "SERVER_ERR_SRV_OVERLOAD";
				e.descr = "服务器负载过重。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 3;
				e.name = "SERVER_ERR_ILLEGAL_LOGIN";
				e.descr = "非法登录。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 4;
				e.name = "SERVER_ERR_NAME_PASSWORD";
				e.descr = "用户名或者密码不正确。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 5;
				e.name = "SERVER_ERR_NAME";
				e.descr = "用户名不正确。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 6;
				e.name = "SERVER_ERR_PASSWORD";
				e.descr = "密码不正确。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 7;
				e.name = "SERVER_ERR_ACCOUNT_CREATE_FAILED";
				e.descr = "创建账号失败（已经存在一个相同的账号）。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 8;
				e.name = "SERVER_ERR_BUSY";
				e.descr = "操作过于繁忙(例如：在服务器前一次请求未执行完毕的情况下连续N次创建账号)。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 9;
				e.name = "SERVER_ERR_ACCOUNT_LOGIN_ANOTHER";
				e.descr = "当前账号在另一处登录了。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 10;
				e.name = "SERVER_ERR_ACCOUNT_IS_ONLINE";
				e.descr = "账号已登陆。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 11;
				e.name = "SERVER_ERR_PROXY_DESTROYED";
				e.descr = "与客户端关联的proxy在服务器上已经销毁。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 12;
				e.name = "SERVER_ERR_ENTITYDEFS_NOT_MATCH";
				e.descr = "EntityDefs不匹配。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 13;
				e.name = "SERVER_ERR_SERVER_IN_SHUTTINGDOWN";
				e.descr = "服务器正在关闭中。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 14;
				e.name = "SERVER_ERR_NAME_MAIL";
				e.descr = "Email地址错误。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 15;
				e.name = "SERVER_ERR_ACCOUNT_LOCK";
				e.descr = "账号被冻结。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 16;
				e.name = "SERVER_ERR_ACCOUNT_DEADLINE";
				e.descr = "账号已过期。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 17;
				e.name = "SERVER_ERR_ACCOUNT_NOT_ACTIVATED";
				e.descr = "账号未激活。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 18;
				e.name = "SERVER_ERR_VERSION_NOT_MATCH";
				e.descr = "与服务端的版本不匹配。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 19;
				e.name = "SERVER_ERR_OP_FAILED";
				e.descr = "操作失败。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 20;
				e.name = "SERVER_ERR_SRV_STARTING";
				e.descr = "服务器正在启动中。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 21;
				e.name = "SERVER_ERR_ACCOUNT_REGISTER_NOT_AVAILABLE";
				e.descr = "未开放账号注册功能。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 22;
				e.name = "SERVER_ERR_CANNOT_USE_MAIL";
				e.descr = "不能使用email地址。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 23;
				e.name = "SERVER_ERR_NOT_FOUND_ACCOUNT";
				e.descr = "找不到此账号。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 24;
				e.name = "SERVER_ERR_DB";
				e.descr = "数据库错误(请检查dbmgr日志和DB)。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 25;
				e.name = "NAME_IS_EXIST";
				e.descr = "昵称已存在。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 26;
				e.name = "NAME_IS_NULL";
				e.descr = "昵称为空。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 27;
				e.name = "ROOM_IS_NOT_EXIST";
				e.descr = "房间不存在。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 28;
				e.name = "ROOM_IS_FULL";
				e.descr = "房间已满员。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 29;
				e.name = "PASSWORD_INVALID";
				e.descr = "房间密码不正确。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 30;
				e.name = "ROOM_IS_PLAYING";
				e.descr = "房间正在游戏中。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 31;
				e.name = "ROOM_NAME_EMPTY";
				e.descr = "房间名为空。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 32;
				e.name = "ROOM_INTRO_EMPTY";
				e.descr = "房间简介为空。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 33;
				e.name = "SERVER_ERR_USER9";
				e.descr = "用户自定义错误码9。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 34;
				e.name = "SERVER_ERR_USER10";
				e.descr = "用户自定义错误码10。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 35;
				e.name = "SERVER_ERR_LOCAL_PROCESSING";
				e.descr = "本地处理，通常为某件事情不由第三方处理而是由KBE服务器处理。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 36;
				e.name = "SERVER_ERR_ACCOUNT_RESET_PASSWORD_NOT_AVAILABLE";
				e.descr = "未开放账号重置密码功能。";

				serverErrs.Add(e.id, e);
			}

			{
				ServerErr e;
				e.id = 37;
				e.name = "SERVER_ERR_ACCOUNT_LOGIN_ANOTHER_SERVER";
				e.descr = "当前账号在其他服务器登陆了。";

				serverErrs.Add(e.id, e);
			}


		}

		public void Clear()
		{
			serverErrs.Clear();
		}

		public string serverErrStr(UInt16 id)
		{
			ServerErr e;
			if(!serverErrs.TryGetValue(id, out e))
			{
				return "";
			}

			return e.name + "[" + e.descr + "]";
		}

		public ServerErr serverErr(UInt16 id)
		{
			ServerErr e;
			serverErrs.TryGetValue(id, out e);
			return e;
		}




	}
}