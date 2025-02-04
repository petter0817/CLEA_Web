﻿using Clea_Web.Models;
using System.ComponentModel;

namespace Clea_Web.ViewModels
{
    public class AccountViewModel : BaseViewModel
    {
        public UserRole userRole { get; set; }
        public Modify modify { get; set; }
        public SchModel schModel { get; set; }

        #region 選單
        public class UserRole
        {
            public List<SysMenu> lst_sysMenu { get; set; }
        }
        #endregion

        #region 編輯頁面
        public class Modify
        {
            /// <summary>
            /// Uid
            /// </summary>
            [DisplayName("Uid")]
            public Guid UId { get; set; }

            /// <summary>
            /// 角色UID
            /// </summary>
            [DisplayName("角色UID")] 
            public Guid RUid { get; set; }

            /// <summary>
            /// 帳號
            /// </summary>
            [DisplayName("帳號")] 
            public string UAccount { get; set; } = null!;

            /// <summary>
            /// 密碼
            /// </summary>
            [DisplayName("密碼")] 
            public string UPassword { get; set; } = null!;

            /// <summary>
            /// 使用者名稱
            /// </summary>
            [DisplayName("使用者名稱")] 
            public string UName { get; set; } = null!;

            /// <summary>
            /// 使用者電子郵件
            /// </summary>
            [DisplayName("使用者電子郵件")] 
            public string UEmail { get; set; } = null!;

            /// <summary>
            /// 使用者連絡電話
            /// </summary>
            [DisplayName("使用者連絡電話")] 
            public string UPhone { get; set; } = null!;

            /// <summary>
            /// 使用者地址
            /// </summary>
            [DisplayName("使用者地址")] 
            public string UAddress { get; set; } = null!;

            /// <summary>
            /// 使用者性別:0女、1男
            /// </summary>
            [DisplayName("使用者性別")] 
            public byte USex { get; set; }

            /// <summary>
            /// 使用者生日
            /// </summary>
            [DisplayName("使用者生日")] 
            public DateTime UBirthday { get; set; }

            /// <summary>
            /// 使用者單位
            /// </summary>
            [DisplayName("使用者單位")] 
            public string UnId { get; set; } = null!;

            /// <summary>
            /// 啟用狀態 True = 啟用 ; False = 停用
            /// </summary>
            [DisplayName("啟用狀態")]
            public bool UStatus { get; set; } = true;

            /// <summary>
            /// 編輯狀態 True = 編輯 ; False = 新增
            /// </summary>
            [DisplayName("編輯狀態")]
            public Boolean IsEdit { get; set; } = false;
        }
        #endregion

        #region Index
        public class SchModel
        {
            public SchItem schItem { get; set; }
            public List<schPageList> schPageList { get; set; }
        }
        #endregion

        #region 搜尋條件
        public class SchItem
        {

            public String? uId { get; set; }
            public String? rId { get; set; }

        }
        #endregion

        #region 列表
        public class schPageList
        {
            public String uUId { get; set; }
            public String uAccount { get; set; }
            public String uPassWord { get; set; }
            public Int16 uName { get; set; }
            public String? uEmail { get; set; }
            public String? uPhone { get; set; }
            public String? uAddress { get; set; }
            public String? uSex { get; set; }
            public String? uBrithday { get; set; }
            public String? uID { get; set; }
            public String? uStatus { get; set; }
            public String creUser { get; set; }
            public String creDate { get; set; }
            public String updUser { get; set; }
            public String updDate { get; set; }
            //public DateTime mbCredateE { get; set; }


        }
        #endregion
    }
}
