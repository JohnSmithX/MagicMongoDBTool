﻿using System;
using System.Collections.Generic;

namespace Card.Player
{
    /// <summary>
    /// 共通情报
    /// </summary>
    public class PlayerBasicInfo
    {
        /// <summary>
        /// 最大生命值
        /// </summary>
        public const int MaxHealthPoint = 30;
        /// <summary>
        /// 是否为先手
        /// </summary>
        public Boolean IsFirst;
        /// <summary>
        /// 是否为冰冻状态
        /// </summary>
        public Boolean Is冰冻Status = false;
        /// <summary>
        /// 护盾点数
        /// </summary>
        public int Sheild = 0;
        /// <summary>
        /// 生命力
        /// </summary>
        public int HealthPoint = 30;
        /// <summary>
        /// 水晶
        /// </summary>
        public Crystal crystal = new Crystal();
        /// <summary>
        /// 武器
        /// </summary>
        public Card.WeaponCard Weapon;
        /// <summary>
        /// 战场信息
        /// </summary>
        public BattleFieldInfo myBattleField = new BattleFieldInfo();
        /// <summary>
        /// 剩余牌数
        /// </summary>
        public int RemainCardDeckCount = 30;
        /// <summary>
        /// 手牌数
        /// </summary>
        public int HandCardCount = 30;


        #region"服务器端通信"
        /// <summary>
        /// 
        /// </summary>
        public void SendMessage()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        public void GetMessage()
        {

        }
        #endregion
    }
    /// <summary>
    /// 本方情报
    /// </summary>
    public class PlayerDetailInfo
    {
        /// <summary>
        /// 基本情报
        /// </summary>
        public PlayerBasicInfo role = new PlayerBasicInfo();
        /// <summary>
        /// 手牌
        /// </summary>
        public List<String> handCards = new List<string>();
    }
}
