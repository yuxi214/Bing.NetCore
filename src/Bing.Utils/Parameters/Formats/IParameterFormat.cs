﻿namespace Bing.Utils.Parameters.Formats
{
    /// <summary>
    /// 参数格式化器
    /// </summary>
    public interface IParameterFormat
    {
        /// <summary>
        /// 格式化
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        string Format(string key, string value);

        /// <summary>
        /// 连接参数
        /// </summary>
        /// <param name="left">左操作数</param>
        /// <param name="right">右操作数</param>
        /// <returns></returns>
        string Join(string left, string right);
    }
}