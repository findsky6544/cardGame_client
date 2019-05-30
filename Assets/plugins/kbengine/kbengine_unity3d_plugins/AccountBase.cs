/*
	Generated by KBEngine!
	Please do not modify this file!
	Please inherit this module, such as: (class Account : AccountBase)
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	// defined in */scripts/entity_defs/Account.def
	public abstract class AccountBase : Entity
	{
		public EntityBaseEntityCall_AccountBase baseEntityCall = null;
		public EntityCellEntityCall_AccountBase cellEntityCall = null;

		public Int16 dbid = 0;
		public virtual void onDbidChanged(Int16 oldValue) {}
		public Int32 gameResult = 0;
		public virtual void onGameResultChanged(Int32 oldValue) {}
		public List<Int32> handCards = new List<Int32>();
		public virtual void onHandCardsChanged(List<Int32> oldValue) {}
		public Int32 handCardsCount = 0;
		public virtual void onHandCardsCountChanged(Int32 oldValue) {}
		public Int32 loseCount = 0;
		public virtual void onLoseCountChanged(Int32 oldValue) {}
		public Int32 loseCountC = 0;
		public virtual void onLoseCountCChanged(Int32 oldValue) {}
		public Int32 message = 0;
		public virtual void onMessageChanged(Int32 oldValue) {}
		public Byte modelID = 0;
		public virtual void onModelIDChanged(Byte oldValue) {}
		public string name = "";
		public virtual void onNameChanged(string oldValue) {}
		public string nameC = "";
		public virtual void onNameCChanged(string oldValue) {}
		public List<Int32> playCards = new List<Int32>();
		public virtual void onPlayCardsChanged(List<Int32> oldValue) {}
		public UInt64 roomKey = 0;
		public virtual void onRoomKeyChanged(UInt64 oldValue) {}
		public Int16 seatIndex = 0;
		public virtual void onSeatIndexChanged(Int16 oldValue) {}
		public Int32 winCount = 0;
		public virtual void onWinCountChanged(Int32 oldValue) {}
		public Int32 winCountC = 0;
		public virtual void onWinCountCChanged(Int32 oldValue) {}

		public abstract void isBan(string arg1, string arg2); 
		public abstract void onCreateRoomFailed(UInt16 arg1); 
		public abstract void onEditRoomInfoFailed(UInt16 arg1); 
		public abstract void onEnterHall(UInt64 arg1); 
		public abstract void onEnterSetName(string arg1); 
		public abstract void onReqExitRoom(Int64 arg1); 
		public abstract void onReqJoinRoomFailed(UInt16 arg1); 
		public abstract void onReqJoinRoomSuccess(UInt16 arg1); 
		public abstract void onReqPlayersInfo(SEATS_INFO arg1); 
		public abstract void onReqRoomPassword(string arg1); 
		public abstract void onReqRoomsByParams(ROOM_INFOS_LIST arg1); 
		public abstract void onSetNameFailed(UInt16 arg1, string arg2); 
		public abstract void onSetNameSuccessfully(string arg1); 

		public override void onGetBase()
		{
			baseEntityCall = new EntityBaseEntityCall_AccountBase();
			baseEntityCall.id = id;
			baseEntityCall.className = className;
		}

		public override void onGetCell()
		{
			cellEntityCall = new EntityCellEntityCall_AccountBase();
			cellEntityCall.id = id;
			cellEntityCall.className = className;
		}

		public override void onLoseCell()
		{
			cellEntityCall = null;
		}

		public override EntityCall getBaseEntityCall()
		{
			return baseEntityCall;
		}

		public override EntityCall getCellEntityCall()
		{
			return cellEntityCall;
		}

		public override void onRemoteMethodCall(Method method, MemoryStream stream)
		{
			switch(method.methodUtype)
			{
				case 23:
					string isBan_arg1 = stream.readUnicode();
					string isBan_arg2 = stream.readUnicode();
					isBan(isBan_arg1, isBan_arg2);
					break;
				case 29:
					UInt16 onCreateRoomFailed_arg1 = stream.readUint16();
					onCreateRoomFailed(onCreateRoomFailed_arg1);
					break;
				case 33:
					UInt16 onEditRoomInfoFailed_arg1 = stream.readUint16();
					onEditRoomInfoFailed(onEditRoomInfoFailed_arg1);
					break;
				case 25:
					UInt64 onEnterHall_arg1 = stream.readUint64();
					onEnterHall(onEnterHall_arg1);
					break;
				case 24:
					string onEnterSetName_arg1 = stream.readUnicode();
					onEnterSetName(onEnterSetName_arg1);
					break;
				case 35:
					Int64 onReqExitRoom_arg1 = stream.readInt64();
					onReqExitRoom(onReqExitRoom_arg1);
					break;
				case 30:
					UInt16 onReqJoinRoomFailed_arg1 = stream.readUint16();
					onReqJoinRoomFailed(onReqJoinRoomFailed_arg1);
					break;
				case 31:
					UInt16 onReqJoinRoomSuccess_arg1 = stream.readUint16();
					onReqJoinRoomSuccess(onReqJoinRoomSuccess_arg1);
					break;
				case 34:
					SEATS_INFO onReqPlayersInfo_arg1 = ((DATATYPE_SEATS_INFO)method.args[0]).createFromStreamEx(stream);
					onReqPlayersInfo(onReqPlayersInfo_arg1);
					break;
				case 32:
					string onReqRoomPassword_arg1 = stream.readUnicode();
					onReqRoomPassword(onReqRoomPassword_arg1);
					break;
				case 28:
					ROOM_INFOS_LIST onReqRoomsByParams_arg1 = ((DATATYPE_ROOM_INFOS_LIST)method.args[0]).createFromStreamEx(stream);
					onReqRoomsByParams(onReqRoomsByParams_arg1);
					break;
				case 26:
					UInt16 onSetNameFailed_arg1 = stream.readUint16();
					string onSetNameFailed_arg2 = stream.readUnicode();
					onSetNameFailed(onSetNameFailed_arg1, onSetNameFailed_arg2);
					break;
				case 27:
					string onSetNameSuccessfully_arg1 = stream.readUnicode();
					onSetNameSuccessfully(onSetNameSuccessfully_arg1);
					break;
				default:
					break;
			};
		}

		public override void onUpdatePropertys(Property prop, MemoryStream stream)
		{
			switch(prop.properUtype)
			{
				case 2:
					Int16 oldval_dbid = dbid;
					dbid = stream.readInt16();

					if(prop.isBase())
					{
						if(inited)
							onDbidChanged(oldval_dbid);
					}
					else
					{
						if(inWorld)
							onDbidChanged(oldval_dbid);
					}

					break;
				case 40001:
					Vector3 oldval_direction = direction;
					direction = stream.readVector3();

					if(prop.isBase())
					{
						if(inited)
							onDirectionChanged(oldval_direction);
					}
					else
					{
						if(inWorld)
							onDirectionChanged(oldval_direction);
					}

					break;
				case 15:
					Int32 oldval_gameResult = gameResult;
					gameResult = stream.readInt32();

					if(prop.isBase())
					{
						if(inited)
							onGameResultChanged(oldval_gameResult);
					}
					else
					{
						if(inWorld)
							onGameResultChanged(oldval_gameResult);
					}

					break;
				case 11:
					List<Int32> oldval_handCards = handCards;
					handCards = ((DATATYPE_AnonymousArray_31)EntityDef.id2datatypes[31]).createFromStreamEx(stream);

					if(prop.isBase())
					{
						if(inited)
							onHandCardsChanged(oldval_handCards);
					}
					else
					{
						if(inWorld)
							onHandCardsChanged(oldval_handCards);
					}

					break;
				case 12:
					Int32 oldval_handCardsCount = handCardsCount;
					handCardsCount = stream.readInt32();

					if(prop.isBase())
					{
						if(inited)
							onHandCardsCountChanged(oldval_handCardsCount);
					}
					else
					{
						if(inWorld)
							onHandCardsCountChanged(oldval_handCardsCount);
					}

					break;
				case 7:
					Int32 oldval_loseCount = loseCount;
					loseCount = stream.readInt32();

					if(prop.isBase())
					{
						if(inited)
							onLoseCountChanged(oldval_loseCount);
					}
					else
					{
						if(inWorld)
							onLoseCountChanged(oldval_loseCount);
					}

					break;
				case 8:
					Int32 oldval_loseCountC = loseCountC;
					loseCountC = stream.readInt32();

					if(prop.isBase())
					{
						if(inited)
							onLoseCountCChanged(oldval_loseCountC);
					}
					else
					{
						if(inWorld)
							onLoseCountCChanged(oldval_loseCountC);
					}

					break;
				case 14:
					Int32 oldval_message = message;
					message = stream.readInt32();

					if(prop.isBase())
					{
						if(inited)
							onMessageChanged(oldval_message);
					}
					else
					{
						if(inWorld)
							onMessageChanged(oldval_message);
					}

					break;
				case 16:
					Byte oldval_modelID = modelID;
					modelID = stream.readUint8();

					if(prop.isBase())
					{
						if(inited)
							onModelIDChanged(oldval_modelID);
					}
					else
					{
						if(inWorld)
							onModelIDChanged(oldval_modelID);
					}

					break;
				case 3:
					string oldval_name = name;
					name = stream.readUnicode();

					if(prop.isBase())
					{
						if(inited)
							onNameChanged(oldval_name);
					}
					else
					{
						if(inWorld)
							onNameChanged(oldval_name);
					}

					break;
				case 4:
					string oldval_nameC = nameC;
					nameC = stream.readUnicode();

					if(prop.isBase())
					{
						if(inited)
							onNameCChanged(oldval_nameC);
					}
					else
					{
						if(inWorld)
							onNameCChanged(oldval_nameC);
					}

					break;
				case 13:
					List<Int32> oldval_playCards = playCards;
					playCards = ((DATATYPE_AnonymousArray_32)EntityDef.id2datatypes[32]).createFromStreamEx(stream);

					if(prop.isBase())
					{
						if(inited)
							onPlayCardsChanged(oldval_playCards);
					}
					else
					{
						if(inWorld)
							onPlayCardsChanged(oldval_playCards);
					}

					break;
				case 40000:
					Vector3 oldval_position = position;
					position = stream.readVector3();

					if(prop.isBase())
					{
						if(inited)
							onPositionChanged(oldval_position);
					}
					else
					{
						if(inWorld)
							onPositionChanged(oldval_position);
					}

					break;
				case 1:
					UInt64 oldval_roomKey = roomKey;
					roomKey = stream.readUint64();

					if(prop.isBase())
					{
						if(inited)
							onRoomKeyChanged(oldval_roomKey);
					}
					else
					{
						if(inWorld)
							onRoomKeyChanged(oldval_roomKey);
					}

					break;
				case 10:
					Int16 oldval_seatIndex = seatIndex;
					seatIndex = stream.readInt16();

					if(prop.isBase())
					{
						if(inited)
							onSeatIndexChanged(oldval_seatIndex);
					}
					else
					{
						if(inWorld)
							onSeatIndexChanged(oldval_seatIndex);
					}

					break;
					case 40002:
						stream.readUint32();
						break;
				case 5:
					Int32 oldval_winCount = winCount;
					winCount = stream.readInt32();

					if(prop.isBase())
					{
						if(inited)
							onWinCountChanged(oldval_winCount);
					}
					else
					{
						if(inWorld)
							onWinCountChanged(oldval_winCount);
					}

					break;
				case 6:
					Int32 oldval_winCountC = winCountC;
					winCountC = stream.readInt32();

					if(prop.isBase())
					{
						if(inited)
							onWinCountCChanged(oldval_winCountC);
					}
					else
					{
						if(inWorld)
							onWinCountCChanged(oldval_winCountC);
					}

					break;
				default:
					break;
			};
		}

		public override void callPropertysSetMethods()
		{
			ScriptModule sm = EntityDef.moduledefs[className];
			Dictionary<UInt16, Property> pdatas = sm.idpropertys;

			Int16 oldval_dbid = dbid;
			Property prop_dbid = pdatas[3];
			if(prop_dbid.isBase())
			{
				if(inited && !inWorld)
					onDbidChanged(oldval_dbid);
			}
			else
			{
				if(inWorld)
				{
					if(prop_dbid.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onDbidChanged(oldval_dbid);
					}
				}
			}

			Vector3 oldval_direction = direction;
			Property prop_direction = pdatas[1];
			if(prop_direction.isBase())
			{
				if(inited && !inWorld)
					onDirectionChanged(oldval_direction);
			}
			else
			{
				if(inWorld)
				{
					if(prop_direction.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onDirectionChanged(oldval_direction);
					}
				}
			}

			Int32 oldval_gameResult = gameResult;
			Property prop_gameResult = pdatas[4];
			if(prop_gameResult.isBase())
			{
				if(inited && !inWorld)
					onGameResultChanged(oldval_gameResult);
			}
			else
			{
				if(inWorld)
				{
					if(prop_gameResult.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onGameResultChanged(oldval_gameResult);
					}
				}
			}

			List<Int32> oldval_handCards = handCards;
			Property prop_handCards = pdatas[5];
			if(prop_handCards.isBase())
			{
				if(inited && !inWorld)
					onHandCardsChanged(oldval_handCards);
			}
			else
			{
				if(inWorld)
				{
					if(prop_handCards.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onHandCardsChanged(oldval_handCards);
					}
				}
			}

			Int32 oldval_handCardsCount = handCardsCount;
			Property prop_handCardsCount = pdatas[6];
			if(prop_handCardsCount.isBase())
			{
				if(inited && !inWorld)
					onHandCardsCountChanged(oldval_handCardsCount);
			}
			else
			{
				if(inWorld)
				{
					if(prop_handCardsCount.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onHandCardsCountChanged(oldval_handCardsCount);
					}
				}
			}

			Int32 oldval_loseCount = loseCount;
			Property prop_loseCount = pdatas[7];
			if(prop_loseCount.isBase())
			{
				if(inited && !inWorld)
					onLoseCountChanged(oldval_loseCount);
			}
			else
			{
				if(inWorld)
				{
					if(prop_loseCount.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onLoseCountChanged(oldval_loseCount);
					}
				}
			}

			Int32 oldval_loseCountC = loseCountC;
			Property prop_loseCountC = pdatas[8];
			if(prop_loseCountC.isBase())
			{
				if(inited && !inWorld)
					onLoseCountCChanged(oldval_loseCountC);
			}
			else
			{
				if(inWorld)
				{
					if(prop_loseCountC.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onLoseCountCChanged(oldval_loseCountC);
					}
				}
			}

			Int32 oldval_message = message;
			Property prop_message = pdatas[9];
			if(prop_message.isBase())
			{
				if(inited && !inWorld)
					onMessageChanged(oldval_message);
			}
			else
			{
				if(inWorld)
				{
					if(prop_message.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onMessageChanged(oldval_message);
					}
				}
			}

			Byte oldval_modelID = modelID;
			Property prop_modelID = pdatas[10];
			if(prop_modelID.isBase())
			{
				if(inited && !inWorld)
					onModelIDChanged(oldval_modelID);
			}
			else
			{
				if(inWorld)
				{
					if(prop_modelID.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onModelIDChanged(oldval_modelID);
					}
				}
			}

			string oldval_name = name;
			Property prop_name = pdatas[11];
			if(prop_name.isBase())
			{
				if(inited && !inWorld)
					onNameChanged(oldval_name);
			}
			else
			{
				if(inWorld)
				{
					if(prop_name.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onNameChanged(oldval_name);
					}
				}
			}

			string oldval_nameC = nameC;
			Property prop_nameC = pdatas[12];
			if(prop_nameC.isBase())
			{
				if(inited && !inWorld)
					onNameCChanged(oldval_nameC);
			}
			else
			{
				if(inWorld)
				{
					if(prop_nameC.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onNameCChanged(oldval_nameC);
					}
				}
			}

			List<Int32> oldval_playCards = playCards;
			Property prop_playCards = pdatas[13];
			if(prop_playCards.isBase())
			{
				if(inited && !inWorld)
					onPlayCardsChanged(oldval_playCards);
			}
			else
			{
				if(inWorld)
				{
					if(prop_playCards.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onPlayCardsChanged(oldval_playCards);
					}
				}
			}

			Vector3 oldval_position = position;
			Property prop_position = pdatas[0];
			if(prop_position.isBase())
			{
				if(inited && !inWorld)
					onPositionChanged(oldval_position);
			}
			else
			{
				if(inWorld)
				{
					if(prop_position.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onPositionChanged(oldval_position);
					}
				}
			}

			UInt64 oldval_roomKey = roomKey;
			Property prop_roomKey = pdatas[14];
			if(prop_roomKey.isBase())
			{
				if(inited && !inWorld)
					onRoomKeyChanged(oldval_roomKey);
			}
			else
			{
				if(inWorld)
				{
					if(prop_roomKey.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onRoomKeyChanged(oldval_roomKey);
					}
				}
			}

			Int16 oldval_seatIndex = seatIndex;
			Property prop_seatIndex = pdatas[15];
			if(prop_seatIndex.isBase())
			{
				if(inited && !inWorld)
					onSeatIndexChanged(oldval_seatIndex);
			}
			else
			{
				if(inWorld)
				{
					if(prop_seatIndex.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onSeatIndexChanged(oldval_seatIndex);
					}
				}
			}

			Int32 oldval_winCount = winCount;
			Property prop_winCount = pdatas[16];
			if(prop_winCount.isBase())
			{
				if(inited && !inWorld)
					onWinCountChanged(oldval_winCount);
			}
			else
			{
				if(inWorld)
				{
					if(prop_winCount.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onWinCountChanged(oldval_winCount);
					}
				}
			}

			Int32 oldval_winCountC = winCountC;
			Property prop_winCountC = pdatas[17];
			if(prop_winCountC.isBase())
			{
				if(inited && !inWorld)
					onWinCountCChanged(oldval_winCountC);
			}
			else
			{
				if(inWorld)
				{
					if(prop_winCountC.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onWinCountCChanged(oldval_winCountC);
					}
				}
			}

		}
	}
}