﻿using aehyok.Infrastructure.Dtos;

namespace aehyok.Core.Dtos
{
    public class UserRoleDto : DtoBase
    {
        /// <summary>
        /// 角色 Id
        /// </summary>
        public long RoleId { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// 区域名称
        /// </summary>
        public string RegionName { get; set; }

        /// <summary>
        /// 区域 Id
        /// </summary>
        public long RegionId { get; set; }

        /// <summary>
        /// 是否默认角色
        /// </summary>
        public bool IsDefault { get; set; }
    }
}