﻿/*
*
* 文件名    ：IAuthority                             
* 程序说明  : 程序功能权限接口
* 更新时间  : 2020-05-11
* 联系作者  : QQ:779149549 
* 开发者群  : QQ群:874752819
* 邮件联系  : zhouhaogg789@outlook.com
* 视频教程  : https://space.bilibili.com/32497462
* 博客地址  : https://www.cnblogs.com/zh7791/
* 项目地址  : https://github.com/HenJigg/WPF-Xamarin-Blazor-Examples
* 项目说明  : 以上所有代码均属开源免费使用,禁止个人行为出售本项目源代码
*/

namespace Consumption.Core.Interfaces
{
    /// <summary>
    /// 权限接口
    /// </summary>
    public interface IAuthority
    {
        /// <summary>
        /// 获取按钮权限
        /// </summary>
        /// <param name="authValue"></param>
        /// <returns></returns>
        bool GetButtonAuth(int authValue);

        /// <summary>
        /// 加载模板权限
        /// </summary>
        void LoadModuleAuth();

        /// <summary>
        /// 权限值
        /// </summary>
        int? AuthValue { get; set; }
    }
}
