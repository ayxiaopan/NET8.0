﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aehyok.Infrastructure.Excel
{
    public class SheetDto
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string SheetName { get; set; }

        /// <summary>
        /// 表数据
        /// </summary>
        public DataTable Data { get; set; }
    }
}
