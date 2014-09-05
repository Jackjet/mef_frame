﻿//------------------------------------------------------------------------------
//Copyright ©车易拍-公共服务组团队. All Rights Reserved.
//------------------------------------------------------------------------------
using Core.Models;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Core.Service
{
    /// <summary>
    /// ——TestData
    /// </summary>    
    public interface ITestDataContract
    {
       
        //查询数据集
        IQueryable<TestData> TestDatas { get; }
        //添加
        int Insert(TestData entity);
        /// <summary>
        ///  删除-根据ID删除实体
        /// </summary>
        /// <param name="id"> 主键ID </param>
        /// <returns> 操作影响的行数 </returns>
        void Delete(int id);
        /// <summary>

        ///  修改-根据ID修改实体
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <param name="updateExpression">Lamda表达式 修改实体</param>
        /// <param name="isSave"> 默认值false;是否执行保存.isSave:true 保存，isSave:false 不保存 </param>
        /// <returns></returns>
        int Update(int id, Expression<Func<TestData, TestData>> updateExpression,bool isSave=false);

        int UpdateEntity(Expression<Func<TestData, object>> propertyExpression, TestData entity, bool isSave = false);
    }
}
